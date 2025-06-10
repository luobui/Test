using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_HR
{
    public partial class FormAddemployees : Form
    {
        public FormAddemployees()
        {
            InitializeComponent();
        }

        private void employeesconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeesadd_Click(object sender, EventArgs e)
        {
            //判断输入不得为空
            if(textemployeesid.Text==""||textemployeesname.Text==""
                ||textemployeeage.Text==""||textemployeegender.Text==""
                ||textdepartmentid.Text==""||textpositionid.Text==""
                ||textemail.Text==""||dateemployees.Text=="")
            {
                MessageBox.Show("所添加的类别不能有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查年龄是否合法
            if (!int.TryParse(textemployeeage.Text, out int age) || age <= 0)
            {
                MessageBox.Show("请输入有效的年龄", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 检查性别是否合法
            string gender = textemployeegender.Text.Trim().ToLower();
            if (gender != "男" && gender != "女")
            {
                MessageBox.Show("性别必须为'男'或'女'", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 检查部门ID是否合法
            if (!int.TryParse(textdepartmentid.Text, out int departmentId))
            {
                MessageBox.Show("请输入有效的部门ID", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 检查职位ID是否合法
            if (!int.TryParse(textpositionid.Text, out int positionId))
            {
                MessageBox.Show("请输入有效的职位ID", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            //检查职工id是否存在
            string sql = $"SELECT COUNT(*) FROM employees WHERE employeeID = {int.Parse(textemployeesid.Text)}";
            SqlCommand cmd = new SqlCommand(sql, dao.connect());
            int employeeCount = (int)cmd.ExecuteScalar();
            if (employeeCount > 0)
            {
                MessageBox.Show("该职工id已经存在，不能再添加", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            //检查部门是否存在
            sql = $"SELECT COUNT(*) FROM Departments WHERE DepartmentID = {int.Parse(textdepartmentid.Text)}";
            cmd = new SqlCommand(sql, dao.connect());
            int departmentCount = (int)cmd.ExecuteScalar();
            if (departmentCount <= 0)
            {
                MessageBox.Show("该部门ID不存在", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            //检查职位是否存在
            sql = $"SELECT COUNT(*) FROM Positions WHERE PositionID =  '{int.Parse(textpositionid.Text)}'";
            cmd = new SqlCommand(sql, dao.connect());
            int positionCount = (int)cmd.ExecuteScalar();
            if (positionCount <= 0)
            {
                MessageBox.Show("该职位ID不存在", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
          
            sql = $"SET IDENTITY_INSERT employees ON;" + $"insert into employees (employeeid,[Name],Age,Gender,DepartmentID, PositionID, HireDate, Email) values('{int.Parse(textemployeesid.Text)}','{textemployeesname.Text}','{int.Parse(textemployeeage.Text)}','{textemployeegender.Text}','{int.Parse(textdepartmentid.Text)}','{int.Parse(textpositionid.Text)}','{dateemployees.Value}','{textemail.Text}')"+$"SET IDENTITY_INSERT employees off;";
            if (dao.Execute(sql)>0)
            {
                dao.DaoClose();
                MessageBox.Show("添加成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close() ;
            }
            else
            {
                dao.DaoClose();
                MessageBox.Show("添加失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textemployeesid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
