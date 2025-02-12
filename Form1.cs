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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer_load.Start();
        }

        private void timer_load_Tick(object sender, EventArgs e)
        {
            if (panel_loading.Width < 408)
            {
                panel_loading.Width += 5;
            }
            else
            {
                timer_load.Stop();
                if (Properties.Settings.Default.Remember == true)
                {
                    MainPage mg = new MainPage();
                    mg.Show();
                    this.Hide();
                }
                else
                {
                    FormRegister fr = new FormRegister();
                    fr.Show();
                    this.Hide();
                }
            }
        }
    }
}
