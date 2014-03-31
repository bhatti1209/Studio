using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TextEncryption
{
    public partial class TextEncrypt : Form
    {
        //for asymmetric ciphers
        RSAParameters rsaparams;
        DSAParameters dsaparams;
        byte[] rsacipherbyte;
        byte[] rsasignaturebytes;
        byte[] dsasignaturebytes;

        //for symmetric cipher
        CipherMode mode;
        PaddingMode padding;
        byte[] key;
        byte[] IV;
        byte[] cipherbytes;

        public TextEncrypt()
        {
            InitializeComponent();
        }

        private void RijndaelButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RijndaelButton.Checked == true)
            {
                ZerosButton.Enabled = false;
                NoneButton.Enabled = false;
                PKCS7Button.Checked = true;
            }
            else
            {
                ZerosButton.Enabled = true;
            }

            KeyTextBox.Text = "";
            Encryptbutton.Enabled = true;
            PlainTextBox.Text = "";
            CipherTextBox1.Text = "";
            DecryptTextBox.Text = "";
            Decryptbutton.Enabled = false;
        }

        private void EstablishMode()
        {
            if (ECBButton.Checked == true)
                mode = CipherMode.ECB;
            if (CBCButton.Checked == true)
                mode = CipherMode.CBC;
            if (CFBButton.Checked == true)
                mode = CipherMode.CFB;
            if (CTSButton.Checked == true)
                mode = CipherMode.CTS;
        }

        private void EstablishPadding()
        {
            if (PKCS7Button.Checked == true)
                padding = PaddingMode.PKCS7;
            if (ZerosButton.Checked == true)
                padding = PaddingMode.Zeros;
            if (NoneButton.Checked == true)
                padding = PaddingMode.None;
        }

        private void TextEncrypt_Load(object sender, EventArgs e)
        {
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

        private void Keybutton_Click(object sender, EventArgs e)
        {
            Encryptbutton.Enabled = true;

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
            CipherTextBox1.Text = "";

            EstablishMode();
            EstablishPadding();

            SymmetricAlgorithm sa = CreateSymmetricAlgorithm();
            
            sa.GenerateIV();
            if (KeyTextBox.Text == "")
                sa.GenerateKey();
            else
                sa.Key = key;

            key = sa.Key;
            IV = sa.IV;
            sa.Mode = mode;
            sa.Padding = padding;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] plaintext = Encoding.UTF8.GetBytes(PlainTextBox.Text);
            cs.Write(plaintext, 0, plaintext.Length);
            cs.Close();

            cipherbytes = ms.ToArray();
            ms.Close();

            CipherTextBox1.Text = Convert.ToBase64String(cipherbytes);

            Decryptbutton.Enabled = true;
            button2.Enabled = true;
        }

        private void Decryptbutton_Click(object sender, EventArgs e)
        {
            DecryptTextBox.Text = "";

            EstablishMode();
            EstablishPadding();

            SymmetricAlgorithm sa = CreateSymmetricAlgorithm();

            sa.Key = key;
            sa.IV = IV;
            sa.Mode = mode;
            sa.Padding = padding;

            MemoryStream ms = new MemoryStream(cipherbytes);
            CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);

            byte[] plainbyte = new Byte[cipherbytes.Length];
            cs.Read(plainbyte, 0, cipherbytes.Length);
            cs.Close();
            ms.Close();

            char[] a = Encoding.UTF8.GetChars(plainbyte);
            for (int q = 0; q < a.Length; q++)
                DecryptTextBox.Text += Convert.ToString(a[q]);
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTextBox.Text != "")
                Encryptbutton.Enabled = false;
            else
                Encryptbutton.Enabled = true;
        }

        private void TDESButton_CheckedChanged(object sender, EventArgs e)
        {
            KeyTextBox.Text = "";
            Encryptbutton.Enabled = true;
            PlainTextBox.Text = "";
            CipherTextBox1.Text = "";
            DecryptTextBox.Text = "";
            Decryptbutton.Enabled = false;
        }

        private void RC2Button_CheckedChanged(object sender, EventArgs e)
        {
            KeyTextBox.Text = "";
            Encryptbutton.Enabled = true;
            PlainTextBox.Text = "";
            CipherTextBox1.Text = "";
            DecryptTextBox.Text = "";
            Decryptbutton.Enabled = false;
        }

        private void DESButton_CheckedChanged(object sender, EventArgs e)
        {
            KeyTextBox.Text = "";
            Encryptbutton.Enabled = true;
            PlainTextBox.Text = "";
            CipherTextBox1.Text = "";
            DecryptTextBox.Text = "";
            Decryptbutton.Enabled = false;
        }

        private void newparameters_Click(object sender, EventArgs e)
        {
            RSACiphertextbox.Text = "";
            RSAPlaintextbox.Text = "";
            RSADecrypttextbox.Text = "";
            linkLabel1.LinkVisited = false;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //using xml files
            //provide public and private RSA params
            StreamWriter writer = new StreamWriter("TextEncryption\\PublicPrivateKey.xml");
            string publicPrivateKeyXML = rsa.ToXmlString(true);
            writer.Write(publicPrivateKeyXML);
            writer.Close();

            //provide public only RSA params
            writer = new StreamWriter("TextEncryption\\PublicOnlyKey.xml");
            string publicOnlyKeyXML = rsa.ToXmlString(false);
            writer.Write(publicOnlyKeyXML);
            writer.Close();

            pvaluebox.Text = publicPrivateKeyXML;
        }

        private void RSAEncryptbutton_Click(object sender, EventArgs e)
        {
            RSADecrypttextbox.Text = "";
            RSACiphertextbox.Text = "";
            //using xml
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            
            //public only RSA parameters for encrypt
            StreamReader reader = new StreamReader("TextEncryption\\PublicOnlyKey.xml");
            string publicOnlyKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicOnlyKeyXML);
            reader.Close();

            //read plaintext, encrypt it to ciphertext
            byte[] plainbytes = Encoding.UTF8.GetBytes(RSAPlaintextbox.Text);
            rsacipherbyte = rsa.Encrypt(plainbytes, false); //fOAEP needs high encryption pack

            RSACiphertextbox.Text = Convert.ToBase64String(rsacipherbyte);

            RSADecryptButton.Enabled = true;
            button4.Enabled = true;
        }

        private void RSADecryptButton_Click(object sender, EventArgs e)
        {
            RSADecrypttextbox.Text = "";
            //using xml
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //public and private RSA parameters for encrypt
            StreamReader reader = new StreamReader("TextEncryption\\PublicPrivateKey.xml");
            string publicPrivateKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicPrivateKeyXML);
            reader.Close();

            //read ciphertext, decrypt it to plaintext
            byte[] plaintext = rsa.Decrypt(rsacipherbyte, false); //fOAEP needs high encryption pack

            char[] a = Encoding.UTF8.GetChars(plaintext);
            for (int q = 0; q < a.Length; q++)
                RSADecrypttextbox.Text += Convert.ToString(a[q]);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("TextEncryption\\PublicPrivateKey.xml");
        }

        private void RSASignButton_Click(object sender, EventArgs e)
        {
            RSAHashMessageDigest.Text = "";
            RSAEncryptedMessageDigest.Text = "";

            byte[] messagebytes = Encoding.UTF8.GetBytes(RSAMessageBox.Text);

            //create digest of original message using SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);
            
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsasignaturebytes = rsa.SignHash(hashbytes, "1.3.14.3.2.26");
            rsaparams = rsa.ExportParameters(false);

            //savin the RSA details in an XML File
            StreamWriter w = new StreamWriter("TextEncryption\\RSADetails.xml");
            string val = rsa.ToXmlString(true);
            w.Write(val);
            w.Close();

            //displayin the obtained codes in text form
            char[] a = Encoding.UTF8.GetChars(hashbytes);
            for (int q = 0; q < a.Length; q++)
                RSAHashMessageDigest.Text += Convert.ToString(a[q]);

            char[] b = Encoding.UTF8.GetChars(rsasignaturebytes);
            for (int q = 0; q < b.Length; q++)
                RSAEncryptedMessageDigest.Text += Convert.ToString(b[q]);

            RSAVerifyButton.Enabled = true;
        }

        private void RSAVerifyButton_Click(object sender, EventArgs e)
        {
            byte[] messagebytes = Encoding.UTF8.GetBytes(RSAMessageBox.Text);

            //create digest of original message using SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);

            //create RSA object using parameters from signing
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(rsaparams);

            //do verification on hash using OID for SHA-1
            bool match = rsa.VerifyHash(hashbytes, "1.3.14.3.2.26", rsasignaturebytes);

            if (match == true)
                MessageBox.Show("RSA Digital Signature Verified");
            else
                MessageBox.Show("RSA Signature Not Verified");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;

            System.Diagnostics.Process.Start("TextEncryption\\RSADetails.xml");
        }

        private void DSASignButton_Click(object sender, EventArgs e)
        {
            DSAHashMessageDigest.Text = "";
            DSAEncryptedMessageDigest.Text = "";

            byte[] messagebytes = Encoding.UTF8.GetBytes(DSAMessageBox.Text);

            //create digest of original message using SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);

            DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
            dsasignaturebytes = dsa.SignHash(hashbytes, "1.3.14.3.2.26");
            dsaparams = dsa.ExportParameters(false);

            //savin the RSA details in an XML File
            StreamWriter w = new StreamWriter("TextEncryption\\DSADetails.xml");
            string val = dsa.ToXmlString(true);
            w.Write(val);
            w.Close();

            //displayin the obtained codes in text form
            char[] a = Encoding.UTF8.GetChars(hashbytes);
            for (int q = 0; q < a.Length; q++)
                DSAHashMessageDigest.Text += Convert.ToString(a[q]);

            char[] b = Encoding.UTF8.GetChars(dsasignaturebytes);
            for (int q = 0; q < b.Length; q++)
                DSAEncryptedMessageDigest.Text += Convert.ToString(b[q]);

            DSAVerifyButton.Enabled = true;
        }

        private void DSAVerifyButton_Click(object sender, EventArgs e)
        {
            byte[] messagebytes = Encoding.UTF8.GetBytes(DSAMessageBox.Text);

            //create digest of original message using SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);

            //create RSA object using parameters from signing
            DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
            dsa.ImportParameters(dsaparams);

            //do verification on hash using OID for SHA-1
            bool match = dsa.VerifyHash(hashbytes, "1.3.14.3.2.26", dsasignaturebytes);

            if (match == true)
                MessageBox.Show("DSA Digital Signature Verified");
            else
                MessageBox.Show("DSA Signature Not Verified");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;

            System.Diagnostics.Process.Start("TextEncryption\\DSADetails.xml");
        }

        private void TextEncrypt_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.Start("TestApp.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.RestoreDirectory = true;
            DialogResult result = openfile.ShowDialog();

            if ( result == DialogResult.Cancel )
                return;

            string filename = openfile.FileName;
            FileStream a = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);

            int len = (int)a.Length;

            byte[] r = new byte[len];
            a.Read(r, 0, len);
            char[] t = Encoding.UTF8.GetChars(r);
            PlainTextBox.Text = "";
            for (int q = 0; q < t.Length; q++)
                PlainTextBox.Text += Convert.ToString(t[q]);
            a.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            DialogResult result = savefile.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            string filename = savefile.FileName;

            FileStream a = new FileStream(filename, FileMode.Truncate, FileAccess.Write);
            StreamWriter op = new StreamWriter(a);
            op.WriteLine(CipherTextBox1.Text);
            op.Close();
            a.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.RestoreDirectory = true;
            DialogResult result = openfile.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            string filename = openfile.FileName;
            FileStream a = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);

            int len = (int)a.Length;

            byte[] r = new byte[len];
            a.Read(r, 0, len);
            char[] t = Encoding.UTF8.GetChars(r);
            RSAPlaintextbox.Text = "";
            for (int q = 0; q < t.Length; q++)
                RSAPlaintextbox.Text += Convert.ToString(t[q]);
            a.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            DialogResult result = savefile.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            string filename = savefile.FileName;

            FileStream a = new FileStream(filename, FileMode.Truncate, FileAccess.Write);
            StreamWriter op = new StreamWriter(a);
            op.WriteLine(RSACiphertextbox.Text);
            op.Close();
            a.Close();
        }
    }
}