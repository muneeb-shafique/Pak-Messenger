using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Pak_Messenger
{
    public partial class FormAdd : Form
    {

        string hash = "PakMessenger";

        public FormAdd()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_friendid.Text != "")
            {
                try
                {
                    //Convert a string to byte array
                    byte[] data = Convert.FromBase64String(txt_friendid.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                        //Decrypt data by hash key
                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripDes.CreateDecryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            MessageBox.Show(UTF8Encoding.UTF8.GetString(results));
                            //txt_decrypted.Text = UTF8Encoding.UTF8.GetString(results);
                        }
                    }
                }
                catch (Exception F)
                {

                    MessageBox.Show("Please add valid friend id & " + F.Message);
                }
            }
        }
    }
}
