using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmsignUp : Form
    {
        public frmsignUp()
        {
            InitializeComponent();
        }

        private void frmsignUp_Load(object sender, EventArgs e)
        {
            txtfullName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfullName.Text == "" && txtmatricNo.Text == "" && txtPassword.Text == "" && txtconPassword.Text == "")
            {
                MessageBox.Show("Empty Fields", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtconPassword.Text)
            {
                Program.signUpvalues[0] = txtfullName.Text;
                Program.signUpvalues[1] = txtmatricNo.Text;
                Program.signUpvalues[2] = txtPassword.Text;

                new frmsignupCtd().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-Enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtconPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtconPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtconPassword.PasswordChar = '●';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void txtconPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Leave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
