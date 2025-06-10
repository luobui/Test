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
    public partial class FormUpdatepassword : Form
    {
        public FormUpdatepassword()
        {
            InitializeComponent();
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {
            if (textnewpassword.Text == "" || textoldpassword.Text == "" || textokpassword.Text == "")
            {
                MessageBox.Show("密码不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(textnewpassword.Text!=textokpassword.Text)
            {
                MessageBox.Show("修改密码与确认密码不匹配", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(textoldpassword.Text==textnewpassword.Text)
            {
                MessageBox.Show("新旧密码不能相同", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select password from admins where adminid='{Form1.id}'";
            SqlDataReader reader=dao.read(sql);
            reader.Read();
            if (reader[0].ToString()!=textoldpassword.Text)
            {
                MessageBox.Show("原密码输入错误请重输", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql=$"update admins set password='{textokpassword.Text}' where adminid='{Form1.id}'";
            if(dao.Execute(sql)>0)
            {
                MessageBox.Show("修改成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Question);
                reader.Close();
                dao.DaoClose();
            }
            else
                MessageBox.Show("修改失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }

        private void texoldpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdatepassword_Load(object sender, EventArgs e)
        {

        }
    }
}
