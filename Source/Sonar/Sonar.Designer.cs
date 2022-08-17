
namespace Sonar
{
    partial class Sonar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sonar));
            this.scanButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.endingPortBox = new System.Windows.Forms.TextBox();
            this.startingPortBox = new System.Windows.Forms.TextBox();
            this.endingPortLabel = new System.Windows.Forms.Label();
            this.startingPortLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.threadComboBox = new System.Windows.Forms.ComboBox();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.threadCountLabel = new System.Windows.Forms.Label();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.hostLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.timeoutComboBox = new System.Windows.Forms.ComboBox();
            this.splitter9 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter8 = new System.Windows.Forms.Splitter();
            this.timerLabel = new System.Windows.Forms.Label();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.openPortsTextbox = new System.Windows.Forms.TextBox();
            this.openPortsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scanButton.Location = new System.Drawing.Point(0, 346);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(320, 30);
            this.scanButton.TabIndex = 4;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutButton.Location = new System.Drawing.Point(0, 376);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(320, 30);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(0, 41);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(320, 20);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status: Idle";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 61);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(320, 23);
            this.progressBar.TabIndex = 7;
            // 
            // endingPortBox
            // 
            this.endingPortBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.endingPortBox.Location = new System.Drawing.Point(0, 316);
            this.endingPortBox.Name = "endingPortBox";
            this.endingPortBox.Size = new System.Drawing.Size(320, 20);
            this.endingPortBox.TabIndex = 3;
            this.endingPortBox.Text = "65535";
            // 
            // startingPortBox
            // 
            this.startingPortBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startingPortBox.Location = new System.Drawing.Point(0, 266);
            this.startingPortBox.Name = "startingPortBox";
            this.startingPortBox.Size = new System.Drawing.Size(320, 20);
            this.startingPortBox.TabIndex = 2;
            this.startingPortBox.Text = "1";
            // 
            // endingPortLabel
            // 
            this.endingPortLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.endingPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingPortLabel.Location = new System.Drawing.Point(0, 296);
            this.endingPortLabel.Name = "endingPortLabel";
            this.endingPortLabel.Size = new System.Drawing.Size(320, 20);
            this.endingPortLabel.TabIndex = 10;
            this.endingPortLabel.Text = "Ending Port";
            this.endingPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPortLabel
            // 
            this.startingPortLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startingPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingPortLabel.Location = new System.Drawing.Point(0, 246);
            this.startingPortLabel.Name = "startingPortLabel";
            this.startingPortLabel.Size = new System.Drawing.Size(320, 20);
            this.startingPortLabel.TabIndex = 11;
            this.startingPortLabel.Text = "Starting Port";
            this.startingPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 336);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(320, 10);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(0, 286);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(320, 10);
            this.splitter2.TabIndex = 13;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(0, 236);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(320, 10);
            this.splitter3.TabIndex = 14;
            this.splitter3.TabStop = false;
            // 
            // threadComboBox
            // 
            this.threadComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.threadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threadComboBox.FormattingEnabled = true;
            this.threadComboBox.Location = new System.Drawing.Point(0, 114);
            this.threadComboBox.Name = "threadComboBox";
            this.threadComboBox.Size = new System.Drawing.Size(320, 21);
            this.threadComboBox.TabIndex = 0;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(0, 31);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(320, 10);
            this.splitter4.TabIndex = 16;
            this.splitter4.TabStop = false;
            // 
            // threadCountLabel
            // 
            this.threadCountLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.threadCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadCountLabel.Location = new System.Drawing.Point(0, 94);
            this.threadCountLabel.Name = "threadCountLabel";
            this.threadCountLabel.Size = new System.Drawing.Size(320, 20);
            this.threadCountLabel.TabIndex = 17;
            this.threadCountLabel.Text = "Thread Count";
            this.threadCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter5.Enabled = false;
            this.splitter5.Location = new System.Drawing.Point(0, 135);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(320, 10);
            this.splitter5.TabIndex = 18;
            this.splitter5.TabStop = false;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hostTextBox.Location = new System.Drawing.Point(0, 216);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(320, 20);
            this.hostTextBox.TabIndex = 2;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter6.Enabled = false;
            this.splitter6.Location = new System.Drawing.Point(0, 84);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(320, 10);
            this.splitter6.TabIndex = 20;
            this.splitter6.TabStop = false;
            // 
            // hostLabel
            // 
            this.hostLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabel.Location = new System.Drawing.Point(0, 196);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(320, 20);
            this.hostLabel.TabIndex = 21;
            this.hostLabel.Text = "IP";
            this.hostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(320, 25);
            this.title.TabIndex = 22;
            this.title.Text = "A Fast and Easy Port Scanner";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.splitter6);
            this.panel1.Controls.Add(this.threadCountLabel);
            this.panel1.Controls.Add(this.threadComboBox);
            this.panel1.Controls.Add(this.splitter5);
            this.panel1.Controls.Add(this.timeoutLabel);
            this.panel1.Controls.Add(this.timeoutComboBox);
            this.panel1.Controls.Add(this.splitter9);
            this.panel1.Controls.Add(this.hostLabel);
            this.panel1.Controls.Add(this.hostTextBox);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.startingPortLabel);
            this.panel1.Controls.Add(this.startingPortBox);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.endingPortLabel);
            this.panel1.Controls.Add(this.endingPortBox);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.scanButton);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 406);
            this.panel1.TabIndex = 23;
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutLabel.Location = new System.Drawing.Point(0, 145);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(320, 20);
            this.timeoutLabel.TabIndex = 24;
            this.timeoutLabel.Text = "Timeout Time (MS)";
            this.timeoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeoutComboBox
            // 
            this.timeoutComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeoutComboBox.FormattingEnabled = true;
            this.timeoutComboBox.Location = new System.Drawing.Point(0, 165);
            this.timeoutComboBox.Name = "timeoutComboBox";
            this.timeoutComboBox.Size = new System.Drawing.Size(320, 21);
            this.timeoutComboBox.TabIndex = 1;
            // 
            // splitter9
            // 
            this.splitter9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter9.Enabled = false;
            this.splitter9.Location = new System.Drawing.Point(0, 186);
            this.splitter9.Name = "splitter9";
            this.splitter9.Size = new System.Drawing.Size(320, 10);
            this.splitter9.TabIndex = 25;
            this.splitter9.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(325, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 406);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitter8);
            this.panel3.Controls.Add(this.timerLabel);
            this.panel3.Controls.Add(this.splitter7);
            this.panel3.Controls.Add(this.openPortsTextbox);
            this.panel3.Controls.Add(this.openPortsLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(340, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 406);
            this.panel3.TabIndex = 0;
            // 
            // splitter8
            // 
            this.splitter8.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter8.Enabled = false;
            this.splitter8.Location = new System.Drawing.Point(0, 143);
            this.splitter8.Name = "splitter8";
            this.splitter8.Size = new System.Drawing.Size(200, 10);
            this.splitter8.TabIndex = 25;
            this.splitter8.TabStop = false;
            // 
            // timerLabel
            // 
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerLabel.Location = new System.Drawing.Point(0, 130);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(200, 13);
            this.timerLabel.TabIndex = 24;
            this.timerLabel.Text = "Latest Time: 0h:0m:0s";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter7
            // 
            this.splitter7.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter7.Enabled = false;
            this.splitter7.Location = new System.Drawing.Point(0, 120);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(200, 10);
            this.splitter7.TabIndex = 23;
            this.splitter7.TabStop = false;
            // 
            // openPortsTextbox
            // 
            this.openPortsTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openPortsTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.openPortsTextbox.Location = new System.Drawing.Point(0, 20);
            this.openPortsTextbox.Multiline = true;
            this.openPortsTextbox.Name = "openPortsTextbox";
            this.openPortsTextbox.ReadOnly = true;
            this.openPortsTextbox.Size = new System.Drawing.Size(200, 100);
            this.openPortsTextbox.TabIndex = 6;
            // 
            // openPortsLabel
            // 
            this.openPortsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openPortsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPortsLabel.Location = new System.Drawing.Point(0, 0);
            this.openPortsLabel.Name = "openPortsLabel";
            this.openPortsLabel.Size = new System.Drawing.Size(200, 20);
            this.openPortsLabel.TabIndex = 23;
            this.openPortsLabel.Text = "Open Ports List";
            this.openPortsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sonar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 416);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sonar";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Sonar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        public System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox endingPortBox;
        private System.Windows.Forms.TextBox startingPortBox;
        private System.Windows.Forms.Label endingPortLabel;
        private System.Windows.Forms.Label startingPortLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ComboBox threadComboBox;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label threadCountLabel;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox openPortsTextbox;
        private System.Windows.Forms.Label openPortsLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.Splitter splitter8;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.ComboBox timeoutComboBox;
        private System.Windows.Forms.Splitter splitter9;
    }
}

