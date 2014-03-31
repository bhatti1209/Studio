namespace testdb
{
    partial class ChangePassAdmin
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
            this.logininbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oldpassbox = new System.Windows.Forms.TextBox();
            this.newpassbox = new System.Windows.Forms.TextBox();
            this.renewpassbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginIDTextBox = new System.Windows.Forms.TextBox();
            this.loginAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new testdb.LoginDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.loginAdminTableAdapter = new testdb.LoginDataSetTableAdapters.LoginAdminTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // logininbox
            // 
            this.logininbox.Location = new System.Drawing.Point(154, 46);
            this.logininbox.Name = "logininbox";
            this.logininbox.Size = new System.Drawing.Size(134, 20);
            this.logininbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LoginID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Re-Confirm Password";
            // 
            // oldpassbox
            // 
            this.oldpassbox.Location = new System.Drawing.Point(154, 81);
            this.oldpassbox.Name = "oldpassbox";
            this.oldpassbox.PasswordChar = '*';
            this.oldpassbox.Size = new System.Drawing.Size(134, 20);
            this.oldpassbox.TabIndex = 2;
            // 
            // newpassbox
            // 
            this.newpassbox.Location = new System.Drawing.Point(154, 118);
            this.newpassbox.Name = "newpassbox";
            this.newpassbox.PasswordChar = '*';
            this.newpassbox.Size = new System.Drawing.Size(134, 20);
            this.newpassbox.TabIndex = 3;
            // 
            // renewpassbox
            // 
            this.renewpassbox.Location = new System.Drawing.Point(154, 150);
            this.renewpassbox.Name = "renewpassbox";
            this.renewpassbox.PasswordChar = '*';
            this.renewpassbox.Size = new System.Drawing.Size(134, 20);
            this.renewpassbox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginIDTextBox);
            this.groupBox1.Controls.Add(this.oldpassbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.renewpassbox);
            this.groupBox1.Controls.Add(this.newpassbox);
            this.groupBox1.Controls.Add(this.logininbox);
            this.groupBox1.Location = new System.Drawing.Point(65, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // loginIDTextBox
            // 
            this.loginIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginAdminBindingSource, "LoginID", true));
            this.loginIDTextBox.Location = new System.Drawing.Point(294, 46);
            this.loginIDTextBox.Name = "loginIDTextBox";
            this.loginIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginIDTextBox.TabIndex = 3;
            // 
            // loginAdminBindingSource
            // 
            this.loginAdminBindingSource.DataMember = "LoginAdmin";
            this.loginAdminBindingSource.DataSource = this.loginDataSet;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "LoginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginAdminTableAdapter
            // 
            this.loginAdminTableAdapter.ClearBeforeFill = true;
            // 
            // ChangePassAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 490);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangePassAdmin";
            this.Text = "ChangePassAdmin";
            this.Load += new System.EventHandler(this.ChangePassAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LoginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource loginAdminBindingSource;
        private testdb.LoginDataSetTableAdapters.LoginAdminTableAdapter loginAdminTableAdapter;
        private System.Windows.Forms.TextBox logininbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldpassbox;
        private System.Windows.Forms.TextBox newpassbox;
        private System.Windows.Forms.TextBox renewpassbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loginIDTextBox;
    }
}