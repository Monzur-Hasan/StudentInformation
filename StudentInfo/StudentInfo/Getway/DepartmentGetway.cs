using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentInfo.DAO;

namespace StudentInfo.Getway
{
    public class DepartmentGetway:DBGetway
    {
        public string SaveDepartment(Department aDepartment)
        {
          ConnectionObj.Open();
          string insert = String.Format("INSERT INTO tblDept VALUES(@DeptName)");
            CommandObj.Parameters.Clear();
            CommandObj.CommandText = insert;
            CommandObj.Parameters.Add("@DeptName", SqlDbType.VarChar);
            CommandObj.Parameters["@DeptName"].Value = aDepartment.DeptName;
            CommandObj.ExecuteNonQuery();
            ConnectionObj.Close();
            return "Department Name Save Successfully";
        }

        public List<Department> GetallDepartmentName()
        {
            ConnectionObj.Open();
            string select = String.Format("SELECT * FROM tblDept");
            CommandObj.Parameters.Clear();
            CommandObj.CommandText = select;
            SqlDataReader reader= CommandObj.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.DeptId = Convert.ToInt32(reader[0]);
                aDepartment.DeptName = reader[1].ToString();
                departments.Add(aDepartment);
            }

            ConnectionObj.Close();
            return departments;
        }
    }
}