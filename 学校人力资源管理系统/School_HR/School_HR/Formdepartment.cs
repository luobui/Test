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
    public partial class Formdepartment : Form
    {
        public Formdepartment()
        {
            InitializeComponent();
        }

        private void departmentconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentadd_Click(object sender, EventArgs e)
        {
            if(textdepartmentid.Text==""||textdepartmentname.Text=="")
            {
                MessageBox.Show("部门编号和部门名称不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查部门ID是否合法
            if (!int.TryParse(textdepartmentid.Text, out int departmentId))
            {
                MessageBox.Show("请输入有效的部门ID", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            //检查部门是否存在
            string sql = $"SELECT COUNT(*) FROM Departments WHERE DepartmentID = {int.Parse(textdepartmentid.Text)}";
            SqlCommand cmd = new SqlCommand(sql, dao.connect());
            int departmentCount = (int)cmd.ExecuteScalar();
            if (departmentCount > 0)
            {
                MessageBox.Show("该部门ID已经存在，不能再添加", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            sql = $"SET IDENTITY_INSERT departments ON;" + $"insert into departments (departmentid,departmentname) values('{int.Parse(textdepartmentid.Text)}','{textdepartmentname.Text}')" + $"SET IDENTITY_INSERT departments off;";
            if (dao.Execute(sql)>0)
            {
                dao.DaoClose();
                MessageBox.Show("添加成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dao.DaoClose();
                MessageBox.Show("添加失败请重试", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
