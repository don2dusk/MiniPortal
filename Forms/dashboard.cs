using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPortalv2;

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {
        Button lastClicked;

        private void makeActive(Button button)
        {
            // deactivate last clicked and activate me
            lastClicked.BackColor = Color.FromArgb(255, 255, 255);
            lastClicked.ForeColor = Color.FromArgb(0, 0, 0);

            button.BackColor = Color.FromArgb(230, 230, 230);
            button.ForeColor = Color.FromArgb(83, 82, 230);

            lastClicked = button;
        }

        private void highlight(Button button, Label label)
        {
            button.ForeColor = Color.FromArgb(83, 82, 230);
            label.ForeColor = Color.FromArgb(83, 82, 230);
            label.BackColor = Color.White;
        }

        private void unhighlight(Button button, Label label)
        {
            if (lastClicked != button)
            {
                button.ForeColor = Color.FromArgb(0, 0, 0);
                label.ForeColor = Color.FromArgb(0, 0, 0);
                label.BackColor = Color.White;
            } else
            {
                label.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);
        public dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            label3.Text = "Dashboard";
            this.pnlformLoader.Controls.Clear();
            frmDashboard vfrmDashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vfrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlformLoader.Controls.Add(vfrmDashboard);
            vfrmDashboard.Show();
    }

       

        private void dashboard_Load(object sender, EventArgs e) {
            usrDBEntities1 db = new usrDBEntities1();
            
            lastClicked = btnDashboard;
            makeActive(btnDashboard);
            label4.ForeColor = Color.FromArgb(83, 82, 210);
            label4.BackColor = Color.FromArgb(230, 230, 230);
            label6.ForeColor = Color.FromArgb(0, 0, 0);
            label6.BackColor = Color.FromArgb(255, 255, 255);
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label7.BackColor = Color.FromArgb(255, 255, 255);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label8.BackColor = Color.FromArgb(255, 255, 255);

            label2.Text = db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().fullName;
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            makeActive(btnDashboard);
            label4.ForeColor = Color.FromArgb(83, 82, 210);
            label4.BackColor = Color.FromArgb(230, 230, 230);
            label6.ForeColor = Color.FromArgb(0, 0, 0);
            label6.BackColor = Color.FromArgb(255, 255, 255);
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label7.BackColor = Color.FromArgb(255, 255, 255);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label8.BackColor = Color.FromArgb(255, 255, 255);
            label3.Text = "Dashboard";
            this.pnlformLoader.Controls.Clear();
            frmDashboard vfrmDashboard = new frmDashboard() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            vfrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlformLoader.Controls.Add(vfrmDashboard);
            vfrmDashboard.Show();
        }
        private void btnCourses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCourses.Height;
            pnlNav.Top = btnCourses.Top;

            makeActive(btnCourses);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label4.BackColor = Color.FromArgb(255, 255, 255);
            label6.ForeColor = Color.FromArgb(83, 82, 210);
            label6.BackColor = Color.FromArgb(230, 230, 230);
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label7.BackColor = Color.FromArgb(255, 255, 255);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label8.BackColor = Color.FromArgb(255, 255, 255);

            label3.Text = "Courses";
            this.pnlformLoader.Controls.Clear();
            frmCourses vfrmDashboard = new frmCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            vfrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlformLoader.Controls.Add(vfrmDashboard);
            vfrmDashboard.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;

            makeActive(btnAccount);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label4.BackColor = Color.FromArgb(255, 255, 255);
            label6.ForeColor = Color.FromArgb(0, 0, 0);
            label6.BackColor = Color.FromArgb(255, 255, 255);
            label7.ForeColor = Color.FromArgb(83, 82, 210);
            label7.BackColor = Color.FromArgb(230, 230, 230);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label8.BackColor = Color.FromArgb(255, 255, 255);

            label3.Text = "Student Account";
            this.pnlformLoader.Controls.Clear();
            frmAccount vfrmDashboard = new frmAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            vfrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlformLoader.Controls.Add(vfrmDashboard);
            vfrmDashboard.Show();
        }

        private void btnGPA_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGPA.Height;
            pnlNav.Top = btnGPA.Top;

            makeActive(btnGPA);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label4.BackColor = Color.FromArgb(255, 255, 255);
            label6.ForeColor = Color.FromArgb(0, 0, 0);
            label6.BackColor = Color.FromArgb(255, 255, 255);
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label7.BackColor = Color.FromArgb(255, 255, 255);
            label8.ForeColor = Color.FromArgb(83, 82, 230);
            label8.BackColor = Color.FromArgb(230, 230, 230);

            label3.Text = "GPA Calculator";
            this.pnlformLoader.Controls.Clear();
            frmGPA vfrmDashboard = new frmGPA() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vfrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlformLoader.Controls.Add(vfrmDashboard);
            vfrmDashboard.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 255, 255);
            Application.Exit();
        }

        private void btnsignOut_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsignOut.Height;
            pnlNav.Top = btnsignOut.Top;
            pnlNav.Left = btnsignOut.Left;
            btnsignOut.BackColor = Color.FromArgb(255, 255, 255);

            new frmLogin().Show();
            this.Hide();
        }

        private void btnClose_Leave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void pnlformLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGPA_Leave(object sender, EventArgs e)
        {

        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            highlight(btnDashboard, label4);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            unhighlight(btnDashboard, label4);
        }

        private void btnCourses_MouseEnter(object sender, EventArgs e)
        {
            highlight(btnCourses, label6);
        }

        private void btnCourses_MouseLeave(object sender, EventArgs e)
        {
            unhighlight(btnCourses, label6);
        }

        private void btnAccount_MouseEnter(object sender, EventArgs e)
        {
            highlight(btnAccount, label7);
        }

        private void btnAccount_MouseLeave(object sender, EventArgs e)
        {
            unhighlight(btnAccount, label7);
        }

        private void btnGPA_MouseEnter(object sender, EventArgs e)
        {
            highlight(btnGPA, label8);
        }

        private void btnGPA_MouseLeave(object sender, EventArgs e)
        {
            unhighlight(btnGPA, label8);
        }
    }
}
