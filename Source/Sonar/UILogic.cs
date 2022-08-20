using System;
using System.Windows.Forms;

namespace Sonar
{
    public class UILogic
    {
        public enum InvokeMode { changeStatusLabel, changeProgressValue, changeProgressMax, toggleButtons, showMessageBox, modifyOpenPortBox, manageTimer }

        //Allows actions to be called from other threads
        public void InvokeFunctionOn(InvokeMode mode, Object value)
        {
            Action safeInvoke = null;

            switch (mode)
            {
                case InvokeMode.changeStatusLabel:
                    safeInvoke = delegate { ChangeStatusLabel((string)value); };
                    Sonar._statusLabel.Invoke(safeInvoke);
                    break;

                case InvokeMode.changeProgressValue:
                    safeInvoke = delegate { ChangeProgressBarFill((int)value); };
                    Sonar._progressBar.Invoke(safeInvoke);
                    break;

                case InvokeMode.changeProgressMax:
                    safeInvoke = delegate { ChangeProgressBarMax((int)value); };
                    Sonar._progressBar.Invoke(safeInvoke);
                    break;

                case InvokeMode.toggleButtons:
                    safeInvoke = delegate { ToggleUI(); };
                    Sonar._scanButton.Invoke(safeInvoke);
                    break;

                case InvokeMode.showMessageBox:
                    safeInvoke = delegate { ShowMessageBox((int) value); };
                    Sonar._progressBar.Invoke(safeInvoke);
                    break;

                case InvokeMode.modifyOpenPortBox:
                    safeInvoke = delegate { ModifyOpenPortBox((int)value); };
                    Sonar._openPortsTextbox.Invoke(safeInvoke);
                    break;

                case InvokeMode.manageTimer:
                    safeInvoke = delegate { WriteTimerOnLabel((string) value); };
                    Sonar._timerLabel.Invoke(safeInvoke);
                    break;
            }
        }

        //Changes the status label text
        public void ChangeStatusLabel(string newStatus) { Sonar._statusLabel.Text = "Status: " + newStatus; }

        //Writes the actual time on the label
        public void WriteTimerOnLabel(string timeInString)
        {
            int seconds = int.Parse(timeInString.Split(':')[2]);
            int minutes = int.Parse(timeInString.Split(':')[1]); ;
            int hours = int.Parse(timeInString.Split(':')[0]); ;

            string textToPrint = "Latest Time: " + hours + "h:" + minutes + "m:" + seconds + "s";
            Sonar._timerLabel.Text = textToPrint;
        }

        //Modifies the open ports textbox
        public void ModifyOpenPortBox(int portToWrite)
        {
            //Easy code to just wipe everything off the textbox
            if (portToWrite == -1) { Sonar._openPortsTextbox.Clear(); }

            //If no wipe code then write as normal
            else
            {
                Sonar._openPortsTextbox.AppendText("- " + portToWrite);
                Sonar._openPortsTextbox.AppendText(Environment.NewLine);
            }
        }

        //Changes the progress bar fill value
        public void ChangeProgressBarFill(int newValue) { Sonar._progressBar.Value = newValue; }

        //Changes the progress bar maximum value
        public void ChangeProgressBarMax(int newValue) { Sonar._progressBar.Maximum = newValue; }

        //Shows message boxes to users
        public void ShowMessageBox(int indexID)
        {
            object[] fetchedData = Sonar.messageBoxData.messageData[indexID];

            MessageBox.Show(
                (string)fetchedData[1], (string)fetchedData[0],
                (MessageBoxButtons)fetchedData[2],
                (MessageBoxIcon)fetchedData[3]
            );
        }

        //Toggles UI On or Off
        public void ToggleUI()
        {
            Sonar._scanButton.Enabled = !Sonar._scanButton.Enabled;
            Sonar._hostTextBox.Enabled = !Sonar._hostTextBox.Enabled;
            Sonar._endingPortBox.Enabled = !Sonar._endingPortBox.Enabled;
            Sonar._startingPortBox.Enabled = !Sonar._startingPortBox.Enabled;
            Sonar._threadComboBox.Enabled = !Sonar._threadComboBox.Enabled;
            Sonar._progressBar.Enabled = !Sonar._progressBar.Enabled;
            Sonar._timeoutComboBox.Enabled = !Sonar._timeoutComboBox.Enabled;
        }
    }
}
