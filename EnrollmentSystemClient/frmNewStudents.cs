using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnrollmentSystemClient.CourseServiceReference;
using EnrollmentSystemClient.StudentServiceReference;

namespace EnrollmentSystemCLient
{
    public partial class frmNewStudents : Form
    {
        StudentServiceClient client = new StudentServiceClient();
        public frmNewStudents()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.validateData())
            {
                client.addStudent(Int32.Parse(txtID.Text), txtName.Text, dtpEnrollment.Value);
                MessageBox.Show("New Student Information Saved", "Add Student",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("New Student Information NOT Saved", "Add Student", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmNewStudents_Load(object sender, EventArgs e)
        {

        }

        private bool validateData()
        {
            if (string.IsNullOrEmpty(dtpEnrollment.Value.ToString()))
                return false;
            if (string.IsNullOrEmpty(txtID.Text))
                return false;
            if (string.IsNullOrEmpty(txtName.Text))
                return false;
            else
                return true;
        }
    }
}