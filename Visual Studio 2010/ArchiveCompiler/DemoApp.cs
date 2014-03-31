using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ArchiveCompiler.Demo
{
	public partial class Form1 : Form
	{
		BindingList<IconFileInfo> files = new BindingList<IconFileInfo>();

		public Form1()
		{
			InitializeComponent();

			pictureBox1.Image = Icon.ExtractAssociatedIcon(Application.ExecutablePath).ToBitmap();

			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = files;
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			foreach (string filename in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				files.Add(new IconFileInfo(filename));
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK != saveFileDialog1.ShowDialog(this))
				return;

			try
			{
				using (SelfExtractor archive = new SelfExtractor())
				{
					foreach (IconFileInfo file in files)
					{
						archive.AddFile(file.FullName);
					}
					archive.CompileArchive(saveFileDialog1.FileName, checkBox1.Checked, pictureBox1.ImageLocation);
				}

				MessageBox.Show(this, Path.GetFileName(saveFileDialog1.FileName) + " built successfully.",
					Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK != openFileDialog1.ShowDialog(this))
				return;

			pictureBox1.ImageLocation = openFileDialog1.FileName;
		}
	}

	class IconFileInfo
	{
		FileInfo fi;
		Icon icon;

		public IconFileInfo(string filename)
		{
			fi = new FileInfo(filename);
			icon = Icon.ExtractAssociatedIcon(filename);
		}

		public Icon Icon { get { return icon; } }
		public string Name { get { return fi.Name; } }
		public long Size { get { return fi.Length; } }
		public string FullName { get { return fi.FullName; } }
		public DateTime Date { get { return fi.LastWriteTime; } }
	}
}