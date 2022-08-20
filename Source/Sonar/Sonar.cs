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
        public static Label _timerLabel;
        public static ProgressBar _progressBar;
        public static TextBox _openPortsTextbox;
        public static TextBox _hostTextBox;
        public static TextBox _startingPortBox;
        public static TextBox _endingPortBox;
        public static ComboBox _threadComboBox;
        public static ComboBox _timeoutComboBox;

        public string ip;
        public int maxThreads;
        public int currentProgressValue;
        public int timeoutTime;

        public int startingPort;
        public int endingPort;

        public List<int> openPorts = new List<int>();
        public List<int> closedPorts = new List<int>();

        private string versionName = "v1.0.1";
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
            _startingPortBox = startingPortBox;
            _endingPortBox = endingPortBox;
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
            if (!utils.CheckVariables()) return;

            ip = hostTextBox.Text;
            startingPort = int.Parse(startingPortBox.Text);
            endingPort = int.Parse(endingPortBox.Text);

            uiLogic.InvokeFunctionOn(UILogic.InvokeMode.modifyOpenPortBox, -1);
            uiLogic.InvokeFunctionOn(UILogic.InvokeMode.toggleButtons, null);
            threading.GenerateThread(0);
        }

        //Opens the "about" URL
        private void aboutButton_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start(aboutURL); }
    }
}
