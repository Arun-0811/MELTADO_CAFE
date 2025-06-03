namespace MELTADO_CAFE
{
    partial class Login_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cmb_role = new ComboBox();
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            lnklbl_forgotpwd = new LinkLabel();
            btnClearall = new Button();
            btn_signin = new Button();
            txt_pwd = new TextBox();
            txt_uname = new TextBox();
            lbl_pwd = new Label();
            lbl_uname = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cmb_role);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(btn_max);
            panel1.Controls.Add(btn_min);
            panel1.Controls.Add(lnklbl_forgotpwd);
            panel1.Controls.Add(btnClearall);
            panel1.Controls.Add(btn_signin);
            panel1.Controls.Add(txt_pwd);
            panel1.Controls.Add(txt_uname);
            panel1.Controls.Add(lbl_pwd);
            panel1.Controls.Add(lbl_uname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 404);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // cmb_role
            // 
            cmb_role.FormattingEnabled = true;
            cmb_role.Location = new Point(199, 261);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(181, 28);
            cmb_role.TabIndex = 13;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(453, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 7;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_max
            // 
            btn_max.BackColor = Color.Lime;
            btn_max.FlatStyle = FlatStyle.Popup;
            btn_max.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_max.Location = new Point(426, 3);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(21, 19);
            btn_max.TabIndex = 8;
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.BackColor = Color.Yellow;
            btn_min.FlatStyle = FlatStyle.Popup;
            btn_min.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_min.Location = new Point(399, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 10;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // lnklbl_forgotpwd
            // 
            lnklbl_forgotpwd.AutoSize = true;
            lnklbl_forgotpwd.Location = new Point(22, 324);
            lnklbl_forgotpwd.Name = "lnklbl_forgotpwd";
            lnklbl_forgotpwd.Size = new Size(134, 20);
            lnklbl_forgotpwd.TabIndex = 5;
            lnklbl_forgotpwd.TabStop = true;
            lnklbl_forgotpwd.Text = "Forgot Password...?";
            lnklbl_forgotpwd.LinkClicked += lnklbl_forgotpwd_LinkClicked;
            // 
            // btnClearall
            // 
            btnClearall.Location = new Point(186, 315);
            btnClearall.Name = "btnClearall";
            btnClearall.Size = new Size(74, 29);
            btnClearall.TabIndex = 4;
            btnClearall.Text = "Clear All";
            btnClearall.UseVisualStyleBackColor = true;
            btnClearall.Click += btnClearall_Click;
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(305, 315);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(75, 29);
            btn_signin.TabIndex = 4;
            btn_signin.Text = "Sign In";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // txt_pwd
            // 
            txt_pwd.BorderStyle = BorderStyle.FixedSingle;
            txt_pwd.Location = new Point(197, 215);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(183, 27);
            txt_pwd.TabIndex = 3;
            // 
            // txt_uname
            // 
            txt_uname.BorderStyle = BorderStyle.FixedSingle;
            txt_uname.Location = new Point(197, 169);
            txt_uname.Name = "txt_uname";
            txt_uname.Size = new Size(183, 27);
            txt_uname.TabIndex = 2;
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Location = new Point(100, 218);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(77, 20);
            lbl_pwd.TabIndex = 0;
            lbl_pwd.Text = "Password :";
            // 
            // lbl_uname
            // 
            lbl_uname.AutoSize = true;
            lbl_uname.Location = new Point(88, 169);
            lbl_uname.Name = "lbl_uname";
            lbl_uname.Size = new Size(89, 20);
            lbl_uname.TabIndex = 0;
            lbl_uname.Text = "User Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(159, 45);
            label4.Name = "label4";
            label4.Size = new Size(179, 31);
            label4.TabIndex = 0;
            label4.Text = "MELTADO CAFE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 110);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "SIGN IN";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 404);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel lnklbl_forgotpwd;
        private Button btn_signin;
        private TextBox txt_uname;
        private Label label1;
        private TextBox txt_pwd;
        private Label lbl_pwd;
        private Label lbl_uname;
        private Button btn_min;
        private Button btn_close;
        private Button btn_max;
        private Label label4;
        private ComboBox cmb_role;
        private PictureBox pictureBox1;
        private Button btnClearall;
    }
}
