namespace DESAnalysis
{
    partial class DESAnalysis
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CipherTextBox = new System.Windows.Forms.RichTextBox();
            this.Encryptbutton = new System.Windows.Forms.Button();
            this.KeyTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PlainTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuppliedCiphertextBox = new System.Windows.Forms.RichTextBox();
            this.CryptaButton = new System.Windows.Forms.Button();
            this.ObtainedKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RecoveredPlaintextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CipherTextBox);
            this.groupBox7.Location = new System.Drawing.Point(40, 163);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(501, 89);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CipherText As Text String";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(16, 19);
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.ReadOnly = true;
            this.CipherTextBox.Size = new System.Drawing.Size(465, 56);
            this.CipherTextBox.TabIndex = 24;
            this.CipherTextBox.Text = "";
            // 
            // Encryptbutton
            // 
            this.Encryptbutton.Location = new System.Drawing.Point(561, 87);
            this.Encryptbutton.Name = "Encryptbutton";
            this.Encryptbutton.Size = new System.Drawing.Size(99, 56);
            this.Encryptbutton.TabIndex = 32;
            this.Encryptbutton.Text = "Encrypt";
            this.Encryptbutton.UseVisualStyleBackColor = true;
            this.Encryptbutton.Click += new System.EventHandler(this.Encryptbutton_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(220, 19);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(271, 29);
            this.KeyTextBox.TabIndex = 30;
            this.KeyTextBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PlainTextBox);
            this.groupBox4.Location = new System.Drawing.Point(40, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 89);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plaintext";
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Location = new System.Drawing.Point(16, 19);
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.Size = new System.Drawing.Size(465, 56);
            this.PlainTextBox.TabIndex = 20;
            this.PlainTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.Encryptbutton);
            this.groupBox1.Controls.Add(this.KeyTextBox);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 269);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DES Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "(Please Enter Numeric Key Only)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SuppliedCiphertextBox);
            this.groupBox2.Location = new System.Drawing.Point(40, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 89);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplied Ciphertext";
            // 
            // SuppliedCiphertextBox
            // 
            this.SuppliedCiphertextBox.Location = new System.Drawing.Point(16, 19);
            this.SuppliedCiphertextBox.Name = "SuppliedCiphertextBox";
            this.SuppliedCiphertextBox.ReadOnly = true;
            this.SuppliedCiphertextBox.Size = new System.Drawing.Size(465, 56);
            this.SuppliedCiphertextBox.TabIndex = 20;
            this.SuppliedCiphertextBox.Text = "";
            // 
            // CryptaButton
            // 
            this.CryptaButton.Location = new System.Drawing.Point(558, 49);
            this.CryptaButton.Name = "CryptaButton";
            this.CryptaButton.Size = new System.Drawing.Size(99, 56);
            this.CryptaButton.TabIndex = 34;
            this.CryptaButton.Text = "Start Crypta-Analysis";
            this.CryptaButton.UseVisualStyleBackColor = true;
            this.CryptaButton.Click += new System.EventHandler(this.CryptaButton_Click);
            // 
            // ObtainedKeyTextBox
            // 
            this.ObtainedKeyTextBox.Location = new System.Drawing.Point(220, 131);
            this.ObtainedKeyTextBox.Name = "ObtainedKeyTextBox";
            this.ObtainedKeyTextBox.ReadOnly = true;
            this.ObtainedKeyTextBox.Size = new System.Drawing.Size(271, 29);
            this.ObtainedKeyTextBox.TabIndex = 34;
            this.ObtainedKeyTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Obtained Key";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(558, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(99, 29);
            this.progressBar1.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ObtainedKeyTextBox);
            this.groupBox3.Controls.Add(this.CryptaButton);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 269);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crypta-Analysis";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RecoveredPlaintextBox);
            this.groupBox5.Location = new System.Drawing.Point(40, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(501, 89);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recovered Plaintext";
            // 
            // RecoveredPlaintextBox
            // 
            this.RecoveredPlaintextBox.Location = new System.Drawing.Point(16, 19);
            this.RecoveredPlaintextBox.Name = "RecoveredPlaintextBox";
            this.RecoveredPlaintextBox.ReadOnly = true;
            this.RecoveredPlaintextBox.Size = new System.Drawing.Size(465, 56);
            this.RecoveredPlaintextBox.TabIndex = 20;
            this.RecoveredPlaintextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // DESAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 577);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "DESAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES Crypta-Analysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DESAnalysis_FormClosed);
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox CipherTextBox;
        private System.Windows.Forms.Button Encryptbutton;
        private System.Windows.Forms.RichTextBox KeyTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox PlainTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox RecoveredPlaintextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ObtainedKeyTextBox;
        private System.Windows.Forms.Button CryptaButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox SuppliedCiphertextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;

    }
}

