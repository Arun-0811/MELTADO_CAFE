using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MELTADO_CAFE
{
    public partial class ForgotPwd_Page : Form
    {
        String randcode;
        String to;
        public ForgotPwd_Page()
        {
            InitializeComponent();
        }


        private void btn_close_click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btn_movesignin_click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_sendotp_Click(object sender, EventArgs e)
        {
            to = txt_email.Text.Trim();
            //My Code
            if (to != null)
            {
                String from, pass, messagebox;
                Random rand = new Random();
                randcode = (rand.Next(999999).ToString());

                MailMessage message = new MailMessage();
                to = (txt_email.Text).ToString();
                from = "type8meenu@gmail.com";
                pass = "xjrn gjre jwky liwh";

                messagebox = "Your Verification OTP : " + randcode;
                if (string.IsNullOrWhiteSpace(to))
                {
                    MessageBox.Show("Please enter email ID first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    message.To.Add(to); // Only add if valid
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                message.From = new MailAddress(from);
                message.Body = messagebox;
                message.Subject = "OTP Verification";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("OTP sent Successfully...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Email...!");

            }
        }

        private void btn_verifyotp_Click(object sender, EventArgs e)
        {
            //my code

            if (randcode == txt_otp.Text.Trim().ToString())
            {
                MessageBox.Show("OTP Verified Successfully");
                //Reset_Password Reset_Pass = new Reset_Password();
                //Reset_Pass.Show();
                //this.Hide();
            }

            else
            {
                MessageBox.Show("Plese Provide Valid Email and OTP...!");
            }
        }
    }
}
