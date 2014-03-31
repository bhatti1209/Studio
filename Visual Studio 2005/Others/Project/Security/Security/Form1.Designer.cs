namespace Security
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proccessMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portScanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firewallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proccessMonitorToolStripMenuItem,
            this.portScanerToolStripMenuItem,
            this.packageFilteringToolStripMenuItem,
            this.firewallToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // proccessMonitorToolStripMenuItem
            // 
            this.proccessMonitorToolStripMenuItem.Name = "proccessMonitorToolStripMenuItem";
            this.proccessMonitorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.proccessMonitorToolStripMenuItem.Text = "Proccess Monitor";
            this.proccessMonitorToolStripMenuItem.Click += new System.EventHandler(this.proccessMonitorToolStripMenuItem_Click);
            // 
            // portScanerToolStripMenuItem
            // 
            this.portScanerToolStripMenuItem.Name = "portScanerToolStripMenuItem";
            this.portScanerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.portScanerToolStripMenuItem.Text = "Port Scaner";
            this.portScanerToolStripMenuItem.Click += new System.EventHandler(this.portScanerToolStripMenuItem_Click);
            // 
            // packageFilteringToolStripMenuItem
            // 
            this.packageFilteringToolStripMenuItem.Name = "packageFilteringToolStripMenuItem";
            this.packageFilteringToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.packageFilteringToolStripMenuItem.Text = "Package Filtering";
            this.packageFilteringToolStripMenuItem.Click += new System.EventHandler(this.packageFilteringToolStripMenuItem_Click);
            // 
            // firewallToolStripMenuItem
            // 
            this.firewallToolStripMenuItem.Name = "firewallToolStripMenuItem";
            this.firewallToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.firewallToolStripMenuItem.Text = "Firewall";
            this.firewallToolStripMenuItem.Click += new System.EventHandler(this.firewallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem1.Text = "IP Scan";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(219, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security System";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(43, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "IP Scanning";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Firewall";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Packet Filtering";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Port Scanner";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process Monitor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Security System";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proccessMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portScanerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packageFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firewallToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

