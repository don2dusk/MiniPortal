using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPortalv2;

namespace WindowsFormsApp1
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            usrDBEntities1 db = new usrDBEntities1();
            string name = db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().fullName;
            string[] nameID = name.Split(' ');

            label8.Text += nameID[0] + '!';

            label9.Text = db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().fullName;
            label10.Text = db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().matricNo;
            var progID = db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().programID;
            label11.Text = db.tblPrograms.Where(student => student.programID == progID).First().programName;
            label12.Text = Convert.ToString(db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().sLevel);
            label13.Text = db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().DOB;
            label14.Text = db.tblsignUps.Where(student => student.matricNo == Program.loggedInID).First().email;
        }
    }
}
