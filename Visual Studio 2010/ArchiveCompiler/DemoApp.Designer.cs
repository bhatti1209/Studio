namespace ArchiveCompiler.Demo
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(388, 235);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 49);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Compile Self-Extractor...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 230);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 56);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(325, 20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(31, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(235, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "&Icon:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(279, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(21, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(160, 17);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "&Run first item after extraction";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Self-Extractor Archives (*.exe)|*.exe";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Drag & drop files to be added to archive";
			this.label1.UseMnemonic = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.Location = new System.Drawing.Point(15, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(465, 199);
			this.dataGridView1.TabIndex = 4;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column1.DataPropertyName = "Icon";
			this.Column1.HeaderText = "";
			this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 20;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Name";
			this.Column2.HeaderText = "File";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Size";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "#,### bytes";
			dataGridViewCellStyle1.NullValue = null;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column3.HeaderText = "Size";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 80;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Date";
			this.Column4.HeaderText = "Date Modified";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 120;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "FullName";
			this.Column5.HeaderText = "Path";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 92;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Icon files (*.ico)|*.ico";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 297);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.MinimumSize = new System.Drawing.Size(500, 320);
			this.Name = "Form1";
			this.Text = "Self-Extractor Compiler";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewImageColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

