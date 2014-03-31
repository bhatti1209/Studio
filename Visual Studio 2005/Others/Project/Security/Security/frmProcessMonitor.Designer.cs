namespace Security
{
    partial class frmProcessMonitor
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ListBox1
            // 
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(0, 0);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(254, 537);
            this.ListBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kill ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(453, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 3;
            this.listBox2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmProcessMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 537);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListBox1);
            this.Name = "frmProcessMonitor";
            this.Text = "frmProcessMonitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProcessMonitor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        internal System.Windows.Forms.Timer timer2;
    }
}