namespace Serial_port_assistant
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port_cbb = new System.Windows.Forms.ComboBox();
            this.receive_rteb = new System.Windows.Forms.RichTextBox();
            this.send_rtxb = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.DTR_chb = new System.Windows.Forms.CheckBox();
            this.RTS_chb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopbit_cbb = new System.Windows.Forms.ComboBox();
            this.databit_cbb = new System.Windows.Forms.ComboBox();
            this.check_cbb = new System.Windows.Forms.ComboBox();
            this.baud_cbb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shiliu_chb = new System.Windows.Forms.CheckBox();
            this.autoclear_chb = new System.Windows.Forms.CheckBox();
            this.receiveflie_txb = new System.Windows.Forms.TextBox();
            this.xzlj_btn = new System.Windows.Forms.Button();
            this.bcsj_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autotimer_teb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendshiliu_chb = new System.Windows.Forms.CheckBox();
            this.autosend_chb = new System.Windows.Forms.CheckBox();
            this.sendflie_teb = new System.Windows.Forms.TextBox();
            this.openflie_btn = new System.Windows.Forms.Button();
            this.sendflie_btn = new System.Windows.Forms.Button();
            this.clearsend_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.state_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sencount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.recivecount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataZhen_chb = new System.Windows.Forms.CheckBox();
            this.data_txb = new System.Windows.Forms.RichTextBox();
            this.data4_txb = new System.Windows.Forms.TextBox();
            this.data3_txb = new System.Windows.Forms.TextBox();
            this.data2_txb = new System.Windows.Forms.TextBox();
            this.data1_txb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // port_cbb
            // 
            this.port_cbb.FormattingEnabled = true;
            this.port_cbb.Location = new System.Drawing.Point(117, 33);
            this.port_cbb.Name = "port_cbb";
            this.port_cbb.Size = new System.Drawing.Size(101, 23);
            this.port_cbb.TabIndex = 0;
            // 
            // receive_rteb
            // 
            this.receive_rteb.Location = new System.Drawing.Point(16, 21);
            this.receive_rteb.Name = "receive_rteb";
            this.receive_rteb.Size = new System.Drawing.Size(313, 270);
            this.receive_rteb.TabIndex = 2;
            this.receive_rteb.Text = "";
            this.receive_rteb.TextChanged += new System.EventHandler(this.receive_rteb_TextChanged);
            // 
            // send_rtxb
            // 
            this.send_rtxb.Location = new System.Drawing.Point(6, 23);
            this.send_rtxb.Name = "send_rtxb";
            this.send_rtxb.Size = new System.Drawing.Size(313, 371);
            this.send_rtxb.TabIndex = 3;
            this.send_rtxb.Text = "";
            this.send_rtxb.TextChanged += new System.EventHandler(this.send_rtxb_TextChanged);
            this.send_rtxb.Leave += new System.EventHandler(this.send_rtxb_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.DTR_chb);
            this.groupBox1.Controls.Add(this.RTS_chb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stopbit_cbb);
            this.groupBox1.Controls.Add(this.databit_cbb);
            this.groupBox1.Controls.Add(this.check_cbb);
            this.groupBox1.Controls.Add(this.baud_cbb);
            this.groupBox1.Controls.Add(this.port_cbb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(117, 192);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(101, 32);
            this.open_btn.TabIndex = 12;
            this.open_btn.Text = "打开串口";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // DTR_chb
            // 
            this.DTR_chb.AutoSize = true;
            this.DTR_chb.Location = new System.Drawing.Point(10, 205);
            this.DTR_chb.Name = "DTR_chb";
            this.DTR_chb.Size = new System.Drawing.Size(53, 19);
            this.DTR_chb.TabIndex = 11;
            this.DTR_chb.Text = "DTR";
            this.DTR_chb.UseVisualStyleBackColor = true;
            this.DTR_chb.CheckedChanged += new System.EventHandler(this.DTR_chb_CheckedChanged);
            // 
            // RTS_chb
            // 
            this.RTS_chb.AutoSize = true;
            this.RTS_chb.Location = new System.Drawing.Point(10, 180);
            this.RTS_chb.Name = "RTS_chb";
            this.RTS_chb.Size = new System.Drawing.Size(53, 19);
            this.RTS_chb.TabIndex = 10;
            this.RTS_chb.Text = "RTS";
            this.RTS_chb.UseVisualStyleBackColor = true;
            this.RTS_chb.CheckedChanged += new System.EventHandler(this.RTS_chb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "端口号";
            // 
            // stopbit_cbb
            // 
            this.stopbit_cbb.FormattingEnabled = true;
            this.stopbit_cbb.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbit_cbb.Location = new System.Drawing.Point(117, 149);
            this.stopbit_cbb.Name = "stopbit_cbb";
            this.stopbit_cbb.Size = new System.Drawing.Size(101, 23);
            this.stopbit_cbb.TabIndex = 4;
            // 
            // databit_cbb
            // 
            this.databit_cbb.FormattingEnabled = true;
            this.databit_cbb.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databit_cbb.Location = new System.Drawing.Point(117, 120);
            this.databit_cbb.Name = "databit_cbb";
            this.databit_cbb.Size = new System.Drawing.Size(101, 23);
            this.databit_cbb.TabIndex = 3;
            // 
            // check_cbb
            // 
            this.check_cbb.FormattingEnabled = true;
            this.check_cbb.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.check_cbb.Location = new System.Drawing.Point(117, 91);
            this.check_cbb.Name = "check_cbb";
            this.check_cbb.Size = new System.Drawing.Size(101, 23);
            this.check_cbb.TabIndex = 2;
            // 
            // baud_cbb
            // 
            this.baud_cbb.FormattingEnabled = true;
            this.baud_cbb.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.baud_cbb.Location = new System.Drawing.Point(117, 62);
            this.baud_cbb.Name = "baud_cbb";
            this.baud_cbb.Size = new System.Drawing.Size(101, 23);
            this.baud_cbb.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shiliu_chb);
            this.groupBox2.Controls.Add(this.autoclear_chb);
            this.groupBox2.Controls.Add(this.receiveflie_txb);
            this.groupBox2.Controls.Add(this.xzlj_btn);
            this.groupBox2.Controls.Add(this.bcsj_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 193);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // shiliu_chb
            // 
            this.shiliu_chb.AutoSize = true;
            this.shiliu_chb.Location = new System.Drawing.Point(6, 88);
            this.shiliu_chb.Name = "shiliu_chb";
            this.shiliu_chb.Size = new System.Drawing.Size(89, 19);
            this.shiliu_chb.TabIndex = 19;
            this.shiliu_chb.Text = "十六进制";
            this.shiliu_chb.UseVisualStyleBackColor = true;
            this.shiliu_chb.CheckedChanged += new System.EventHandler(this.shiliu_chb_CheckedChanged);
            // 
            // autoclear_chb
            // 
            this.autoclear_chb.AutoSize = true;
            this.autoclear_chb.Location = new System.Drawing.Point(6, 48);
            this.autoclear_chb.Name = "autoclear_chb";
            this.autoclear_chb.Size = new System.Drawing.Size(89, 19);
            this.autoclear_chb.TabIndex = 18;
            this.autoclear_chb.Text = "自动清空";
            this.autoclear_chb.UseVisualStyleBackColor = true;
            this.autoclear_chb.CheckedChanged += new System.EventHandler(this.autoclear_chb_CheckedChanged);
            // 
            // receiveflie_txb
            // 
            this.receiveflie_txb.Location = new System.Drawing.Point(6, 154);
            this.receiveflie_txb.Name = "receiveflie_txb";
            this.receiveflie_txb.Size = new System.Drawing.Size(212, 25);
            this.receiveflie_txb.TabIndex = 17;
            // 
            // xzlj_btn
            // 
            this.xzlj_btn.Location = new System.Drawing.Point(0, 124);
            this.xzlj_btn.Name = "xzlj_btn";
            this.xzlj_btn.Size = new System.Drawing.Size(105, 24);
            this.xzlj_btn.TabIndex = 16;
            this.xzlj_btn.Text = "选择路径";
            this.xzlj_btn.UseVisualStyleBackColor = true;
            this.xzlj_btn.Click += new System.EventHandler(this.xzlj_btn_Click);
            // 
            // bcsj_btn
            // 
            this.bcsj_btn.Location = new System.Drawing.Point(117, 116);
            this.bcsj_btn.Name = "bcsj_btn";
            this.bcsj_btn.Size = new System.Drawing.Size(101, 32);
            this.bcsj_btn.TabIndex = 15;
            this.bcsj_btn.Text = "保存数据";
            this.bcsj_btn.UseVisualStyleBackColor = true;
            this.bcsj_btn.Click += new System.EventHandler(this.bcsj_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(117, 78);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(101, 32);
            this.stop_btn.TabIndex = 14;
            this.stop_btn.Text = "暂停";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(117, 40);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(101, 32);
            this.clear_btn.TabIndex = 13;
            this.clear_btn.Text = "手动清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autotimer_teb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.sendshiliu_chb);
            this.groupBox3.Controls.Add(this.autosend_chb);
            this.groupBox3.Controls.Add(this.sendflie_teb);
            this.groupBox3.Controls.Add(this.openflie_btn);
            this.groupBox3.Controls.Add(this.sendflie_btn);
            this.groupBox3.Controls.Add(this.clearsend_btn);
            this.groupBox3.Controls.Add(this.send_btn);
            this.groupBox3.Location = new System.Drawing.Point(12, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 223);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // autotimer_teb
            // 
            this.autotimer_teb.Location = new System.Drawing.Point(155, 189);
            this.autotimer_teb.Name = "autotimer_teb";
            this.autotimer_teb.Size = new System.Drawing.Size(82, 25);
            this.autotimer_teb.TabIndex = 28;
            this.autotimer_teb.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "自动发送周期（ms）";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sendshiliu_chb
            // 
            this.sendshiliu_chb.AutoSize = true;
            this.sendshiliu_chb.Location = new System.Drawing.Point(16, 87);
            this.sendshiliu_chb.Name = "sendshiliu_chb";
            this.sendshiliu_chb.Size = new System.Drawing.Size(89, 19);
            this.sendshiliu_chb.TabIndex = 26;
            this.sendshiliu_chb.Text = "十六进制";
            this.sendshiliu_chb.UseVisualStyleBackColor = true;
            this.sendshiliu_chb.CheckedChanged += new System.EventHandler(this.sendshiliu_chb_CheckedChanged);
            // 
            // autosend_chb
            // 
            this.autosend_chb.AutoSize = true;
            this.autosend_chb.Location = new System.Drawing.Point(16, 47);
            this.autosend_chb.Name = "autosend_chb";
            this.autosend_chb.Size = new System.Drawing.Size(89, 19);
            this.autosend_chb.TabIndex = 25;
            this.autosend_chb.Text = "自动发送";
            this.autosend_chb.UseVisualStyleBackColor = true;
            this.autosend_chb.CheckedChanged += new System.EventHandler(this.autosend_chb_CheckedChanged);
            // 
            // sendflie_teb
            // 
            this.sendflie_teb.Location = new System.Drawing.Point(16, 153);
            this.sendflie_teb.Name = "sendflie_teb";
            this.sendflie_teb.Size = new System.Drawing.Size(227, 25);
            this.sendflie_teb.TabIndex = 24;
            // 
            // openflie_btn
            // 
            this.openflie_btn.Location = new System.Drawing.Point(10, 123);
            this.openflie_btn.Name = "openflie_btn";
            this.openflie_btn.Size = new System.Drawing.Size(105, 24);
            this.openflie_btn.TabIndex = 23;
            this.openflie_btn.Text = "打开文件";
            this.openflie_btn.UseVisualStyleBackColor = true;
            this.openflie_btn.Click += new System.EventHandler(this.openflie_btn_Click);
            // 
            // sendflie_btn
            // 
            this.sendflie_btn.Location = new System.Drawing.Point(127, 115);
            this.sendflie_btn.Name = "sendflie_btn";
            this.sendflie_btn.Size = new System.Drawing.Size(121, 32);
            this.sendflie_btn.TabIndex = 22;
            this.sendflie_btn.Text = "发送文件";
            this.sendflie_btn.UseVisualStyleBackColor = true;
            this.sendflie_btn.Click += new System.EventHandler(this.sendflie_btn_Click);
            // 
            // clearsend_btn
            // 
            this.clearsend_btn.Location = new System.Drawing.Point(127, 77);
            this.clearsend_btn.Name = "clearsend_btn";
            this.clearsend_btn.Size = new System.Drawing.Size(121, 32);
            this.clearsend_btn.TabIndex = 21;
            this.clearsend_btn.Text = "清空发送";
            this.clearsend_btn.UseVisualStyleBackColor = true;
            this.clearsend_btn.Click += new System.EventHandler(this.clearsend_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(127, 39);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(121, 32);
            this.send_btn.TabIndex = 20;
            this.send_btn.Text = "手动发送";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.send_rtxb);
            this.groupBox4.Location = new System.Drawing.Point(271, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 382);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.receive_rteb);
            this.groupBox5.Location = new System.Drawing.Point(255, 400);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 281);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "接收区";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.state_tssl,
            this.toolStripStatusLabel3,
            this.sencount_tssl,
            this.toolStripStatusLabel5,
            this.recivecount_tssl,
            this.clearcount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // state_tssl
            // 
            this.state_tssl.AutoSize = false;
            this.state_tssl.Name = "state_tssl";
            this.state_tssl.Size = new System.Drawing.Size(200, 20);
            this.state_tssl.Text = "初始化正常！";
            this.state_tssl.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // sencount_tssl
            // 
            this.sencount_tssl.AutoSize = false;
            this.sencount_tssl.Name = "sencount_tssl";
            this.sencount_tssl.Size = new System.Drawing.Size(50, 20);
            this.sencount_tssl.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // recivecount_tssl
            // 
            this.recivecount_tssl.AutoSize = false;
            this.recivecount_tssl.Name = "recivecount_tssl";
            this.recivecount_tssl.Size = new System.Drawing.Size(50, 20);
            this.recivecount_tssl.Text = "0";
            // 
            // clearcount
            // 
            this.clearcount.Name = "clearcount";
            this.clearcount.Size = new System.Drawing.Size(69, 20);
            this.clearcount.Text = "清空计数";
            this.clearcount.Click += new System.EventHandler(this.clearcount_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.dataZhen_chb);
            this.groupBox6.Controls.Add(this.data_txb);
            this.groupBox6.Controls.Add(this.data4_txb);
            this.groupBox6.Controls.Add(this.data3_txb);
            this.groupBox6.Controls.Add(this.data2_txb);
            this.groupBox6.Controls.Add(this.data1_txb);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(601, 35);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 460);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "指令解析";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(19, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "7F+长度+数据+CRC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "格式：";
            // 
            // dataZhen_chb
            // 
            this.dataZhen_chb.AutoSize = true;
            this.dataZhen_chb.Location = new System.Drawing.Point(12, 340);
            this.dataZhen_chb.Name = "dataZhen_chb";
            this.dataZhen_chb.Size = new System.Drawing.Size(134, 19);
            this.dataZhen_chb.TabIndex = 10;
            this.dataZhen_chb.Text = "启动数据帧接收";
            this.dataZhen_chb.UseVisualStyleBackColor = true;
            // 
            // data_txb
            // 
            this.data_txb.Location = new System.Drawing.Point(11, 209);
            this.data_txb.Name = "data_txb";
            this.data_txb.Size = new System.Drawing.Size(149, 121);
            this.data_txb.TabIndex = 9;
            this.data_txb.Text = "";
            // 
            // data4_txb
            // 
            this.data4_txb.Location = new System.Drawing.Point(57, 141);
            this.data4_txb.Name = "data4_txb";
            this.data4_txb.Size = new System.Drawing.Size(104, 25);
            this.data4_txb.TabIndex = 8;
            // 
            // data3_txb
            // 
            this.data3_txb.Location = new System.Drawing.Point(57, 107);
            this.data3_txb.Name = "data3_txb";
            this.data3_txb.Size = new System.Drawing.Size(104, 25);
            this.data3_txb.TabIndex = 7;
            // 
            // data2_txb
            // 
            this.data2_txb.Location = new System.Drawing.Point(57, 73);
            this.data2_txb.Name = "data2_txb";
            this.data2_txb.Size = new System.Drawing.Size(104, 25);
            this.data2_txb.TabIndex = 6;
            // 
            // data1_txb
            // 
            this.data1_txb.Location = new System.Drawing.Point(57, 37);
            this.data1_txb.Name = "data1_txb";
            this.data1_txb.Size = new System.Drawing.Size(104, 25);
            this.data1_txb.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "数据帧";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "数据4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "数据3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "数据2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "数据1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 730);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox port_cbb;
        private System.Windows.Forms.RichTextBox receive_rteb;
        private System.Windows.Forms.RichTextBox send_rtxb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stopbit_cbb;
        private System.Windows.Forms.ComboBox databit_cbb;
        private System.Windows.Forms.ComboBox check_cbb;
        private System.Windows.Forms.ComboBox baud_cbb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox DTR_chb;
        private System.Windows.Forms.CheckBox RTS_chb;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.CheckBox shiliu_chb;
        private System.Windows.Forms.CheckBox autoclear_chb;
        private System.Windows.Forms.TextBox receiveflie_txb;
        private System.Windows.Forms.Button xzlj_btn;
        private System.Windows.Forms.Button bcsj_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox sendshiliu_chb;
        private System.Windows.Forms.CheckBox autosend_chb;
        private System.Windows.Forms.TextBox sendflie_teb;
        private System.Windows.Forms.Button openflie_btn;
        private System.Windows.Forms.Button sendflie_btn;
        private System.Windows.Forms.Button clearsend_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox autotimer_teb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel state_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sencount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel recivecount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel clearcount;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox data4_txb;
        private System.Windows.Forms.TextBox data3_txb;
        private System.Windows.Forms.TextBox data2_txb;
        private System.Windows.Forms.TextBox data1_txb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox dataZhen_chb;
        private System.Windows.Forms.RichTextBox data_txb;
        private System.Windows.Forms.Timer timer2;
    }
}

