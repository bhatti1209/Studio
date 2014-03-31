using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FileEncryption
{
    public partial class Form1 : Form
    {
        string filename1;
        string filename2;
        string filename3;
        string filename4;

        byte[] cipherbytes;
        byte[] key;
        byte[] r;
        byte[] r1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.RestoreDirectory = true;
            od.ShowDialog();
            filename1 = od.FileName;
            origianlfilebox.Text = filename1;

            //entering the .enc extension to the file to be saved
            filename2 += filename1 + ".enc";

            encryptionfilebox.Text = filename2;
        }

        SymmetricAlgorithm CreateSymmetricAlgorithm()
        {
            if (DESButton.Checked == true)
                return DES.Create();
            if (RijndaelButton.Checked == true)
                return Rijndael.Create();
            if (RC2Button.Checked == true)
                return RC2.Create();
            if (TDESButton.Checked == true)
                return TripleDES.Create();
            return null;
        }

        void checkkey1()
        {
            if (DESButton.Checked == true)
            {
                string t = Convert.ToString(KeyTextBox.Text);
                if (t.Length == 8)
                    key = Encoding.UTF8.GetBytes(KeyTextBox.Text);
                else
                    MessageBox.Show("Please Enter \"64\" Bit Key (8 Chars)");
            }

            if (TDESButton.Checked == true)
            {
                string t = Convert.ToString(KeyTextBox.Text);
                if (t.Length == 24)
                    key = Encoding.UTF8.GetBytes(KeyTextBox.Text);
                else
                    MessageBox.Show("Please Enter \"192\" Bit Key (24 Chars)");
            }

            if (RijndaelButton.Checked == true)
            {
                string t = Convert.ToString(KeyTextBox.Text);
                if (t.Length == 32)
                    key = Encoding.UTF8.GetBytes(KeyTextBox.Text);
                else
                    MessageBox.Show("Please Enter \"256\" Bit Key (32 Chars)");
            }

            if (RC2Button.Checked == true)
            {
                string t = Convert.ToString(KeyTextBox.Text);
                if (t.Length == 16)
                    key = Encoding.UTF8.GetBytes(KeyTextBox.Text);
                else
                    MessageBox.Show("Please Enter \"128\" Bit Key (16 Chars)");
            }
        }

        private void Encryptbutton_Click(object sender, EventArgs e)
        {
            if (KeyTextBox.Text == "")
                MessageBox.Show("Please Enter Password For Encryption Of File");
            else
            {
                checkkey1();

                FileStream a1 = new FileStream(filename1, FileMode.Open, FileAccess.ReadWrite);
                int len = (int)a1.Length;
                r = new byte[len];
                a1.Read(r, 0, len);
                a1.Close();

                SymmetricAlgorithm sa = CreateSymmetricAlgorithm();
                sa.Key = key;
                sa.Mode = CipherMode.ECB;
                sa.Padding = PaddingMode.PKCS7;

                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(r, 0, r.Length);
                cs.Close();
                cipherbytes = ms.ToArray();
                ms.Close();

                FileStream a2 = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                a2.Write(cipherbytes, 0, cipherbytes.Length);
                a2.Close();

                MessageBox.Show("File Encrypted Successfully");
            }
        }

        void checkkey2()
        {
            if (DESButton2.Checked == true)
            {
                string t = Convert.ToString(decryptpassbox.Text);
                if (t.Length == 8)
                    key = Encoding.UTF8.GetBytes(decryptpassbox.Text);
                else
                    MessageBox.Show("Please Enter \"64\" Bit Key (8 Chars)");
            }

            if (TDESButton2.Checked == true)
            {
                string t = Convert.ToString(decryptpassbox.Text);
                if (t.Length == 24)
                    key = Encoding.UTF8.GetBytes(decryptpassbox.Text);
                else
                    MessageBox.Show("Please Enter \"192\" Bit Key (24 Chars)");
            }

            if (RijndaelButton2.Checked == true)
            {
                string t = Convert.ToString(decryptpassbox.Text);
                if (t.Length == 32)
                    key = Encoding.UTF8.GetBytes(decryptpassbox.Text);
                else
                    MessageBox.Show("Please Enter \"256\" Bit Key (32 Chars)");
            }

            if (RC2Button2.Checked == true)
            {
                string t = Convert.ToString(decryptpassbox.Text);
                if (t.Length == 16)
                    key = Encoding.UTF8.GetBytes(decryptpassbox.Text);
                else
                    MessageBox.Show("Please Enter \"128\" Bit Key (16 Chars)");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.RestoreDirectory = true;
            od.ShowDialog();
            filename3 = od.FileName;
            decryptencryptedbox.Text = filename3;

            //removing the .enc extension to the file to be saved
            filename4 = "";
            int len = filename3.Length;

            for (int y = 0; y < (len - 4); y++)
                filename4 += filename3[y];

            decryptoriginalbox.Text = filename4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (decryptpassbox.Text == "")
                MessageBox.Show("Please Enter Password For Encryption Of File");
            else
            {
                checkkey2();

                FileStream a1 = new FileStream(filename3, FileMode.Open, FileAccess.ReadWrite);

                r1 = new byte[a1.Length];
                a1.Seek(0, SeekOrigin.Begin);
                a1.Read(r1, 0, r1.Length);
                a1.Close();

                try
                {
                    SymmetricAlgorithm sa = CreateSymmetricAlgorithm();
                    sa.Key = key;
                    sa.Mode = CipherMode.ECB;
                    sa.Padding = PaddingMode.PKCS7;

                    MemoryStream ms = new MemoryStream(r1);
                    CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);

                    byte[] plainbyte = new Byte[r1.Length];
                    cs.Read(plainbyte, 0, r1.Length);
                    cs.Close();
                    ms.Close();

                    FileStream a2 = new FileStream(filename4, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    a2.Write(plainbyte, 0, plainbyte.Length);
                    a2.Close();

                    MessageBox.Show("File Decrypted Successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("Decryption Failed !!");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.Start("TestApp.exe");
        }
    }
}