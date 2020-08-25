using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentInfo.DAO;
using StudentInfo.Getway;

namespace StudentInfo.Manager
{
    public class StudentManager
    {
        StudentGetway aStudentGetway = new StudentGetway();
        public string SaveStudent(List<Student> students)
        {
         
         return aStudentGetway.SaveStudent(students);
        }

        public List<Student> GetallStudent()
        {
          return  aStudentGetway.GetallStudent();
        }

        public string DeletStudentById(int StudentId)
        {
          return  aStudentGetway.DeleteStudentById(StudentId);
        }

        public string UpdateStudentById(Student aStudent)
        {
           return aStudentGetway.UpdateStudentById(aStudent);
        }
    }
}