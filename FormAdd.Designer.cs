namespace Pak_Messenger
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_friendid = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_add.Location = new System.Drawing.Point(379, 39);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(65, 33);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_friendid
            // 
            this.txt_friendid.AcceptsReturn = false;
            this.txt_friendid.AcceptsTab = false;
            this.txt_friendid.AnimationSpeed = 220;
            this.txt_friendid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_friendid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_friendid.BackColor = System.Drawing.Color.Transparent;
            this.txt_friendid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_friendid.BackgroundImage")));
            this.txt_friendid.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.txt_friendid.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_friendid.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.txt_friendid.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_friendid.BorderRadius = 1;
            this.txt_friendid.BorderThickness = 1;
            this.txt_friendid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_friendid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_friendid.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_friendid.DefaultText = "";
            this.txt_friendid.FillColor = System.Drawing.Color.White;
            this.txt_friendid.HideSelection = true;
            this.txt_friendid.IconLeft = null;
            this.txt_friendid.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_friendid.IconPadding = 10;
            this.txt_friendid.IconRight = null;
            this.txt_friendid.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_friendid.Lines = new string[0];
            this.txt_friendid.Location = new System.Drawing.Point(12, 37);
            this.txt_friendid.MaxLength = 32767;
            this.txt_friendid.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_friendid.Modified = false;
            this.txt_friendid.Multiline = false;
            this.txt_friendid.Name = "txt_friendid";
            this.txt_friendid.PasswordChar = '\0';
            this.txt_friendid.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_friendid.PlaceholderText = "Friend Id";
            this.txt_friendid.ReadOnly = false;
            this.txt_friendid.SelectedText = "";
            this.txt_friendid.SelectionLength = 0;
            this.txt_friendid.SelectionStart = 0;
            this.txt_friendid.ShortcutsEnabled = true;
            this.txt_friendid.Size = new System.Drawing.Size(361, 35);
            this.txt_friendid.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_friendid.TabIndex = 0;
            this.txt_friendid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_friendid.TextMarginLeft = 5;
            this.txt_friendid.TextMarginTop = 0;
            this.txt_friendid.TextPlaceholder = "Friend Id";
            this.txt_friendid.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter friend id";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 85);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_friendid);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_friendid;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
    }
}