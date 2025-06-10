using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_HR
{
    public partial class Formupdatedepartment : Form
    {
        public Formupdatedepartment()
        {
            InitializeComponent();
        }

        private void departmentconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formupdatedepartment_Load(object sender, EventArgs e)
        {
            
            textupdatedepartmentname.Text=Formdepartmentchange.departname.ToString();
        }

        private void departmentadd_Click(object sender, EventArgs e)
        {
            if (textupdatedepartmentname.Text=="")
            {
                MessageBox.Show("修改不能有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            string sql = $"UPDATE departments  SET " +
            $"departmentname = '{textupdatedepartmentname.Text}' " +
            $"WHERE departmentid ='{int.Parse(Formdepartmentchange.departid.ToString())}'; ";                                                 //
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
    }
}
