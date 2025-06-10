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
    public partial class Formsalarychange : Form
    {
        public Formsalarychange()
        {
            InitializeComponent();
        }

        public static int salid;
        public static int empid;
        public static float salmount;
        public static string salardate;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载数据库
        private void Loadsalary()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from salaries";
            SqlDataReader reader=dao.read(sql);

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),reader[1].ToString(),
                    reader[2].ToString(), reader[3].ToString());
            }
            reader.Close();
            dao.DaoClose();
        }
        private void Formsalarychange_Load(object sender, EventArgs e)
        {
            //加载数据库到表中；
            Loadsalary();   
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells == null || dataGridView1.CurrentRow.Cells[0].Value==null)
            {
                MessageBox.Show("当前选中无效","消息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string salaryid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string employeeid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labsalaryID.Text = salaryid;
            labemployeeid.Text = employeeid;



            //******************************
            salid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            empid = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            salmount = float.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            salardate = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loadsalary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取关键字内容
            string key =textkey.Text;
            //模糊识别
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from salaries where salaryid like '%{key}%' or employeeid like '%{key}%'";
            SqlDataReader reader = dao.read(sql);
            //清空原先表格
            dataGridView1.Rows.Clear();
            //加载新表格数据
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(),
                    reader[2].ToString(), reader[3].ToString());
            }
            reader.Close();
            dao.DaoClose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //删除数据
            Dao dao = new Dao();
            dao.connect();
            string sql = $"delete salaries where salaryid='{int.Parse(labsalaryID.Text)}'";
            if (dao.Execute(sql) > 0)
            {
                //删除成功
                MessageBox.Show("删除成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labsalaryID.Text = "NULL";
                labemployeeid.Text = "NULL";
                Loadsalary();
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("删除失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取要修改的工资编号
            if (labsalaryID.Text == "NULL")
            {
                MessageBox.Show("未选择要删除的工资信息", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Formupdatesalary form=new Formupdatesalary();
            form.ShowDialog();
        }
    }
}
