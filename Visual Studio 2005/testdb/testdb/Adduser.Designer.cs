namespace testdb
{
    partial class Adduser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passbox1 = new System.Windows.Forms.TextBox();
            this.passbox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginDataSet = new testdb.LoginDataSet();
            this.loginAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginAdminTableAdapter = new testdb.LoginDataSetTableAdapters.LoginAdminTableAdapter();
            this.loginStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginStudentTableAdapter = new testdb.LoginDataSetTableAdapters.LoginStudentTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirm Password";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(141, 37);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(138, 20);
            this.usernamebox.TabIndex = 1;
            // 
            // passbox1
            // 
            this.passbox1.Location = new System.Drawing.Point(141, 75);
            this.passbox1.Name = "passbox1";
            this.passbox1.PasswordChar = '*';
            this.passbox1.Size = new System.Drawing.Size(138, 20);
            this.passbox1.TabIndex = 2;
            // 
            // passbox2
            // 
            this.passbox2.Location = new System.Drawing.Point(141, 114);
            this.passbox2.Name = "passbox2";
            this.passbox2.PasswordChar = '*';
            this.passbox2.Size = new System.Drawing.Size(138, 20);
            this.passbox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Group";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(141, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save !!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.passbox2);
            this.groupBox1.Controls.Add(this.passbox1);
            this.groupBox1.Controls.Add(this.usernamebox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 280);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Details";
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "LoginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginAdminBindingSource
            // 
            this.loginAdminBindingSource.DataMember = "LoginAdmin";
            this.loginAdminBindingSource.DataSource = this.loginDataSet;
            // 
            // loginAdminTableAdapter
            // 
            this.loginAdminTableAdapter.ClearBeforeFill = true;
            // 
            // loginStudentBindingSource
            // 
            this.loginStudentBindingSource.DataMember = "LoginStudent";
            this.loginStudentBindingSource.DataSource = this.loginDataSet;
            // 
            // loginStudentTableAdapter
            // 
            this.loginStudentTableAdapter.ClearBeforeFill = true;
            // 
            // Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 490);
            this.Controls.Add(this.groupBox1);
            this.Name = "Adduser";
            this.Text = "Adduser";
            this.Load += new System.EventHandler(this.Adduser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox passbox1;
        private System.Windows.Forms.TextBox passbox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private LoginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource loginAdminBindingSource;
        private testdb.LoginDataSetTableAdapters.LoginAdminTableAdapter loginAdminTableAdapter;
        private System.Windows.Forms.BindingSource loginStudentBindingSource;
        private testdb.LoginDataSetTableAdapters.LoginStudentTableAdapter loginStudentTableAdapter;
    }
}