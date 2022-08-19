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
    public partial class frmsignupCtd : Form
    {
        public frmsignupCtd()
        {
            InitializeComponent();
        }
        usrDBEntities1 db = new usrDBEntities1();
        private void frmsignupCtd_Load(object sender, EventArgs e)
        {

        }

        private void txtfullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmsignUp().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(230, 230, 230);
            Application.Exit();
        }

        private void btnClose_Leave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.loggedInID = Program.signUpvalues[1];
            int id = 1;
            var progid = "";
            if (txtCourse.Text == "Computer Science")
            {
                progid = "CIS001";
            } else
            {
                progid = "X";
            }

            db.tblsignUps.Add(new tblsignUp
            {
                fullName = Program.signUpvalues[0],
                matricNo = Program.signUpvalues[1],
                password = Program.signUpvalues[2],
                email = txtEmail.Text,
                DOB = txtDOB.Text,
                sLevel = Convert.ToInt32(txtLevel.Text),
                programID = progid,
            });
                db.SaveChanges();
            // get the courses offered by the program
            // and add them along with the matric umber to the StudentCourses table
            /* foreach (var course in db.tblProgramCourses.Where(c => c.programID == progid))
            {
                db.tblStudentCourses.Add(new tblStudentCours {
                    id = id++,
                    foreignCourse = course.courseID,
                    foreignMatric = Program.loggedInID
                });
            }


            new frmsignUp3().Show();
            this.Hide(); */
            // Do this later. C# Project doesn't deserve this much stress. 
        }
    }
}
