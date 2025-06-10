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
    public partial class Form1 : Form
    {
        public static int id;
        public static string name;
        public Form1()
        {
            InitializeComponent();
        }
        //管理员登录方法
        public void Admitlogin()
        {
            int id = int.Parse(textid.Text);
            string password = textpassword.Text;

            Dao dao=new Dao();
            dao.connect();
            string sql = $"select * from admins where adminID='{id}' and password='{password}'";   
            SqlDataReader reader=dao.read(sql);
            if(reader.Read()==true)
            {
                Form1.id = id;
                sql = $"select [name] from employees where employeeID='{id}'";
                reader = dao.read(sql);
                reader.Read();
                if (remberpassword.Checked == false)
                {
                    textid.Text = "";
                    textpassword.Text = "";
                }
                admin form = new admin();
                form.ShowDialog();
            }
            else
            {
                //登录失败
                MessageBox.Show("登录失败请检查账号或者密码是否正确", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes== MessageBox.Show("是否确定退出","消息",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                this.Close();
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {
            if(textid.Text==""||textpassword.Text=="")
            {
                MessageBox.Show("账户或密码不能为空", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

         
            Admitlogin();

        }

       
        private void txtlogin_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textid.Text, out int adminid) || adminid <= 0)
            {
                MessageBox.Show("请输入有效的账号", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textid.Text == "" || textpassword.Text == "")
            {
                MessageBox.Show("账户或密码不能为空", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            Admitlogin();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormLogon form=new FormLogon();
            form.ShowDialog();
        }
    }
}
