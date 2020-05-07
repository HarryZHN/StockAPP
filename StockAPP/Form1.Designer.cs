namespace StockAPP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.txtWord1 = new System.Windows.Forms.RichTextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.txtReceive1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPList = new System.Windows.Forms.ListBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.txtWord2 = new System.Windows.Forms.RichTextBox();
            this.txtReceive2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.txtWord1);
            this.tp1.Controls.Add(this.btnSend1);
            this.tp1.Controls.Add(this.txtReceive1);
            this.tp1.Controls.Add(this.panel1);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(971, 607);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "服务端";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // txtWord1
            // 
            this.txtWord1.Location = new System.Drawing.Point(317, 493);
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(565, 96);
            this.txtWord1.TabIndex = 6;
            this.txtWord1.Text = "";
            // 
            // btnSend1
            // 
            this.btnSend1.Enabled = false;
            this.btnSend1.Location = new System.Drawing.Point(888, 493);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(75, 96);
            this.btnSend1.TabIndex = 5;
            this.btnSend1.Text = "发送";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceive1
            // 
            this.txtReceive1.Location = new System.Drawing.Point(317, 6);
            this.txtReceive1.Name = "txtReceive1";
            this.txtReceive1.ReadOnly = true;
            this.txtReceive1.Size = new System.Drawing.Size(646, 481);
            this.txtReceive1.TabIndex = 3;
            this.txtReceive1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IPList);
            this.panel1.Controls.Add(this.btnListen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 601);
            this.panel1.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(144, 108);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 34);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "断开连接";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(95, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(142, 25);
            this.txtIP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "本地IP:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(95, 57);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(142, 25);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8885";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口号：";
            // 
            // IPList
            // 
            this.IPList.FormattingEnabled = true;
            this.IPList.ItemHeight = 15;
            this.IPList.Location = new System.Drawing.Point(21, 168);
            this.IPList.Name = "IPList";
            this.IPList.Size = new System.Drawing.Size(240, 409);
            this.IPList.TabIndex = 2;
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnListen.Location = new System.Drawing.Point(21, 108);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(117, 34);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "开启监听";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.btnSend2);
            this.tp2.Controls.Add(this.txtWord2);
            this.tp2.Controls.Add(this.txtReceive2);
            this.tp2.Controls.Add(this.panel2);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(971, 607);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "客户端";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // btnSend2
            // 
            this.btnSend2.Enabled = false;
            this.btnSend2.Location = new System.Drawing.Point(894, 482);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(69, 101);
            this.btnSend2.TabIndex = 7;
            this.btnSend2.Text = "发送";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // txtWord2
            // 
            this.txtWord2.Location = new System.Drawing.Point(317, 482);
            this.txtWord2.Name = "txtWord2";
            this.txtWord2.Size = new System.Drawing.Size(570, 101);
            this.txtWord2.TabIndex = 6;
            this.txtWord2.Text = "";
            // 
            // txtReceive2
            // 
            this.txtReceive2.Location = new System.Drawing.Point(316, 6);
            this.txtReceive2.Name = "txtReceive2";
            this.txtReceive2.ReadOnly = true;
            this.txtReceive2.Size = new System.Drawing.Size(647, 469);
            this.txtReceive2.TabIndex = 5;
            this.txtReceive2.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Port);
            this.panel2.Controls.Add(this.IP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 601);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "端口号:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "远程IP:";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(94, 86);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(138, 25);
            this.Port.TabIndex = 2;
            this.Port.Text = "8885";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(94, 33);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(138, 25);
            this.IP.TabIndex = 1;
            this.IP.Text = "10.16.201.156";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(132, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "断开连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 636);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.RichTextBox txtReceive1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox IPList;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtWord1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.RichTextBox txtWord2;
        private System.Windows.Forms.RichTextBox txtReceive2;
        private System.Windows.Forms.Button button2;
    }
}

