using System.Collections.Generic;
using System.Net.Sockets;

namespace Sonar
{
    public class Networking
    {
        public string ip;
        public int[] portArray;

        //Scans all the ports that have been requested to this instance
        public void ScanPort()
        {
            List<int> openPortsList = new List<int>();
            List<int> closedPortsList = new List<int>();

            for (int i = 0; i < portArray.Length; i++)
            {
                int port = portArray[i];

                try
                {
                    TcpClient newTcpClient = new TcpClient();
                    if (!newTcpClient.ConnectAsync(ip, port).Wait(Sonar.sonar.timeoutTime)) closedPortsList.Add(port);
                    else
                    {
                        openPortsList.Add(port);
                        Sonar.utils.AddPortToUI(port);
                    }

                    newTcpClient.Close();
                }

                catch { closedPortsList.Add(port); }

                Sonar.utils.AddProgressToUI();
            }

            //When finished, adds all ports to global list and removes itself from the active thread list
            Sonar.utils.FinalizeNetworkThread(openPortsList, closedPortsList);
        }
    }
}
