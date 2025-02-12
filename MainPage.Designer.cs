namespace Pak_Messenger
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_friend_id = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_message = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txt_panel = new System.Windows.Forms.Timer(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_myid = new System.Windows.Forms.Button();
            this.list_friends = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_d = new System.Windows.Forms.Panel();
            this.btn_fadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_visible = new System.Windows.Forms.Timer(this.components);
            this.timer_invisible = new System.Windows.Forms.Timer(this.components);
            this.chat = new System.Windows.Forms.WebBrowser();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.list_friends.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txt_friend_id);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 47);
            this.panel1.TabIndex = 0;
            // 
            // txt_friend_id
            // 
            this.txt_friend_id.AcceptsReturn = false;
            this.txt_friend_id.AcceptsTab = false;
            this.txt_friend_id.AnimationSpeed = 220;
            this.txt_friend_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_friend_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_friend_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_friend_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_friend_id.BackgroundImage")));
            this.txt_friend_id.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.txt_friend_id.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_friend_id.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.txt_friend_id.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_friend_id.BorderRadius = 1;
            this.txt_friend_id.BorderThickness = 1;
            this.txt_friend_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_friend_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_friend_id.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_friend_id.DefaultText = "";
            this.txt_friend_id.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_friend_id.FillColor = System.Drawing.Color.White;
            this.txt_friend_id.HideSelection = true;
            this.txt_friend_id.IconLeft = null;
            this.txt_friend_id.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_friend_id.IconPadding = 10;
            this.txt_friend_id.IconRight = null;
            this.txt_friend_id.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_friend_id.Lines = new string[0];
            this.txt_friend_id.Location = new System.Drawing.Point(857, 0);
            this.txt_friend_id.MaxLength = 32767;
            this.txt_friend_id.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_friend_id.Modified = false;
            this.txt_friend_id.Multiline = false;
            this.txt_friend_id.Name = "txt_friend_id";
            this.txt_friend_id.PasswordChar = '\0';
            this.txt_friend_id.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_friend_id.PlaceholderText = "Add Friend Id";
            this.txt_friend_id.ReadOnly = false;
            this.txt_friend_id.SelectedText = "";
            this.txt_friend_id.SelectionLength = 0;
            this.txt_friend_id.SelectionStart = 0;
            this.txt_friend_id.ShortcutsEnabled = true;
            this.txt_friend_id.Size = new System.Drawing.Size(267, 47);
            this.txt_friend_id.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_friend_id.TabIndex = 4;
            this.txt_friend_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_friend_id.TextMarginLeft = 5;
            this.txt_friend_id.TextMarginTop = 0;
            this.txt_friend_id.TextPlaceholder = "Add Friend Id";
            this.txt_friend_id.UseSystemPasswordChar = false;
            this.txt_friend_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_friend_id_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Add.Enabled = false;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_Add.Location = new System.Drawing.Point(1124, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(77, 47);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pak_Messenger.Properties.Resources.pak_logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = global::Pak_Messenger.Properties.Resources.menu_dot;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(1201, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(24, 47);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pak Messenger";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.84873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.151268F));
            this.tableLayoutPanel1.Controls.Add(this.btn_send, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(274, 681);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.BackgroundImage = global::Pak_Messenger.Properties.Resources.send;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Location = new System.Drawing.Point(905, 3);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(43, 44);
            this.btn_send.TabIndex = 2;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_message);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 44);
            this.panel2.TabIndex = 2;
            // 
            // txt_message
            // 
            this.txt_message.AcceptsReturn = false;
            this.txt_message.AcceptsTab = false;
            this.txt_message.AnimationSpeed = 220;
            this.txt_message.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_message.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_message.BackColor = System.Drawing.Color.Transparent;
            this.txt_message.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_message.BackgroundImage")));
            this.txt_message.BorderColorActive = System.Drawing.Color.White;
            this.txt_message.BorderColorDisabled = System.Drawing.Color.White;
            this.txt_message.BorderColorHover = System.Drawing.Color.White;
            this.txt_message.BorderColorIdle = System.Drawing.Color.White;
            this.txt_message.BorderRadius = 1;
            this.txt_message.BorderThickness = 1;
            this.txt_message.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_message.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_message.DefaultText = "";
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_message.FillColor = System.Drawing.Color.White;
            this.txt_message.HideSelection = true;
            this.txt_message.IconLeft = null;
            this.txt_message.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_message.IconPadding = 10;
            this.txt_message.IconRight = null;
            this.txt_message.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_message.Lines = new string[0];
            this.txt_message.Location = new System.Drawing.Point(0, 0);
            this.txt_message.MaxLength = 32767;
            this.txt_message.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_message.Modified = false;
            this.txt_message.Multiline = false;
            this.txt_message.Name = "txt_message";
            this.txt_message.PasswordChar = '\0';
            this.txt_message.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_message.PlaceholderText = "Enter text";
            this.txt_message.ReadOnly = false;
            this.txt_message.SelectedText = "";
            this.txt_message.SelectionLength = 0;
            this.txt_message.SelectionStart = 0;
            this.txt_message.ShortcutsEnabled = true;
            this.txt_message.Size = new System.Drawing.Size(896, 44);
            this.txt_message.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_message.TabIndex = 0;
            this.txt_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_message.TextMarginLeft = 5;
            this.txt_message.TextMarginTop = 0;
            this.txt_message.TextPlaceholder = "Enter text";
            this.txt_message.UseSystemPasswordChar = false;
            this.txt_message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_message_KeyPress);
            // 
            // txt_panel
            // 
            this.txt_panel.Interval = 1;
            this.txt_panel.Tick += new System.EventHandler(this.txt_panel_Tick);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.Control;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.btn_settings);
            this.panel_menu.Controls.Add(this.btn_myid);
            this.panel_menu.Location = new System.Drawing.Point(1007, 47);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 111);
            this.panel_menu.TabIndex = 3;
            this.panel_menu.Visible = false;
            this.panel_menu.Leave += new System.EventHandler(this.panel_menu_Leave);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_settings.Location = new System.Drawing.Point(0, 49);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(198, 49);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_myid
            // 
            this.btn_myid.BackColor = System.Drawing.Color.Transparent;
            this.btn_myid.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_myid.FlatAppearance.BorderSize = 0;
            this.btn_myid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_myid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_myid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_myid.Location = new System.Drawing.Point(0, 0);
            this.btn_myid.Name = "btn_myid";
            this.btn_myid.Size = new System.Drawing.Size(198, 49);
            this.btn_myid.TabIndex = 3;
            this.btn_myid.Text = "My FriendId";
            this.btn_myid.UseVisualStyleBackColor = false;
            this.btn_myid.Click += new System.EventHandler(this.btn_myid_Click);
            // 
            // list_friends
            // 
            this.list_friends.BackColor = System.Drawing.SystemColors.Control;
            this.list_friends.Controls.Add(this.webBrowser1);
            this.list_friends.Controls.Add(this.panel3);
            this.list_friends.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_friends.Location = new System.Drawing.Point(0, 47);
            this.list_friends.Name = "list_friends";
            this.list_friends.Size = new System.Drawing.Size(274, 684);
            this.list_friends.TabIndex = 4;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 63);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(274, 621);
            this.webBrowser1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_d);
            this.panel3.Controls.Add(this.btn_fadd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 63);
            this.panel3.TabIndex = 8;
            // 
            // panel_d
            // 
            this.panel_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.panel_d.Location = new System.Drawing.Point(1, 59);
            this.panel_d.Name = "panel_d";
            this.panel_d.Size = new System.Drawing.Size(273, 2);
            this.panel_d.TabIndex = 6;
            // 
            // btn_fadd
            // 
            this.btn_fadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fadd.FlatAppearance.BorderSize = 0;
            this.btn_fadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_fadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_fadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fadd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_fadd.Location = new System.Drawing.Point(225, 6);
            this.btn_fadd.Name = "btn_fadd";
            this.btn_fadd.Size = new System.Drawing.Size(47, 47);
            this.btn_fadd.TabIndex = 7;
            this.btn_fadd.Text = "+";
            this.btn_fadd.UseVisualStyleBackColor = true;
            this.btn_fadd.Click += new System.EventHandler(this.btn_fadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(80, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Friend List";
            // 
            // timer_visible
            // 
            this.timer_visible.Interval = 1;
            this.timer_visible.Tick += new System.EventHandler(this.timer_animate_Tick);
            // 
            // timer_invisible
            // 
            this.timer_invisible.Interval = 1;
            this.timer_invisible.Tick += new System.EventHandler(this.timer_invisible_Tick);
            // 
            // chat
            // 
            this.chat.CausesValidation = false;
            this.chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat.Location = new System.Drawing.Point(274, 47);
            this.chat.MinimumSize = new System.Drawing.Size(20, 20);
            this.chat.Name = "chat";
            this.chat.ScriptErrorsSuppressed = true;
            this.chat.Size = new System.Drawing.Size(951, 634);
            this.chat.TabIndex = 5;
            this.chat.Url = new System.Uri("C:\\Users\\munee\\Documents\\Visual Studio 2012\\Projects\\Pak Messenger\\Pak Messenger\\" +
        "bin\\Debug\\Data\\Main\\main.html", System.UriKind.Absolute);
            // 
            // timer_menu
            // 
            this.timer_menu.Interval = 1;
            this.timer_menu.Tick += new System.EventHandler(this.timer_menu_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 731);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.list_friends);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(657, 623);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.list_friends.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_message;
        private System.Windows.Forms.Timer txt_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_Add;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_friend_id;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_myid;
        private System.Windows.Forms.Panel list_friends;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Timer timer_visible;
        private System.Windows.Forms.Timer timer_invisible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_d;
        private System.Windows.Forms.WebBrowser chat;
        private System.Windows.Forms.Timer timer_menu;
        private System.Windows.Forms.Button btn_fadd;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel3;

    }
}