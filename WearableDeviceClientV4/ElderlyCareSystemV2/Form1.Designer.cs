namespace ElderlyCareSystemV2
{
    partial class ElderlyCareSystem
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_emerg = new System.Windows.Forms.GroupBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.emergTime = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emergType = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Emerg = new System.Windows.Forms.Button();
            this.groupBox_monitoring = new System.Windows.Forms.GroupBox();
            this.checkBox_server = new System.Windows.Forms.CheckBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.comboBoxIP = new System.Windows.Forms.ComboBox();
            this.Button_Disconnect_Server = new System.Windows.Forms.Button();
            this.Button_Connect_Server = new System.Windows.Forms.Button();
            this.groupBox_en = new System.Windows.Forms.GroupBox();
            this.Button_Disconnect_EN = new System.Windows.Forms.Button();
            this.labelPortNameEn = new System.Windows.Forms.Label();
            this.Button_Connect_EN = new System.Windows.Forms.Button();
            this.comboBoxPortNameEn = new System.Windows.Forms.ComboBox();
            this.checkBox_en = new System.Windows.Forms.CheckBox();
            this.groupBox_rfid = new System.Windows.Forms.GroupBox();
            this.Button_Disconnect_RFID = new System.Windows.Forms.Button();
            this.labelPortNameRfid = new System.Windows.Forms.Label();
            this.Button_Connect_RFID = new System.Windows.Forms.Button();
            this.comboBoxPortNameRfid = new System.Windows.Forms.ComboBox();
            this.checkBox_rfid = new System.Windows.Forms.CheckBox();
            this.groupBox_cw = new System.Windows.Forms.GroupBox();
            this.labelMedicationCw = new System.Windows.Forms.Label();
            this.comboBoxMedicationCw = new System.Windows.Forms.ComboBox();
            this.labelGenderCw = new System.Windows.Forms.Label();
            this.comboBoxGenderCw = new System.Windows.Forms.ComboBox();
            this.labelPortNameCw = new System.Windows.Forms.Label();
            this.comboBoxPortNameCw = new System.Windows.Forms.ComboBox();
            this.checkBox_cw = new System.Windows.Forms.CheckBox();
            this.Button_Disconnect_CW = new System.Windows.Forms.Button();
            this.Button_Connect_CW = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.low_cw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.avg_cw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.high_cw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chart_cw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.current_cw = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.previous_rfid = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.time_rfid = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.current_rfid = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.status_rfid = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.front_door = new System.Windows.Forms.Panel();
            this.lounge = new System.Windows.Forms.Panel();
            this.back_door = new System.Windows.Forms.Panel();
            this.kitchen = new System.Windows.Forms.Panel();
            this.bathroom = new System.Windows.Forms.Panel();
            this.bedroom = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enApp2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.enApp1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.serialPort_cw = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_rfid = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_en = new System.IO.Ports.SerialPort(this.components);
            this.alert = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_emerg.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox_monitoring.SuspendLayout();
            this.groupBox_en.SuspendLayout();
            this.groupBox_rfid.SuspendLayout();
            this.groupBox_cw.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cw)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox_emerg);
            this.tabPage1.Controls.Add(this.groupBox_monitoring);
            this.tabPage1.Controls.Add(this.groupBox_en);
            this.tabPage1.Controls.Add(this.groupBox_rfid);
            this.tabPage1.Controls.Add(this.groupBox_cw);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // groupBox_emerg
            // 
            this.groupBox_emerg.Controls.Add(this.groupBox24);
            this.groupBox_emerg.Controls.Add(this.groupBox23);
            this.groupBox_emerg.Controls.Add(this.groupBox22);
            this.groupBox_emerg.Controls.Add(this.Button_Cancel);
            this.groupBox_emerg.Controls.Add(this.Button_Emerg);
            this.groupBox_emerg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_emerg.Location = new System.Drawing.Point(10, 197);
            this.groupBox_emerg.Name = "groupBox_emerg";
            this.groupBox_emerg.Size = new System.Drawing.Size(380, 250);
            this.groupBox_emerg.TabIndex = 13;
            this.groupBox_emerg.TabStop = false;
            this.groupBox_emerg.Text = "Emergency";
            this.groupBox_emerg.Visible = false;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.label12);
            this.groupBox24.Controls.Add(this.emergTime);
            this.groupBox24.Location = new System.Drawing.Point(198, 128);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(164, 63);
            this.groupBox24.TabIndex = 18;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Time";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 22);
            this.label12.TabIndex = 5;
            // 
            // emergTime
            // 
            this.emergTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emergTime.AutoSize = true;
            this.emergTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergTime.Location = new System.Drawing.Point(13, 22);
            this.emergTime.Name = "emergTime";
            this.emergTime.Size = new System.Drawing.Size(140, 22);
            this.emergTime.TabIndex = 15;
            this.emergTime.Text = "No Emergency.";
            this.emergTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label11);
            this.groupBox23.Controls.Add(this.emergType);
            this.groupBox23.Location = new System.Drawing.Point(16, 128);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(164, 63);
            this.groupBox23.TabIndex = 17;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Status";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 22);
            this.label11.TabIndex = 5;
            // 
            // emergType
            // 
            this.emergType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emergType.AutoSize = true;
            this.emergType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergType.Location = new System.Drawing.Point(6, 22);
            this.emergType.Name = "emergType";
            this.emergType.Size = new System.Drawing.Size(140, 22);
            this.emergType.TabIndex = 15;
            this.emergType.Text = "No Emergency.";
            this.emergType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label10);
            this.groupBox22.Controls.Add(this.countdown);
            this.groupBox22.Location = new System.Drawing.Point(16, 21);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(346, 101);
            this.groupBox22.TabIndex = 16;
            this.groupBox22.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 22);
            this.label10.TabIndex = 5;
            // 
            // countdown
            // 
            this.countdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.countdown.AutoSize = true;
            this.countdown.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.Location = new System.Drawing.Point(132, 18);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(102, 72);
            this.countdown.TabIndex = 14;
            this.countdown.Text = "00";
            this.countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Cancel.Location = new System.Drawing.Point(190, 220);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(128, 24);
            this.Button_Cancel.TabIndex = 13;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Emerg
            // 
            this.Button_Emerg.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Emerg.Location = new System.Drawing.Point(56, 220);
            this.Button_Emerg.Name = "Button_Emerg";
            this.Button_Emerg.Size = new System.Drawing.Size(128, 24);
            this.Button_Emerg.TabIndex = 12;
            this.Button_Emerg.Text = "Emergency";
            this.Button_Emerg.UseVisualStyleBackColor = false;
            this.Button_Emerg.Click += new System.EventHandler(this.Button_Emerg_Click);
            // 
            // groupBox_monitoring
            // 
            this.groupBox_monitoring.Controls.Add(this.checkBox_server);
            this.groupBox_monitoring.Controls.Add(this.labelIP);
            this.groupBox_monitoring.Controls.Add(this.comboBoxIP);
            this.groupBox_monitoring.Controls.Add(this.Button_Disconnect_Server);
            this.groupBox_monitoring.Controls.Add(this.Button_Connect_Server);
            this.groupBox_monitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_monitoring.Location = new System.Drawing.Point(10, 4);
            this.groupBox_monitoring.Name = "groupBox_monitoring";
            this.groupBox_monitoring.Size = new System.Drawing.Size(380, 187);
            this.groupBox_monitoring.TabIndex = 12;
            this.groupBox_monitoring.TabStop = false;
            this.groupBox_monitoring.Text = "Monitoring";
            // 
            // checkBox_server
            // 
            this.checkBox_server.AutoSize = true;
            this.checkBox_server.Location = new System.Drawing.Point(21, 21);
            this.checkBox_server.Name = "checkBox_server";
            this.checkBox_server.Size = new System.Drawing.Size(67, 20);
            this.checkBox_server.TabIndex = 10;
            this.checkBox_server.Text = "Server";
            this.checkBox_server.UseVisualStyleBackColor = true;
            this.checkBox_server.CheckedChanged += new System.EventHandler(this.checkBox_server_CheckedChanged);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Enabled = false;
            this.labelIP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(60, 47);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(75, 16);
            this.labelIP.TabIndex = 11;
            this.labelIP.Text = "IP Address:";
            // 
            // comboBoxIP
            // 
            this.comboBoxIP.Enabled = false;
            this.comboBoxIP.FormattingEnabled = true;
            this.comboBoxIP.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.comboBoxIP.Location = new System.Drawing.Point(150, 44);
            this.comboBoxIP.Name = "comboBoxIP";
            this.comboBoxIP.Size = new System.Drawing.Size(168, 24);
            this.comboBoxIP.TabIndex = 10;
            // 
            // Button_Disconnect_Server
            // 
            this.Button_Disconnect_Server.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Disconnect_Server.Enabled = false;
            this.Button_Disconnect_Server.Location = new System.Drawing.Point(190, 155);
            this.Button_Disconnect_Server.Name = "Button_Disconnect_Server";
            this.Button_Disconnect_Server.Size = new System.Drawing.Size(128, 24);
            this.Button_Disconnect_Server.TabIndex = 1;
            this.Button_Disconnect_Server.Text = "Disconnect";
            this.Button_Disconnect_Server.UseVisualStyleBackColor = false;
            this.Button_Disconnect_Server.Click += new System.EventHandler(this.Button_Disconnect_Server_Click);
            // 
            // Button_Connect_Server
            // 
            this.Button_Connect_Server.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Connect_Server.Enabled = false;
            this.Button_Connect_Server.Location = new System.Drawing.Point(56, 155);
            this.Button_Connect_Server.Name = "Button_Connect_Server";
            this.Button_Connect_Server.Size = new System.Drawing.Size(128, 24);
            this.Button_Connect_Server.TabIndex = 0;
            this.Button_Connect_Server.Text = "Connect";
            this.Button_Connect_Server.UseVisualStyleBackColor = false;
            this.Button_Connect_Server.Click += new System.EventHandler(this.Button_Connect_Server_Click);
            // 
            // groupBox_en
            // 
            this.groupBox_en.Controls.Add(this.Button_Disconnect_EN);
            this.groupBox_en.Controls.Add(this.labelPortNameEn);
            this.groupBox_en.Controls.Add(this.Button_Connect_EN);
            this.groupBox_en.Controls.Add(this.comboBoxPortNameEn);
            this.groupBox_en.Controls.Add(this.checkBox_en);
            this.groupBox_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_en.Location = new System.Drawing.Point(398, 325);
            this.groupBox_en.Name = "groupBox_en";
            this.groupBox_en.Size = new System.Drawing.Size(377, 122);
            this.groupBox_en.TabIndex = 11;
            this.groupBox_en.TabStop = false;
            this.groupBox_en.Text = "Environment Settings";
            // 
            // Button_Disconnect_EN
            // 
            this.Button_Disconnect_EN.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Disconnect_EN.Enabled = false;
            this.Button_Disconnect_EN.Location = new System.Drawing.Point(203, 92);
            this.Button_Disconnect_EN.Name = "Button_Disconnect_EN";
            this.Button_Disconnect_EN.Size = new System.Drawing.Size(128, 24);
            this.Button_Disconnect_EN.TabIndex = 13;
            this.Button_Disconnect_EN.Text = "Disconnect";
            this.Button_Disconnect_EN.UseVisualStyleBackColor = false;
            this.Button_Disconnect_EN.Click += new System.EventHandler(this.Button_Disconnect_EN_Click);
            // 
            // labelPortNameEn
            // 
            this.labelPortNameEn.AutoSize = true;
            this.labelPortNameEn.Enabled = false;
            this.labelPortNameEn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortNameEn.Location = new System.Drawing.Point(67, 47);
            this.labelPortNameEn.Name = "labelPortNameEn";
            this.labelPortNameEn.Size = new System.Drawing.Size(74, 16);
            this.labelPortNameEn.TabIndex = 5;
            this.labelPortNameEn.Text = "Port Name:";
            // 
            // Button_Connect_EN
            // 
            this.Button_Connect_EN.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Connect_EN.Enabled = false;
            this.Button_Connect_EN.Location = new System.Drawing.Point(69, 92);
            this.Button_Connect_EN.Name = "Button_Connect_EN";
            this.Button_Connect_EN.Size = new System.Drawing.Size(128, 24);
            this.Button_Connect_EN.TabIndex = 12;
            this.Button_Connect_EN.Text = "Connect";
            this.Button_Connect_EN.UseVisualStyleBackColor = false;
            this.Button_Connect_EN.Click += new System.EventHandler(this.Button_Connect_EN_Click);
            // 
            // comboBoxPortNameEn
            // 
            this.comboBoxPortNameEn.Enabled = false;
            this.comboBoxPortNameEn.FormattingEnabled = true;
            this.comboBoxPortNameEn.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBoxPortNameEn.Location = new System.Drawing.Point(157, 44);
            this.comboBoxPortNameEn.Name = "comboBoxPortNameEn";
            this.comboBoxPortNameEn.Size = new System.Drawing.Size(168, 24);
            this.comboBoxPortNameEn.TabIndex = 1;
            // 
            // checkBox_en
            // 
            this.checkBox_en.AutoSize = true;
            this.checkBox_en.Location = new System.Drawing.Point(23, 21);
            this.checkBox_en.Name = "checkBox_en";
            this.checkBox_en.Size = new System.Drawing.Size(101, 20);
            this.checkBox_en.TabIndex = 2;
            this.checkBox_en.Text = "Environment";
            this.checkBox_en.UseVisualStyleBackColor = true;
            this.checkBox_en.CheckedChanged += new System.EventHandler(this.checkBox_en_CheckedChanged);
            // 
            // groupBox_rfid
            // 
            this.groupBox_rfid.Controls.Add(this.Button_Disconnect_RFID);
            this.groupBox_rfid.Controls.Add(this.labelPortNameRfid);
            this.groupBox_rfid.Controls.Add(this.Button_Connect_RFID);
            this.groupBox_rfid.Controls.Add(this.comboBoxPortNameRfid);
            this.groupBox_rfid.Controls.Add(this.checkBox_rfid);
            this.groupBox_rfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_rfid.Location = new System.Drawing.Point(398, 197);
            this.groupBox_rfid.Name = "groupBox_rfid";
            this.groupBox_rfid.Size = new System.Drawing.Size(377, 122);
            this.groupBox_rfid.TabIndex = 10;
            this.groupBox_rfid.TabStop = false;
            this.groupBox_rfid.Text = "RFID Settings";
            // 
            // Button_Disconnect_RFID
            // 
            this.Button_Disconnect_RFID.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Disconnect_RFID.Enabled = false;
            this.Button_Disconnect_RFID.Location = new System.Drawing.Point(203, 92);
            this.Button_Disconnect_RFID.Name = "Button_Disconnect_RFID";
            this.Button_Disconnect_RFID.Size = new System.Drawing.Size(128, 24);
            this.Button_Disconnect_RFID.TabIndex = 11;
            this.Button_Disconnect_RFID.Text = "Disconnect";
            this.Button_Disconnect_RFID.UseVisualStyleBackColor = false;
            this.Button_Disconnect_RFID.Click += new System.EventHandler(this.Button_Disconnect_RFID_Click);
            // 
            // labelPortNameRfid
            // 
            this.labelPortNameRfid.AutoSize = true;
            this.labelPortNameRfid.Enabled = false;
            this.labelPortNameRfid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortNameRfid.Location = new System.Drawing.Point(67, 47);
            this.labelPortNameRfid.Name = "labelPortNameRfid";
            this.labelPortNameRfid.Size = new System.Drawing.Size(74, 16);
            this.labelPortNameRfid.TabIndex = 5;
            this.labelPortNameRfid.Text = "Port Name:";
            // 
            // Button_Connect_RFID
            // 
            this.Button_Connect_RFID.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Connect_RFID.Enabled = false;
            this.Button_Connect_RFID.Location = new System.Drawing.Point(69, 92);
            this.Button_Connect_RFID.Name = "Button_Connect_RFID";
            this.Button_Connect_RFID.Size = new System.Drawing.Size(128, 24);
            this.Button_Connect_RFID.TabIndex = 10;
            this.Button_Connect_RFID.Text = "Connect";
            this.Button_Connect_RFID.UseVisualStyleBackColor = false;
            this.Button_Connect_RFID.Click += new System.EventHandler(this.Button_Connect_RFID_Click);
            // 
            // comboBoxPortNameRfid
            // 
            this.comboBoxPortNameRfid.Enabled = false;
            this.comboBoxPortNameRfid.FormattingEnabled = true;
            this.comboBoxPortNameRfid.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBoxPortNameRfid.Location = new System.Drawing.Point(157, 44);
            this.comboBoxPortNameRfid.Name = "comboBoxPortNameRfid";
            this.comboBoxPortNameRfid.Size = new System.Drawing.Size(168, 24);
            this.comboBoxPortNameRfid.TabIndex = 1;
            // 
            // checkBox_rfid
            // 
            this.checkBox_rfid.AutoSize = true;
            this.checkBox_rfid.Enabled = false;
            this.checkBox_rfid.Location = new System.Drawing.Point(23, 21);
            this.checkBox_rfid.Name = "checkBox_rfid";
            this.checkBox_rfid.Size = new System.Drawing.Size(58, 20);
            this.checkBox_rfid.TabIndex = 2;
            this.checkBox_rfid.Text = "RFID";
            this.checkBox_rfid.UseVisualStyleBackColor = true;
            this.checkBox_rfid.CheckedChanged += new System.EventHandler(this.checkBox_rfid_CheckedChanged);
            // 
            // groupBox_cw
            // 
            this.groupBox_cw.Controls.Add(this.labelMedicationCw);
            this.groupBox_cw.Controls.Add(this.comboBoxMedicationCw);
            this.groupBox_cw.Controls.Add(this.labelGenderCw);
            this.groupBox_cw.Controls.Add(this.comboBoxGenderCw);
            this.groupBox_cw.Controls.Add(this.labelPortNameCw);
            this.groupBox_cw.Controls.Add(this.comboBoxPortNameCw);
            this.groupBox_cw.Controls.Add(this.checkBox_cw);
            this.groupBox_cw.Controls.Add(this.Button_Disconnect_CW);
            this.groupBox_cw.Controls.Add(this.Button_Connect_CW);
            this.groupBox_cw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_cw.Location = new System.Drawing.Point(398, 4);
            this.groupBox_cw.Name = "groupBox_cw";
            this.groupBox_cw.Size = new System.Drawing.Size(377, 187);
            this.groupBox_cw.TabIndex = 0;
            this.groupBox_cw.TabStop = false;
            this.groupBox_cw.Text = "Chest Wear Settings";
            // 
            // labelMedicationCw
            // 
            this.labelMedicationCw.AutoSize = true;
            this.labelMedicationCw.Enabled = false;
            this.labelMedicationCw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicationCw.Location = new System.Drawing.Point(66, 107);
            this.labelMedicationCw.Name = "labelMedicationCw";
            this.labelMedicationCw.Size = new System.Drawing.Size(75, 16);
            this.labelMedicationCw.TabIndex = 9;
            this.labelMedicationCw.Text = "Medication:";
            // 
            // comboBoxMedicationCw
            // 
            this.comboBoxMedicationCw.Enabled = false;
            this.comboBoxMedicationCw.FormattingEnabled = true;
            this.comboBoxMedicationCw.Items.AddRange(new object[] {
            "Beta Blocker",
            "Thyroid",
            "None"});
            this.comboBoxMedicationCw.Location = new System.Drawing.Point(157, 104);
            this.comboBoxMedicationCw.Name = "comboBoxMedicationCw";
            this.comboBoxMedicationCw.Size = new System.Drawing.Size(168, 24);
            this.comboBoxMedicationCw.TabIndex = 8;
            // 
            // labelGenderCw
            // 
            this.labelGenderCw.AutoSize = true;
            this.labelGenderCw.Enabled = false;
            this.labelGenderCw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderCw.Location = new System.Drawing.Point(87, 77);
            this.labelGenderCw.Name = "labelGenderCw";
            this.labelGenderCw.Size = new System.Drawing.Size(54, 16);
            this.labelGenderCw.TabIndex = 7;
            this.labelGenderCw.Text = "Gender:";
            // 
            // comboBoxGenderCw
            // 
            this.comboBoxGenderCw.Enabled = false;
            this.comboBoxGenderCw.FormattingEnabled = true;
            this.comboBoxGenderCw.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.comboBoxGenderCw.Location = new System.Drawing.Point(157, 74);
            this.comboBoxGenderCw.Name = "comboBoxGenderCw";
            this.comboBoxGenderCw.Size = new System.Drawing.Size(168, 24);
            this.comboBoxGenderCw.TabIndex = 6;
            // 
            // labelPortNameCw
            // 
            this.labelPortNameCw.AutoSize = true;
            this.labelPortNameCw.Enabled = false;
            this.labelPortNameCw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortNameCw.Location = new System.Drawing.Point(67, 47);
            this.labelPortNameCw.Name = "labelPortNameCw";
            this.labelPortNameCw.Size = new System.Drawing.Size(74, 16);
            this.labelPortNameCw.TabIndex = 5;
            this.labelPortNameCw.Text = "Port Name:";
            // 
            // comboBoxPortNameCw
            // 
            this.comboBoxPortNameCw.Enabled = false;
            this.comboBoxPortNameCw.FormattingEnabled = true;
            this.comboBoxPortNameCw.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBoxPortNameCw.Location = new System.Drawing.Point(157, 44);
            this.comboBoxPortNameCw.Name = "comboBoxPortNameCw";
            this.comboBoxPortNameCw.Size = new System.Drawing.Size(168, 24);
            this.comboBoxPortNameCw.TabIndex = 1;
            // 
            // checkBox_cw
            // 
            this.checkBox_cw.AutoSize = true;
            this.checkBox_cw.Location = new System.Drawing.Point(23, 21);
            this.checkBox_cw.Name = "checkBox_cw";
            this.checkBox_cw.Size = new System.Drawing.Size(97, 20);
            this.checkBox_cw.TabIndex = 2;
            this.checkBox_cw.Text = "Chest Wear";
            this.checkBox_cw.UseVisualStyleBackColor = true;
            this.checkBox_cw.CheckedChanged += new System.EventHandler(this.checkBox_cw_CheckedChanged);
            // 
            // Button_Disconnect_CW
            // 
            this.Button_Disconnect_CW.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Disconnect_CW.Enabled = false;
            this.Button_Disconnect_CW.Location = new System.Drawing.Point(203, 155);
            this.Button_Disconnect_CW.Name = "Button_Disconnect_CW";
            this.Button_Disconnect_CW.Size = new System.Drawing.Size(128, 24);
            this.Button_Disconnect_CW.TabIndex = 1;
            this.Button_Disconnect_CW.Text = "Disconnect";
            this.Button_Disconnect_CW.UseVisualStyleBackColor = false;
            this.Button_Disconnect_CW.Click += new System.EventHandler(this.Button_Disconnect_CW_Click);
            // 
            // Button_Connect_CW
            // 
            this.Button_Connect_CW.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Connect_CW.Enabled = false;
            this.Button_Connect_CW.Location = new System.Drawing.Point(69, 155);
            this.Button_Connect_CW.Name = "Button_Connect_CW";
            this.Button_Connect_CW.Size = new System.Drawing.Size(128, 24);
            this.Button_Connect_CW.TabIndex = 0;
            this.Button_Connect_CW.Text = "Connect";
            this.Button_Connect_CW.UseVisualStyleBackColor = false;
            this.Button_Connect_CW.Click += new System.EventHandler(this.Button_Connect_CW_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Heart Rate";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.low_cw);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Location = new System.Drawing.Point(612, 106);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(164, 101);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Low";
            // 
            // low_cw
            // 
            this.low_cw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.low_cw.AutoSize = true;
            this.low_cw.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low_cw.Location = new System.Drawing.Point(51, 21);
            this.low_cw.Name = "low_cw";
            this.low_cw.Size = new System.Drawing.Size(51, 55);
            this.low_cw.TabIndex = 4;
            this.low_cw.Text = "0";
            this.low_cw.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "bpm";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.avg_cw);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(443, 106);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(164, 101);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Average";
            // 
            // avg_cw
            // 
            this.avg_cw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.avg_cw.AutoSize = true;
            this.avg_cw.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_cw.Location = new System.Drawing.Point(52, 21);
            this.avg_cw.Name = "avg_cw";
            this.avg_cw.Size = new System.Drawing.Size(51, 55);
            this.avg_cw.TabIndex = 3;
            this.avg_cw.Text = "0";
            this.avg_cw.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "bpm";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.high_cw);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Location = new System.Drawing.Point(612, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(164, 101);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "High";
            // 
            // high_cw
            // 
            this.high_cw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.high_cw.AutoSize = true;
            this.high_cw.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_cw.Location = new System.Drawing.Point(51, 21);
            this.high_cw.Name = "high_cw";
            this.high_cw.Size = new System.Drawing.Size(51, 55);
            this.high_cw.TabIndex = 5;
            this.high_cw.Text = "0";
            this.high_cw.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "bpm";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(443, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(164, 101);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(6, 213);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(774, 245);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.chart_cw);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(766, 216);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Chart";
            // 
            // chart_cw
            // 
            this.chart_cw.BackColor = System.Drawing.SystemColors.Control;
            this.chart_cw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_cw.Location = new System.Drawing.Point(3, 3);
            this.chart_cw.Name = "chart_cw";
            this.chart_cw.Size = new System.Drawing.Size(760, 210);
            this.chart_cw.TabIndex = 0;
            this.chart_cw.Text = "chart1";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(766, 219);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(433, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.current_cw);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(10, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(427, 201);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current";
            // 
            // current_cw
            // 
            this.current_cw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.current_cw.AutoSize = true;
            this.current_cw.Font = new System.Drawing.Font("Arial", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_cw.Location = new System.Drawing.Point(120, 21);
            this.current_cw.Name = "current_cw";
            this.current_cw.Size = new System.Drawing.Size(137, 149);
            this.current_cw.TabIndex = 1;
            this.current_cw.Text = "0";
            this.current_cw.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "bpm";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.groupBox16);
            this.tabPage7.Controls.Add(this.groupBox17);
            this.tabPage7.Controls.Add(this.groupBox18);
            this.tabPage7.Controls.Add(this.groupBox19);
            this.tabPage7.Controls.Add(this.groupBox20);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(786, 464);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Accelerometer";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label4);
            this.groupBox16.Location = new System.Drawing.Point(612, 341);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(164, 101);
            this.groupBox16.TabIndex = 15;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "G";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "n/a";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label5);
            this.groupBox17.Location = new System.Drawing.Point(612, 234);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(164, 101);
            this.groupBox17.TabIndex = 14;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Z";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "n/a";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label6);
            this.groupBox18.Location = new System.Drawing.Point(612, 127);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(164, 101);
            this.groupBox18.TabIndex = 13;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Y";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "n/a";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label8);
            this.groupBox19.Location = new System.Drawing.Point(612, 20);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(164, 101);
            this.groupBox19.TabIndex = 12;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "X";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "n/a";
            // 
            // groupBox20
            // 
            this.groupBox20.Location = new System.Drawing.Point(6, 6);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(596, 452);
            this.groupBox20.TabIndex = 11;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Status";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RFID";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.previous_rfid);
            this.groupBox13.Location = new System.Drawing.Point(612, 341);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(164, 101);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Previous";
            // 
            // previous_rfid
            // 
            this.previous_rfid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.previous_rfid.AutoSize = true;
            this.previous_rfid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_rfid.Location = new System.Drawing.Point(25, 46);
            this.previous_rfid.Name = "previous_rfid";
            this.previous_rfid.Size = new System.Drawing.Size(35, 22);
            this.previous_rfid.TabIndex = 5;
            this.previous_rfid.Text = "n/a";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.time_rfid);
            this.groupBox14.Location = new System.Drawing.Point(612, 234);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(164, 101);
            this.groupBox14.TabIndex = 9;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Time";
            // 
            // time_rfid
            // 
            this.time_rfid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.time_rfid.AutoSize = true;
            this.time_rfid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_rfid.Location = new System.Drawing.Point(25, 44);
            this.time_rfid.Name = "time_rfid";
            this.time_rfid.Size = new System.Drawing.Size(35, 22);
            this.time_rfid.TabIndex = 5;
            this.time_rfid.Text = "n/a";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.current_rfid);
            this.groupBox12.Location = new System.Drawing.Point(612, 127);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(164, 101);
            this.groupBox12.TabIndex = 8;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Current";
            // 
            // current_rfid
            // 
            this.current_rfid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.current_rfid.AutoSize = true;
            this.current_rfid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_rfid.Location = new System.Drawing.Point(25, 40);
            this.current_rfid.Name = "current_rfid";
            this.current_rfid.Size = new System.Drawing.Size(35, 22);
            this.current_rfid.TabIndex = 5;
            this.current_rfid.Text = "n/a";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.status_rfid);
            this.groupBox11.Location = new System.Drawing.Point(612, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(164, 101);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Status";
            // 
            // status_rfid
            // 
            this.status_rfid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.status_rfid.AutoSize = true;
            this.status_rfid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_rfid.Location = new System.Drawing.Point(25, 43);
            this.status_rfid.Name = "status_rfid";
            this.status_rfid.Size = new System.Drawing.Size(35, 22);
            this.status_rfid.TabIndex = 5;
            this.status_rfid.Text = "n/a";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.front_door);
            this.groupBox10.Controls.Add(this.lounge);
            this.groupBox10.Controls.Add(this.back_door);
            this.groupBox10.Controls.Add(this.kitchen);
            this.groupBox10.Controls.Add(this.bathroom);
            this.groupBox10.Controls.Add(this.bedroom);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(596, 452);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Map";
            // 
            // front_door
            // 
            this.front_door.BackColor = System.Drawing.Color.White;
            this.front_door.Location = new System.Drawing.Point(227, 52);
            this.front_door.Name = "front_door";
            this.front_door.Size = new System.Drawing.Size(143, 27);
            this.front_door.TabIndex = 4;
            // 
            // lounge
            // 
            this.lounge.BackColor = System.Drawing.Color.White;
            this.lounge.Location = new System.Drawing.Point(95, 85);
            this.lounge.Name = "lounge";
            this.lounge.Size = new System.Drawing.Size(200, 139);
            this.lounge.TabIndex = 0;
            // 
            // back_door
            // 
            this.back_door.BackColor = System.Drawing.Color.White;
            this.back_door.Location = new System.Drawing.Point(227, 375);
            this.back_door.Name = "back_door";
            this.back_door.Size = new System.Drawing.Size(143, 27);
            this.back_door.TabIndex = 3;
            // 
            // kitchen
            // 
            this.kitchen.BackColor = System.Drawing.Color.White;
            this.kitchen.Location = new System.Drawing.Point(95, 230);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(200, 139);
            this.kitchen.TabIndex = 2;
            // 
            // bathroom
            // 
            this.bathroom.BackColor = System.Drawing.Color.White;
            this.bathroom.Location = new System.Drawing.Point(298, 230);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(200, 139);
            this.bathroom.TabIndex = 3;
            // 
            // bedroom
            // 
            this.bedroom.BackColor = System.Drawing.Color.White;
            this.bedroom.Location = new System.Drawing.Point(298, 85);
            this.bedroom.Name = "bedroom";
            this.bedroom.Size = new System.Drawing.Size(200, 139);
            this.bedroom.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox15);
            this.tabPage4.Controls.Add(this.groupBox21);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(786, 464);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Environment Control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enApp2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(614, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 200);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliance 2";
            // 
            // enApp2
            // 
            this.enApp2.Location = new System.Drawing.Point(35, 70);
            this.enApp2.Name = "enApp2";
            this.enApp2.Size = new System.Drawing.Size(94, 30);
            this.enApp2.TabIndex = 6;
            this.enApp2.Text = "...";
            this.enApp2.UseVisualStyleBackColor = true;
            this.enApp2.Click += new System.EventHandler(this.enApp2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "n/a";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.enApp1);
            this.groupBox15.Controls.Add(this.label15);
            this.groupBox15.Location = new System.Drawing.Point(614, 20);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(164, 200);
            this.groupBox15.TabIndex = 17;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Appliance 1";
            // 
            // enApp1
            // 
            this.enApp1.Location = new System.Drawing.Point(35, 70);
            this.enApp1.Name = "enApp1";
            this.enApp1.Size = new System.Drawing.Size(94, 30);
            this.enApp1.TabIndex = 6;
            this.enApp1.Text = "...";
            this.enApp1.UseVisualStyleBackColor = true;
            this.enApp1.Click += new System.EventHandler(this.enApp1_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(58, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "n/a";
            // 
            // groupBox21
            // 
            this.groupBox21.Location = new System.Drawing.Point(8, 6);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(596, 452);
            this.groupBox21.TabIndex = 16;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Status";
            // 
            // serialPort_cw
            // 
            this.serialPort_cw.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_cw_DataReceived);
            // 
            // serialPort_rfid
            // 
            this.serialPort_rfid.BaudRate = 2400;
            this.serialPort_rfid.DtrEnable = true;
            this.serialPort_rfid.ReadTimeout = 3000;
            this.serialPort_rfid.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_rfid_DataReceived);
            // 
            // alert
            // 
            this.alert.BackColor = System.Drawing.Color.Transparent;
            this.alert.Location = new System.Drawing.Point(1, 0);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(817, 517);
            this.alert.TabIndex = 1;
            // 
            // ElderlyCareSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 517);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.alert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ElderlyCareSystem";
            this.ShowIcon = false;
            this.Text = "Elderly Care System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_emerg.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox_monitoring.ResumeLayout(false);
            this.groupBox_monitoring.PerformLayout();
            this.groupBox_en.ResumeLayout(false);
            this.groupBox_en.PerformLayout();
            this.groupBox_rfid.ResumeLayout(false);
            this.groupBox_rfid.PerformLayout();
            this.groupBox_cw.ResumeLayout(false);
            this.groupBox_cw.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_cw)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox_cw;
        private System.Windows.Forms.Label labelMedicationCw;
        private System.Windows.Forms.ComboBox comboBoxMedicationCw;
        private System.Windows.Forms.Label labelGenderCw;
        private System.Windows.Forms.ComboBox comboBoxGenderCw;
        private System.Windows.Forms.Label labelPortNameCw;
        private System.Windows.Forms.ComboBox comboBoxPortNameCw;
        private System.Windows.Forms.CheckBox checkBox_cw;
        private System.Windows.Forms.Button Button_Disconnect_CW;
        private System.Windows.Forms.Button Button_Connect_CW;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label current_cw;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.IO.Ports.SerialPort serialPort_cw;
        private System.IO.Ports.SerialPort serialPort_rfid;
        private System.IO.Ports.SerialPort serialPort_en;
        private System.Windows.Forms.GroupBox groupBox_en;
        private System.Windows.Forms.Button Button_Disconnect_EN;
        private System.Windows.Forms.Label labelPortNameEn;
        private System.Windows.Forms.Button Button_Connect_EN;
        private System.Windows.Forms.ComboBox comboBoxPortNameEn;
        private System.Windows.Forms.CheckBox checkBox_en;
        private System.Windows.Forms.GroupBox groupBox_rfid;
        private System.Windows.Forms.Button Button_Disconnect_RFID;
        private System.Windows.Forms.Label labelPortNameRfid;
        private System.Windows.Forms.Button Button_Connect_RFID;
        private System.Windows.Forms.ComboBox comboBoxPortNameRfid;
        private System.Windows.Forms.CheckBox checkBox_rfid;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label low_cw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label avg_cw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label high_cw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label previous_rfid;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label time_rfid;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label current_rfid;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label status_rfid;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Panel front_door;
        private System.Windows.Forms.Panel lounge;
        private System.Windows.Forms.Panel back_door;
        private System.Windows.Forms.Panel kitchen;
        private System.Windows.Forms.Panel bathroom;
        private System.Windows.Forms.Panel bedroom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cw;
        private System.Windows.Forms.GroupBox groupBox_monitoring;
        private System.Windows.Forms.Button Button_Disconnect_Server;
        private System.Windows.Forms.Button Button_Connect_Server;
        private System.Windows.Forms.Panel alert;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.ComboBox comboBoxIP;
        private System.Windows.Forms.GroupBox groupBox_emerg;
        private System.Windows.Forms.CheckBox checkBox_server;
        private System.Windows.Forms.Label emergType;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Emerg;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label emergTime;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enApp2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button enApp1;

    }
}

