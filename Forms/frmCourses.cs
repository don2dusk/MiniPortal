using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MiniPortalv2
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            List<string> courseIDs = new List<string>();
            List<string> courseUnits = new List<string>();
            List<string> courseNames = new List<string>();

            using (var db = new usrDBEntities1())
            {
                foreach (var course in db.tblProgramCourses.Where(c => c.programID == Program.progID))
                {
                    // add the course.courseID to the courseIDs
                    courseIDs.Add(course.courseID);
                    // add the course.courseUnits to the courseUnits
                    courseUnits.Add(Convert.ToString(course.courseUnits));
                    courseNames.Add(db.tblCourses.Where(c => c.courseID == course.courseID).First().courseName);
                }
            }

            label3.Text = courseIDs[0];
            label15.Text = courseUnits[0];
            label16.Text = courseNames[0];

            label4.Text = courseIDs[1];
            label17.Text = courseUnits[1];
            label27.Text = courseNames[1];

            label5.Text = courseIDs[2];
            label18.Text = courseUnits[2];
            label28.Text = courseNames[2];

            label6.Text = courseIDs[3];
            label19.Text = courseUnits[3];
            label29.Text = courseNames[3];

            label7.Text = courseIDs[4];
            label20.Text = courseUnits[4];
            label30.Text = courseNames[4];

            label8.Text = courseIDs[5];
            label21.Text = courseUnits[5];
            label31.Text = courseNames[5];

            label10.Text = courseIDs[6];
            label22.Text = courseUnits[6];
            label32.Text = courseNames[6];

            label11.Text = courseIDs[7];
            label23.Text = courseUnits[7];
            label33.Text = courseNames[7];

            label12.Text = courseIDs[8];
            label24.Text = courseUnits[8];
            label34.Text = courseNames[8];

            label13.Text = courseIDs[9];
            label25.Text = courseUnits[9];
            label35.Text = courseNames[9];

            label14.Text = courseIDs[10];
            label26.Text = courseUnits[10];
            label36.Text = courseNames[10];
        }
    }
}
