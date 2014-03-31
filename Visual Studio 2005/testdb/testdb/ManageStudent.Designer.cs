namespace testdb
{
    partial class ManageStudent
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginidbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.loginStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new testdb.LoginDataSet();
            this.loginStudentTableAdapter = new testdb.LoginDataSetTableAdapters.LoginStudentTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.loginidbox);
            this.groupBox2.Location = new System.Drawing.Point(86, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reset Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "LoginID";
            // 
            // loginidbox
            // 
            this.loginidbox.Location = new System.Drawing.Point(144, 45);
            this.loginidbox.Name = "loginidbox";
            this.loginidbox.Size = new System.Drawing.Size(128, 20);
            this.loginidbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginIDTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usernamebox);
            this.groupBox1.Location = new System.Drawing.Point(86, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete An Account";
            // 
            // loginIDTextBox
            // 
            this.loginIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginStudentBindingSource, "LoginID", true));
            this.loginIDTextBox.Location = new System.Drawing.Point(144, 69);
            this.loginIDTextBox.Name = "loginIDTextBox";
            this.loginIDTextBox.Size = new System.Drawing.Size(128, 20);
            this.loginIDTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete !!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoginID";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(144, 43);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(128, 20);
            this.usernamebox.TabIndex = 1;
            // 
            // loginStudentBindingSource
            // 
            this.loginStudentBindingSource.DataMember = "LoginStudent";
            this.loginStudentBindingSource.DataSource = this.loginDataSet;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "LoginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginStudentTableAdapter
            // 
            this.loginStudentTableAdapter.ClearBeforeFill = true;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ManageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginidbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernamebox;
        private LoginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource loginStudentBindingSource;
        private testdb.LoginDataSetTableAdapters.LoginStudentTableAdapter loginStudentTableAdapter;
        private System.Windows.Forms.TextBox loginIDTextBox;
    }
}