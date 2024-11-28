using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrollmentSystemService
{
    [DataContract]
    public class Enrollment
    {
        [DataMember]
        public int EnrollmentId;
        [DataMember]
        public int StudentId;
        [DataMember]
        public int CourseId;
        [DataMember]
        public string Grade;
    }
}