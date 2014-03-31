using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace SelfExtractor
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}

	public class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Visible = false;
			ShowInTaskbar = false;

			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Please, select a destination folder.";

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				Assembly ass = Assembly.GetExecutingAssembly();
				string[] res = ass.GetManifestResourceNames();

				try
				{
					foreach (string name in res)
					{
						Stream rs = ass.GetManifestResourceStream(name);

						using (Stream gzip = new GZipStream(rs, CompressionMode.Decompress, true))
						{
							string path = Path.Combine(fbd.SelectedPath, Path.GetFileNameWithoutExtension(name)); // remove ".gz"
							
							using (Stream file = File.Create(path))
							{
								for (int b = gzip.ReadByte(); b != -1; b = gzip.ReadByte())
								{
									file.WriteByte((byte)b);
								}
							}
						}
					}
#if RUN_1ST_ITEM
				if (res.Length > 0)
				{
					Process.Start(Path.GetFileNameWithoutExtension(res[0]));
				}
#endif
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, ex.Message, ass.GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			Close();
		}

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
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
		}

		#endregion
	}
}