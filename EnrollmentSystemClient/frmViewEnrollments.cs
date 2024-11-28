using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnrollmentSystemClient.EnrollmentServiceReference;
using EnrollmentSystemClient.StudentServiceReference;
using EnrollmentSystemClient.CourseServiceReference;

namespace EnrollmentSystemCLient
{
    public partial class frmViewEnrollments : Form
    {
        //TafeDBDataSet.CourseDataTable table;
        private EnrollmentServiceClient enrollmentClient = new EnrollmentServiceClient();
        private StudentServiceClient studentClient = new StudentServiceClient();
        private CourseServiceClient courseClient = new CourseServiceClient();
        public frmViewEnrollments()
        {
            InitializeComponent();
        }

        private void frmViewEnrollments_Load(object sender, EventArgs e)
        {
            cbCourses.Text = "-Select Courset-";

            foreach (Enrollment enrollment in enrollmentClient.getEnrollments())
            {
                cbCourses.Items.Add(enrollment.EnrollmentId.ToString()); ;

            }
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStudents.Items.Clear(); 
            int enrollmentId = Int32.Parse(cbCourses.SelectedItem.ToString());

            int studentId = enrollmentClient.getAnEnrollment(enrollmentId).StudentId;
            string studentName = studentClient.getAStudent(studentId).StudentName;

            int courseId = enrollmentClient.getAnEnrollment(enrollmentId).CourseId;
            string courseName = courseClient.getACourse(courseId).CourseName;
            string cost = courseClient.getACourse(courseId).Cost.ToString();

            this.txtName.Text = courseName;
            this.txtCost.Text = cost;
            
            if (enrollmentId == null)
            {
                lbStudents.Items.Add("--------- NO ENROLLMENTS ----------");
            }
            else
            {
                this.lbStudents.Items.Add(studentId + "-->" + studentName);
            }
        }
    }
}