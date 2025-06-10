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
    public partial class Formdepartmentchange : Form
    {
        public Formdepartmentchange()
        {
            InitializeComponent();
        }
        public static int departid;
        public static string departname;
        //加载数据
        private void Loaddepartment()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from departments";
            SqlDataReader reader=dao.read(sql);

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString());
            }
            reader.Close();
            dao.DaoClose();
        }

        private void Formdepartmentchange_Load(object sender, EventArgs e)
        {
            //加载数据库数据
            Loaddepartment();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("当前选择为无效信息","消息",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labID.Text = id;
            labname.Text = name;


            //**************************************************8
            departid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            departname = dataGridView1.CurrentRow.Cells[1].Value.ToString() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loaddepartment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取关键字内容
            string key=textkey.Text;
            // 模糊查询
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from departments where departmentid like '%{key}%' or departmentname like '%{key}%'";
            SqlDataReader reader = dao.read(sql);
            //清空原表格
            dataGridView1.Rows.Clear();

            //加载新数据
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString());
            }
            reader.Close();
            dao.DaoClose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //删除选中的数据
            Dao dao = new Dao();
            dao.connect();
            string sql = $"delete departments where departmentid='{int.Parse(labID.Text)}'";
            if (dao.Execute(sql) > 0)
            {
                //删除成功
                MessageBox.Show("删除成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labID.Text = "NULL";
                labname.Text = "NULL";
                Loaddepartment();
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("删除失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dao.DaoClose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取要删除的部门编号
            if (labID.Text == "NULL")
            {
                MessageBox.Show("未选择要删除的部门", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Formupdatedepartment form=new Formupdatedepartment();
            form.ShowDialog();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
