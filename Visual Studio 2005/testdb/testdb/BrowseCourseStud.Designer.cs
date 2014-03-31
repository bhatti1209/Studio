namespace testdb
{
    partial class BrowseCourseStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseCourseStud));
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label rollNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label totalCreditLabel;
            System.Windows.Forms.Label semLabel;
            System.Windows.Forms.Label sub1Label;
            System.Windows.Forms.Label sub2Label;
            System.Windows.Forms.Label sub3Label;
            System.Windows.Forms.Label sub4Label;
            System.Windows.Forms.Label sub5Label;
            System.Windows.Forms.Label sub6Label;
            System.Windows.Forms.Label sub7Label;
            System.Windows.Forms.Label sub8Label;
            this.studentDBDataSet = new testdb.StudentDBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new testdb.StudentDBDataSetTableAdapters.StudentTableAdapter();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.rollNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.totalCreditTextBox = new System.Windows.Forms.TextBox();
            this.semTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sub1TextBox = new System.Windows.Forms.TextBox();
            this.sub2TextBox = new System.Windows.Forms.TextBox();
            this.sub3TextBox = new System.Windows.Forms.TextBox();
            this.sub4TextBox = new System.Windows.Forms.TextBox();
            this.sub5TextBox = new System.Windows.Forms.TextBox();
            this.sub6TextBox = new System.Windows.Forms.TextBox();
            this.sub7TextBox = new System.Windows.Forms.TextBox();
            this.sub8TextBox = new System.Windows.Forms.TextBox();
            this.core1TextBox = new System.Windows.Forms.TextBox();
            this.core2TextBox = new System.Windows.Forms.TextBox();
            this.core3TextBox = new System.Windows.Forms.TextBox();
            this.core4TextBox = new System.Windows.Forms.TextBox();
            this.opt1TextBox = new System.Windows.Forms.TextBox();
            this.opt2TextBox = new System.Windows.Forms.TextBox();
            this.opt3TextBox = new System.Windows.Forms.TextBox();
            this.opt4TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            rollNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            totalCreditLabel = new System.Windows.Forms.Label();
            semLabel = new System.Windows.Forms.Label();
            sub1Label = new System.Windows.Forms.Label();
            sub2Label = new System.Windows.Forms.Label();
            sub3Label = new System.Windows.Forms.Label();
            sub4Label = new System.Windows.Forms.Label();
            sub5Label = new System.Windows.Forms.Label();
            sub6Label = new System.Windows.Forms.Label();
            sub7Label = new System.Windows.Forms.Label();
            sub8Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = null;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = null;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(504, 25);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(37, 39);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(103, 36);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(237, 39);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(304, 36);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // rollNumberLabel
            // 
            rollNumberLabel.AutoSize = true;
            rollNumberLabel.Location = new System.Drawing.Point(29, 76);
            rollNumberLabel.Name = "rollNumberLabel";
            rollNumberLabel.Size = new System.Drawing.Size(68, 13);
            rollNumberLabel.TabIndex = 5;
            rollNumberLabel.Text = "Roll Number:";
            // 
            // rollNumberTextBox
            // 
            this.rollNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "RollNumber", true));
            this.rollNumberTextBox.Location = new System.Drawing.Point(103, 73);
            this.rollNumberTextBox.Name = "rollNumberTextBox";
            this.rollNumberTextBox.ReadOnly = true;
            this.rollNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.rollNumberTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(263, 79);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(304, 76);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // totalCreditLabel
            // 
            totalCreditLabel.AutoSize = true;
            totalCreditLabel.Location = new System.Drawing.Point(320, 60);
            totalCreditLabel.Name = "totalCreditLabel";
            totalCreditLabel.Size = new System.Drawing.Size(72, 13);
            totalCreditLabel.TabIndex = 9;
            totalCreditLabel.Text = "Total Credits :";
            // 
            // totalCreditTextBox
            // 
            this.totalCreditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "TotalCredit", true));
            this.totalCreditTextBox.Location = new System.Drawing.Point(327, 86);
            this.totalCreditTextBox.Name = "totalCreditTextBox";
            this.totalCreditTextBox.ReadOnly = true;
            this.totalCreditTextBox.Size = new System.Drawing.Size(41, 20);
            this.totalCreditTextBox.TabIndex = 10;
            // 
            // semLabel
            // 
            semLabel.AutoSize = true;
            semLabel.Location = new System.Drawing.Point(320, 156);
            semLabel.Name = "semLabel";
            semLabel.Size = new System.Drawing.Size(57, 13);
            semLabel.TabIndex = 11;
            semLabel.Text = "Semester :";
            // 
            // semTextBox
            // 
            this.semTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sem", true));
            this.semTextBox.Location = new System.Drawing.Point(327, 186);
            this.semTextBox.Name = "semTextBox";
            this.semTextBox.ReadOnly = true;
            this.semTextBox.Size = new System.Drawing.Size(41, 20);
            this.semTextBox.TabIndex = 12;
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
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 134);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // sub1Label
            // 
            sub1Label.AutoSize = true;
            sub1Label.Location = new System.Drawing.Point(46, 32);
            sub1Label.Name = "sub1Label";
            sub1Label.Size = new System.Drawing.Size(13, 13);
            sub1Label.TabIndex = 13;
            sub1Label.Text = "1";
            // 
            // sub1TextBox
            // 
            this.sub1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub1", true));
            this.sub1TextBox.Location = new System.Drawing.Point(85, 29);
            this.sub1TextBox.Name = "sub1TextBox";
            this.sub1TextBox.ReadOnly = true;
            this.sub1TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub1TextBox.TabIndex = 14;
            // 
            // sub2Label
            // 
            sub2Label.AutoSize = true;
            sub2Label.Location = new System.Drawing.Point(46, 58);
            sub2Label.Name = "sub2Label";
            sub2Label.Size = new System.Drawing.Size(13, 13);
            sub2Label.TabIndex = 14;
            sub2Label.Text = "2";
            // 
            // sub2TextBox
            // 
            this.sub2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub2", true));
            this.sub2TextBox.Location = new System.Drawing.Point(85, 55);
            this.sub2TextBox.Name = "sub2TextBox";
            this.sub2TextBox.ReadOnly = true;
            this.sub2TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub2TextBox.TabIndex = 15;
            // 
            // sub3Label
            // 
            sub3Label.AutoSize = true;
            sub3Label.Location = new System.Drawing.Point(46, 84);
            sub3Label.Name = "sub3Label";
            sub3Label.Size = new System.Drawing.Size(13, 13);
            sub3Label.TabIndex = 15;
            sub3Label.Text = "3";
            // 
            // sub3TextBox
            // 
            this.sub3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub3", true));
            this.sub3TextBox.Location = new System.Drawing.Point(85, 81);
            this.sub3TextBox.Name = "sub3TextBox";
            this.sub3TextBox.ReadOnly = true;
            this.sub3TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub3TextBox.TabIndex = 16;
            // 
            // sub4Label
            // 
            sub4Label.AutoSize = true;
            sub4Label.Location = new System.Drawing.Point(46, 110);
            sub4Label.Name = "sub4Label";
            sub4Label.Size = new System.Drawing.Size(13, 13);
            sub4Label.TabIndex = 16;
            sub4Label.Text = "4";
            // 
            // sub4TextBox
            // 
            this.sub4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub4", true));
            this.sub4TextBox.Location = new System.Drawing.Point(85, 107);
            this.sub4TextBox.Name = "sub4TextBox";
            this.sub4TextBox.ReadOnly = true;
            this.sub4TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub4TextBox.TabIndex = 17;
            // 
            // sub5Label
            // 
            sub5Label.AutoSize = true;
            sub5Label.Location = new System.Drawing.Point(46, 136);
            sub5Label.Name = "sub5Label";
            sub5Label.Size = new System.Drawing.Size(13, 13);
            sub5Label.TabIndex = 17;
            sub5Label.Text = "5";
            // 
            // sub5TextBox
            // 
            this.sub5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub5", true));
            this.sub5TextBox.Location = new System.Drawing.Point(85, 133);
            this.sub5TextBox.Name = "sub5TextBox";
            this.sub5TextBox.ReadOnly = true;
            this.sub5TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub5TextBox.TabIndex = 18;
            // 
            // sub6Label
            // 
            sub6Label.AutoSize = true;
            sub6Label.Location = new System.Drawing.Point(46, 162);
            sub6Label.Name = "sub6Label";
            sub6Label.Size = new System.Drawing.Size(13, 13);
            sub6Label.TabIndex = 18;
            sub6Label.Text = "6";
            // 
            // sub6TextBox
            // 
            this.sub6TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub6", true));
            this.sub6TextBox.Location = new System.Drawing.Point(85, 159);
            this.sub6TextBox.Name = "sub6TextBox";
            this.sub6TextBox.ReadOnly = true;
            this.sub6TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub6TextBox.TabIndex = 19;
            // 
            // sub7Label
            // 
            sub7Label.AutoSize = true;
            sub7Label.Location = new System.Drawing.Point(46, 188);
            sub7Label.Name = "sub7Label";
            sub7Label.Size = new System.Drawing.Size(13, 13);
            sub7Label.TabIndex = 19;
            sub7Label.Text = "7";
            // 
            // sub7TextBox
            // 
            this.sub7TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub7", true));
            this.sub7TextBox.Location = new System.Drawing.Point(85, 185);
            this.sub7TextBox.Name = "sub7TextBox";
            this.sub7TextBox.ReadOnly = true;
            this.sub7TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub7TextBox.TabIndex = 20;
            // 
            // sub8Label
            // 
            sub8Label.AutoSize = true;
            sub8Label.Location = new System.Drawing.Point(46, 214);
            sub8Label.Name = "sub8Label";
            sub8Label.Size = new System.Drawing.Size(13, 13);
            sub8Label.TabIndex = 20;
            sub8Label.Text = "8";
            // 
            // sub8TextBox
            // 
            this.sub8TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "sub8", true));
            this.sub8TextBox.Location = new System.Drawing.Point(85, 211);
            this.sub8TextBox.Name = "sub8TextBox";
            this.sub8TextBox.ReadOnly = true;
            this.sub8TextBox.Size = new System.Drawing.Size(100, 20);
            this.sub8TextBox.TabIndex = 21;
            // 
            // core1TextBox
            // 
            this.core1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core1", true));
            this.core1TextBox.Location = new System.Drawing.Point(213, 29);
            this.core1TextBox.Name = "core1TextBox";
            this.core1TextBox.ReadOnly = true;
            this.core1TextBox.Size = new System.Drawing.Size(43, 20);
            this.core1TextBox.TabIndex = 23;
            // 
            // core2TextBox
            // 
            this.core2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core2", true));
            this.core2TextBox.Location = new System.Drawing.Point(213, 55);
            this.core2TextBox.Name = "core2TextBox";
            this.core2TextBox.ReadOnly = true;
            this.core2TextBox.Size = new System.Drawing.Size(43, 20);
            this.core2TextBox.TabIndex = 24;
            // 
            // core3TextBox
            // 
            this.core3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core3", true));
            this.core3TextBox.Location = new System.Drawing.Point(213, 81);
            this.core3TextBox.Name = "core3TextBox";
            this.core3TextBox.ReadOnly = true;
            this.core3TextBox.Size = new System.Drawing.Size(43, 20);
            this.core3TextBox.TabIndex = 25;
            // 
            // core4TextBox
            // 
            this.core4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "core4", true));
            this.core4TextBox.Location = new System.Drawing.Point(213, 107);
            this.core4TextBox.Name = "core4TextBox";
            this.core4TextBox.ReadOnly = true;
            this.core4TextBox.Size = new System.Drawing.Size(43, 20);
            this.core4TextBox.TabIndex = 26;
            // 
            // opt1TextBox
            // 
            this.opt1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt1", true));
            this.opt1TextBox.Location = new System.Drawing.Point(213, 133);
            this.opt1TextBox.Name = "opt1TextBox";
            this.opt1TextBox.ReadOnly = true;
            this.opt1TextBox.Size = new System.Drawing.Size(43, 20);
            this.opt1TextBox.TabIndex = 27;
            // 
            // opt2TextBox
            // 
            this.opt2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt2", true));
            this.opt2TextBox.Location = new System.Drawing.Point(213, 159);
            this.opt2TextBox.Name = "opt2TextBox";
            this.opt2TextBox.ReadOnly = true;
            this.opt2TextBox.Size = new System.Drawing.Size(43, 20);
            this.opt2TextBox.TabIndex = 28;
            // 
            // opt3TextBox
            // 
            this.opt3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt3", true));
            this.opt3TextBox.Location = new System.Drawing.Point(213, 185);
            this.opt3TextBox.Name = "opt3TextBox";
            this.opt3TextBox.ReadOnly = true;
            this.opt3TextBox.Size = new System.Drawing.Size(43, 20);
            this.opt3TextBox.TabIndex = 29;
            // 
            // opt4TextBox
            // 
            this.opt4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "opt4", true));
            this.opt4TextBox.Location = new System.Drawing.Point(213, 211);
            this.opt4TextBox.Name = "opt4TextBox";
            this.opt4TextBox.ReadOnly = true;
            this.opt4TextBox.Size = new System.Drawing.Size(43, 20);
            this.opt4TextBox.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opt4TextBox);
            this.groupBox2.Controls.Add(this.opt3TextBox);
            this.groupBox2.Controls.Add(this.opt2TextBox);
            this.groupBox2.Controls.Add(this.opt1TextBox);
            this.groupBox2.Controls.Add(this.core4TextBox);
            this.groupBox2.Controls.Add(this.core3TextBox);
            this.groupBox2.Controls.Add(this.core2TextBox);
            this.groupBox2.Controls.Add(this.core1TextBox);
            this.groupBox2.Controls.Add(sub8Label);
            this.groupBox2.Controls.Add(this.sub8TextBox);
            this.groupBox2.Controls.Add(sub7Label);
            this.groupBox2.Controls.Add(this.sub7TextBox);
            this.groupBox2.Controls.Add(sub6Label);
            this.groupBox2.Controls.Add(this.sub6TextBox);
            this.groupBox2.Controls.Add(sub5Label);
            this.groupBox2.Controls.Add(this.sub5TextBox);
            this.groupBox2.Controls.Add(sub4Label);
            this.groupBox2.Controls.Add(this.sub4TextBox);
            this.groupBox2.Controls.Add(sub3Label);
            this.groupBox2.Controls.Add(this.sub3TextBox);
            this.groupBox2.Controls.Add(sub2Label);
            this.groupBox2.Controls.Add(this.sub2TextBox);
            this.groupBox2.Controls.Add(sub1Label);
            this.groupBox2.Controls.Add(this.sub1TextBox);
            this.groupBox2.Controls.Add(semLabel);
            this.groupBox2.Controls.Add(this.semTextBox);
            this.groupBox2.Controls.Add(totalCreditLabel);
            this.groupBox2.Controls.Add(this.totalCreditTextBox);
            this.groupBox2.Location = new System.Drawing.Point(28, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 262);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courser Details";
            // 
            // BrowseCourseStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentBindingNavigator);
            this.Name = "BrowseCourseStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowseCourseStud";
            this.Load += new System.EventHandler(this.BrowseCourseStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private testdb.StudentDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox rollNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox totalCreditTextBox;
        private System.Windows.Forms.TextBox semTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sub1TextBox;
        private System.Windows.Forms.TextBox sub2TextBox;
        private System.Windows.Forms.TextBox sub3TextBox;
        private System.Windows.Forms.TextBox sub4TextBox;
        private System.Windows.Forms.TextBox sub5TextBox;
        private System.Windows.Forms.TextBox sub6TextBox;
        private System.Windows.Forms.TextBox sub7TextBox;
        private System.Windows.Forms.TextBox sub8TextBox;
        private System.Windows.Forms.TextBox core1TextBox;
        private System.Windows.Forms.TextBox core2TextBox;
        private System.Windows.Forms.TextBox core3TextBox;
        private System.Windows.Forms.TextBox core4TextBox;
        private System.Windows.Forms.TextBox opt1TextBox;
        private System.Windows.Forms.TextBox opt2TextBox;
        private System.Windows.Forms.TextBox opt3TextBox;
        private System.Windows.Forms.TextBox opt4TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}