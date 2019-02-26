namespace SerialCommunication
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.gpbSend = new System.Windows.Forms.GroupBox();
            this.rbSendStr = new System.Windows.Forms.RadioButton();
            this.rbSend16 = new System.Windows.Forms.RadioButton();
            this.gpbReceive = new System.Windows.Forms.GroupBox();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcv16 = new System.Windows.Forms.RadioButton();
            this.cbTimeSend = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Save = new System.Windows.Forms.TextBox();
            this.txtRcv = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsSpNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeSend = new System.Windows.Forms.Timer(this.components);
            this.cbSendHex = new System.Windows.Forms.CheckBox();
            this.txtStrTo16 = new System.Windows.Forms.TextBox();
            this.btnSendCRC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.send_num = new System.Windows.Forms.Label();
            this.Rcvnum = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.gpbSend.SuspendLayout();
            this.gpbReceive.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口：";
            // 
            // cbSerial
            // 
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(61, 31);
            this.cbSerial.Margin = new System.Windows.Forms.Padding(2);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(103, 20);
            this.cbSerial.TabIndex = 1;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(184, 27);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(95, 26);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "打开串口";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(293, 27);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "波特率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "停止位：";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(63, 73);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(100, 20);
            this.cbBaudRate.TabIndex = 6;
            // 
            // cbStop
            // 
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(63, 107);
            this.cbStop.Margin = new System.Windows.Forms.Padding(2);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(100, 20);
            this.cbStop.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "校验位：";
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(272, 73);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(100, 20);
            this.cbDataBits.TabIndex = 10;
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(272, 107);
            this.cbParity.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(100, 20);
            this.cbParity.TabIndex = 11;
            // 
            // gpbSend
            // 
            this.gpbSend.Controls.Add(this.rbSendStr);
            this.gpbSend.Controls.Add(this.rbSend16);
            this.gpbSend.Location = new System.Drawing.Point(16, 141);
            this.gpbSend.Margin = new System.Windows.Forms.Padding(2);
            this.gpbSend.Name = "gpbSend";
            this.gpbSend.Padding = new System.Windows.Forms.Padding(2);
            this.gpbSend.Size = new System.Drawing.Size(136, 41);
            this.gpbSend.TabIndex = 12;
            this.gpbSend.TabStop = false;
            this.gpbSend.Text = "发送数据格式";
            // 
            // rbSendStr
            // 
            this.rbSendStr.AutoSize = true;
            this.rbSendStr.Location = new System.Drawing.Point(76, 21);
            this.rbSendStr.Margin = new System.Windows.Forms.Padding(2);
            this.rbSendStr.Name = "rbSendStr";
            this.rbSendStr.Size = new System.Drawing.Size(59, 16);
            this.rbSendStr.TabIndex = 1;
            this.rbSendStr.TabStop = true;
            this.rbSendStr.Text = "字符串";
            this.rbSendStr.UseVisualStyleBackColor = true;
            // 
            // rbSend16
            // 
            this.rbSend16.AutoSize = true;
            this.rbSend16.Location = new System.Drawing.Point(6, 21);
            this.rbSend16.Margin = new System.Windows.Forms.Padding(2);
            this.rbSend16.Name = "rbSend16";
            this.rbSend16.Size = new System.Drawing.Size(59, 16);
            this.rbSend16.TabIndex = 0;
            this.rbSend16.TabStop = true;
            this.rbSend16.Text = "16进制";
            this.rbSend16.UseVisualStyleBackColor = true;
            this.rbSend16.CheckedChanged += new System.EventHandler(this.rbSend16_CheckedChanged);
            // 
            // gpbReceive
            // 
            this.gpbReceive.Controls.Add(this.rbRcvStr);
            this.gpbReceive.Controls.Add(this.rbRcv16);
            this.gpbReceive.Location = new System.Drawing.Point(184, 141);
            this.gpbReceive.Margin = new System.Windows.Forms.Padding(2);
            this.gpbReceive.Name = "gpbReceive";
            this.gpbReceive.Padding = new System.Windows.Forms.Padding(2);
            this.gpbReceive.Size = new System.Drawing.Size(136, 41);
            this.gpbReceive.TabIndex = 13;
            this.gpbReceive.TabStop = false;
            this.gpbReceive.Text = "接收数据格式";
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.Location = new System.Drawing.Point(76, 21);
            this.rbRcvStr.Margin = new System.Windows.Forms.Padding(2);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(59, 16);
            this.rbRcvStr.TabIndex = 1;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符串";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            // 
            // rbRcv16
            // 
            this.rbRcv16.AutoSize = true;
            this.rbRcv16.Location = new System.Drawing.Point(6, 21);
            this.rbRcv16.Margin = new System.Windows.Forms.Padding(2);
            this.rbRcv16.Name = "rbRcv16";
            this.rbRcv16.Size = new System.Drawing.Size(59, 16);
            this.rbRcv16.TabIndex = 0;
            this.rbRcv16.TabStop = true;
            this.rbRcv16.Text = "16进制";
            this.rbRcv16.UseVisualStyleBackColor = true;
            // 
            // cbTimeSend
            // 
            this.cbTimeSend.AutoSize = true;
            this.cbTimeSend.Location = new System.Drawing.Point(16, 201);
            this.cbTimeSend.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeSend.Name = "cbTimeSend";
            this.cbTimeSend.Size = new System.Drawing.Size(96, 16);
            this.cbTimeSend.TabIndex = 14;
            this.cbTimeSend.Text = "定时发送数据";
            this.cbTimeSend.UseVisualStyleBackColor = true;
            this.cbTimeSend.CheckedChanged += new System.EventHandler(this.cbTimeSend_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "时间间隔：";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(248, 199);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(76, 21);
            this.txtSecond.TabIndex = 16;
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecond_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "发送数据：";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(15, 245);
            this.txtSend.Margin = new System.Windows.Forms.Padding(2);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSend.Size = new System.Drawing.Size(373, 87);
            this.txtSend.TabIndex = 19;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_Save);
            this.groupBox3.Controls.Add(this.txtRcv);
            this.groupBox3.Location = new System.Drawing.Point(409, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(361, 388);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收方";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 7F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.Location = new System.Drawing.Point(36, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 10);
            this.label13.TabIndex = 4;
            this.label13.Text = "（不用写.txt等后缀）";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "保存文件名：";
            // 
            // txt_Save
            // 
            this.txt_Save.Location = new System.Drawing.Point(26, 338);
            this.txt_Save.Name = "txt_Save";
            this.txt_Save.Size = new System.Drawing.Size(133, 21);
            this.txt_Save.TabIndex = 1;
            this.txt_Save.TextChanged += new System.EventHandler(this.txt_Save_TextChanged);
            // 
            // txtRcv
            // 
            this.txtRcv.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRcv.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtRcv.Location = new System.Drawing.Point(0, 20);
            this.txtRcv.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcv.Name = "txtRcv";
            this.txtRcv.Size = new System.Drawing.Size(361, 285);
            this.txtRcv.TabIndex = 0;
            this.txtRcv.Text = "";
            this.txtRcv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRcv_MouseClick);
            this.txtRcv.TextChanged += new System.EventHandler(this.txtRcv_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(583, 416);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 24);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "清空接收框";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(676, 416);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 24);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(321, 381);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(68, 24);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Press);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSpNum,
            this.tsBaudRate,
            this.tsDataBits,
            this.tsStopBits,
            this.tsParity});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tsSpNum
            // 
            this.tsSpNum.Name = "tsSpNum";
            this.tsSpNum.Size = new System.Drawing.Size(0, 17);
            // 
            // tsBaudRate
            // 
            this.tsBaudRate.Name = "tsBaudRate";
            this.tsBaudRate.Size = new System.Drawing.Size(0, 17);
            // 
            // tsDataBits
            // 
            this.tsDataBits.Name = "tsDataBits";
            this.tsDataBits.Size = new System.Drawing.Size(0, 17);
            // 
            // tsStopBits
            // 
            this.tsStopBits.Name = "tsStopBits";
            this.tsStopBits.Size = new System.Drawing.Size(0, 17);
            // 
            // tsParity
            // 
            this.tsParity.Name = "tsParity";
            this.tsParity.Size = new System.Drawing.Size(0, 17);
            // 
            // timeSend
            // 
            this.timeSend.Tick += new System.EventHandler(this.timeSend_Tick);
            // 
            // cbSendHex
            // 
            this.cbSendHex.AutoSize = true;
            this.cbSendHex.Location = new System.Drawing.Point(15, 336);
            this.cbSendHex.Margin = new System.Windows.Forms.Padding(2);
            this.cbSendHex.Name = "cbSendHex";
            this.cbSendHex.Size = new System.Drawing.Size(144, 16);
            this.cbSendHex.TabIndex = 25;
            this.cbSendHex.Text = "显示此字符串的16进制";
            this.cbSendHex.UseVisualStyleBackColor = true;
            this.cbSendHex.CheckedChanged += new System.EventHandler(this.cbSendHex_CheckedChanged);
            // 
            // txtStrTo16
            // 
            this.txtStrTo16.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStrTo16.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtStrTo16.Location = new System.Drawing.Point(16, 356);
            this.txtStrTo16.Margin = new System.Windows.Forms.Padding(2);
            this.txtStrTo16.Name = "txtStrTo16";
            this.txtStrTo16.ReadOnly = true;
            this.txtStrTo16.Size = new System.Drawing.Size(373, 21);
            this.txtStrTo16.TabIndex = 26;
            // 
            // btnSendCRC
            // 
            this.btnSendCRC.Location = new System.Drawing.Point(15, 381);
            this.btnSendCRC.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendCRC.Name = "btnSendCRC";
            this.btnSendCRC.Size = new System.Drawing.Size(108, 24);
            this.btnSendCRC.TabIndex = 27;
            this.btnSendCRC.Text = "添加CRC校验发送";
            this.btnSendCRC.UseVisualStyleBackColor = true;
            this.btnSendCRC.Click += new System.EventHandler(this.btnSendCRC_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10F);
            this.label9.Location = new System.Drawing.Point(619, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 14);
            this.label9.TabIndex = 28;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "读取已有文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 8F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(105, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 11);
            this.label10.TabIndex = 30;
            this.label10.Text = "（默认为demo_try.txt）";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 31;
            this.button2.Text = "清空发送框";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 7F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(291, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 10);
            this.label11.TabIndex = 32;
            this.label11.Text = "（快捷键为Enter键）";
            // 
            // send_num
            // 
            this.send_num.AutoSize = true;
            this.send_num.Font = new System.Drawing.Font("宋体", 10F);
            this.send_num.Location = new System.Drawing.Point(17, 422);
            this.send_num.Name = "send_num";
            this.send_num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.send_num.Size = new System.Drawing.Size(119, 14);
            this.send_num.TabIndex = 33;
            this.send_num.Text = "已发送字节数 0个";
            this.send_num.Click += new System.EventHandler(this.label14_Click);
            // 
            // Rcvnum
            // 
            this.Rcvnum.AutoSize = true;
            this.Rcvnum.Font = new System.Drawing.Font("宋体", 10F);
            this.Rcvnum.Location = new System.Drawing.Point(257, 422);
            this.Rcvnum.Name = "Rcvnum";
            this.Rcvnum.Size = new System.Drawing.Size(119, 14);
            this.Rcvnum.TabIndex = 34;
            this.Rcvnum.Text = "已接收字节数 0个";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 22);
            this.button4.TabIndex = 35;
            this.button4.Text = "清零";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(382, 419);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 22);
            this.button5.TabIndex = 36;
            this.button5.Text = "清零";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ActiveLinkColor = System.Drawing.Color.PeachPuff;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton1.Text = "便捷软件：";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton2.Text = "记事本";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton3.Text = "计算器";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "当前时间：";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "00：00：00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(792, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Rcvnum);
            this.Controls.Add(this.send_num);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSendCRC);
            this.Controls.Add(this.txtStrTo16);
            this.Controls.Add(this.cbSendHex);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTimeSend);
            this.Controls.Add(this.gpbReceive);
            this.Controls.Add(this.gpbSend);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStop);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.cbSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "三丫串口助手1.0 （QQ:272597062） (E-mail:272597062@qq.com)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbSend.ResumeLayout(false);
            this.gpbSend.PerformLayout();
            this.gpbReceive.ResumeLayout(false);
            this.gpbReceive.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.GroupBox gpbSend;
        private System.Windows.Forms.RadioButton rbSendStr;
        private System.Windows.Forms.RadioButton rbSend16;
        private System.Windows.Forms.GroupBox gpbReceive;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcv16;
        private System.Windows.Forms.CheckBox cbTimeSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsSpNum;
        private System.Windows.Forms.ToolStripStatusLabel tsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel tsDataBits;
        private System.Windows.Forms.ToolStripStatusLabel tsStopBits;
        private System.Windows.Forms.ToolStripStatusLabel tsParity;
        //private System.Windows.Forms.ToolStripStatusLabel tsSend_num;
        //private System.Windows.Forms.ToolStripStatusLabel tsRcv_num;
        private System.Windows.Forms.Timer timeSend;
        private System.Windows.Forms.RichTextBox txtRcv;
        private System.Windows.Forms.CheckBox cbSendHex;
        private System.Windows.Forms.TextBox txtStrTo16;
        private System.Windows.Forms.Button btnSendCRC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Save;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label send_num;
        private System.Windows.Forms.Label Rcvnum;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

