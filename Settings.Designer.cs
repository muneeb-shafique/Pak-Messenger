namespace Pak_Messenger
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.side_bar = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.theme1 = new Pak_Messenger.Theme();
            this.btn_close = new System.Windows.Forms.Button();
            this.side_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_bar
            // 
            this.side_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.side_bar.Controls.Add(this.btn_close);
            this.side_bar.Controls.Add(this.btn_Add);
            this.side_bar.Controls.Add(this.label);
            this.side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_bar.Location = new System.Drawing.Point(0, 0);
            this.side_bar.Name = "side_bar";
            this.side_bar.Size = new System.Drawing.Size(186, 515);
            this.side_bar.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(0, 150);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Add.Size = new System.Drawing.Size(186, 47);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Theme";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(45, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.theme1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(186, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 515);
            this.panel2.TabIndex = 1;
            // 
            // theme1
            // 
            this.theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme1.Location = new System.Drawing.Point(0, 0);
            this.theme1.Name = "theme1";
            this.theme1.Size = new System.Drawing.Size(640, 515);
            this.theme1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 43);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.side_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Leave += new System.EventHandler(this.Settings_Leave);
            this.side_bar.ResumeLayout(false);
            this.side_bar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel2;
        private Theme theme1;
        public System.Windows.Forms.Panel side_bar;
        private System.Windows.Forms.Button btn_close;
    }
}