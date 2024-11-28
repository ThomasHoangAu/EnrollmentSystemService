using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using EnrollmentSystemClient.EnrollmentServiceReference;
using EnrollmentSystemClient.CourseServiceReference;
using EnrollmentSystemClient.StudentServiceReference;

namespace EnrollmentSystemCLient
{
    public partial class frmEnroll : Form
    {
        EnrollmentServiceClient enrollmentClient = new EnrollmentServiceClient();
        CourseServiceClient courseClient = new CourseServiceClient();
        StudentServiceClient studentClient = new StudentServiceClient();

        public frmEnroll()
        {
            InitializeComponent();
        }

        private void frmEnroll_Load(object sender, EventArgs e)
        {
            cbStudents.Text = "-Select Student-";
            foreach (Student student in studentClient.getStudents())
            {
                cbStudents.Items.Add(student.StudentId); ;
            }

            cbCourses .Text = "-Select Course-";
            foreach (Course course in courseClient.getCourses())
            {
                cbCourses.Items.Add(course.CourseId); ;
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (this.validateData())
            {
                enrollmentClient.addEnrollment(Int32.Parse(cbStudents.SelectedItem.ToString()), Int32.Parse(cbCourses.SelectedItem.ToString()), null);
                MessageBox.Show("New Enrollment Information Saved", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("New Enrollment Information NOT Saved", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
                int id = Int32.Parse(cbStudents.SelectedItem.ToString());
                this.txtStudName.Text = studentClient.getAStudent(id).StudentName;
                txtDateEnrolled.Text = studentClient.getAStudent(id).DateEnrolled.ToString("d");

        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(cbCourses.SelectedItem.ToString());
            txtCourseName.Text = courseClient.getACourse(id).CourseName;
            this.txtCost.Text = courseClient.getACourse(id).Cost.ToString("C");
        }

        private bool validateData()
        {
            if (string.IsNullOrEmpty(cbStudents.SelectedItem.ToString()))
                return false;
            if (string.IsNullOrEmpty(cbCourses.SelectedItem.ToString()))
                return false;
            else
                return true;
        }
    }
}