using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_HR
{
    public partial class Formupdateemployee : Form
    {
        public Formupdateemployee()
        {
            InitializeComponent();
        }

        private void Formupdateemployee_Load(object sender, EventArgs e)
        {


            textupdateemployeesname.Text=Formemployeechange.empname.ToString();
            textupdateemployeeage.Text=Formemployeechange.age.ToString();
            textupdateemployeegender.Text=Formemployeechange.gender.ToString();
            textupdatedepartmentid.Text=Formemployeechange.departid.ToString();
            textupdatepositionid.Text=Formemployeechange.positid.ToString();
            textupdateemail.Text=Formemployeechange.EMAIL.ToString();
            dateupdateemployees.Value = DateTime.Parse(Formemployeechange.date);
        }

        private void employeesconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void employeesadd_Click(object sender, EventArgs e)
        {
            if( textupdateemployeesname.Text == ""||textupdateemployeeage.Text==""
                ||textupdateemployeegender.Text==""|| textupdatedepartmentid.Text==""
                ||textupdatepositionid.Text==""||textupdateemail.Text==""
                ||dateupdateemployees.Text=="")
            {
                MessageBox.Show("修改不能有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查年龄是否合法
            if (!int.TryParse(textupdateemployeeage.Text, out int age) || age <= 0)
            {
                MessageBox.Show("请输入有效的年龄", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 检查性别是否合法
            string gender = textupdateemployeegender.Text.Trim().ToLower();
            if (gender != "男" && gender != "女")
            {
                MessageBox.Show("性别必须为'男'或'女'", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 检查部门ID是否合法
            if (!int.TryParse(textupdatedepartmentid.Text, out int departmentId))
            {
                MessageBox.Show("请输入有效的部门ID", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 检查职位ID是否合法
            if (!int.TryParse(textupdatepositionid.Text, out int positionId))
            {
                MessageBox.Show("请输入有效的职位ID", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            //检查部门是否存在
            string sql = $"SELECT COUNT(*) FROM Departments WHERE DepartmentID = {int.Parse(textupdatedepartmentid.Text)}";
            SqlCommand cmd = new SqlCommand(sql, dao.connect());
            int departmentCount = (int)cmd.ExecuteScalar();
            if (departmentCount <= 0)
            {
                MessageBox.Show("该部门ID不存在", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            //检查职位是否存在
            sql = $"SELECT COUNT(*) FROM Positions WHERE PositionID =  '{int.Parse(textupdatepositionid.Text)}'";
            cmd = new SqlCommand(sql, dao.connect());
            int positionCount = (int)cmd.ExecuteScalar();
            if (positionCount <= 0)
            {
                MessageBox.Show("该职位ID不存在", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            //修改数据
            sql = $"SET IDENTITY_INSERT employees ON; " +
             $"UPDATE employees  SET " +
             
             $"[name] = '{textupdateemployeesname.Text}', " +
             $" age= '{int.Parse(textupdateemployeeage.Text)}', " +
             $"gender = '{textupdateemployeegender.Text}', " +
             $"departmentid = '{int.Parse(textupdatedepartmentid.Text)}', " +
             $"positionid = '{int.Parse(textupdatepositionid.Text)}', " +
             $"hiredate = '{dateupdateemployees.Value}', " +
             $"email = '{textupdateemail.Text}' " +
             $"WHERE employeeid ='{int.Parse(Formemployeechange.empid.ToString())}'; " +
             $"SET IDENTITY_INSERT employees OFF;";                                                   //
            if (dao.Execute(sql) > 0)
            {
                //删除成功
                dao.DaoClose();
                MessageBox.Show("修改成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dao.DaoClose();
                MessageBox.Show("修改失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dao.DaoClose();
            }
        }

        private void Formupdateemployee_Click(object sender, EventArgs e)
        {

        }
    }
}
