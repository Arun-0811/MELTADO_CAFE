namespace MELTADO_CAFE
{
    partial class ResetPassword_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword_Page));
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            lbl_email = new Label();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            btn_movesignin = new Button();
            txt_newpwd = new TextBox();
            lbl_pwd = new Label();
            btn_save = new Button();
            label1 = new Label();
            txt_confirmpwd = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(670, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 25;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_max
            // 
            btn_max.BackColor = Color.Lime;
            btn_max.FlatStyle = FlatStyle.Popup;
            btn_max.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_max.Location = new Point(643, 3);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(21, 19);
            btn_max.TabIndex = 27;
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.BackColor = Color.Yellow;
            btn_min.FlatStyle = FlatStyle.Popup;
            btn_min.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_min.Location = new Point(616, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 29;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(219, 173);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(86, 20);
            lbl_email.TabIndex = 28;
            lbl_email.Text = "User Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(288, 38);
            label4.Name = "label4";
            label4.Size = new Size(179, 31);
            label4.TabIndex = 32;
            label4.Text = "MELTADO CAFE";
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(328, 171);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(183, 27);
            txt_email.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 110);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 31;
            label3.Text = "RESET PASSWORD";
            // 
            // btn_movesignin
            // 
            btn_movesignin.Location = new Point(207, 358);
            btn_movesignin.Name = "btn_movesignin";
            btn_movesignin.Size = new Size(123, 29);
            btn_movesignin.TabIndex = 30;
            btn_movesignin.Text = "Move to Sign In";
            btn_movesignin.UseVisualStyleBackColor = true;
            // 
            // txt_newpwd
            // 
            txt_newpwd.BorderStyle = BorderStyle.FixedSingle;
            txt_newpwd.Location = new Point(328, 235);
            txt_newpwd.Name = "txt_newpwd";
            txt_newpwd.PasswordChar = '*';
            txt_newpwd.Size = new Size(183, 27);
            txt_newpwd.TabIndex = 23;
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Location = new Point(190, 242);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(115, 20);
            lbl_pwd.TabIndex = 26;
            lbl_pwd.Text = "New Password : ";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(417, 358);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 24;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 300);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 26;
            label1.Text = "Confirm Password :";
            // 
            // txt_confirmpwd
            // 
            txt_confirmpwd.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmpwd.Location = new Point(328, 293);
            txt_confirmpwd.Name = "txt_confirmpwd";
            txt_confirmpwd.PasswordChar = '*';
            txt_confirmpwd.Size = new Size(183, 27);
            txt_confirmpwd.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 450);
            panel1.TabIndex = 34;
            // 
            // ResetPassword_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_close);
            Controls.Add(btn_max);
            Controls.Add(btn_min);
            Controls.Add(lbl_email);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(btn_movesignin);
            Controls.Add(txt_confirmpwd);
            Controls.Add(label1);
            Controls.Add(txt_newpwd);
            Controls.Add(lbl_pwd);
            Controls.Add(btn_save);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPassword_Page";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
        private Label lbl_email;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private Button btn_movesignin;
        private TextBox txt_newpwd;
        private Label lbl_pwd;
        private Button btn_save;
        private Label label1;
        private TextBox txt_confirmpwd;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}