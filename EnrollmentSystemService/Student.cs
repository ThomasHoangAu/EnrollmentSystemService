using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrollmentSystemService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentId;
        [DataMember]
        public string StudentName;
        [DataMember]
        public DateTime DateEnrolled;
    }
}