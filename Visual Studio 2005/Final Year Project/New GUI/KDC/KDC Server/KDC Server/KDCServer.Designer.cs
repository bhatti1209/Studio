namespace KDC_Server
{
    partial class KDCServer
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
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(94, 130);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(505, 374);
            this.displayTextBox.TabIndex = 3;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(94, 83);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(505, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // KDCServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 571);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "KDCServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KDC Server";
            this.Load += new System.EventHandler(this.KDCServer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KDCServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}