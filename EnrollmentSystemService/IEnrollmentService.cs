using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrollmentSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnrollmentService" in both code and config file together.
    [ServiceContract]
    public interface IEnrollmentService
    {
        [OperationContract]
        List<Enrollment> getEnrollments();

        [OperationContract]
        void addEnrollment(int studentId, int courseId, string grade);

        [OperationContract]
        Enrollment getAnEnrollment(int enrollmentId);
    }
}

