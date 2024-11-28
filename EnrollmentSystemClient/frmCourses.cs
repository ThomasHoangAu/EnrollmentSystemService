using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnrollmentSystemClient.CourseServiceReference;

namespace EnrollmentSystemCLient
{
   
    public partial class frmCourses : Form
    {
        private CourseServiceClient client = new CourseServiceClient();

        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            
            foreach (Course course in client.getCourses())
            {
                lbCourses.Items.Add(course.CourseId + "-->" + course.CourseName);

            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}