namespace KDC_Client
{
    partial class SessionKeyClient
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EncryptedOutgoingMessageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutgoingMessageBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DecryptedIncommingMessageBox = new System.Windows.Forms.TextBox();
            this.EncryptedIncommingMessageBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EncryptedOutgoingMessageBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OutgoingMessageBox);
            this.groupBox2.Location = new System.Drawing.Point(45, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 163);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outgoing Messages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time Left Before Session Expires";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(303, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(158, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "0 : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Encrypted Outgoing Message";
            // 
            // EncryptedOutgoingMessageBox
            // 
            this.EncryptedOutgoingMessageBox.Location = new System.Drawing.Point(173, 81);
            this.EncryptedOutgoingMessageBox.Name = "EncryptedOutgoingMessageBox";
            this.EncryptedOutgoingMessageBox.ReadOnly = true;
            this.EncryptedOutgoingMessageBox.Size = new System.Drawing.Size(367, 20);
            this.EncryptedOutgoingMessageBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Outgoing Message";
            // 
            // OutgoingMessageBox
            // 
            this.OutgoingMessageBox.Location = new System.Drawing.Point(173, 45);
            this.OutgoingMessageBox.Name = "OutgoingMessageBox";
            this.OutgoingMessageBox.Size = new System.Drawing.Size(367, 20);
            this.OutgoingMessageBox.TabIndex = 0;
            this.OutgoingMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutgoingMessageBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DecryptedIncommingMessageBox);
            this.groupBox1.Controls.Add(this.EncryptedIncommingMessageBox);
            this.groupBox1.Location = new System.Drawing.Point(47, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 320);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incomming Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decrypted Incomming Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encrypted Incomming Message";
            // 
            // DecryptedIncommingMessageBox
            // 
            this.DecryptedIncommingMessageBox.Location = new System.Drawing.Point(321, 41);
            this.DecryptedIncommingMessageBox.Multiline = true;
            this.DecryptedIncommingMessageBox.Name = "DecryptedIncommingMessageBox";
            this.DecryptedIncommingMessageBox.ReadOnly = true;
            this.DecryptedIncommingMessageBox.Size = new System.Drawing.Size(234, 246);
            this.DecryptedIncommingMessageBox.TabIndex = 2;
            // 
            // EncryptedIncommingMessageBox
            // 
            this.EncryptedIncommingMessageBox.Location = new System.Drawing.Point(36, 41);
            this.EncryptedIncommingMessageBox.Multiline = true;
            this.EncryptedIncommingMessageBox.Name = "EncryptedIncommingMessageBox";
            this.EncryptedIncommingMessageBox.ReadOnly = true;
            this.EncryptedIncommingMessageBox.Size = new System.Drawing.Size(234, 246);
            this.EncryptedIncommingMessageBox.TabIndex = 1;
            // 
            // SessionKeyClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SessionKeyClient";
            this.Text = "Session Key Message Exchange";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SessionKeyClient_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SessionKeyClient_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EncryptedOutgoingMessageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutgoingMessageBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DecryptedIncommingMessageBox;
        private System.Windows.Forms.TextBox EncryptedIncommingMessageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
    }
}