namespace MELTADO_CAFE
{
    partial class SignUp_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Page));
            lnklbl_signin = new LinkLabel();
            btn_signin = new Button();
            txt_pwd = new TextBox();
            lbl_role = new Label();
            lbl_pwd = new Label();
            label1 = new Label();
            lbl_email = new Label();
            txt_uname = new TextBox();
            txt_email = new TextBox();
            cmb_role = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lnklbl_signin
            // 
            lnklbl_signin.AutoSize = true;
            lnklbl_signin.Location = new Point(235, 447);
            lnklbl_signin.Name = "lnklbl_signin";
            lnklbl_signin.Size = new Size(54, 20);
            lnklbl_signin.TabIndex = 11;
            lnklbl_signin.TabStop = true;
            lnklbl_signin.Text = "Sign In";
            lnklbl_signin.LinkClicked += lnklbl_signin_LinkClicked;
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(326, 438);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(94, 29);
            btn_signin.TabIndex = 10;
            btn_signin.Text = "Sign Up";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // txt_pwd
            // 
            txt_pwd.BorderStyle = BorderStyle.FixedSingle;
            txt_pwd.Location = new Point(237, 304);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(183, 27);
            txt_pwd.TabIndex = 8;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Location = new Point(171, 362);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(46, 20);
            lbl_role.TabIndex = 6;
            lbl_role.Text = "Role :";
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Location = new Point(140, 304);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(77, 20);
            lbl_pwd.TabIndex = 7;
            lbl_pwd.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 191);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "User Name :";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(164, 249);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(53, 20);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Email :";
            // 
            // txt_uname
            // 
            txt_uname.BorderStyle = BorderStyle.FixedSingle;
            txt_uname.Location = new Point(237, 191);
            txt_uname.Name = "txt_uname";
            txt_uname.Size = new Size(183, 27);
            txt_uname.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(237, 247);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(183, 27);
            txt_email.TabIndex = 9;
            // 
            // cmb_role
            // 
            cmb_role.FormattingEnabled = true;
            cmb_role.Location = new Point(239, 362);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(181, 28);
            cmb_role.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 447);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 6;
            label2.Text = "Already Registered?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(310, 46);
            label4.Name = "label4";
            label4.Size = new Size(179, 31);
            label4.TabIndex = 13;
            label4.Text = "MELTADO CAFE";
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(777, 1);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 14;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_click;
            // 
            // btn_max
            // 
            btn_max.BackColor = Color.Lime;
            btn_max.FlatStyle = FlatStyle.Popup;
            btn_max.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_max.Location = new Point(750, 1);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(21, 19);
            btn_max.TabIndex = 15;
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.BackColor = Color.Yellow;
            btn_min.FlatStyle = FlatStyle.Popup;
            btn_min.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_min.Location = new Point(723, 1);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 16;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 121);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 13;
            label3.Text = "REGISTER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(512, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 519);
            panel1.TabIndex = 18;
            // 
            // SignUp_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(pictureBox1);
            Controls.Add(btn_close);
            Controls.Add(btn_max);
            Controls.Add(btn_min);
            Controls.Add(label3);
            Controls.Add(cmb_role);
            Controls.Add(lnklbl_signin);
            Controls.Add(btn_signin);
            Controls.Add(txt_email);
            Controls.Add(txt_uname);
            Controls.Add(lbl_email);
            Controls.Add(txt_pwd);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lbl_role);
            Controls.Add(lbl_pwd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SignUp_Page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnklbl_signin;
        private Button btn_signin;
        private TextBox txt_pwd;
        private Label lbl_role;
        private Label lbl_pwd;
        private Label label1;
        private Label lbl_email;
        private TextBox txt_uname;
        private TextBox txt_email;
        private ComboBox cmb_role;
        private Label label2;
        private Label label4;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}