namespace testdb
{
    partial class Student
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label rollNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label totalCreditLabel;
            System.Windows.Forms.Label semLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet = new testdb.StudentDBDataSet();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.rollNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalcredits = new System.Windows.Forms.TextBox();
            this.semTextBox = new System.Windows.Forms.TextBox();
            this.selectsem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sub1 = new System.Windows.Forms.TextBox();
            this.core1 = new System.Windows.Forms.TextBox();
            this.sub2 = new System.Windows.Forms.TextBox();
            this.core2 = new System.Windows.Forms.TextBox();
            this.sub3 = new System.Windows.Forms.TextBox();
            this.core3 = new System.Windows.Forms.TextBox();
            this.sub4 = new System.Windows.Forms.TextBox();
            this.core4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sub5TextBox = new System.Windows.Forms.TextBox();
            this.opt1 = new System.Windows.Forms.TextBox();
            this.sub6TextBox = new System.Windows.Forms.TextBox();
            this.sub7TextBox = new System.Windows.Forms.TextBox();
            this.sub8TextBox = new System.Windows.Forms.TextBox();
            this.opt2 = new System.Windows.Forms.TextBox();
            this.opt3 = new System.Windows.Forms.TextBox();
            this.opt4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sub8 = new System.Windows.Forms.ComboBox();
            this.sub7 = new System.Windows.Forms.ComboBox();
            this.sub6 = new System.Windows.Forms.ComboBox();
            this.sub5 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.studentTableAdapter = new testdb.StudentDBDataSetTableAdapters.StudentTableAdapter();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            rollNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            totalCreditLabel = new System.Windows.Forms.Label();
            semLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(26, 32);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(266, 32);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // rollNumberLabel
            // 
            rollNumberLabel.AutoSize = true;
            rollNumberLabel.Location = new System.Drawing.Point(259, 72);
            rollNumberLabel.Name = "rollNumberLabel";
            rollNumberLabel.Size = new System.Drawing.Size(68, 13);
            rollNumberLabel.TabIndex = 4;
            rollNumberLabel.Text = "Roll Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(51, 72);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // totalCreditLabel
            // 
            totalCreditLabel.AutoSize = true;
            totalCreditLabel.Location = new System.Drawing.Point(98, 212);
            totalCreditLabel.Name = "totalCreditLabel";
            totalCreditLabel.Size = new System.Drawing.Size(109, 13);
            totalCreditLabel.TabIndex = 8;
            totalCreditLabel.Text = "Total Credits Earned :";
            // 
            // semLabel
            // 
            semLabel.AutoSize = true;
            semLabel.Location = new System.Drawing.Point(222, 30);
            semLabel.Name = "semLabel";
            semLabel.Size = new System.Drawing.Size(57, 13);
            semLabel.TabIndex = 9;
            semLabel.Text = "Semester :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(92, 29);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(333, 29);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // rollNumberTextBox
            // 
            this.rollNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "RollNumber", true));
            this.rollNumberTextBox.Location = new System.Drawing.Point(333, 69);
            this.rollNumberTextBox.Name = "rollNumberTextBox";
            this.rollNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.rollNumberTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(92, 69);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(rollNumberLabel);
            this.groupBox1.Controls.Add(this.rollNumberTextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // totalcredits
            // 
            this.totalcredits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "TotalCredit", true));
            this.totalcredits.Location = new System.Drawing.Point(226, 209);
            this.totalcredits.Name = "totalcredits";
            this.totalcredits.ReadOnly = true;
            this.totalcredits.Size = new System.Drawing.Size(71, 20);
            this.totalcredits.TabIndex = 9;
            // 
            // semTextBox
            // 
            this.semTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sem", true));
            this.semTextBox.Location = new System.Drawing.Point(285, 27);
            this.semTextBox.Name = "semTextBox";
            this.semTextBox.ReadOnly = true;
            this.semTextBox.Size = new System.Drawing.Size(39, 20);
            this.semTextBox.TabIndex = 10;
            // 
            // selectsem
            // 
            this.selectsem.FormattingEnabled = true;
            this.selectsem.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.selectsem.Location = new System.Drawing.Point(101, 27);
            this.selectsem.Name = "selectsem";
            this.selectsem.Size = new System.Drawing.Size(80, 21);
            this.selectsem.TabIndex = 11;
            this.selectsem.Text = "Select Sem.";
            this.selectsem.SelectedIndexChanged += new System.EventHandler(this.selectsem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "4";
            // 
            // sub1
            // 
            this.sub1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub1", true));
            this.sub1.Location = new System.Drawing.Point(39, 25);
            this.sub1.Name = "sub1";
            this.sub1.ReadOnly = true;
            this.sub1.Size = new System.Drawing.Size(127, 20);
            this.sub1.TabIndex = 16;
            // 
            // core1
            // 
            this.core1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core1", true));
            this.core1.Location = new System.Drawing.Point(172, 25);
            this.core1.Name = "core1";
            this.core1.ReadOnly = true;
            this.core1.Size = new System.Drawing.Size(36, 20);
            this.core1.TabIndex = 17;
            // 
            // sub2
            // 
            this.sub2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub2", true));
            this.sub2.Location = new System.Drawing.Point(39, 51);
            this.sub2.Name = "sub2";
            this.sub2.ReadOnly = true;
            this.sub2.Size = new System.Drawing.Size(127, 20);
            this.sub2.TabIndex = 18;
            // 
            // core2
            // 
            this.core2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core2", true));
            this.core2.Location = new System.Drawing.Point(172, 51);
            this.core2.Name = "core2";
            this.core2.ReadOnly = true;
            this.core2.Size = new System.Drawing.Size(36, 20);
            this.core2.TabIndex = 19;
            // 
            // sub3
            // 
            this.sub3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub3", true));
            this.sub3.Location = new System.Drawing.Point(39, 77);
            this.sub3.Name = "sub3";
            this.sub3.ReadOnly = true;
            this.sub3.Size = new System.Drawing.Size(127, 20);
            this.sub3.TabIndex = 20;
            // 
            // core3
            // 
            this.core3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core3", true));
            this.core3.Location = new System.Drawing.Point(172, 77);
            this.core3.Name = "core3";
            this.core3.ReadOnly = true;
            this.core3.Size = new System.Drawing.Size(36, 20);
            this.core3.TabIndex = 21;
            // 
            // sub4
            // 
            this.sub4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub4", true));
            this.sub4.Location = new System.Drawing.Point(39, 103);
            this.sub4.Name = "sub4";
            this.sub4.ReadOnly = true;
            this.sub4.Size = new System.Drawing.Size(127, 20);
            this.sub4.TabIndex = 22;
            // 
            // core4
            // 
            this.core4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core4", true));
            this.core4.Location = new System.Drawing.Point(172, 103);
            this.core4.Name = "core4";
            this.core4.ReadOnly = true;
            this.core4.Size = new System.Drawing.Size(36, 20);
            this.core4.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.core4);
            this.groupBox2.Controls.Add(this.sub4);
            this.groupBox2.Controls.Add(this.core3);
            this.groupBox2.Controls.Add(this.sub3);
            this.groupBox2.Controls.Add(this.core2);
            this.groupBox2.Controls.Add(this.sub2);
            this.groupBox2.Controls.Add(this.core1);
            this.groupBox2.Controls.Add(this.sub1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 141);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Core Subjects";
            // 
            // sub5TextBox
            // 
            this.sub5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub5", true));
            this.sub5TextBox.Location = new System.Drawing.Point(35, 26);
            this.sub5TextBox.Name = "sub5TextBox";
            this.sub5TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub5TextBox.TabIndex = 25;
            this.sub5TextBox.Visible = false;
            // 
            // opt1
            // 
            this.opt1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt1", true));
            this.opt1.Location = new System.Drawing.Point(166, 26);
            this.opt1.Name = "opt1";
            this.opt1.ReadOnly = true;
            this.opt1.Size = new System.Drawing.Size(36, 20);
            this.opt1.TabIndex = 26;
            // 
            // sub6TextBox
            // 
            this.sub6TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub6", true));
            this.sub6TextBox.Location = new System.Drawing.Point(35, 51);
            this.sub6TextBox.Name = "sub6TextBox";
            this.sub6TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub6TextBox.TabIndex = 27;
            this.sub6TextBox.Visible = false;
            // 
            // sub7TextBox
            // 
            this.sub7TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub7", true));
            this.sub7TextBox.Location = new System.Drawing.Point(35, 78);
            this.sub7TextBox.Name = "sub7TextBox";
            this.sub7TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub7TextBox.TabIndex = 28;
            this.sub7TextBox.Visible = false;
            // 
            // sub8TextBox
            // 
            this.sub8TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub8", true));
            this.sub8TextBox.Location = new System.Drawing.Point(35, 104);
            this.sub8TextBox.Name = "sub8TextBox";
            this.sub8TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub8TextBox.TabIndex = 29;
            this.sub8TextBox.Visible = false;
            // 
            // opt2
            // 
            this.opt2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt2", true));
            this.opt2.Location = new System.Drawing.Point(166, 51);
            this.opt2.Name = "opt2";
            this.opt2.ReadOnly = true;
            this.opt2.Size = new System.Drawing.Size(36, 20);
            this.opt2.TabIndex = 30;
            // 
            // opt3
            // 
            this.opt3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt3", true));
            this.opt3.Location = new System.Drawing.Point(166, 77);
            this.opt3.Name = "opt3";
            this.opt3.ReadOnly = true;
            this.opt3.Size = new System.Drawing.Size(36, 20);
            this.opt3.TabIndex = 31;
            // 
            // opt4
            // 
            this.opt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt4", true));
            this.opt4.Location = new System.Drawing.Point(166, 103);
            this.opt4.Name = "opt4";
            this.opt4.ReadOnly = true;
            this.opt4.Size = new System.Drawing.Size(36, 20);
            this.opt4.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sub8);
            this.groupBox3.Controls.Add(this.sub7);
            this.groupBox3.Controls.Add(this.sub6);
            this.groupBox3.Controls.Add(this.sub5);
            this.groupBox3.Controls.Add(this.opt4);
            this.groupBox3.Controls.Add(this.opt3);
            this.groupBox3.Controls.Add(this.opt2);
            this.groupBox3.Controls.Add(this.sub8TextBox);
            this.groupBox3.Controls.Add(this.sub7TextBox);
            this.groupBox3.Controls.Add(this.sub6TextBox);
            this.groupBox3.Controls.Add(this.opt1);
            this.groupBox3.Controls.Add(this.sub5TextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(247, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 141);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Optional Subjects";
            // 
            // sub8
            // 
            this.sub8.FormattingEnabled = true;
            this.sub8.Location = new System.Drawing.Point(35, 103);
            this.sub8.Name = "sub8";
            this.sub8.Size = new System.Drawing.Size(125, 21);
            this.sub8.TabIndex = 34;
            this.sub8.SelectedIndexChanged += new System.EventHandler(this.sub8_SelectedIndexChanged);
            // 
            // sub7
            // 
            this.sub7.FormattingEnabled = true;
            this.sub7.Location = new System.Drawing.Point(35, 77);
            this.sub7.Name = "sub7";
            this.sub7.Size = new System.Drawing.Size(125, 21);
            this.sub7.TabIndex = 34;
            this.sub7.SelectedIndexChanged += new System.EventHandler(this.sub7_SelectedIndexChanged);
            // 
            // sub6
            // 
            this.sub6.FormattingEnabled = true;
            this.sub6.Location = new System.Drawing.Point(35, 51);
            this.sub6.Name = "sub6";
            this.sub6.Size = new System.Drawing.Size(125, 21);
            this.sub6.TabIndex = 34;
            this.sub6.SelectedIndexChanged += new System.EventHandler(this.sub6_SelectedIndexChanged);
            // 
            // sub5
            // 
            this.sub5.FormattingEnabled = true;
            this.sub5.Location = new System.Drawing.Point(35, 25);
            this.sub5.Name = "sub5";
            this.sub5.Size = new System.Drawing.Size(125, 21);
            this.sub5.TabIndex = 34;
            this.sub5.SelectedIndexChanged += new System.EventHandler(this.sub5_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.selectsem);
            this.groupBox4.Controls.Add(semLabel);
            this.groupBox4.Controls.Add(this.semTextBox);
            this.groupBox4.Controls.Add(totalCreditLabel);
            this.groupBox4.Controls.Add(this.totalcredits);
            this.groupBox4.Location = new System.Drawing.Point(22, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 244);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Course Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 29);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add To DataBase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Student";
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private testdb.StudentDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox rollNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalcredits;
        private System.Windows.Forms.TextBox semTextBox;
        private System.Windows.Forms.ComboBox selectsem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sub1;
        private System.Windows.Forms.TextBox core1;
        private System.Windows.Forms.TextBox sub2;
        private System.Windows.Forms.TextBox core2;
        private System.Windows.Forms.TextBox sub3;
        private System.Windows.Forms.TextBox core3;
        private System.Windows.Forms.TextBox sub4;
        private System.Windows.Forms.TextBox core4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox opt1;
        private System.Windows.Forms.TextBox sub5TextBox;
        private System.Windows.Forms.TextBox sub6TextBox;
        private System.Windows.Forms.TextBox sub7TextBox;
        private System.Windows.Forms.TextBox sub8TextBox;
        private System.Windows.Forms.TextBox opt2;
        private System.Windows.Forms.TextBox opt3;
        private System.Windows.Forms.TextBox opt4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox sub8;
        private System.Windows.Forms.ComboBox sub7;
        private System.Windows.Forms.ComboBox sub6;
        private System.Windows.Forms.ComboBox sub5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
    }
}