namespace MELTADO_CAFE
{
    partial class ForgotPwd_Page
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
            btn_sendotp = new Button();
            txt_otp = new TextBox();
            txt_email = new TextBox();
            lbl_pwd = new Label();
            lbl_email = new Label();
            btn_movesignin = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_close = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            btn_verifyotp = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sendotp
            // 
            btn_sendotp.Location = new Point(135, 349);
            btn_sendotp.Name = "btn_sendotp";
            btn_sendotp.Size = new Size(94, 29);
            btn_sendotp.TabIndex = 2;
            btn_sendotp.Text = "Send OTP";
            btn_sendotp.UseVisualStyleBackColor = true;
            btn_sendotp.Click += btn_sendotp_Click;
            // 
            // txt_otp
            // 
            txt_otp.BorderStyle = BorderStyle.FixedSingle;
            txt_otp.Location = new Point(232, 268);
            txt_otp.Name = "txt_otp";
            txt_otp.PasswordChar = '*';
            txt_otp.Size = new Size(183, 27);
            txt_otp.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(232, 204);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(183, 27);
            txt_email.TabIndex = 1;
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Location = new Point(167, 275);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(42, 20);
            lbl_pwd.TabIndex = 5;
            lbl_pwd.Text = "OTP :";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(123, 206);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(86, 20);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "User Email :";
            // 
            // btn_movesignin
            // 
            btn_movesignin.Location = new Point(12, 12);
            btn_movesignin.Name = "btn_movesignin";
            btn_movesignin.Size = new Size(123, 29);
            btn_movesignin.TabIndex = 8;
            btn_movesignin.Text = "Move to Sign In";
            btn_movesignin.UseVisualStyleBackColor = true;
            btn_movesignin.Click += btn_movesignin_click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 450);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_close);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lbl_email);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_movesignin);
            panel2.Controls.Add(txt_otp);
            panel2.Controls.Add(lbl_pwd);
            panel2.Controls.Add(btn_verifyotp);
            panel2.Controls.Add(btn_sendotp);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 450);
            panel2.TabIndex = 21;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(554, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 5;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(527, 3);
            button2.Name = "button2";
            button2.Size = new Size(21, 19);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(500, 3);
            button1.Name = "button1";
            button1.Size = new Size(21, 19);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 54);
            label4.Name = "label4";
            label4.Size = new Size(179, 31);
            label4.TabIndex = 20;
            label4.Text = "MELTADO CAFE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 127);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 19;
            label3.Text = "FORGOT PASSWORD";
            // 
            // btn_verifyotp
            // 
            btn_verifyotp.Location = new Point(321, 349);
            btn_verifyotp.Name = "btn_verifyotp";
            btn_verifyotp.Size = new Size(94, 29);
            btn_verifyotp.TabIndex = 4;
            btn_verifyotp.Text = "Verify OTP";
            btn_verifyotp.UseVisualStyleBackColor = true;
            btn_verifyotp.Click += btn_verifyotp_Click;
            // 
            // ForgotPwd_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPwd_Page";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_sendotp;
        private TextBox txt_otp;
        private TextBox txt_email;
        private Label lbl_pwd;
        private Label lbl_email;
        private Button btn_movesignin;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Button btn_close;
        private Button button2;
        private Button button1;
        private Button btn_verifyotp;
    }
}