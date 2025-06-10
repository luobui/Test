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
    public partial class Formemployeechange : Form
    {
        public Formemployeechange()
        {
            InitializeComponent();
        }
        public static int empid;
        public static string empname;
        public static int age;
        public static string gender;
        public static int departid;
        public static int positid;
        public static string date;
        public static string EMAIL;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载数据库到表格
        private void Loademployees()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from employees";
            SqlDataReader reader = dao.read(sql);

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(),
                    reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                    reader[5].ToString(), reader[6].ToString(), reader[7].ToString());
            }
            reader.Close(); 
            dao.DaoClose();
        }
        private void Formemployeechange_Load(object sender, EventArgs e)
        {
            //加载界面的同时将数据库中的数据加载到表格当中
            Loademployees();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells[0].Value==null)
            {
                MessageBox.Show("当前选择为空","消息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string id=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labID.Text = id;
            labname.Text = name;




            //************************************************
            empid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            empname=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            age = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            gender=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            departid = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            positid = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            date=dataGridView1.CurrentRow.Cells[6].Value.ToString();
            EMAIL=dataGridView1.CurrentRow.Cells[7].Value.ToString();
    }

        private void button4_Click(object sender, EventArgs e)
        {
            Loademployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取关键字内容
            string key=textkey.Text.Trim();
            //模糊查询
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from employees where name like '%{key}%' or employeeid like '%{key}%'or age like '%{key}%'or gender like '%{key}%' or email like '%{key}%'";
            SqlDataReader reader = dao.read(sql);
            //清空原先表格
            dataGridView1.Rows.Clear();
            //读入数据

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(),
                    reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                    reader[5].ToString(), reader[6].ToString(), reader[7].ToString());
            }
            reader.Close();
            dao.DaoClose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //删除数据
            Dao dao = new Dao();
            dao.connect();
            string sql = $"delete employees where employeeid='{int.Parse(labID.Text)}'";
            if(dao.Execute(sql)>0)
            {
                //删除成功
                MessageBox.Show("删除成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labID.Text = "NULL";
                labname.Text = "NULL";
                Loademployees();
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("删除失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取需要删除的目标
            if (labID.Text == "NULL")
            {
                MessageBox.Show("未选择要删除的教职工信息", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Formupdateemployee form=new Formupdateemployee();
            form.ShowDialog();
        }

        private void Formemployeechange_Click(object sender, EventArgs e)
        {

        }
    }
}
