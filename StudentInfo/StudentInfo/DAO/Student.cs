using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInfo.DAO
{
    public class Student
    {
        public Department DDeptName { get; set; }
        public int StudentId { get; set; }
        public string StudentName{ get; set; }
        public int RollNo { get; set; }
        public int RegNo { get; set; }
        public int Age { get; set; }
      
    }
}