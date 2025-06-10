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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否确定退出", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void admin_Load(object sender, EventArgs e)
        {
            this.label1.Text = $"管理员信息：{Form1.name}  {Form1.id}";
        }

        private void 修改管理员密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdatepassword form = new FormUpdatepassword();
            form.ShowDialog();
        }

        private void 添加个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddemployees form = new FormAddemployees();
            form.ShowDialog();
        }

        private void 添加部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdepartment form=new Formdepartment();
            form.ShowDialog();
        }

        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddadmins form = new FormAddadmins();
            form.ShowDialog();
        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formemployeechange form = new Formemployeechange();
            form.ShowDialog();
        }

        private void 修改部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdepartmentchange form = new Formdepartmentchange(); 
            form.ShowDialog();
        }

        private void 修改员工职位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formpositionchange form = new Formpositionchange();
            form.ShowDialog();
        }

        private void 工资修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formsalarychange form = new Formsalarychange();
            form.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAddposition form = new FormAddposition();
            form.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormAddsalary formAddsalary = new FormAddsalary();
            formAddsalary.ShowDialog();
        }

        private void 个人信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 部门管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 修改管理员密码ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
