using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentInfo.DAO;
using StudentInfo.Manager;

namespace StudentInfo.UI
{
    public partial class DepartmentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department();
            aDepartment.DeptName = deptNameTextBox.Text;

            DepartmentManager aDepartmentManager = new DepartmentManager();
            string msg= aDepartmentManager.SaveDepartment(aDepartment);
            messageLabel.Text = msg;
            messageLabel.ForeColor = Color.Green;
        }
    }
}