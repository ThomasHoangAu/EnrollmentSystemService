﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrollmentSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        List<Student> getStudents();

        [OperationContract]
        void addStudent(int studentId, string studentName, DateTime dateEnrolled);

        [OperationContract]
        Student getAStudent(int studentId);
    }
}
