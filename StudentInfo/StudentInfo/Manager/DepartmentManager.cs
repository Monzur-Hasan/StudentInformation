using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentInfo.DAO;
using StudentInfo.Getway;

namespace StudentInfo.Manager
{
    public class DepartmentManager
    {
       DepartmentGetway aDepartmentGetway = new DepartmentGetway();

       public string SaveDepartment(Department aDepartment)
        {
         
          return aDepartmentGetway.SaveDepartment(aDepartment);
        }

       public List<Department> GetallDepartment()
       {

          return aDepartmentGetway.GetallDepartmentName();
       }
    }
}