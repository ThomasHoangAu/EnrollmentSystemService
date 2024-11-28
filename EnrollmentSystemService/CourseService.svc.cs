using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrollmentSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CourseService.svc or CourseService.svc.cs at the Solution Explorer and start debugging.
    public class CourseService : ICourseService
    {
        private CourseDataSetTableAdapters.CourseTableAdapter courseTA = new CourseDataSetTableAdapters.CourseTableAdapter();
        public List<Course> getCourses()
        {
            CourseDataSet.CourseDataTable table = courseTA.GetData();
            List<Course> courseList = new List<Course>();
            foreach (DataRow row in table)
            {
                Course course = new Course();
                course.CourseId = (int)row["CourseId"];
                course.CourseName = row["CourseName"].ToString();
                course.Cost = (decimal)row["Cost"];
                courseList.Add(course);
            }
            return courseList;
        }

        public void addCourse(int courseId, string courseName, decimal cost)
        {

            courseTA.Insert(courseId, courseName, cost);
            return;    
            
        }

        public Course getACourse(int courseId)
        {
            CourseDataSet.CourseDataTable table = courseTA.GetDataById(courseId);
            Course course = new Course();
            course.CourseId = (int)table.Rows[0]["CourseId"];
            course.CourseName = table.Rows[0]["CourseName"].ToString();
            course.Cost = (decimal)table.Rows[0]["Cost"];
            return course;
        }
    }
}
