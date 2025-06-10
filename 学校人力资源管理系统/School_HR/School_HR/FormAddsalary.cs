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
    public partial class FormAddsalary : Form
    {
        public FormAddsalary()
        {
            InitializeComponent();
        }

        private void salaryconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salaryadd_Click(object sender, EventArgs e)
        {
            //判断输入不得为空
            if (textsalaryid.Text==""||textemployeeid.Text==""||textsalaryamount.Text==""||datesalary.Text=="")
            {
                MessageBox.Show("所添加的类别不能有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查工资id是否合法
            if (!int.TryParse(textsalaryid.Text, out int id) || id <= 0)
            {
                MessageBox.Show("请输入有效的工资id", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查职工编号是否合法
            if (!int.TryParse(textemployeeid.Text, out int eid) || eid <= 0)
            {
                MessageBox.Show("请输入有效的职工id", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查工资输入是否合法
            if (!int.TryParse(textsalaryamount.Text, out int salary) || salary <= 0)
            {
                MessageBox.Show("请输入有效的工资", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            //检查职工是否存在
            string sql = $"SELECT COUNT(*) FROM employees WHERE employeeID = {int.Parse(textemployeeid.Text)}";
            SqlCommand cmd = new SqlCommand(sql, dao.connect());
            int departmentCount = (int)cmd.ExecuteScalar();
            if (departmentCount <= 0)
            {
                MessageBox.Show("该职工ID不存在", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            sql = $"SET IDENTITY_INSERT salaries ON;" +
             $"INSERT INTO salaries (salaryid, employeeid, salaryamount, salarydate) " +
             $"VALUES ('{int.Parse(textsalaryid.Text)}', '{int.Parse(textemployeeid.Text)}', '{float.Parse(textsalaryamount.Text)}', '{datesalary.Value}');" +
             $"SET IDENTITY_INSERT salaries OFF;";
            if (dao.Execute(sql) > 0)
            {
                dao.DaoClose();
                MessageBox.Show("添加成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dao.DaoClose();
                MessageBox.Show("添加失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
