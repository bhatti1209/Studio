namespace KDC_Client
{
    partial class ClientServer
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
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ExtractDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExchangemessageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(24, 28);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(466, 190);
            this.displayTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server Console";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(231, 210);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 210);
            this.textBox2.TabIndex = 9;
            // 
            // ExtractDataButton
            // 
            this.ExtractDataButton.Location = new System.Drawing.Point(499, 78);
            this.ExtractDataButton.Name = "ExtractDataButton";
            this.ExtractDataButton.Size = new System.Drawing.Size(126, 82);
            this.ExtractDataButton.TabIndex = 10;
            this.ExtractDataButton.Text = "Extract Session Key";
            this.ExtractDataButton.UseVisualStyleBackColor = true;
            this.ExtractDataButton.Click += new System.EventHandler(this.ExtractDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Extracted Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Decrypted Data";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(100, 256);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(126, 23);
            this.DecryptButton.TabIndex = 13;
            this.DecryptButton.Text = "Decrypt Data";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExtractDataButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.displayTextBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 244);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExchangemessageButton);
            this.groupBox2.Controls.Add(this.DecryptButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(23, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 287);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption Of Data";
            // 
            // ExchangemessageButton
            // 
            this.ExchangemessageButton.Location = new System.Drawing.Point(399, 256);
            this.ExchangemessageButton.Name = "ExchangemessageButton";
            this.ExchangemessageButton.Size = new System.Drawing.Size(126, 23);
            this.ExchangemessageButton.TabIndex = 14;
            this.ExchangemessageButton.Text = "Exchange Message";
            this.ExchangemessageButton.UseVisualStyleBackColor = true;
            this.ExchangemessageButton.Click += new System.EventHandler(this.ExchangemessageButton_Click);
            // 
            // ClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientServer";
            this.Text = "Client Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientServer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientServer_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ExtractDataButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ExchangemessageButton;
    }
}