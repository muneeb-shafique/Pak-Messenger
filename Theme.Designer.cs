namespace Pak_Messenger
{
    partial class Theme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_dark = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.dark_move = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.dark_back = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.lbl.Location = new System.Drawing.Point(33, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(319, 56);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Color Theme";
            // 
            // lbl_dark
            // 
            this.lbl_dark.AutoSize = true;
            this.lbl_dark.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dark.ForeColor = System.Drawing.Color.Black;
            this.lbl_dark.Location = new System.Drawing.Point(63, 84);
            this.lbl_dark.Name = "lbl_dark";
            this.lbl_dark.Size = new System.Drawing.Size(182, 36);
            this.lbl_dark.TabIndex = 1;
            this.lbl_dark.Text = "Dark Theme";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.dark_move,
            this.dark_back,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(640, 515);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // dark_move
            // 
            this.dark_move.BackColor = System.Drawing.Color.Black;
            this.dark_move.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.dark_move.BorderColor = System.Drawing.Color.Black;
            this.dark_move.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dark_move.Location = new System.Drawing.Point(252, 93);
            this.dark_move.Name = "dark_move";
            this.dark_move.SelectionColor = System.Drawing.Color.Transparent;
            this.dark_move.Size = new System.Drawing.Size(21, 23);
            this.dark_move.Click += new System.EventHandler(this.ovalShape1_Click);
            // 
            // dark_back
            // 
            this.dark_back.BackColor = System.Drawing.Color.Transparent;
            this.dark_back.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.dark_back.BorderWidth = 2;
            this.dark_back.CornerRadius = 15;
            this.dark_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dark_back.FillGradientColor = System.Drawing.Color.Black;
            this.dark_back.Location = new System.Drawing.Point(247, 89);
            this.dark_back.Name = "dark_back";
            this.dark_back.SelectionColor = System.Drawing.Color.Transparent;
            this.dark_back.Size = new System.Drawing.Size(54, 31);
            this.dark_back.Click += new System.EventHandler(this.rectangleShape2_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 1;
            this.rectangleShape1.Location = new System.Drawing.Point(27, 40);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Size = new System.Drawing.Size(591, 445);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(65)))), ((int)(((byte)(28)))));
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.Location = new System.Drawing.Point(495, 420);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_apply.Size = new System.Drawing.Size(102, 47);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.lbl_dark);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Theme";
            this.Size = new System.Drawing.Size(640, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_dark;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape dark_move;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape dark_back;
        private System.Windows.Forms.Button btn_apply;
    }
}
