namespace KDC_Client
{
    partial class ClientConnect
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
            this.ConfigureClient = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.connecttokdc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GenerateIV = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RC2Button = new System.Windows.Forms.RadioButton();
            this.RijndaelButton = new System.Windows.Forms.RadioButton();
            this.TDESButton = new System.Windows.Forms.RadioButton();
            this.DESButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EncryptUsingPublic = new System.Windows.Forms.Button();
            this.EncryptUsingPrivate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigureClient
            // 
            this.ConfigureClient.Location = new System.Drawing.Point(379, 27);
            this.ConfigureClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfigureClient.Name = "ConfigureClient";
            this.ConfigureClient.Size = new System.Drawing.Size(98, 26);
            this.ConfigureClient.TabIndex = 0;
            this.ConfigureClient.Text = "Connect";
            this.ConfigureClient.UseVisualStyleBackColor = true;
            this.ConfigureClient.Click += new System.EventHandler(this.ConfigureClient_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "172.16.5.237";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address Of Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ConfigureClient);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(72, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(541, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2 : Connect To Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(611, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Follow The Following Steps Given Below For Session Key Exchange";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connecttokdc);
            this.groupBox2.Location = new System.Drawing.Point(72, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(541, 76);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1 : Get Public Key Of Client";
            // 
            // connecttokdc
            // 
            this.connecttokdc.Location = new System.Drawing.Point(119, 31);
            this.connecttokdc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connecttokdc.Name = "connecttokdc";
            this.connecttokdc.Size = new System.Drawing.Size(265, 26);
            this.connecttokdc.TabIndex = 0;
            this.connecttokdc.Text = "Connect To KDC To Get Key Of Client";
            this.connecttokdc.UseVisualStyleBackColor = true;
            this.connecttokdc.Click += new System.EventHandler(this.connecttokdc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GenerateIV);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(72, 224);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(541, 135);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3 : Generation Of Session Key";
            // 
            // GenerateIV
            // 
            this.GenerateIV.Location = new System.Drawing.Point(352, 41);
            this.GenerateIV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.GenerateIV.Name = "GenerateIV";
            this.GenerateIV.Size = new System.Drawing.Size(125, 61);
            this.GenerateIV.TabIndex = 6;
            this.GenerateIV.Text = "Generate IV And Key";
            this.GenerateIV.UseVisualStyleBackColor = true;
            this.GenerateIV.Click += new System.EventHandler(this.GenerateIV_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RC2Button);
            this.groupBox4.Controls.Add(this.RijndaelButton);
            this.groupBox4.Controls.Add(this.TDESButton);
            this.groupBox4.Controls.Add(this.DESButton);
            this.groupBox4.Location = new System.Drawing.Point(49, 41);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox4.Size = new System.Drawing.Size(272, 61);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Symmetric Algorithms";
            // 
            // RC2Button
            // 
            this.RC2Button.AutoSize = true;
            this.RC2Button.Location = new System.Drawing.Point(219, 30);
            this.RC2Button.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RC2Button.Name = "RC2Button";
            this.RC2Button.Size = new System.Drawing.Size(47, 17);
            this.RC2Button.TabIndex = 3;
            this.RC2Button.Text = "RC2";
            this.RC2Button.UseVisualStyleBackColor = true;
            // 
            // RijndaelButton
            // 
            this.RijndaelButton.AutoSize = true;
            this.RijndaelButton.Location = new System.Drawing.Point(151, 30);
            this.RijndaelButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RijndaelButton.Name = "RijndaelButton";
            this.RijndaelButton.Size = new System.Drawing.Size(64, 17);
            this.RijndaelButton.TabIndex = 2;
            this.RijndaelButton.Text = "Rijndael";
            this.RijndaelButton.UseVisualStyleBackColor = true;
            // 
            // TDESButton
            // 
            this.TDESButton.AutoSize = true;
            this.TDESButton.Location = new System.Drawing.Point(70, 30);
            this.TDESButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TDESButton.Name = "TDESButton";
            this.TDESButton.Size = new System.Drawing.Size(77, 17);
            this.TDESButton.TabIndex = 1;
            this.TDESButton.Text = "Triple DES";
            this.TDESButton.UseVisualStyleBackColor = true;
            // 
            // DESButton
            // 
            this.DESButton.AutoSize = true;
            this.DESButton.Checked = true;
            this.DESButton.Location = new System.Drawing.Point(18, 30);
            this.DESButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DESButton.Name = "DESButton";
            this.DESButton.Size = new System.Drawing.Size(48, 17);
            this.DESButton.TabIndex = 0;
            this.DESButton.TabStop = true;
            this.DESButton.Text = "DES";
            this.DESButton.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EncryptUsingPublic);
            this.groupBox5.Controls.Add(this.EncryptUsingPrivate);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(72, 367);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(541, 76);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 4 : Encrypt Session Key And IV";
            // 
            // EncryptUsingPublic
            // 
            this.EncryptUsingPublic.Location = new System.Drawing.Point(38, 32);
            this.EncryptUsingPublic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptUsingPublic.Name = "EncryptUsingPublic";
            this.EncryptUsingPublic.Size = new System.Drawing.Size(226, 26);
            this.EncryptUsingPublic.TabIndex = 1;
            this.EncryptUsingPublic.Text = "Encrypt Data Using Client Public Key";
            this.EncryptUsingPublic.UseVisualStyleBackColor = true;
            this.EncryptUsingPublic.Click += new System.EventHandler(this.EncryptUsingPublic_Click);
            // 
            // EncryptUsingPrivate
            // 
            this.EncryptUsingPrivate.Enabled = false;
            this.EncryptUsingPrivate.Location = new System.Drawing.Point(270, 32);
            this.EncryptUsingPrivate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptUsingPrivate.Name = "EncryptUsingPrivate";
            this.EncryptUsingPrivate.Size = new System.Drawing.Size(254, 26);
            this.EncryptUsingPrivate.TabIndex = 0;
            this.EncryptUsingPrivate.Text = "Encrypt Data Using Own Private Key";
            this.EncryptUsingPrivate.UseVisualStyleBackColor = true;
            this.EncryptUsingPrivate.Click += new System.EventHandler(this.EncryptUsingPrivate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(72, 451);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(541, 76);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step 5 : Send Data To Client";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "Send Data To Client And Exchange Message";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 633);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 6;
            // 
            // ClientConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 571);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientConnect";
            this.Text = "Session Key Exchange";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientConnect_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientConnect_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfigureClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connecttokdc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RC2Button;
        private System.Windows.Forms.RadioButton RijndaelButton;
        private System.Windows.Forms.RadioButton TDESButton;
        private System.Windows.Forms.RadioButton DESButton;
        private System.Windows.Forms.Button GenerateIV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button EncryptUsingPublic;
        private System.Windows.Forms.Button EncryptUsingPrivate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}