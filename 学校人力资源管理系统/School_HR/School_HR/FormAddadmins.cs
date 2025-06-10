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
    public partial class FormAddadmins : Form
    {
        public FormAddadmins()
        {
            InitializeComponent();
        }

        private void adminsconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminsadd_Click(object sender, EventArgs e)
        {
            //判断输入不为空
            if(textadminid.Text==""||textadminpassword.Text=="")
            {
                MessageBox.Show("管理员编号和密码不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查id是否合法
            if (!int.TryParse(textadminid.Text, out int admin) || admin <= 0)
            {
                MessageBox.Show("请输入有效的id", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            Dao dao = new Dao();
            dao.connect();
            //检查部门是否存在
            string sql = $"SELECT COUNT(*) FROM employees WHERE employeeID = {int.Parse(textadminid.Text)}";
            SqlCommand cmd = new SqlCommand(sql, dao.connect());
            int departmentCount = (int)cmd.ExecuteScalar();
            if (departmentCount <= 0)
            {
                MessageBox.Show("该ID不存在,不能添加为管理员", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            sql = $"insert into admins(adminid,password) values('{int.Parse(textadminid.Text)}','{textadminpassword.Text}')";
            if(dao.Execute(sql)>0)
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

        private void textadminpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textadminid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
