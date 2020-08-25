using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentInfo.DAO;
using StudentInfo.Manager;

namespace StudentInfo.UI
{
    public partial class StudentUI : System.Web.UI.Page
    {
        DepartmentManager aDepartmentManager =new DepartmentManager();
        StudentManager aStudentManager = new StudentManager();
        Student aStudent = new Student();
        List<Student> students=new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["StudentInfo"] = students;
            }

            LoadStudentGridView();
            LoadDeptName();
        }



        private void LoadDeptName()
        {
          List<Department> departments=  aDepartmentManager.GetallDepartment();
            dptNameDropDownList.DataSource = departments;
            dptNameDropDownList.DataTextField = "DeptName";
            dptNameDropDownList.DataValueField = "DeptId";
            dptNameDropDownList.DataBind();
        }



        private void LoadStudentGridView()
        {
            List<Student> students;
            students=  aStudentManager.GetallStudent();
            studentGridView.DataSource = students;
            studentGridView.DataBind();
       

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            List<Student> students = (List<Student>) Session["StudentInfo"];
            
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.RollNo = Convert.ToInt32(rollNoTextBox.Text);
            aStudent.RegNo = Convert.ToInt32(regNoTextBox.Text);
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);

            Department aDepartment=new Department();
            aDepartment.DeptId =Convert.ToInt32(dptNameDropDownList.SelectedValue);
            aStudent.DDeptName = aDepartment;
            students.Add(aStudent);
            Session["StudentInfo"] = students;
            Formclear();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Student> students =(List<Student>) Session["StudentInfo"];
            string msg= aStudentManager.SaveStudent(students);
            messageLabel.Text = msg;
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            Formclear();
        }

        private void Formclear()
        {
            studentNameTextBox.Text = "";
            rollNoTextBox.Text = "";
            regNoTextBox.Text = "";
            ageTextBox.Text = "";
        }

        protected void studentGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveButton.Visible = true;
            try
            {
                if (studentGridView.SelectedIndex != -1)
                {
                    saveButton.Visible = false;
                    GridViewRow gridViewRow = studentGridView.SelectedRow;
                    studentIdTextBox.Text = ((Label)(gridViewRow.FindControl("Label1"))).Text;
                    studentNameTextBox.Text = ((Label)(gridViewRow.FindControl("Label2"))).Text;
                    rollNoTextBox.Text = ((Label)(gridViewRow.FindControl("Label3"))).Text;
                    regNoTextBox.Text = ((Label)(gridViewRow.FindControl("Label4"))).Text;
                    ageTextBox.Text = ((Label)(gridViewRow.FindControl("Label5"))).Text;
                }
            }
            catch (Exception)
            {
            }
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            int StudentId = Convert.ToInt32(studentIdTextBox.Text);
            string msg= aStudentManager.DeletStudentById(StudentId);
            messageLabel.Text = msg;
            LoadStudentGridView();

        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            aStudent.StudentId = Convert.ToInt32(studentIdTextBox.Text);
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.RollNo = Convert.ToInt32(rollNoTextBox.Text);
            aStudent.RegNo = Convert.ToInt32(regNoTextBox.Text);
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);

            string mes= aStudentManager.UpdateStudentById(aStudent);
            messageLabel.Text = mes;
        }
    }
}