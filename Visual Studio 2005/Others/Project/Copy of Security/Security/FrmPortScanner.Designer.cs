namespace Security
{
    partial class FrmPortScanner
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.prgScanning = new System.Windows.Forms.ProgressBar();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLog.Location = new System.Drawing.Point(322, 201);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(302, 149);
            this.txtLog.TabIndex = 18;
            // 
            // numEnd
            // 
            this.numEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numEnd.Location = new System.Drawing.Point(237, 229);
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(50, 20);
            this.numEnd.TabIndex = 17;
            // 
            // numStart
            // 
            this.numStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numStart.Location = new System.Drawing.Point(163, 229);
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(50, 20);
            this.numStart.TabIndex = 16;
            // 
            // prgScanning
            // 
            this.prgScanning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prgScanning.Location = new System.Drawing.Point(322, 356);
            this.prgScanning.Name = "prgScanning";
            this.prgScanning.Size = new System.Drawing.Size(302, 18);
            this.prgScanning.Step = 1;
            this.prgScanning.TabIndex = 15;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(219, 233);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(16, 13);
            this.lblEnd.TabIndex = 14;
            this.lblEnd.Text = "to";
            // 
            // lblStart
            // 
            this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(128, 233);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(33, 13);
            this.lblStart.TabIndex = 13;
            this.lblStart.Text = "From:";
            // 
            // lblIP
            // 
            this.lblIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(129, 204);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 12;
            this.lblIP.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIP.Location = new System.Drawing.Point(163, 201);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(124, 20);
            this.txtIP.TabIndex = 11;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScan.Location = new System.Drawing.Point(212, 255);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Start Scan";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click_1);
            // 
            // FrmPortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 560);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.numEnd);
            this.Controls.Add(this.numStart);
            this.Controls.Add(this.prgScanning);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnScan);
            this.Name = "FrmPortScanner";
            this.Text = "FrmPortScanner";
            this.Load += new System.EventHandler(this.FrmPortScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.ProgressBar prgScanning;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnScan;
        private System.IO.Ports.SerialPort serialPort1;

    }
}