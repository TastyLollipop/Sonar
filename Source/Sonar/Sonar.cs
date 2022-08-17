using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Sonar
{
    public partial class Sonar : Form
    {
        public static Sonar sonar;
        public static UILogic uiLogic = new UILogic();
        public static Threading threading = new Threading();
        public static Utils utils = new Utils();
        public static MessageBoxData messageBoxData = new MessageBoxData();

        public static Button _scanButton;
        public static Label _statusLabel;
        public static Label _openPortsLabel;
        public static ProgressBar _progressBar;
        public static Label _timerLabel;
        public static TextBox _openPortsTextbox;
        public static TextBox _hostTextBox;
        public static TextBox _minPortBox;
        public static TextBox _maxPortBox;
        public static ComboBox _threadComboBox;
        public static ComboBox _timeoutComboBox;

        public string ip;
        public int maxThreads;
        public int currentProgressValue;
        public int timeoutTime;

        public int minPort;
        public int maxPort;

        public List<int> openPorts = new List<int>();
        public List<int> closedPorts = new List<int>();

        private string versionName = "v1.0.0";
        private string aboutURL = "https://github.com/TastyLollipop/Sonar";

        public Sonar()
        {
            InitializeComponent();
            SetupAppDetails();
            PopulateComboBox();
            SetupVariables();
        }

        //Setup every variable needed to be accessed from another class
        private void SetupVariables()
        {
            _scanButton = scanButton;
            _statusLabel = statusLabel;
            _progressBar = progressBar;
            _openPortsTextbox = openPortsTextbox;
            _openPortsLabel = openPortsLabel;
            _hostTextBox = hostTextBox;
            _minPortBox = startingPortBox;
            _maxPortBox = endingPortBox;
            _threadComboBox = threadComboBox;
            _timerLabel = timerLabel;
            _timeoutComboBox = timeoutComboBox;
        }

        //Setup every detail that needs to be ready before launch
        private void SetupAppDetails()
        {
            sonar = this;

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US", false);

            Text = "Sonar " + versionName;
        }

        //Populate the combobox that contains the thread counter
        private void PopulateComboBox()
        {
            for (int i = 1; i < 128; i *= 2) threadComboBox.Items.Add(i);
            threadComboBox.SelectedIndex = 6;

            for (int i = 1000; i <= 8000; i += 1000) timeoutComboBox.Items.Add(i);
            timeoutComboBox.SelectedIndex = 0;
        }

        //Starts the process when 'Scan' button is pressed
        private void scanButton_Click(object sender, EventArgs e)
        {
            maxThreads = int.Parse(threadComboBox.Text);
            timeoutTime = int.Parse(timeoutComboBox.Text);

            if (!CheckVariables()) return;

            ip = hostTextBox.Text;
            minPort = int.Parse(startingPortBox.Text);
            maxPort = int.Parse(endingPortBox.Text);

            uiLogic.InvokeFunctionOn(UILogic.InvokeMode.modifyOpenPortBox, -1);
            uiLogic.InvokeFunctionOn(UILogic.InvokeMode.toggleButtons, null);
            threading.GenerateThread(0);
        }

        //Opens the "about" URL
        private void aboutButton_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start(aboutURL); }

        //Checks if every variable input is correct
        private bool CheckVariables()
        {
            try
            {
                int minPortValue = int.Parse(startingPortBox.Text);
                int maxPortValue = int.Parse(endingPortBox.Text);
                int totalPorts = maxPortValue - minPortValue + 1;
                bool isWrong = false;

                if (string.IsNullOrWhiteSpace(hostTextBox.Text)) isWrong = true;
                if (string.IsNullOrWhiteSpace(endingPortBox.Text)) isWrong = true;
                if (string.IsNullOrWhiteSpace(startingPortBox.Text)) isWrong = true;
                if (minPortValue > maxPortValue) isWrong = true;
                if (minPortValue < 0 || maxPortValue < 0) isWrong = true;
                if (totalPorts < maxThreads) isWrong = true;
                if (minPortValue < 1) isWrong = true;
                if (maxPortValue > 65535) isWrong = true;

                if (isWrong)
                {
                    uiLogic.InvokeFunctionOn(UILogic.InvokeMode.showMessageBox, 0);
                    return false;
                }
                else return true;
            }

            catch
            {
                uiLogic.InvokeFunctionOn(UILogic.InvokeMode.showMessageBox, 0);
                return false;
            }
        }
    }
}
