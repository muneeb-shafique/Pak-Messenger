using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pak_Messenger
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Leave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            MainPage mg = new MainPage();
            mg.Show();
            this.Hide();
        }
    }
}
