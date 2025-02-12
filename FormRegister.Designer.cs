namespace Pak_Messenger
{
    partial class FormRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.btn_request = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txt_phone = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txt_country = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.err_validate = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer_validate = new System.Windows.Forms.Timer(this.components);
            this.lbl_sms = new System.Windows.Forms.Label();
            this.txt_sms = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err_validate)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_request
            // 
            this.btn_request.Enabled = false;
            this.btn_request.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_request.FlatAppearance.BorderSize = 0;
            this.btn_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_request.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_request.Location = new System.Drawing.Point(26, 195);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(350, 42);
            this.btn_request.TabIndex = 6;
            this.btn_request.Text = "Send Code";
            this.btn_request.UseVisualStyleBackColor = true;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.lbl_name.Location = new System.Drawing.Point(60, 162);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(92, 19);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "Full Name:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.lbl_phone.Location = new System.Drawing.Point(22, 121);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(144, 19);
            this.lbl_phone.TabIndex = 10;
            this.lbl_phone.Text = "Phone Number: +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.label4.Location = new System.Drawing.Point(91, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Verification";
            // 
            // txt_name
            // 
            this.txt_name.AcceptsReturn = false;
            this.txt_name.AcceptsTab = false;
            this.txt_name.AnimationSpeed = 220;
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_name.BackgroundImage")));
            this.txt_name.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_name.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_name.BorderRadius = 1;
            this.txt_name.BorderThickness = 1;
            this.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_name.DefaultText = "";
            this.txt_name.FillColor = System.Drawing.Color.White;
            this.txt_name.HideSelection = true;
            this.txt_name.IconLeft = null;
            this.txt_name.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.IconPadding = 10;
            this.txt_name.IconRight = null;
            this.txt_name.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(150, 154);
            this.txt_name.MaxLength = 32767;
            this.txt_name.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_name.Modified = false;
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name.PlaceholderText = "Name";
            this.txt_name.ReadOnly = false;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(226, 35);
            this.txt_name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_name.TabIndex = 3;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.TextMarginLeft = 5;
            this.txt_name.TextMarginTop = 0;
            this.txt_name.TextPlaceholder = "Name";
            this.txt_name.UseSystemPasswordChar = false;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_name_Validating);
            // 
            // txt_phone
            // 
            this.txt_phone.AcceptsReturn = false;
            this.txt_phone.AcceptsTab = false;
            this.txt_phone.AnimationSpeed = 220;
            this.txt_phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_phone.BackColor = System.Drawing.Color.Transparent;
            this.txt_phone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_phone.BackgroundImage")));
            this.txt_phone.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_phone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_phone.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_phone.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_phone.BorderRadius = 1;
            this.txt_phone.BorderThickness = 1;
            this.txt_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_phone.DefaultText = "";
            this.txt_phone.FillColor = System.Drawing.Color.White;
            this.txt_phone.HideSelection = true;
            this.txt_phone.IconLeft = null;
            this.txt_phone.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.IconPadding = 10;
            this.txt_phone.IconRight = null;
            this.txt_phone.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.Lines = new string[0];
            this.txt_phone.Location = new System.Drawing.Point(216, 113);
            this.txt_phone.MaxLength = 32767;
            this.txt_phone.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_phone.Modified = false;
            this.txt_phone.Multiline = false;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_phone.PlaceholderText = "Phone Number";
            this.txt_phone.ReadOnly = false;
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.ShortcutsEnabled = true;
            this.txt_phone.Size = new System.Drawing.Size(160, 35);
            this.txt_phone.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_phone.TabIndex = 2;
            this.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_phone.TextMarginLeft = 5;
            this.txt_phone.TextMarginTop = 0;
            this.txt_phone.TextPlaceholder = "Phone Number";
            this.txt_phone.UseSystemPasswordChar = false;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            this.txt_phone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phone_Validating);
            // 
            // txt_country
            // 
            this.txt_country.AcceptsReturn = false;
            this.txt_country.AcceptsTab = false;
            this.txt_country.AnimationSpeed = 220;
            this.txt_country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_country.BackColor = System.Drawing.Color.Transparent;
            this.txt_country.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_country.BackgroundImage")));
            this.txt_country.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_country.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_country.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_country.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_country.BorderRadius = 1;
            this.txt_country.BorderThickness = 1;
            this.txt_country.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_country.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_country.DefaultText = "92";
            this.txt_country.FillColor = System.Drawing.Color.White;
            this.txt_country.HideSelection = true;
            this.txt_country.IconLeft = null;
            this.txt_country.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_country.IconPadding = 10;
            this.txt_country.IconRight = null;
            this.txt_country.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_country.Lines = new string[] {
        "92"};
            this.txt_country.Location = new System.Drawing.Point(163, 113);
            this.txt_country.MaxLength = 32767;
            this.txt_country.MinimumSize = new System.Drawing.Size(10, 35);
            this.txt_country.Modified = false;
            this.txt_country.Multiline = false;
            this.txt_country.Name = "txt_country";
            this.txt_country.PasswordChar = '\0';
            this.txt_country.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_country.PlaceholderText = "";
            this.txt_country.ReadOnly = false;
            this.txt_country.SelectedText = "";
            this.txt_country.SelectionLength = 0;
            this.txt_country.SelectionStart = 2;
            this.txt_country.ShortcutsEnabled = true;
            this.txt_country.Size = new System.Drawing.Size(47, 35);
            this.txt_country.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_country.TabIndex = 1;
            this.txt_country.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_country.TextMarginLeft = 5;
            this.txt_country.TextMarginTop = 0;
            this.txt_country.TextPlaceholder = "";
            this.txt_country.UseSystemPasswordChar = false;
            this.txt_country.Validating += new System.ComponentModel.CancelEventHandler(this.txt_country_Validating);
            // 
            // err_validate
            // 
            this.err_validate.ContainerControl = this;
            this.err_validate.Icon = ((System.Drawing.Icon)(resources.GetObject("err_validate.Icon")));
            // 
            // timer_validate
            // 
            this.timer_validate.Tick += new System.EventHandler(this.timer_validate_Tick);
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sms.ForeColor = System.Drawing.Color.Silver;
            this.lbl_sms.Location = new System.Drawing.Point(50, 252);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(90, 19);
            this.lbl_sms.TabIndex = 14;
            this.lbl_sms.Text = "SMS Code:";
            // 
            // txt_sms
            // 
            this.txt_sms.AcceptsReturn = false;
            this.txt_sms.AcceptsTab = false;
            this.txt_sms.AnimationSpeed = 220;
            this.txt_sms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_sms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_sms.BackColor = System.Drawing.Color.Transparent;
            this.txt_sms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_sms.BackgroundImage")));
            this.txt_sms.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_sms.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_sms.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_sms.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_sms.BorderRadius = 1;
            this.txt_sms.BorderThickness = 1;
            this.txt_sms.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_sms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sms.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_sms.DefaultText = "";
            this.txt_sms.Enabled = false;
            this.txt_sms.FillColor = System.Drawing.Color.White;
            this.txt_sms.HideSelection = true;
            this.txt_sms.IconLeft = null;
            this.txt_sms.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sms.IconPadding = 10;
            this.txt_sms.IconRight = null;
            this.txt_sms.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sms.Lines = new string[0];
            this.txt_sms.Location = new System.Drawing.Point(150, 243);
            this.txt_sms.MaxLength = 32767;
            this.txt_sms.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_sms.Modified = false;
            this.txt_sms.Multiline = false;
            this.txt_sms.Name = "txt_sms";
            this.txt_sms.PasswordChar = '\0';
            this.txt_sms.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_sms.PlaceholderText = "SMS Code";
            this.txt_sms.ReadOnly = false;
            this.txt_sms.SelectedText = "";
            this.txt_sms.SelectionLength = 0;
            this.txt_sms.SelectionStart = 0;
            this.txt_sms.ShortcutsEnabled = true;
            this.txt_sms.Size = new System.Drawing.Size(226, 35);
            this.txt_sms.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_sms.TabIndex = 7;
            this.txt_sms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_sms.TextMarginLeft = 5;
            this.txt_sms.TextMarginTop = 0;
            this.txt_sms.TextPlaceholder = "SMS Code";
            this.txt_sms.UseSystemPasswordChar = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_confirm.Location = new System.Drawing.Point(26, 284);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(350, 42);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Verify";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 339);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sms);
            this.Controls.Add(this.lbl_sms);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_phone);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_validate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phone;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_phone;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_country;
        private System.Windows.Forms.ErrorProvider err_validate;
        private System.Windows.Forms.Timer timer_validate;
        private System.Windows.Forms.Button btn_confirm;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_sms;
        private System.Windows.Forms.Label lbl_sms;
    }
}