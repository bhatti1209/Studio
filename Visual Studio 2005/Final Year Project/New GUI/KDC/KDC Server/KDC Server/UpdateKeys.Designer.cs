namespace KDC_Server
{
    partial class UpdateKeys
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kDCDataSet = new KDC_Server.KDCDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.loginnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publickeyDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateRequestsTableAdapter = new KDC_Server.KDCDataSetTableAdapters.UpdateRequestsTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loginnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publickeyDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.privatekey = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kDCDataSet)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.loginnameDataGridViewTextBoxColumn1,
            this.publickeyDataGridViewImageColumn1,
            this.privatekey,
            this.dateDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.updateRequestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // updateRequestsBindingSource
            // 
            this.updateRequestsBindingSource.DataMember = "UpdateRequests";
            this.updateRequestsBindingSource.DataSource = this.kDCDataSet;
            // 
            // kDCDataSet
            // 
            this.kDCDataSet.DataSetName = "KDCDataSet";
            this.kDCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update Selected Requests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(700, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // loginnameDataGridViewTextBoxColumn
            // 
            this.loginnameDataGridViewTextBoxColumn.DataPropertyName = "loginname";
            this.loginnameDataGridViewTextBoxColumn.HeaderText = "loginname";
            this.loginnameDataGridViewTextBoxColumn.Name = "loginnameDataGridViewTextBoxColumn";
            this.loginnameDataGridViewTextBoxColumn.Width = 300;
            // 
            // publickeyDataGridViewImageColumn
            // 
            this.publickeyDataGridViewImageColumn.DataPropertyName = "publickey";
            this.publickeyDataGridViewImageColumn.HeaderText = "publickey";
            this.publickeyDataGridViewImageColumn.Name = "publickeyDataGridViewImageColumn";
            this.publickeyDataGridViewImageColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 200;
            // 
            // updateRequestsTableAdapter
            // 
            this.updateRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // loginnameDataGridViewTextBoxColumn1
            // 
            this.loginnameDataGridViewTextBoxColumn1.DataPropertyName = "loginname";
            this.loginnameDataGridViewTextBoxColumn1.HeaderText = "loginname";
            this.loginnameDataGridViewTextBoxColumn1.Name = "loginnameDataGridViewTextBoxColumn1";
            this.loginnameDataGridViewTextBoxColumn1.Width = 300;
            // 
            // publickeyDataGridViewImageColumn1
            // 
            this.publickeyDataGridViewImageColumn1.DataPropertyName = "publickey";
            this.publickeyDataGridViewImageColumn1.HeaderText = "publickey";
            this.publickeyDataGridViewImageColumn1.Name = "publickeyDataGridViewImageColumn1";
            this.publickeyDataGridViewImageColumn1.Visible = false;
            // 
            // privatekey
            // 
            this.privatekey.DataPropertyName = "privatekey";
            this.privatekey.HeaderText = "privatekey";
            this.privatekey.Name = "privatekey";
            this.privatekey.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 200;
            // 
            // UpdateKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 571);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateKeys";
            this.Text = "Update Requests";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateKeys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kDCDataSet)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KDCDataSet kDCDataSet;
        private System.Windows.Forms.BindingSource updateRequestsBindingSource;
        private KDC_Server.KDCDataSetTableAdapters.UpdateRequestsTableAdapter updateRequestsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn publickeyDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn publickeyDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn privatekey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
    }
}