namespace TextEncryption
{
    partial class TextEncrypt
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
            this.DESButton = new System.Windows.Forms.RadioButton();
            this.TDESButton = new System.Windows.Forms.RadioButton();
            this.RijndaelButton = new System.Windows.Forms.RadioButton();
            this.RC2Button = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PKCS7Button = new System.Windows.Forms.RadioButton();
            this.ZerosButton = new System.Windows.Forms.RadioButton();
            this.NoneButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ECBButton = new System.Windows.Forms.RadioButton();
            this.CBCButton = new System.Windows.Forms.RadioButton();
            this.CFBButton = new System.Windows.Forms.RadioButton();
            this.OFBButton = new System.Windows.Forms.RadioButton();
            this.CTSButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Keybutton = new System.Windows.Forms.Button();
            this.KeyTextBox = new System.Windows.Forms.RichTextBox();
            this.PlainTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Encryptbutton = new System.Windows.Forms.Button();
            this.DecryptTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Decryptbutton = new System.Windows.Forms.Button();
            this.CipherTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Symmetric = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Asymmetric = new System.Windows.Forms.TabPage();
            this.RSADecryptButton = new System.Windows.Forms.Button();
            this.RSAEncryptbutton = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.RSADecrypttextbox = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.RSACiphertextbox = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.RSAPlaintextbox = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pvaluebox = new System.Windows.Forms.RichTextBox();
            this.newparameters = new System.Windows.Forms.Button();
            this.DigitalSignatures = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.DSAVerifyButton = new System.Windows.Forms.Button();
            this.DSASignButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DSAEncryptedMessageDigest = new System.Windows.Forms.RichTextBox();
            this.DSAHashMessageDigest = new System.Windows.Forms.RichTextBox();
            this.DSAMessageBox = new System.Windows.Forms.RichTextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.RSAVerifyButton = new System.Windows.Forms.Button();
            this.RSASignButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RSAEncryptedMessageDigest = new System.Windows.Forms.RichTextBox();
            this.RSAHashMessageDigest = new System.Windows.Forms.RichTextBox();
            this.RSAMessageBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Symmetric.SuspendLayout();
            this.Asymmetric.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.DigitalSignatures.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // DESButton
            // 
            this.DESButton.AutoSize = true;
            this.DESButton.Checked = true;
            this.DESButton.Location = new System.Drawing.Point(36, 28);
            this.DESButton.Name = "DESButton";
            this.DESButton.Size = new System.Drawing.Size(48, 17);
            this.DESButton.TabIndex = 0;
            this.DESButton.TabStop = true;
            this.DESButton.Text = "DES";
            this.DESButton.UseVisualStyleBackColor = true;
            this.DESButton.CheckedChanged += new System.EventHandler(this.DESButton_CheckedChanged);
            // 
            // TDESButton
            // 
            this.TDESButton.AutoSize = true;
            this.TDESButton.Location = new System.Drawing.Point(35, 53);
            this.TDESButton.Name = "TDESButton";
            this.TDESButton.Size = new System.Drawing.Size(77, 17);
            this.TDESButton.TabIndex = 1;
            this.TDESButton.Text = "Triple DES";
            this.TDESButton.UseVisualStyleBackColor = true;
            this.TDESButton.CheckedChanged += new System.EventHandler(this.TDESButton_CheckedChanged);
            // 
            // RijndaelButton
            // 
            this.RijndaelButton.AutoSize = true;
            this.RijndaelButton.Location = new System.Drawing.Point(35, 86);
            this.RijndaelButton.Name = "RijndaelButton";
            this.RijndaelButton.Size = new System.Drawing.Size(64, 17);
            this.RijndaelButton.TabIndex = 2;
            this.RijndaelButton.Text = "Rijndael";
            this.RijndaelButton.UseVisualStyleBackColor = true;
            this.RijndaelButton.CheckedChanged += new System.EventHandler(this.RijndaelButton_CheckedChanged);
            // 
            // RC2Button
            // 
            this.RC2Button.AutoSize = true;
            this.RC2Button.Location = new System.Drawing.Point(36, 118);
            this.RC2Button.Name = "RC2Button";
            this.RC2Button.Size = new System.Drawing.Size(47, 17);
            this.RC2Button.TabIndex = 3;
            this.RC2Button.Text = "RC2";
            this.RC2Button.UseVisualStyleBackColor = true;
            this.RC2Button.CheckedChanged += new System.EventHandler(this.RC2Button_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RC2Button);
            this.groupBox1.Controls.Add(this.RijndaelButton);
            this.groupBox1.Controls.Add(this.TDESButton);
            this.groupBox1.Controls.Add(this.DESButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symmetric Algorithms";
            // 
            // PKCS7Button
            // 
            this.PKCS7Button.AutoSize = true;
            this.PKCS7Button.Checked = true;
            this.PKCS7Button.Location = new System.Drawing.Point(12, 19);
            this.PKCS7Button.Name = "PKCS7Button";
            this.PKCS7Button.Size = new System.Drawing.Size(60, 17);
            this.PKCS7Button.TabIndex = 5;
            this.PKCS7Button.TabStop = true;
            this.PKCS7Button.Text = "PKCS7";
            this.PKCS7Button.UseVisualStyleBackColor = true;
            // 
            // ZerosButton
            // 
            this.ZerosButton.AutoSize = true;
            this.ZerosButton.Location = new System.Drawing.Point(78, 19);
            this.ZerosButton.Name = "ZerosButton";
            this.ZerosButton.Size = new System.Drawing.Size(53, 17);
            this.ZerosButton.TabIndex = 6;
            this.ZerosButton.Text = "Zeros";
            this.ZerosButton.UseVisualStyleBackColor = true;
            // 
            // NoneButton
            // 
            this.NoneButton.AutoSize = true;
            this.NoneButton.Enabled = false;
            this.NoneButton.Location = new System.Drawing.Point(137, 19);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(52, 17);
            this.NoneButton.TabIndex = 7;
            this.NoneButton.Text = "None";
            this.NoneButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoneButton);
            this.groupBox2.Controls.Add(this.ZerosButton);
            this.groupBox2.Controls.Add(this.PKCS7Button);
            this.groupBox2.Location = new System.Drawing.Point(453, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 45);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Padding";
            // 
            // ECBButton
            // 
            this.ECBButton.AutoSize = true;
            this.ECBButton.Checked = true;
            this.ECBButton.Location = new System.Drawing.Point(10, 17);
            this.ECBButton.Name = "ECBButton";
            this.ECBButton.Size = new System.Drawing.Size(47, 17);
            this.ECBButton.TabIndex = 9;
            this.ECBButton.TabStop = true;
            this.ECBButton.Text = "ECB";
            this.ECBButton.UseVisualStyleBackColor = true;
            // 
            // CBCButton
            // 
            this.CBCButton.AutoSize = true;
            this.CBCButton.Location = new System.Drawing.Point(63, 17);
            this.CBCButton.Name = "CBCButton";
            this.CBCButton.Size = new System.Drawing.Size(47, 17);
            this.CBCButton.TabIndex = 10;
            this.CBCButton.Text = "CBC";
            this.CBCButton.UseVisualStyleBackColor = true;
            // 
            // CFBButton
            // 
            this.CFBButton.AutoSize = true;
            this.CFBButton.Location = new System.Drawing.Point(116, 17);
            this.CFBButton.Name = "CFBButton";
            this.CFBButton.Size = new System.Drawing.Size(46, 17);
            this.CFBButton.TabIndex = 11;
            this.CFBButton.Text = "CFB";
            this.CFBButton.UseVisualStyleBackColor = true;
            // 
            // OFBButton
            // 
            this.OFBButton.AutoSize = true;
            this.OFBButton.Enabled = false;
            this.OFBButton.Location = new System.Drawing.Point(168, 17);
            this.OFBButton.Name = "OFBButton";
            this.OFBButton.Size = new System.Drawing.Size(47, 17);
            this.OFBButton.TabIndex = 12;
            this.OFBButton.Text = "OFB";
            this.OFBButton.UseVisualStyleBackColor = true;
            // 
            // CTSButton
            // 
            this.CTSButton.AutoSize = true;
            this.CTSButton.Enabled = false;
            this.CTSButton.Location = new System.Drawing.Point(221, 17);
            this.CTSButton.Name = "CTSButton";
            this.CTSButton.Size = new System.Drawing.Size(47, 17);
            this.CTSButton.TabIndex = 13;
            this.CTSButton.Text = "CTS";
            this.CTSButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CTSButton);
            this.groupBox3.Controls.Add(this.OFBButton);
            this.groupBox3.Controls.Add(this.CFBButton);
            this.groupBox3.Controls.Add(this.CBCButton);
            this.groupBox3.Controls.Add(this.ECBButton);
            this.groupBox3.Location = new System.Drawing.Point(162, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 45);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // Keybutton
            // 
            this.Keybutton.Location = new System.Drawing.Point(186, 80);
            this.Keybutton.Name = "Keybutton";
            this.Keybutton.Size = new System.Drawing.Size(138, 29);
            this.Keybutton.TabIndex = 15;
            this.Keybutton.Text = "Use User Key";
            this.Keybutton.UseVisualStyleBackColor = true;
            this.Keybutton.Click += new System.EventHandler(this.Keybutton_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(371, 80);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(271, 29);
            this.KeyTextBox.TabIndex = 18;
            this.KeyTextBox.Text = "";
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Location = new System.Drawing.Point(16, 19);
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.Size = new System.Drawing.Size(465, 56);
            this.PlainTextBox.TabIndex = 20;
            this.PlainTextBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.PlainTextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 110);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plaintext";
            // 
            // Encryptbutton
            // 
            this.Encryptbutton.Location = new System.Drawing.Point(555, 201);
            this.Encryptbutton.Name = "Encryptbutton";
            this.Encryptbutton.Size = new System.Drawing.Size(76, 56);
            this.Encryptbutton.TabIndex = 22;
            this.Encryptbutton.Text = "Encrypt";
            this.Encryptbutton.UseVisualStyleBackColor = true;
            this.Encryptbutton.Click += new System.EventHandler(this.Encryptbutton_Click);
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(16, 19);
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.ReadOnly = true;
            this.DecryptTextBox.Size = new System.Drawing.Size(465, 56);
            this.DecryptTextBox.TabIndex = 23;
            this.DecryptTextBox.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DecryptTextBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 429);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(501, 88);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recovered Plaintext";
            // 
            // Decryptbutton
            // 
            this.Decryptbutton.Enabled = false;
            this.Decryptbutton.Location = new System.Drawing.Point(555, 448);
            this.Decryptbutton.Name = "Decryptbutton";
            this.Decryptbutton.Size = new System.Drawing.Size(76, 56);
            this.Decryptbutton.TabIndex = 25;
            this.Decryptbutton.Text = "Decrypt";
            this.Decryptbutton.UseVisualStyleBackColor = true;
            this.Decryptbutton.Click += new System.EventHandler(this.Decryptbutton_Click);
            // 
            // CipherTextBox1
            // 
            this.CipherTextBox1.Location = new System.Drawing.Point(16, 19);
            this.CipherTextBox1.Name = "CipherTextBox1";
            this.CipherTextBox1.ReadOnly = true;
            this.CipherTextBox1.Size = new System.Drawing.Size(465, 56);
            this.CipherTextBox1.TabIndex = 24;
            this.CipherTextBox1.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.CipherTextBox1);
            this.groupBox7.Location = new System.Drawing.Point(6, 293);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(501, 110);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CipherText As Text String";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Symmetric);
            this.tabControl1.Controls.Add(this.Asymmetric);
            this.tabControl1.Controls.Add(this.DigitalSignatures);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 573);
            this.tabControl1.TabIndex = 29;
            // 
            // Symmetric
            // 
            this.Symmetric.Controls.Add(this.label1);
            this.Symmetric.Controls.Add(this.groupBox1);
            this.Symmetric.Controls.Add(this.groupBox7);
            this.Symmetric.Controls.Add(this.groupBox2);
            this.Symmetric.Controls.Add(this.groupBox3);
            this.Symmetric.Controls.Add(this.Decryptbutton);
            this.Symmetric.Controls.Add(this.Keybutton);
            this.Symmetric.Controls.Add(this.groupBox5);
            this.Symmetric.Controls.Add(this.Encryptbutton);
            this.Symmetric.Controls.Add(this.KeyTextBox);
            this.Symmetric.Controls.Add(this.groupBox4);
            this.Symmetric.Location = new System.Drawing.Point(4, 22);
            this.Symmetric.Name = "Symmetric";
            this.Symmetric.Padding = new System.Windows.Forms.Padding(3);
            this.Symmetric.Size = new System.Drawing.Size(664, 547);
            this.Symmetric.TabIndex = 0;
            this.Symmetric.Text = "Symmetric Algorithms";
            this.Symmetric.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "(Please Leave The Space Blank To Generate A Random Key)";
            // 
            // Asymmetric
            // 
            this.Asymmetric.Controls.Add(this.RSADecryptButton);
            this.Asymmetric.Controls.Add(this.RSAEncryptbutton);
            this.Asymmetric.Controls.Add(this.groupBox10);
            this.Asymmetric.Controls.Add(this.groupBox9);
            this.Asymmetric.Controls.Add(this.groupBox8);
            this.Asymmetric.Controls.Add(this.groupBox6);
            this.Asymmetric.Controls.Add(this.newparameters);
            this.Asymmetric.Location = new System.Drawing.Point(4, 22);
            this.Asymmetric.Name = "Asymmetric";
            this.Asymmetric.Padding = new System.Windows.Forms.Padding(3);
            this.Asymmetric.Size = new System.Drawing.Size(664, 547);
            this.Asymmetric.TabIndex = 1;
            this.Asymmetric.Text = "Asymmetric Algorithms";
            this.Asymmetric.UseVisualStyleBackColor = true;
            this.Asymmetric.Enter += new System.EventHandler(this.newparameters_Click);
            // 
            // RSADecryptButton
            // 
            this.RSADecryptButton.Enabled = false;
            this.RSADecryptButton.Location = new System.Drawing.Point(550, 484);
            this.RSADecryptButton.Name = "RSADecryptButton";
            this.RSADecryptButton.Size = new System.Drawing.Size(81, 46);
            this.RSADecryptButton.TabIndex = 12;
            this.RSADecryptButton.Text = "Decrypt";
            this.RSADecryptButton.UseVisualStyleBackColor = true;
            this.RSADecryptButton.Click += new System.EventHandler(this.RSADecryptButton_Click);
            // 
            // RSAEncryptbutton
            // 
            this.RSAEncryptbutton.Location = new System.Drawing.Point(550, 268);
            this.RSAEncryptbutton.Name = "RSAEncryptbutton";
            this.RSAEncryptbutton.Size = new System.Drawing.Size(81, 46);
            this.RSAEncryptbutton.TabIndex = 12;
            this.RSAEncryptbutton.Text = "Encrypt";
            this.RSAEncryptbutton.UseVisualStyleBackColor = true;
            this.RSAEncryptbutton.Click += new System.EventHandler(this.RSAEncryptbutton_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.RSADecrypttextbox);
            this.groupBox10.Location = new System.Drawing.Point(38, 461);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(496, 80);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Recovered Plaintext";
            // 
            // RSADecrypttextbox
            // 
            this.RSADecrypttextbox.Location = new System.Drawing.Point(36, 23);
            this.RSADecrypttextbox.Name = "RSADecrypttextbox";
            this.RSADecrypttextbox.ReadOnly = true;
            this.RSADecrypttextbox.Size = new System.Drawing.Size(438, 46);
            this.RSADecrypttextbox.TabIndex = 9;
            this.RSADecrypttextbox.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.RSACiphertextbox);
            this.groupBox9.Location = new System.Drawing.Point(38, 355);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(496, 100);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ciphertext As Text";
            // 
            // RSACiphertextbox
            // 
            this.RSACiphertextbox.Location = new System.Drawing.Point(36, 19);
            this.RSACiphertextbox.Name = "RSACiphertextbox";
            this.RSACiphertextbox.ReadOnly = true;
            this.RSACiphertextbox.Size = new System.Drawing.Size(438, 46);
            this.RSACiphertextbox.TabIndex = 12;
            this.RSACiphertextbox.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.RSAPlaintextbox);
            this.groupBox8.Location = new System.Drawing.Point(38, 249);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(496, 100);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Plaintext";
            // 
            // RSAPlaintextbox
            // 
            this.RSAPlaintextbox.Location = new System.Drawing.Point(36, 19);
            this.RSAPlaintextbox.Name = "RSAPlaintextbox";
            this.RSAPlaintextbox.Size = new System.Drawing.Size(438, 46);
            this.RSAPlaintextbox.TabIndex = 9;
            this.RSAPlaintextbox.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.linkLabel1);
            this.groupBox6.Controls.Add(this.pvaluebox);
            this.groupBox6.Location = new System.Drawing.Point(38, 40);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(593, 203);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Parameters Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(237, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View The XML File";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pvaluebox
            // 
            this.pvaluebox.Location = new System.Drawing.Point(23, 30);
            this.pvaluebox.Name = "pvaluebox";
            this.pvaluebox.Size = new System.Drawing.Size(542, 147);
            this.pvaluebox.TabIndex = 5;
            this.pvaluebox.Text = "";
            // 
            // newparameters
            // 
            this.newparameters.Location = new System.Drawing.Point(38, 6);
            this.newparameters.Name = "newparameters";
            this.newparameters.Size = new System.Drawing.Size(132, 28);
            this.newparameters.TabIndex = 0;
            this.newparameters.Text = "New Parameters";
            this.newparameters.UseVisualStyleBackColor = true;
            this.newparameters.Click += new System.EventHandler(this.newparameters_Click);
            // 
            // DigitalSignatures
            // 
            this.DigitalSignatures.Controls.Add(this.groupBox12);
            this.DigitalSignatures.Controls.Add(this.groupBox11);
            this.DigitalSignatures.Location = new System.Drawing.Point(4, 22);
            this.DigitalSignatures.Name = "DigitalSignatures";
            this.DigitalSignatures.Size = new System.Drawing.Size(664, 547);
            this.DigitalSignatures.TabIndex = 2;
            this.DigitalSignatures.Text = "Digital Signatures";
            this.DigitalSignatures.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.linkLabel3);
            this.groupBox12.Controls.Add(this.DSAVerifyButton);
            this.groupBox12.Controls.Add(this.DSASignButton);
            this.groupBox12.Controls.Add(this.label5);
            this.groupBox12.Controls.Add(this.label6);
            this.groupBox12.Controls.Add(this.label7);
            this.groupBox12.Controls.Add(this.DSAEncryptedMessageDigest);
            this.groupBox12.Controls.Add(this.DSAHashMessageDigest);
            this.groupBox12.Controls.Add(this.DSAMessageBox);
            this.groupBox12.Location = new System.Drawing.Point(24, 276);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(611, 256);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Using DSA";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(405, 217);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(115, 13);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "DSA Parameter Details";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // DSAVerifyButton
            // 
            this.DSAVerifyButton.Enabled = false;
            this.DSAVerifyButton.Location = new System.Drawing.Point(289, 207);
            this.DSAVerifyButton.Name = "DSAVerifyButton";
            this.DSAVerifyButton.Size = new System.Drawing.Size(75, 32);
            this.DSAVerifyButton.TabIndex = 7;
            this.DSAVerifyButton.Text = "Verify";
            this.DSAVerifyButton.UseVisualStyleBackColor = true;
            this.DSAVerifyButton.Click += new System.EventHandler(this.DSAVerifyButton_Click);
            // 
            // DSASignButton
            // 
            this.DSASignButton.Location = new System.Drawing.Point(154, 207);
            this.DSASignButton.Name = "DSASignButton";
            this.DSASignButton.Size = new System.Drawing.Size(75, 32);
            this.DSASignButton.TabIndex = 6;
            this.DSASignButton.Text = "Sign";
            this.DSASignButton.UseVisualStyleBackColor = true;
            this.DSASignButton.Click += new System.EventHandler(this.DSASignButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Digital Signature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hashed Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Message";
            // 
            // DSAEncryptedMessageDigest
            // 
            this.DSAEncryptedMessageDigest.Location = new System.Drawing.Point(135, 137);
            this.DSAEncryptedMessageDigest.Name = "DSAEncryptedMessageDigest";
            this.DSAEncryptedMessageDigest.ReadOnly = true;
            this.DSAEncryptedMessageDigest.Size = new System.Drawing.Size(413, 49);
            this.DSAEncryptedMessageDigest.TabIndex = 2;
            this.DSAEncryptedMessageDigest.Text = "";
            // 
            // DSAHashMessageDigest
            // 
            this.DSAHashMessageDigest.Location = new System.Drawing.Point(135, 78);
            this.DSAHashMessageDigest.Name = "DSAHashMessageDigest";
            this.DSAHashMessageDigest.ReadOnly = true;
            this.DSAHashMessageDigest.Size = new System.Drawing.Size(413, 49);
            this.DSAHashMessageDigest.TabIndex = 1;
            this.DSAHashMessageDigest.Text = "";
            // 
            // DSAMessageBox
            // 
            this.DSAMessageBox.Location = new System.Drawing.Point(135, 23);
            this.DSAMessageBox.Name = "DSAMessageBox";
            this.DSAMessageBox.Size = new System.Drawing.Size(413, 49);
            this.DSAMessageBox.TabIndex = 0;
            this.DSAMessageBox.Text = "";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.linkLabel2);
            this.groupBox11.Controls.Add(this.RSAVerifyButton);
            this.groupBox11.Controls.Add(this.RSASignButton);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.label2);
            this.groupBox11.Controls.Add(this.RSAEncryptedMessageDigest);
            this.groupBox11.Controls.Add(this.RSAHashMessageDigest);
            this.groupBox11.Controls.Add(this.RSAMessageBox);
            this.groupBox11.Location = new System.Drawing.Point(24, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(611, 242);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Using RSA";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(405, 205);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(115, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "RSA Parameter Details";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // RSAVerifyButton
            // 
            this.RSAVerifyButton.Enabled = false;
            this.RSAVerifyButton.Location = new System.Drawing.Point(289, 195);
            this.RSAVerifyButton.Name = "RSAVerifyButton";
            this.RSAVerifyButton.Size = new System.Drawing.Size(75, 32);
            this.RSAVerifyButton.TabIndex = 7;
            this.RSAVerifyButton.Text = "Verify";
            this.RSAVerifyButton.UseVisualStyleBackColor = true;
            this.RSAVerifyButton.Click += new System.EventHandler(this.RSAVerifyButton_Click);
            // 
            // RSASignButton
            // 
            this.RSASignButton.Location = new System.Drawing.Point(154, 195);
            this.RSASignButton.Name = "RSASignButton";
            this.RSASignButton.Size = new System.Drawing.Size(75, 32);
            this.RSASignButton.TabIndex = 6;
            this.RSASignButton.Text = "Sign";
            this.RSASignButton.UseVisualStyleBackColor = true;
            this.RSASignButton.Click += new System.EventHandler(this.RSASignButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Digital Signature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hashed Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // RSAEncryptedMessageDigest
            // 
            this.RSAEncryptedMessageDigest.Location = new System.Drawing.Point(135, 140);
            this.RSAEncryptedMessageDigest.Name = "RSAEncryptedMessageDigest";
            this.RSAEncryptedMessageDigest.ReadOnly = true;
            this.RSAEncryptedMessageDigest.Size = new System.Drawing.Size(413, 49);
            this.RSAEncryptedMessageDigest.TabIndex = 2;
            this.RSAEncryptedMessageDigest.Text = "";
            // 
            // RSAHashMessageDigest
            // 
            this.RSAHashMessageDigest.Location = new System.Drawing.Point(135, 85);
            this.RSAHashMessageDigest.Name = "RSAHashMessageDigest";
            this.RSAHashMessageDigest.ReadOnly = true;
            this.RSAHashMessageDigest.Size = new System.Drawing.Size(413, 49);
            this.RSAHashMessageDigest.TabIndex = 1;
            this.RSAHashMessageDigest.Text = "";
            // 
            // RSAMessageBox
            // 
            this.RSAMessageBox.Location = new System.Drawing.Point(135, 30);
            this.RSAMessageBox.Name = "RSAMessageBox";
            this.RSAMessageBox.Size = new System.Drawing.Size(413, 49);
            this.RSAMessageBox.TabIndex = 0;
            this.RSAMessageBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Open TextFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(157, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Save Encrypted Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Open File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(175, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Save Encrypted Message";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 577);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "TextEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encryption";
            this.Load += new System.EventHandler(this.TextEncrypt_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextEncrypt_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Symmetric.ResumeLayout(false);
            this.Symmetric.PerformLayout();
            this.Asymmetric.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.DigitalSignatures.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Symmetric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RC2Button;
        private System.Windows.Forms.RadioButton RijndaelButton;
        private System.Windows.Forms.RadioButton TDESButton;
        private System.Windows.Forms.RadioButton DESButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox CipherTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NoneButton;
        private System.Windows.Forms.RadioButton ZerosButton;
        private System.Windows.Forms.RadioButton PKCS7Button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton CTSButton;
        private System.Windows.Forms.RadioButton OFBButton;
        private System.Windows.Forms.RadioButton CFBButton;
        private System.Windows.Forms.RadioButton CBCButton;
        private System.Windows.Forms.RadioButton ECBButton;
        private System.Windows.Forms.Button Decryptbutton;
        private System.Windows.Forms.Button Keybutton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox DecryptTextBox;
        private System.Windows.Forms.Button Encryptbutton;
        private System.Windows.Forms.RichTextBox KeyTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox PlainTextBox;
        private System.Windows.Forms.TabPage Asymmetric;
        private System.Windows.Forms.Button RSADecryptButton;
        private System.Windows.Forms.Button RSAEncryptbutton;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RichTextBox RSADecrypttextbox;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox RSACiphertextbox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox RSAPlaintextbox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox pvaluebox;
        private System.Windows.Forms.Button newparameters;
        private System.Windows.Forms.TabPage DigitalSignatures;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button DSAVerifyButton;
        private System.Windows.Forms.Button DSASignButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox DSAEncryptedMessageDigest;
        private System.Windows.Forms.RichTextBox DSAHashMessageDigest;
        private System.Windows.Forms.RichTextBox DSAMessageBox;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button RSAVerifyButton;
        private System.Windows.Forms.Button RSASignButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RSAEncryptedMessageDigest;
        private System.Windows.Forms.RichTextBox RSAHashMessageDigest;
        private System.Windows.Forms.RichTextBox RSAMessageBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

