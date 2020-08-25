using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentInfo.DAO;

namespace StudentInfo.Getway
{
    public class StudentGetway:DBGetway
    {
        public string SaveStudent(List<Student> students)
        {
          ConnectionObj.Open();
            foreach (Student astudent in students)
            {
                string insert = String.Format("INSERT INTO tblStudentInfo VALUES(@StudentName,@RollNo,@RegNo,@Age,@Id)");
                CommandObj.Parameters.Clear();
                CommandObj.CommandText = insert;
                CommandObj.Parameters.Add("@StudentName", SqlDbType.VarChar);
                CommandObj.Parameters["@StudentName"].Value = astudent.StudentName;
                CommandObj.Parameters.Add("@RollNo", SqlDbType.Int);
                CommandObj.Parameters["@RollNo"].Value = astudent.RollNo;
                CommandObj.Parameters.Add("@RegNo", SqlDbType.Int);
                CommandObj.Parameters["@RegNo"].Value = astudent.RegNo;
                CommandObj.Parameters.Add("@Age", SqlDbType.Int);
                CommandObj.Parameters["@Age"].Value = astudent.Age;
                CommandObj.Parameters.Add("@Id", SqlDbType.Int);
                CommandObj.Parameters["@Id"].Value = astudent.DDeptName.DeptId;
                CommandObj.ExecuteNonQuery();

            }
            ConnectionObj.Close();
            return "Student Information Save Successfully";
        }

        public List<Student> GetallStudent()
        {
            ConnectionObj.Open();
            string select = String.Format("SELECT * FROM tblStudentInfo");
            CommandObj.Parameters.Clear();
            CommandObj.CommandText = select;
            SqlDataReader reader = CommandObj.ExecuteReader();
            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.StudentId = Convert.ToInt32(reader[0]);
                aStudent.StudentName = reader[1].ToString();
                aStudent.RollNo = Convert.ToInt32(reader[2]);
                aStudent.RegNo = Convert.ToInt32(reader[3]);
                aStudent.Age = Convert.ToInt32(reader[4]);

                students.Add(aStudent);
            }

            ConnectionObj.Close();
            return students;
        }

        public string DeleteStudentById(int StudentId)
        {
            ConnectionObj.Open();
            string delete = String.Format("Delete From tblStudentInfo Where StudentId='{0}'", StudentId);
            CommandObj.CommandText = delete;
            CommandObj.ExecuteNonQuery();
            ConnectionObj.Close();
            return "Delete Successfully";
        }

        public string UpdateStudentById(Student aStudent)
        {
           ConnectionObj.Open();
            string update =String.Format("Update tblStudentInfo set StudentName='{0}', RollNo='{1}', RegNo='{3}', Age='{4}' where StudentId='{5}",aStudent.StudentName, aStudent.RollNo, aStudent.RegNo, aStudent.Age);
            CommandObj.CommandText = update;
            CommandObj.ExecuteNonQuery();
            return "Student Info Save Successfully";
        }
    }
}