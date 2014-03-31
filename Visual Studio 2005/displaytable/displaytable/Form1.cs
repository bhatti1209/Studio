using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace displaytable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.ordersTableAdapter.Update(this.booksDataSet.Orders);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.booksDataSet.Orders);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: ordersTableAdapter.Fill(booksDataSet.Orders);
                    break;

                case 1: ordersTableAdapter.Fillwithcustomerid(booksDataSet.Orders);
                    break;

                case 2: ordersTableAdapter.InsertQuery();
                    break;
            }
        }
    }
}