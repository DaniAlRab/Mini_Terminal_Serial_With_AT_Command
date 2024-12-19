namespace Serial_Catur1._0
{
    partial class Form1
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
            System.Windows.Forms.GroupBox groupBox3;
            this.CboxCOMPORT = new System.Windows.Forms.ComboBox();
            this.CboxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.CboxDATABITS = new System.Windows.Forms.ComboBox();
            this.CboxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.CboxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOPEN = new System.Windows.Forms.Button();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSENDDATA = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboxCOMPORT
            // 
            this.CboxCOMPORT.FormattingEnabled = true;
            this.CboxCOMPORT.Location = new System.Drawing.Point(119, 51);
            this.CboxCOMPORT.Name = "CboxCOMPORT";
            this.CboxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.CboxCOMPORT.TabIndex = 0;
            this.CboxCOMPORT.Text = "COM3";
            // 
            // CboxBAUDRATE
            // 
            this.CboxBAUDRATE.FormattingEnabled = true;
            this.CboxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.CboxBAUDRATE.Location = new System.Drawing.Point(119, 91);
            this.CboxBAUDRATE.Name = "CboxBAUDRATE";
            this.CboxBAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.CboxBAUDRATE.TabIndex = 1;
            this.CboxBAUDRATE.Text = "115200";
            // 
            // CboxDATABITS
            // 
            this.CboxDATABITS.FormattingEnabled = true;
            this.CboxDATABITS.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CboxDATABITS.Location = new System.Drawing.Point(119, 129);
            this.CboxDATABITS.Name = "CboxDATABITS";
            this.CboxDATABITS.Size = new System.Drawing.Size(121, 21);
            this.CboxDATABITS.TabIndex = 2;
            this.CboxDATABITS.Text = "8";
            // 
            // CboxPARITYBITS
            // 
            this.CboxPARITYBITS.FormattingEnabled = true;
            this.CboxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CboxPARITYBITS.Location = new System.Drawing.Point(119, 205);
            this.CboxPARITYBITS.Name = "CboxPARITYBITS";
            this.CboxPARITYBITS.Size = new System.Drawing.Size(121, 21);
            this.CboxPARITYBITS.TabIndex = 3;
            this.CboxPARITYBITS.Text = "None";
            // 
            // CboxSTOPBITS
            // 
            this.CboxSTOPBITS.FormattingEnabled = true;
            this.CboxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CboxSTOPBITS.Location = new System.Drawing.Point(119, 166);
            this.CboxSTOPBITS.Name = "CboxSTOPBITS";
            this.CboxSTOPBITS.Size = new System.Drawing.Size(121, 21);
            this.CboxSTOPBITS.TabIndex = 4;
            this.CboxSTOPBITS.Text = "One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CboxCOMPORT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CboxBAUDRATE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboxDATABITS);
            this.groupBox1.Controls.Add(this.CboxPARITYBITS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CboxSTOPBITS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 264);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(43, 293);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(75, 23);
            this.btnOPEN.TabIndex = 11;
            this.btnOPEN.Text = "OPEN";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(152, 293);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(75, 23);
            this.btnCLOSE.TabIndex = 12;
            this.btnCLOSE.Text = "CLOSE";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 340);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // btnSENDDATA
            // 
            this.btnSENDDATA.Location = new System.Drawing.Point(34, 125);
            this.btnSENDDATA.Name = "btnSENDDATA";
            this.btnSENDDATA.Size = new System.Drawing.Size(75, 28);
            this.btnSENDDATA.TabIndex = 14;
            this.btnSENDDATA.Text = "115200";
            this.btnSENDDATA.UseVisualStyleBackColor = true;
            this.btnSENDDATA.Click += new System.EventHandler(this.btnSENDDATA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "9600";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxDataIN);
            this.groupBox2.Location = new System.Drawing.Point(558, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 264);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminal";
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(24, 26);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tBoxDataIN.Size = new System.Drawing.Size(211, 199);
            this.tBoxDataIN.TabIndex = 0;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.button1);
            groupBox3.Controls.Add(this.btnSENDDATA);
            groupBox3.Location = new System.Drawing.Point(376, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(155, 252);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Send (AT+IPR=\"\")";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 411);
            this.Controls.Add(groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.btnOPEN);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mini Terminal Serial - With AT Command - 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxCOMPORT;
        private System.Windows.Forms.ComboBox CboxBAUDRATE;
        private System.Windows.Forms.ComboBox CboxDATABITS;
        private System.Windows.Forms.ComboBox CboxPARITYBITS;
        private System.Windows.Forms.ComboBox CboxSTOPBITS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOPEN;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSENDDATA;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

