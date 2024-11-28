using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrollmentSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnrollmentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EnrollmentService.svc or EnrollmentService.svc.cs at the Solution Explorer and start debugging.
    public class EnrollmentService : IEnrollmentService
    {
        private EnrollmentDataSetTableAdapters.EnrollmentTableAdapter enrollmentTA = new EnrollmentDataSetTableAdapters.EnrollmentTableAdapter();
        public List<Enrollment> getEnrollments()
        {
            EnrollmentDataSet.EnrollmentDataTable table = enrollmentTA.GetData();
            List<Enrollment> enrollmentList = new List<Enrollment>();
            foreach (DataRow row in table)
            {
                Enrollment enrollment = new Enrollment();
                enrollment.EnrollmentId = (int)row["EnrollmentId"];
                enrollment.StudentId = (int)row["StudentId"];
                enrollment.CourseId = (int)row["CourseId"];
                enrollment.Grade = row["Grade"].ToString();
                enrollmentList.Add(enrollment);
            }
            return enrollmentList;
        }

        public void addEnrollment(int studentId, int courseId, string grade )
        {

            enrollmentTA.Insert(studentId, courseId, grade);
            return;

        }

        public Enrollment getAnEnrollment(int enrollmentId)
        {
            EnrollmentDataSet.EnrollmentDataTable table = enrollmentTA.GetDataById(enrollmentId);
            Enrollment enrollment = new Enrollment();
            enrollment.EnrollmentId = (int)table.Rows[0]["EnrollmentId"];
            enrollment.StudentId = (int)table.Rows[0]["StudentId"];
            enrollment.CourseId = (int)table.Rows[0]["CourseId"];
            enrollment.Grade = table.Rows[0]["Grade"].ToString();
            return enrollment;
        }
    }
}
