using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Sonar
{
    public class Utils
    {
        private bool threadFinalizing = false;
        private bool threadAddingProgress = false;
        private bool threadAddingOpenPort = false;

        //Checks if every variable input is correct
        public bool CheckVariables()
        {
            try
            {
                Sonar.sonar.maxThreads = int.Parse(Sonar._threadComboBox.Text);
                Sonar.sonar.timeoutTime = int.Parse(Sonar._timeoutComboBox.Text);

                int startingPortValue = int.Parse(Sonar._startingPortBox.Text);
                int endingPortValue = int.Parse(Sonar._endingPortBox.Text);
                int totalPorts = endingPortValue - startingPortValue + 1;
                bool isWrong = false;

                if (string.IsNullOrWhiteSpace(Sonar._hostTextBox.Text) || Sonar._hostTextBox.Text.Contains(' ')) isWrong = true;
                if (string.IsNullOrWhiteSpace(Sonar._endingPortBox.Text)) isWrong = true;
                if (string.IsNullOrWhiteSpace(Sonar._startingPortBox.Text)) isWrong = true;
                if (startingPortValue > endingPortValue) isWrong = true;
                if (startingPortValue < 1 || endingPortValue > 65535) isWrong = true;
                if (totalPorts < Sonar.sonar.maxThreads) isWrong = true;

                if (isWrong)
                {
                    Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.showMessageBox, 0);
                    return false;
                }
                else return true;
            }

            catch
            {
                Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.showMessageBox, 0);
                return false;
            }
        }

        //Generates all instances needed to check the ports
        public void GenerateNetworkInstances()
        {
            string ip = Sonar.sonar.ip;
            int startingPort = Sonar.sonar.startingPort;
            int endingPort = Sonar.sonar.endingPort;
            int totalPorts = endingPort - startingPort + 1;

            float tempPortValue = 0;
            int outOfBoundsPorts = 0;
            int extraStartingPort = 0;

            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressMax, totalPorts);
            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeStatusLabel, "Preparing");

            //Calculate ports that are out of bounds
            for (int i = 0; i < Sonar.sonar.maxThreads; i++)
            {
                float numberOfPorts = (float)totalPorts / (float)Sonar.sonar.maxThreads;
                tempPortValue += numberOfPorts % 1;
            }

            outOfBoundsPorts = (int)Math.Round(tempPortValue, 0);

            //Invoke threads to check the ports
            for (int i = 0; i < Sonar.sonar.maxThreads; i++)
            {
                Thread.Sleep(100);

                int portSegment = (totalPorts / Sonar.sonar.maxThreads) * i;
                int startingPosition = startingPort + portSegment + extraStartingPort;

                float numberOfPorts = (float) totalPorts / (float) Sonar.sonar.maxThreads;

                //If there were extra ports, add one per thread until there's none left
                if (outOfBoundsPorts > 0)
                {
                    numberOfPorts++;
                    extraStartingPort++;
                    outOfBoundsPorts--;
                }

                int[] portsToCheck = Enumerable.Range(startingPosition, (int)numberOfPorts).ToArray();

                tempPortValue += numberOfPorts % 1;

                Networking networkingInstance = new Networking();
                networkingInstance.ip = ip;
                networkingInstance.portArray = portsToCheck;
                Sonar.threading.GenerateNetworkThread(networkingInstance);

                //Starts the timer and counter system on the first thread
                if (i == 0)
                {
                    Sonar.threading.GenerateThread(1);
                    Sonar.threading.GenerateThread(2);
                }
            }

            //Loops until every thread has finished working and finishes the operation
            while (Sonar.threading.networkThreadCount > 0) Thread.Sleep(1000);

            FinalizeOperation();
        }

        //Starts the timer system
        public void StartTimer()
        {
            int seconds = 0;
            int minutes = 0;
            int hours = 0;

            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.manageTimer, hours + ":" + minutes + ":" + seconds);

            while (Sonar.threading.networkThreadCount > 0)
            {
                Thread.Sleep(1000);

                seconds++;

                if (seconds >= 60)
                {
                    minutes++;
                    seconds = 0;
                }

                if (minutes >= 60)
                {
                    hours++;
                    minutes = 0;
                }

                string timeToPrint = hours + ":" + minutes + ":" + seconds;
                Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.manageTimer, timeToPrint);
            }
        }

        //Start the counter system
        public void StartCounter()
        {
            while (Sonar.threading.networkThreadCount > 0)
            {
                Thread.Sleep(100);

                if (Sonar.sonar.currentProgressValue == 0) continue;

                Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressValue, Sonar.sonar.currentProgressValue);
                Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeStatusLabel, Sonar._progressBar.Value + "/" + Sonar._progressBar.Maximum);
            }    
        }

        //Adds progress to the UI
        public void AddProgressToUI()
        {
            while (threadAddingProgress) Thread.Sleep(100);

            threadAddingProgress = true;

            try { Sonar.sonar.currentProgressValue++; }
            catch { }

            threadAddingProgress = false;
        }

        //Adds a port to the open ports list

        public void AddPortToUI(int port)
        {
            while (threadAddingOpenPort) Thread.Sleep(100);

            threadAddingOpenPort = true;

            try { Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.modifyOpenPortBox, port); }
            catch { }

            threadAddingOpenPort = false;
        }

        //Executes all the actions to close a certain thread
        public void FinalizeNetworkThread(List<int> openPortsList, List<int> closedPortsList)
        {
            while (threadFinalizing) Thread.Sleep(100);

            threadFinalizing = true;

            Sonar.sonar.openPorts.AddRange(openPortsList);
            Sonar.sonar.closedPorts.AddRange(closedPortsList);

            Sonar.threading.networkThreadCount--;
            threadFinalizing = false;
        }

        //Finishes all operations and cleans the UI for next use
        public void FinalizeOperation()
        {
            Sonar.sonar.openPorts.Clear();
            Sonar.sonar.closedPorts.Clear();
            Sonar.threading.networkThreadCount = 0;
            Sonar.sonar.currentProgressValue = 0;

            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressValue, Sonar._progressBar.Maximum);
            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeStatusLabel, Sonar._progressBar.Maximum + "/" + Sonar._progressBar.Maximum);
            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.showMessageBox, 1);
            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeStatusLabel, "Idle");
            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressMax, 0);
            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressValue, 0);
            Sonar.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.toggleButtons, null);
        }
    }
}
