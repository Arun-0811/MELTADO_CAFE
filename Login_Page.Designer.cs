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
            panel1 = new Panel();
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            toggleBtn = new MELTADO_CAFE.Controls.ToggleBtn();
            lmklbl_signup = new LinkLabel();
            lnklbl_forgotpwd = new LinkLabel();
            btn_signin = new Button();
            txt_pwd = new TextBox();
            txt_uname = new TextBox();
            lbl_pwd = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_uname = new Label();
            label4 = new Label();
            label1 = new Label();
            lbl_staff = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(btn_max);
            panel1.Controls.Add(btn_min);
            panel1.Controls.Add(toggleBtn);
            panel1.Controls.Add(lmklbl_signup);
            panel1.Controls.Add(lnklbl_forgotpwd);
            panel1.Controls.Add(btn_signin);
            panel1.Controls.Add(txt_pwd);
            panel1.Controls.Add(txt_uname);
            panel1.Controls.Add(lbl_pwd);
            panel1.Controls.Add(lbl_staff);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_uname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 450);
            panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(678, 3);
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
            btn_max.Location = new Point(651, 3);
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
            btn_min.Location = new Point(624, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 10;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // toggleBtn
            // 
            toggleBtn.Location = new Point(127, 120);
            toggleBtn.MinimumSize = new Size(45, 22);
            toggleBtn.Name = "toggleBtn";
            toggleBtn.OffBackColor = Color.DimGray;
            toggleBtn.OffToggleColor = Color.Crimson;
            toggleBtn.OnBackColor = Color.RoyalBlue;
            toggleBtn.OnToggleColor = Color.LightSteelBlue;
            toggleBtn.Size = new Size(59, 27);
            toggleBtn.TabIndex = 1;
            toggleBtn.Text = "toggleBtn1";
            toggleBtn.UseVisualStyleBackColor = true;
            // 
            // lmklbl_signup
            // 
            lmklbl_signup.AutoSize = true;
            lmklbl_signup.Location = new Point(426, 372);
            lmklbl_signup.Name = "lmklbl_signup";
            lmklbl_signup.Size = new Size(61, 20);
            lmklbl_signup.TabIndex = 6;
            lmklbl_signup.TabStop = true;
            lmklbl_signup.Text = "Sign Up";
            lmklbl_signup.LinkClicked += lmklbl_signup_LinkClicked;
            // 
            // lnklbl_forgotpwd
            // 
            lnklbl_forgotpwd.AutoSize = true;
            lnklbl_forgotpwd.Location = new Point(175, 320);
            lnklbl_forgotpwd.Name = "lnklbl_forgotpwd";
            lnklbl_forgotpwd.Size = new Size(134, 20);
            lnklbl_forgotpwd.TabIndex = 5;
            lnklbl_forgotpwd.TabStop = true;
            lnklbl_forgotpwd.Text = "Forgot Password...?";
            lnklbl_forgotpwd.LinkClicked += lnklbl_forgotpwd_LinkClicked;
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(393, 311);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(94, 29);
            btn_signin.TabIndex = 4;
            btn_signin.Text = "Sign In";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // txt_pwd
            // 
            txt_pwd.BorderStyle = BorderStyle.FixedSingle;
            txt_pwd.Location = new Point(304, 247);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(183, 27);
            txt_pwd.TabIndex = 3;
            // 
            // txt_uname
            // 
            txt_uname.BorderStyle = BorderStyle.FixedSingle;
            txt_uname.Location = new Point(304, 201);
            txt_uname.Name = "txt_uname";
            txt_uname.Size = new Size(183, 27);
            txt_uname.TabIndex = 2;
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Location = new Point(207, 250);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(77, 20);
            lbl_pwd.TabIndex = 0;
            lbl_pwd.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 122);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 372);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 0;
            label3.Text = "Register new user here..!";
            // 
            // lbl_uname
            // 
            lbl_uname.AutoSize = true;
            lbl_uname.Location = new Point(195, 201);
            lbl_uname.Name = "lbl_uname";
            lbl_uname.Size = new Size(89, 20);
            lbl_uname.TabIndex = 0;
            lbl_uname.Text = "User Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(249, 41);
            label4.Name = "label4";
            label4.Size = new Size(179, 31);
            label4.TabIndex = 0;
            label4.Text = "MELTADO CAFE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 120);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // lbl_staff
            // 
            lbl_staff.AutoSize = true;
            lbl_staff.Location = new Point(81, 122);
            lbl_staff.Name = "lbl_staff";
            lbl_staff.Size = new Size(40, 20);
            lbl_staff.TabIndex = 0;
            lbl_staff.Text = "Staff";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Controls.ToggleBtn toggleBtn;
        private Label label2;
        private LinkLabel lmklbl_signup;
        private Label label3;
        private Button btn_min;
        private Button btn_close;
        private Button btn_max;
        private Label label4;
        private Label lbl_staff;
    }
}
