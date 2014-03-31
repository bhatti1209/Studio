namespace KDC_Client
{
    partial class KDCClient
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(62, 157);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(537, 315);
            this.displayTextBox.TabIndex = 5;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(179, 75);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(420, 20);
            this.inputTextBox.TabIndex = 4;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Users Key Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save Users Key Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KDCClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "KDCClient";
            this.Text = "KDC Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KDCClient_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KDCClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}