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
    public partial class frmNewCourses : Form
    {
        CourseServiceClient client = new CourseServiceClient();
        public frmNewCourses()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.validateData())
            {
                client.addCourse(Int32.Parse(txtID.Text), txtName.Text, Decimal.Parse(txtCost.Text));
                MessageBox.Show("New Course Information Saved", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("New Course Information NOT Saved", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewCourses_Load(object sender, EventArgs e)
        {

        }
        private bool validateData()
        {
            if (string.IsNullOrEmpty(txtCost.Text))
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