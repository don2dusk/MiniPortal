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
    public partial class frmsignUp3 : Form
    {
        public frmsignUp3()
        {
            InitializeComponent();
        }
        usrDBEntities1 db = new usrDBEntities1();
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void frmsignUp3_Load(object sender, EventArgs e)
        {
            foreach (var course in db.tblStudentCourses.Where(a => a.foreignMatric == Program.loggedInID))
            {
                dataGridView1.Rows.Add(course.foreignCourse);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}