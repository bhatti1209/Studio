using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KDC_Server
{
    public partial class UpdateKeys : Form
    {
        public UpdateKeys()
        {
            InitializeComponent();
        }

        private void UpdateKeys_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kDCDataSet.UpdateRequests' table. You can move, or remove it, as needed.
            this.updateRequestsTableAdapter.Fill(this.kDCDataSet.UpdateRequests);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;

            for (int q = 0; q < dataGridView1.Rows.Count; q++)
            {
                if (dataGridView1.Rows[q].Cells[0].Value != null)
                {
                    string temp = dataGridView1.Rows[q].Cells[0].Value.ToString();
                    if (temp == "True")
                    {
                        KDCDataSetTableAdapters.KeyDirectoryTableAdapter a = new KDC_Server.KDCDataSetTableAdapters.KeyDirectoryTableAdapter();

                        string login = dataGridView1.Rows[q].Cells[1].Value.ToString();
                        int count = (int)a.CheckLogin(login);

                        if (count == 1)
                        {
                            //change exsisting value
                            a.UpdateKeyPairs((byte[])dataGridView1.Rows[q].Cells[2].Value, (byte[])dataGridView1.Rows[q].Cells[3].Value,(DateTime)dataGridView1.Rows[q].Cells[4].Value, login);
                        }
                        else if (count == 0)
                        {
                            //add new user if not present
                            a.InsertUser(login, (byte[])dataGridView1.Rows[q].Cells[2].Value, (byte[])dataGridView1.Rows[q].Cells[3].Value, (DateTime)dataGridView1.Rows[q].Cells[4].Value);
                        }
                        counter = 1;

                        KDCDataSetTableAdapters.UpdateRequestsTableAdapter b = new KDC_Server.KDCDataSetTableAdapters.UpdateRequestsTableAdapter();
                        b.DeleteValue(login);
                    }
                }
            }

            if (counter != 0)
                MessageBox.Show("Selected Value(s) Updated");

            this.updateRequestsTableAdapter.Fill(this.kDCDataSet.UpdateRequests);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.updateRequestsTableAdapter.Fill(this.kDCDataSet.UpdateRequests);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}