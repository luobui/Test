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
    public partial class Formupdatesalary : Form
    {
        public Formupdatesalary()
        {
            InitializeComponent();
        }

        private void salaryconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formupdatesalary_Load(object sender, EventArgs e)
        {
         
            textupdateemployeeid.Text=Formsalarychange.empid.ToString();
            textupdatesalaryamount.Text=Formsalarychange.salmount.ToString();
            datesalaryupdate.Value = DateTime.Parse(Formsalarychange.salardate);
        }

        private void salaryadd_Click(object sender, EventArgs e)
        {
            if (textupdateemployeeid.Text == ""||textupdatesalaryamount.Text==""||datesalaryupdate.Text=="")
            {
                MessageBox.Show("修改不能有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查职工ID是否合法
            if (!int.TryParse(textupdateemployeeid.Text, out int Id))
            {
                MessageBox.Show("请输入有效的职工ID", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查工资数是否合法
            if (!int.TryParse(textupdatesalaryamount.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("请输入有效的年龄", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            //检查职工id是否存在
            string sql = $"SELECT COUNT(*) FROM employees WHERE employeeID = {int.Parse(textupdateemployeeid.Text)}";
            SqlCommand cmd = new SqlCommand(sql, dao.connect());
            int employeeCount = (int)cmd.ExecuteScalar();
            if (employeeCount <= 0)
            {
                MessageBox.Show("该职工id已经存在，不能再添加", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            sql = $"UPDATE salaries  SET " +
            $"employeeid = '{int.Parse(textupdateemployeeid.Text)}', " +
            $"salaryamount={float.Parse(textupdatesalaryamount.Text)}, " +
            $"salarydate='{datesalaryupdate.Value}' " +
            $"WHERE salaryid ='{int.Parse(Formsalarychange.salid.ToString())}'; ";
            
            if(dao.Execute(sql)>0)
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
    }
}
