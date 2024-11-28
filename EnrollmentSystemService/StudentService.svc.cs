using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrollmentSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        private StudentDataSetTableAdapters.StudentTableAdapter studentTA = new StudentDataSetTableAdapters.StudentTableAdapter();

        public List<Student> getStudents()
        {
            StudentDataSet.StudentDataTable table = studentTA.GetData();
            List<Student> studentList = new List<Student>();
            foreach (DataRow row in table)
            {
                Student student = new Student();
                student.StudentId = (int)row["StudentId"];
                student.StudentName = row["StudentName"].ToString();
                student.DateEnrolled = (DateTime)row["DateEnrolled"];
                studentList.Add(student);
            }
            return studentList;
        }

        public void addStudent(int studentId, string studentName, DateTime dateEnrolled)
        {

            studentTA.Insert(studentId, studentName, dateEnrolled);
            return;

        }

        public Student getAStudent(int studentId)
        {
            StudentDataSet.StudentDataTable table = studentTA.GetDataById(studentId);
            Student student = new Student();
            student.StudentId = (int)table.Rows[0]["StudentId"];
            student.StudentName = table.Rows[0]["StudentName"].ToString();
            student.DateEnrolled = (DateTime)table.Rows[0]["DateEnrolled"];
            return student;
        }
    }
}

