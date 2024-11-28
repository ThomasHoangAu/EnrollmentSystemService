using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnrollmentSystemClient.StudentServiceReference;

namespace EnrollmentSystemCLient
{
    public partial class frmStudents : Form
    {
        private StudentServiceClient client = new StudentServiceClient();

        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
         
            foreach (Student student in client.getStudents())
            {
                lbStudents.Items.Add(student.StudentId.ToString() + "-->" + student.StudentName.ToString()); ;

            }
        }
    }
}
