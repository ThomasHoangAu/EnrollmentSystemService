using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrollmentSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICourseService" in both code and config file together.
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        List<Course> getCourses();

        [OperationContract]
        void addCourse(int courseId, string courseName, decimal cost);

        [OperationContract]
        Course getACourse(int courseId);
    }
}
