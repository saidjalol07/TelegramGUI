using System;
using System.Drawing;
using System.Windows.Forms;

namespace Telegram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 fmr2 = new Form2();

        private void UserNametxt_Click(object sender, EventArgs e)
        {
            UserNametxt.Clear();
            pictureBoxUserName.BackgroundImage = Properties.Resources.usericon;
            UserPanel.BackColor = Color.FromArgb(135,236,235);
            UserNametxt.ForeColor = Color.FromArgb(135, 236, 235);

            pictureBoxPassword.BackgroundImage = Properties.Resources.passwordicon;
            PasswordPanel.BackColor = Color.WhiteSmoke;
            Passwordtxt.ForeColor = Color.WhiteSmoke;

            pictureBoxEmail.BackgroundImage = Properties.Resources.emailicon;
            EmailPanel.BackColor = Color.WhiteSmoke;
            Emailtxt.ForeColor = Color.WhiteSmoke;

        }

        private void Passwordtxt_Click(object sender, EventArgs e)
        {
            Passwordtxt.Clear();
            Passwordtxt.PasswordChar = '.';

            pictureBoxPassword.BackgroundImage = Properties.Resources.passwordicon;
            PasswordPanel.BackColor = Color.FromArgb(135, 236, 235);
            Passwordtxt.ForeColor = Color.FromArgb(135, 236, 235);

            pictureBoxUserName.BackgroundImage = Properties.Resources.usericon;
            UserPanel.BackColor = Color.WhiteSmoke;
            UserNametxt.ForeColor = Color.WhiteSmoke;

            pictureBoxEmail.BackgroundImage = Properties.Resources.emailicon;
            EmailPanel.BackColor = Color.WhiteSmoke;
            Emailtxt.ForeColor = Color.WhiteSmoke;

        }

        private void Emailtxt_Click(object sender, EventArgs e)
        {
            Emailtxt.Clear();
            pictureBoxEmail.BackgroundImage = Properties.Resources.emailicon;
            EmailPanel.BackColor = Color.FromArgb(135, 236, 235);
            Emailtxt.ForeColor = Color.FromArgb(135, 236, 235);

            pictureBoxUserName.BackgroundImage = Properties.Resources.usericon;
            UserPanel.BackColor = Color.WhiteSmoke;
            UserNametxt.ForeColor = Color.WhiteSmoke;

            pictureBoxPassword.BackgroundImage = Properties.Resources.passwordicon;
            PasswordPanel.BackColor = Color.WhiteSmoke;
            Passwordtxt.ForeColor = Color.WhiteSmoke;
        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panelAbove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panelAbove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void lbl_Close_MouseHover(object sender, EventArgs e)
        {
            this.lbl_Close.BackColor = Color.Red;
        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Close.BackColor = Color.LightSkyBlue;
        }

        private void lbl_Minimize_MouseHover(object sender, EventArgs e)
        {
            this.lbl_Minimize.BackColor = Color.Teal;
        }

        private void lbl_Minimize_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Minimize.BackColor = Color.LightSkyBlue;
        }

        private void lbl_Maximize_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Maximize.BackColor = Color.LightSkyBlue;
        }

        private void lbl_Maximize_MouseHover(object sender, EventArgs e)
        {
            this.lbl_Maximize.BackColor = Color.Teal;
        }

        private void PictureBox_Facebook_Icon_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fmr2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fmr2.Left += 7;
            if (fmr2.Left >= 880)
            {
                timer1.Stop();
                this.TopMost = false;
                fmr2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fmr2.Left -= 7;
            if (fmr2.Left <= 580)
            {
                timer2.Stop();
            }
        }

        private void panelAbove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        
    }
}
