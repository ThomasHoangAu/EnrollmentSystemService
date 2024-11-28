using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrollmentSystemService
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int CourseId;
        [DataMember]
        public string CourseName;
        [DataMember]
        public Decimal Cost;
    }
}