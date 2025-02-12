using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;
//using System.Text.RegularExpressions;

namespace Pak_Messenger
{
    public partial class MainPage : Form
    {
        string friendip;
        string id;
        WebClient download;
        WebClient updates;
        string myIP;
        string hash = "PakMessenger";
        public MainPage()
        {
            InitializeComponent();
        }

        private void txt_panel_Tick(object sender, EventArgs e)
        {
            txt_message.Width = panel2.Width - 6;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            Message();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Visible == false)
            {
                panel_menu.Visible = true;
                timer_visible.Start();
            }
            else
            {
                timer_invisible.Start();
            }
        }

        private void btn_myid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Friend Id is: " + id,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            friendip = id;
            txt_friend_id.Text = id;
        }

        private void btn_menu_Leave(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert a string to byte array
                byte[] data = Convert.FromBase64String(friendip);
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
            /*if (txt_friend_id.Text != "")
            {
                string message = txt_friend_id.Text;
                txt_friend_id.Text = "";
            }*/
        }

        private void txt_friend_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_friend_id.Text != "")
            {
                btn_Add.Enabled = true;
                if (e.KeyChar == 10)
                {
                    
                }
            }
            else
            {
                btn_Add.Enabled = false;
            }
        }

        private void panel_menu_Leave(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
        }

        private void timer_animate_Tick(object sender, EventArgs e)
        {
            if (panel_menu.Height <= 104)
            {
                panel_menu.Height += 4;
            }
            else
            {
                timer_visible.Stop();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dark == true)
            {
                /*panel1.BackColor = Color.Black;
                list_friends.BackColor = Color.Black;
                btn_fadd.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                panel_d.BackColor = Color.White;
                txt_message.FillColor = Color.Black;
                txt_message.ForeColor = Color.White;
                tableLayoutPanel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
                panel_menu.BackColor = Color.Black;
                btn_myid.ForeColor = Color.White;
                btn_settings.ForeColor = Color.White;*/
            }
            else
            {
                /*panel1.BackColor = Color.Black;
                list_friends.BackColor = Color.Black;
                btn_fadd.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                panel_d.BackColor = Color.White;
                txt_message.FillColor = Color.Black;
                txt_message.ForeColor = Color.White;
                tableLayoutPanel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;*/
            }
            timer_menu.Start();
            string hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            byte[] data = UTF8Encoding.UTF8.GetBytes(myIP);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Encrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    id = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private void timer_invisible_Tick(object sender, EventArgs e)
        {
            if (panel_menu.Height >= 2)
            {
                panel_menu.Height -= 4;
            }
            else
            {
                timer_invisible.Stop();
                panel_menu.Visible = false;
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            this.Hide();
        }

        private void timerh_Tick(object sender, EventArgs e)
        {
            chat.Refresh();
            txt_message.Focus();
        }

        // Sending Message //
        void Message()
        {
            if (txt_message.Text != "")
            {
                string message = "<div class='a'>\n" + txt_message.Text + "\n</div>\n<br>\n<br>\n<br>\n";
                message = (File.ReadAllText(@"Data/chat.html")).Replace("<a name='bottom'></a>", "") + message + "<a name='bottom'></a>";
                File.WriteAllText(@"Data/chat.html", message);
                txt_message.Text = "";
                chat.Refresh();
                chat.Document.Body.ScrollIntoView(false);
                //chat.Document.Window.ScrollTo(0, chat.Document.Window.Size.Height + 100);
            }
        }

        private void txt_message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                if (!Char.IsNumber(e.KeyChar))
                {
                    if (txt_message.Text != "")
                    {
                        Message();
                        MessageBox.Show("");
                    }
                }
            }
        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {
            panel_menu.Location = new System.Drawing.Point(this.Size.Width - 234, 47);
        }

        private void btn_fadd_Click(object sender, EventArgs e)
        {
            FormAdd fa = new FormAdd();
            fa.Show();
            this.Hide();
        }
    }
}