using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollmentSystemCLient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuNewStudents_Click(object sender, EventArgs e)
        {
            new frmNewStudents().Show();
        }

        private void mnuNewCourses_Click(object sender, EventArgs e)
        {
            new frmNewCourses().Show();
        }

        private void mnuViewStudents_Click(object sender, EventArgs e)
        {
            new frmStudents().Show();
        }

        private void mnuViewCourses_Click(object sender, EventArgs e)
        {
            new frmCourses().Show();
        }

        private void mnuEnroll_Click(object sender, EventArgs e)
        {
            new frmEnroll().Show();
        }

        private void mnuViewRoll_Click(object sender, EventArgs e)
        {
            new frmViewEnrollments().Show();
        }
    }
}