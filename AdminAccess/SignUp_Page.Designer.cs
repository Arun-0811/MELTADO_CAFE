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
            txt_uname = new TextBox();
            txt_email = new TextBox();
            cmb_role = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            dataGridViewUsers = new DataGridView();
            toggleBtn = new MELTADO_CAFE.Controls.ToggleBtn();
            btnClearAll = new Button();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            lblIsActive = new Label();
            groupBox1 = new GroupBox();
            txtConfirmPwd = new TextBox();
            txtPnoneNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lnklbl_signin
            // 
            lnklbl_signin.AutoSize = true;
            lnklbl_signin.Location = new Point(235, 452);
            lnklbl_signin.Name = "lnklbl_signin";
            lnklbl_signin.Size = new Size(54, 20);
            lnklbl_signin.TabIndex = 11;
            lnklbl_signin.TabStop = true;
            lnklbl_signin.Text = "Sign In";
            lnklbl_signin.LinkClicked += lnklbl_signin_LinkClicked;
            // 
            // btn_signin
            // 
            btn_signin.BackColor = Color.Blue;
            btn_signin.Cursor = Cursors.Hand;
            btn_signin.FlatStyle = FlatStyle.Popup;
            btn_signin.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_signin.ForeColor = SystemColors.ButtonHighlight;
            btn_signin.Location = new Point(326, 440);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(163, 37);
            btn_signin.TabIndex = 10;
            btn_signin.Text = "Regisster New";
            btn_signin.UseVisualStyleBackColor = false;
            btn_signin.Click += btn_signin_Click;
            // 
            // txt_pwd
            // 
            txt_pwd.BorderStyle = BorderStyle.FixedSingle;
            txt_pwd.Location = new Point(29, 155);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(183, 27);
            txt_pwd.TabIndex = 8;
            // 
            // txt_uname
            // 
            txt_uname.BorderStyle = BorderStyle.FixedSingle;
            txt_uname.Location = new Point(29, 34);
            txt_uname.Name = "txt_uname";
            txt_uname.Size = new Size(183, 27);
            txt_uname.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(247, 34);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(183, 27);
            txt_email.TabIndex = 9;
            // 
            // cmb_role
            // 
            cmb_role.FormattingEnabled = true;
            cmb_role.Location = new Point(247, 94);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(181, 28);
            cmb_role.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 452);
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
            btn_close.Location = new Point(996, 3);
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
            btn_max.Location = new Point(969, 3);
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
            btn_min.Location = new Point(942, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 16;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewUsers);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_max);
            panel1.Controls.Add(btn_min);
            panel1.Controls.Add(toggleBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnClearAll);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnUpdateUser);
            panel1.Controls.Add(btn_signin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lnklbl_signin);
            panel1.Controls.Add(lblIsActive);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 508);
            panel1.TabIndex = 18;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(573, 162);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(417, 188);
            dataGridViewUsers.TabIndex = 18;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // toggleBtn
            // 
            toggleBtn.Location = new Point(426, 162);
            toggleBtn.MinimumSize = new Size(45, 22);
            toggleBtn.Name = "toggleBtn";
            toggleBtn.OffBackColor = Color.DimGray;
            toggleBtn.OffToggleColor = Color.Crimson;
            toggleBtn.OnBackColor = Color.RoyalBlue;
            toggleBtn.OnToggleColor = Color.LightSteelBlue;
            toggleBtn.Size = new Size(59, 27);
            toggleBtn.TabIndex = 14;
            toggleBtn.Text = "toggleBtn1";
            toggleBtn.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.Gray;
            btnClearAll.Cursor = Cursors.Hand;
            btnClearAll.FlatStyle = FlatStyle.Popup;
            btnClearAll.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearAll.ForeColor = SystemColors.ButtonHighlight;
            btnClearAll.Location = new Point(896, 385);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(94, 37);
            btnClearAll.TabIndex = 10;
            btnClearAll.Text = "Clear";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Red;
            btnDeleteUser.Cursor = Cursors.Hand;
            btnDeleteUser.FlatStyle = FlatStyle.Popup;
            btnDeleteUser.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteUser.Location = new Point(735, 385);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(114, 37);
            btnDeleteUser.TabIndex = 10;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateUser.Cursor = Cursors.Hand;
            btnUpdateUser.FlatStyle = FlatStyle.Popup;
            btnUpdateUser.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUser.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateUser.Location = new Point(573, 385);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(114, 37);
            btnUpdateUser.TabIndex = 10;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(326, 164);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(82, 20);
            lblIsActive.TabIndex = 6;
            lblIsActive.Text = "Is Active :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(txt_uname);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_pwd);
            groupBox1.Controls.Add(txtConfirmPwd);
            groupBox1.Controls.Add(txtPnoneNo);
            groupBox1.Controls.Add(cmb_role);
            groupBox1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(41, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 227);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTER (Admin | Sataff)";
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPwd.Location = new Point(247, 155);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.Size = new Size(183, 27);
            txtConfirmPwd.TabIndex = 8;
            // 
            // txtPnoneNo
            // 
            txtPnoneNo.BorderStyle = BorderStyle.FixedSingle;
            txtPnoneNo.Location = new Point(29, 94);
            txtPnoneNo.Name = "txtPnoneNo";
            txtPnoneNo.Size = new Size(183, 27);
            txtPnoneNo.TabIndex = 8;
            // 
            // SignUp_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 599);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SignUp_Page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel lnklbl_signin;
        private Button btn_signin;
        private TextBox txt_pwd;
        private TextBox txt_uname;
        private TextBox txt_email;
        private ComboBox cmb_role;
        private Label label2;
        private Label label4;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtPnoneNo;
        private TextBox txtConfirmPwd;
        private Label lblIsActive;
        private Controls.ToggleBtn toggleBtn;
        private GroupBox groupBox1;
        private DataGridView dataGridViewUsers;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button btnClearAll;
    }
}