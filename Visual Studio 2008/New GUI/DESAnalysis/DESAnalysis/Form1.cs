using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace DESAnalysis
{
    public partial class DESAnalysis : Form
    {
        byte[] IV;
        byte[] key;
        byte[] cipherbytes;
        const int MAXVAL = 50000;

        public DESAnalysis()
        {
            InitializeComponent();
        }

        private void Encryptbutton_Click(object sender, EventArgs e)
        {
            string t = Convert.ToString(KeyTextBox.Text);
            if (t.Length == 8)
            {
                byte[] key = Encoding.UTF8.GetBytes(KeyTextBox.Text);

                CipherTextBox.Text = "";
                CipherMode mode = CipherMode.CFB;
                PaddingMode padding = PaddingMode.Zeros;

                SymmetricAlgorithm sa = DES.Create();

                sa.GenerateIV();
                IV = sa.IV;
                sa.Key = key;
                sa.Mode = mode;
                sa.Padding = padding;

                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);

                byte[] plaintext = Encoding.UTF8.GetBytes(PlainTextBox.Text);
                cs.Write(plaintext, 0, plaintext.Length);
                cs.Close();

                cipherbytes = ms.ToArray();
                ms.Close();

                CipherTextBox.Text = Convert.ToBase64String(cipherbytes);
                SuppliedCiphertextBox.Text = CipherTextBox.Text;
            }
            else
                MessageBox.Show("Please Enter \"64\" Bit Key (8 Chars)");
        }

        private void CryptaButton_Click(object sender, EventArgs e)
        {
            int q = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = MAXVAL;
            progressBar1.Minimum = 0;

            for (q = 0; q <= MAXVAL; q++)
            {
                progressBar1.Increment(1);
                string temp = Convert.ToString(q);
                int len = temp.Length;

                string t1 = "";
                for (int w = 0; w < (8 - len); w++)
                    t1 += "0";

                t1 += temp;
                key = Encoding.UTF8.GetBytes(t1);
                int res = decrypt(t1);

                if (res == 1)
                    break;
            }
        }

        private int decrypt(string value)
        {
            SymmetricAlgorithm sa = DES.Create();
            CipherMode mode = CipherMode.CFB;
            PaddingMode padding = PaddingMode.Zeros;

            sa.Key = key;
            sa.IV = IV;
            sa.Mode = mode;
            sa.Padding = padding;

            MemoryStream ms = new MemoryStream(cipherbytes);
            CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);

            byte[] plainbyte = new Byte[cipherbytes.Length];
            int ptl = cs.Read(plainbyte, 0, cipherbytes.Length);
            byte[] plntxt = new byte[ptl];
            Array.Copy(plainbyte, 0, plntxt, 0, ptl);

            string recoveredtext = "";
            char[] original = PlainTextBox.Text.ToCharArray();

            char[] a = Encoding.ASCII.GetChars(plntxt, 0, PlainTextBox.Text.Length);
            for (int q = 0; q < a.Length; q++)
                recoveredtext += Convert.ToString(a[q]);

            int l1 = recoveredtext.Length;
            int l2 = original.Length;

            int counter = 0;
            for (int e = 0; e < l2; e++)
            {
                if (recoveredtext[e] != original[e])
                    counter = 1;
            }
            if (counter == 0)
            {
                RecoveredPlaintextBox.Text = recoveredtext;
                ObtainedKeyTextBox.Text = value;
                return 1;
            }
            else
                return 0;
        }

        private void DESAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.Start("TestApp.exe");
        }
    }
}