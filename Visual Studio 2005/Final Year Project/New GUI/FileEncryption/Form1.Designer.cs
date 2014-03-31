namespace FileEncryption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RC2Button = new System.Windows.Forms.RadioButton();
            this.RijndaelButton = new System.Windows.Forms.RadioButton();
            this.TDESButton = new System.Windows.Forms.RadioButton();
            this.DESButton = new System.Windows.Forms.RadioButton();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.origianlfilebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Encryptbutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.encryptionfilebox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.decryptoriginalbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.decryptencryptedbox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.decryptpassbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RC2Button2 = new System.Windows.Forms.RadioButton();
            this.RijndaelButton2 = new System.Windows.Forms.RadioButton();
            this.TDESButton2 = new System.Windows.Forms.RadioButton();
            this.DESButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RC2Button);
            this.groupBox1.Controls.Add(this.RijndaelButton);
            this.groupBox1.Controls.Add(this.TDESButton);
            this.groupBox1.Controls.Add(this.DESButton);
            this.groupBox1.Location = new System.Drawing.Point(96, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Symmetric Algorithms";
            // 
            // RC2Button
            // 
            this.RC2Button.AutoSize = true;
            this.RC2Button.Location = new System.Drawing.Point(326, 32);
            this.RC2Button.Name = "RC2Button";
            this.RC2Button.Size = new System.Drawing.Size(47, 17);
            this.RC2Button.TabIndex = 3;
            this.RC2Button.Text = "RC2";
            this.RC2Button.UseVisualStyleBackColor = true;
            // 
            // RijndaelButton
            // 
            this.RijndaelButton.AutoSize = true;
            this.RijndaelButton.Location = new System.Drawing.Point(241, 32);
            this.RijndaelButton.Name = "RijndaelButton";
            this.RijndaelButton.Size = new System.Drawing.Size(64, 17);
            this.RijndaelButton.TabIndex = 2;
            this.RijndaelButton.Text = "Rijndael";
            this.RijndaelButton.UseVisualStyleBackColor = true;
            // 
            // TDESButton
            // 
            this.TDESButton.AutoSize = true;
            this.TDESButton.Location = new System.Drawing.Point(127, 32);
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
            this.DESButton.Location = new System.Drawing.Point(57, 32);
            this.DESButton.Name = "DESButton";
            this.DESButton.Size = new System.Drawing.Size(48, 17);
            this.DESButton.TabIndex = 0;
            this.DESButton.TabStop = true;
            this.DESButton.Text = "DES";
            this.DESButton.UseVisualStyleBackColor = true;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(197, 29);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(197, 20);
            this.KeyTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter The Encryption Password :";
            // 
            // origianlfilebox
            // 
            this.origianlfilebox.Location = new System.Drawing.Point(98, 30);
            this.origianlfilebox.Name = "origianlfilebox";
            this.origianlfilebox.Size = new System.Drawing.Size(256, 20);
            this.origianlfilebox.TabIndex = 8;
            this.origianlfilebox.Text = "--Choose File--";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Original File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Encrypted File";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 430);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Encryptbutton);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Encryptbutton
            // 
            this.Encryptbutton.Location = new System.Drawing.Point(246, 331);
            this.Encryptbutton.Name = "Encryptbutton";
            this.Encryptbutton.Size = new System.Drawing.Size(121, 39);
            this.Encryptbutton.TabIndex = 15;
            this.Encryptbutton.Text = "Encrypt File";
            this.Encryptbutton.UseVisualStyleBackColor = true;
            this.Encryptbutton.Click += new System.EventHandler(this.Encryptbutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.encryptionfilebox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.origianlfilebox);
            this.groupBox3.Location = new System.Drawing.Point(96, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 111);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Browse Files";
            // 
            // encryptionfilebox
            // 
            this.encryptionfilebox.Location = new System.Drawing.Point(98, 65);
            this.encryptionfilebox.Name = "encryptionfilebox";
            this.encryptionfilebox.Size = new System.Drawing.Size(275, 20);
            this.encryptionfilebox.TabIndex = 12;
            this.encryptionfilebox.Text = "--Output In The Same Directory As Of The Selected File--";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KeyTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(96, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Encryption Password";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "Decrypt File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.decryptoriginalbox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.decryptencryptedbox);
            this.groupBox4.Location = new System.Drawing.Point(96, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 111);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Browse Files";
            // 
            // decryptoriginalbox
            // 
            this.decryptoriginalbox.Location = new System.Drawing.Point(98, 65);
            this.decryptoriginalbox.Name = "decryptoriginalbox";
            this.decryptoriginalbox.Size = new System.Drawing.Size(275, 20);
            this.decryptoriginalbox.TabIndex = 12;
            this.decryptoriginalbox.Text = "--Output In The Same Directory As Of The Selected File--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Encrypted File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Original File";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(362, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "..";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // decryptencryptedbox
            // 
            this.decryptencryptedbox.Location = new System.Drawing.Point(98, 30);
            this.decryptencryptedbox.Name = "decryptencryptedbox";
            this.decryptencryptedbox.Size = new System.Drawing.Size(256, 20);
            this.decryptencryptedbox.TabIndex = 8;
            this.decryptencryptedbox.Text = "--Choose File--";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.decryptpassbox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(96, 119);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 65);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Enter Encryption Password";
            // 
            // decryptpassbox
            // 
            this.decryptpassbox.Location = new System.Drawing.Point(197, 29);
            this.decryptpassbox.Name = "decryptpassbox";
            this.decryptpassbox.Size = new System.Drawing.Size(197, 20);
            this.decryptpassbox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Enter The Encryption Password :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RC2Button2);
            this.groupBox6.Controls.Add(this.RijndaelButton2);
            this.groupBox6.Controls.Add(this.TDESButton2);
            this.groupBox6.Controls.Add(this.DESButton2);
            this.groupBox6.Location = new System.Drawing.Point(96, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(428, 70);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Choose Symmetric Algorithms";
            // 
            // RC2Button2
            // 
            this.RC2Button2.AutoSize = true;
            this.RC2Button2.Location = new System.Drawing.Point(326, 32);
            this.RC2Button2.Name = "RC2Button2";
            this.RC2Button2.Size = new System.Drawing.Size(47, 17);
            this.RC2Button2.TabIndex = 3;
            this.RC2Button2.Text = "RC2";
            this.RC2Button2.UseVisualStyleBackColor = true;
            // 
            // RijndaelButton2
            // 
            this.RijndaelButton2.AutoSize = true;
            this.RijndaelButton2.Location = new System.Drawing.Point(241, 32);
            this.RijndaelButton2.Name = "RijndaelButton2";
            this.RijndaelButton2.Size = new System.Drawing.Size(64, 17);
            this.RijndaelButton2.TabIndex = 2;
            this.RijndaelButton2.Text = "Rijndael";
            this.RijndaelButton2.UseVisualStyleBackColor = true;
            // 
            // TDESButton2
            // 
            this.TDESButton2.AutoSize = true;
            this.TDESButton2.Location = new System.Drawing.Point(127, 32);
            this.TDESButton2.Name = "TDESButton2";
            this.TDESButton2.Size = new System.Drawing.Size(77, 17);
            this.TDESButton2.TabIndex = 1;
            this.TDESButton2.Text = "Triple DES";
            this.TDESButton2.UseVisualStyleBackColor = true;
            // 
            // DESButton2
            // 
            this.DESButton2.AutoSize = true;
            this.DESButton2.Checked = true;
            this.DESButton2.Location = new System.Drawing.Point(57, 32);
            this.DESButton2.Name = "DESButton2";
            this.DESButton2.Size = new System.Drawing.Size(48, 17);
            this.DESButton2.TabIndex = 0;
            this.DESButton2.TabStop = true;
            this.DESButton2.Text = "DES";
            this.DESButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 497);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Encryption";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RC2Button;
        private System.Windows.Forms.RadioButton RijndaelButton;
        private System.Windows.Forms.RadioButton TDESButton;
        private System.Windows.Forms.RadioButton DESButton;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox origianlfilebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox encryptionfilebox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Encryptbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox decryptoriginalbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox decryptencryptedbox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox decryptpassbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton RC2Button2;
        private System.Windows.Forms.RadioButton RijndaelButton2;
        private System.Windows.Forms.RadioButton TDESButton2;
        private System.Windows.Forms.RadioButton DESButton2;
    }
}

