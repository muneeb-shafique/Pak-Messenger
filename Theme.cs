using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pak_Messenger
{
    public partial class Theme : UserControl
    {
        bool dark = false;
        public Theme()
        {
            InitializeComponent();
        }
        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            if (dark == false)
            {
                dark_back.BackColor = Color.Black;
                dark_move.Location = new Point(275, 93);
                dark_move.BackColor = Color.White;
                dark_move.BorderColor = Color.White;
                dark = true;
            }
            else
            {
                dark_back.BackColor = Color.White;
                dark_move.Location = new Point(252, 93);
                dark_move.BackColor = Color.Black;
                dark_move.BorderColor = Color.Black;
                dark = false;
            }
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            if (dark == false)
            {
                dark_back.BackColor = Color.Black;
                dark_move.Location = new Point(275, 93);
                dark_move.BackColor = Color.White;
                dark_move.BorderColor = Color.White;
                dark = true;
            }
            else
            {
                dark_back.BackColor = Color.White;
                dark_move.Location = new Point(252, 93);
                dark_move.BackColor = Color.Black;
                dark_move.BorderColor = Color.Black;
                dark = false;
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (dark == true)
            {
                Properties.Settings.Default.dark = true;
                Properties.Settings.Default.Save();
                Dark();
            }
            else
            {
                Properties.Settings.Default.dark = false;
                Properties.Settings.Default.Save();
                this.BackColor = Color.White;
                //lbl.ForeColor = Color.
                rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
                btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
                lbl_dark.ForeColor = Color.Black;
                dark_back.BorderColor = Color.Black;
                dark_back.BackColor = Color.White;
                dark_move.BorderColor = Color.Black;
                btn_apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
                lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            }
        }
        void Dark()
        {
            this.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
            rectangleShape1.BorderColor = Color.White;
            btn_apply.BackColor = Color.Black;
            lbl_dark.ForeColor = Color.White;
            dark_back.BorderColor = Color.White;
            dark_back.BackColor = Color.Black;
            dark_move.BackColor = Color.White;
            dark_move.BorderColor = Color.White;
            btn_apply.FlatAppearance.BorderColor = Color.White;

        }
    }
}
