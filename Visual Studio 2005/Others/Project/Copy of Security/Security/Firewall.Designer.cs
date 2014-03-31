namespace Security
{
    partial class Firewall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firewall));
            this.Label8 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label8.Location = new System.Drawing.Point(377, 104);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(208, 48);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Fire Wall ";
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(329, 104);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(32, 40);
            this.PictureBox3.TabIndex = 22;
            this.PictureBox3.TabStop = false;
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(97, 400);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(184, 32);
            this.Button5.TabIndex = 21;
            this.Button5.Text = "Remove from List";
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(465, 400);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(128, 32);
            this.Button7.TabIndex = 20;
            this.Button7.Text = "Disable Firewall";
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Green;
            this.Label5.Location = new System.Drawing.Point(385, 200);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(160, 16);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "NOT MONITORING";
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(321, 400);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(136, 32);
            this.Button6.TabIndex = 18;
            this.Button6.Text = "Enable Firewall";
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label4.Location = new System.Drawing.Point(529, 232);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 24);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "000";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(361, 232);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(160, 24);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Blocked Processes :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button3);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(329, 272);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(272, 112);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Process Name to Block :";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(72, 64);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(160, 32);
            this.Button3.TabIndex = 1;
            this.Button3.Text = "Add to Block List";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(16, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(240, 25);
            this.TextBox1.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(81, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(216, 24);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Block List :";
            // 
            // ListBox1
            // 
            this.ListBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox1.ItemHeight = 15;
            this.ListBox1.Location = new System.Drawing.Point(97, 120);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(184, 274);
            this.ListBox1.TabIndex = 13;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Firewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 497);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ListBox1);
            this.Name = "Firewall";
            this.Text = "Firewall";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Timer Timer1;
    }
}