namespace testdb
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.selectuser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginIDTextBox = new System.Windows.Forms.TextBox();
            this.loginAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new testdb.LoginDataSet();
            this.loginIDTextBox1 = new System.Windows.Forms.TextBox();
            this.loginStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errordisplay = new System.Windows.Forms.Label();
            this.loginAdminTableAdapter = new testdb.LoginDataSetTableAdapters.LoginAdminTableAdapter();
            this.loginStudentTableAdapter = new testdb.LoginDataSetTableAdapters.LoginStudentTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(107, 43);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(131, 20);
            this.usernamebox.TabIndex = 1;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(107, 79);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.Size = new System.Drawing.Size(131, 20);
            this.passbox.TabIndex = 2;
            // 
            // selectuser
            // 
            this.selectuser.FormattingEnabled = true;
            this.selectuser.Items.AddRange(new object[] {
            "",
            "Administrator",
            "Student"});
            this.selectuser.Location = new System.Drawing.Point(107, 117);
            this.selectuser.Name = "selectuser";
            this.selectuser.Size = new System.Drawing.Size(131, 21);
            this.selectuser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login As";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernamebox);
            this.groupBox1.Controls.Add(this.loginIDTextBox);
            this.groupBox1.Controls.Add(this.loginIDTextBox1);
            this.groupBox1.Controls.Add(this.selectuser);
            this.groupBox1.Controls.Add(this.passbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(131, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // loginIDTextBox
            // 
            this.loginIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginAdminBindingSource, "LoginID", true));
            this.loginIDTextBox.Location = new System.Drawing.Point(107, 43);
            this.loginIDTextBox.Name = "loginIDTextBox";
            this.loginIDTextBox.ReadOnly = true;
            this.loginIDTextBox.Size = new System.Drawing.Size(131, 20);
            this.loginIDTextBox.TabIndex = 6;
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
            // loginIDTextBox1
            // 
            this.loginIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginStudentBindingSource, "LoginID", true));
            this.loginIDTextBox1.Location = new System.Drawing.Point(107, 43);
            this.loginIDTextBox1.Name = "loginIDTextBox1";
            this.loginIDTextBox1.ReadOnly = true;
            this.loginIDTextBox1.Size = new System.Drawing.Size(131, 20);
            this.loginIDTextBox1.TabIndex = 6;
            // 
            // loginStudentBindingSource
            // 
            this.loginStudentBindingSource.DataMember = "LoginStudent";
            this.loginStudentBindingSource.DataSource = this.loginDataSet;
            // 
            // errordisplay
            // 
            this.errordisplay.AutoSize = true;
            this.errordisplay.ForeColor = System.Drawing.Color.Red;
            this.errordisplay.Location = new System.Drawing.Point(182, 103);
            this.errordisplay.Name = "errordisplay";
            this.errordisplay.Size = new System.Drawing.Size(0, 13);
            this.errordisplay.TabIndex = 5;
            // 
            // loginAdminTableAdapter
            // 
            this.loginAdminTableAdapter.ClearBeforeFill = true;
            // 
            // loginStudentTableAdapter
            // 
            this.loginStudentTableAdapter.ClearBeforeFill = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 544);
            this.Controls.Add(this.errordisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.ComboBox selectuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errordisplay;
        private LoginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource loginAdminBindingSource;
        private testdb.LoginDataSetTableAdapters.LoginAdminTableAdapter loginAdminTableAdapter;
        private System.Windows.Forms.BindingSource loginStudentBindingSource;
        private testdb.LoginDataSetTableAdapters.LoginStudentTableAdapter loginStudentTableAdapter;
        private System.Windows.Forms.TextBox loginIDTextBox1;
        private System.Windows.Forms.TextBox loginIDTextBox;
    }
}