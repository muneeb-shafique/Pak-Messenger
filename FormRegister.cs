using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pak_Messenger
{
    public partial class FormRegister : Form
    {
        int i = 1;
        string ver;
        string num;
        string verify;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timer_validate.Start();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            // Checking for errors //
            // try 1 starts //
            try 
	        {
                if (i < 1)
                {
                    
                }
                else
                {
                    Random rand = new Random();
                    ver = rand.Next(100000, 999999).ToString();
                    verify = "Your Pak Messenger Verification code is: " + ver;
                    WebClient client = new WebClient();
                    //Call web api to send sms messages
                    Stream s = client.OpenRead(string.Format("http://api.clickatell.com/http/sendmsg?user=muneeb512&password=@Edmin786&api_id=4ElzcHbfR_6MiWipW9qTMw==&to={0}&text={1}", num, verify));
                    StreamReader reader = new StreamReader(s);
                    btn_request.Text = "Send Code Again";
                    btn_request.Enabled = false;

                    lbl_sms.ForeColor = Color.Black;
                    txt_sms.Enabled = true;
                    btn_confirm.FlatAppearance.BorderSize = 2;
                    btn_confirm.Enabled = true;
                    txt_name.Enabled = false;
                    txt_phone.Enabled = false;
                    txt_country.Enabled = false;

                    txt_sms.Enabled = true;

                    lbl_phone.ForeColor = Color.DarkGray;
                    lbl_name.ForeColor = Color.DarkGray;

                    btn_request.FlatAppearance.BorderSize = 0;
                    btn_request.Text = "Send Code Again";
                    num = txt_country.Text + txt_phone.Text;
                }
            }
            catch(Exception F)
            {
                MessageBox.Show(F.Message);
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 08))
            {
                if (!Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_country_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 08))
            {
                if (!Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 08))
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                e.Cancel = true;
                txt_phone.Focus();
                err_validate.SetError(txt_name, "Please Fill this feild!!");
            }
            else
            {
                err_validate.SetError(txt_name, null);
            }
        }

        private void txt_phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_phone.Text))
            {
                e.Cancel = true;
                txt_phone.Focus();
                err_validate.SetError(txt_phone, "Please Fill this feild!!");
            }
            else
            {
                err_validate.SetError(txt_phone, null);
            }

            if (txt_phone.TextLength != 10)
            {
                e.Cancel = true;
                txt_phone.Focus();
                err_validate.SetError(txt_phone, "Please Enter valid phone number!!");
            }
            else
            {
                err_validate.SetError(txt_phone, null);
            }
        }

        private void txt_country_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_country.Text))
            {
                e.Cancel = true;
                txt_phone.Focus();
                err_validate.SetError(txt_country, "Please Fill this feild!!");
            }
            else
            {
                err_validate.SetError(txt_country, null);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.phone = txt_phone.Text;
            Properties.Settings.Default.country = txt_country.Text;
            Properties.Settings.Default.Remember = true;
            Properties.Settings.Default.Save();
            MainPage mg = new MainPage();
            mg.Show();
            this.Hide();
        }

        private void timer_validate_Tick(object sender, EventArgs e)
        {
            if (txt_country.Text != "" && txt_phone.Text != "" && txt_name.Text != "")
            {
                btn_request.Enabled = true;
            }
            else
            {
                btn_request.Enabled = false;
            }
            if (txt_sms.Text != "")
            {
                btn_confirm.Enabled = true;
            }
            else
            {
                btn_confirm.Enabled = false;
            }
        }
    }
}