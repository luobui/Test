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
    public partial class FormAddposition : Form
    {
        public FormAddposition()
        {
            InitializeComponent();
        }

        private void positionconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void positionadd_Click(object sender, EventArgs e)
        {
            //判断输入不为空
            if (textpositionid.Text == "" || textpositionname.Text == "")
            {
                MessageBox.Show("职位编号和职位名称不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查id是否合法
            if (!int.TryParse(textpositionid.Text, out int id) || id<= 0)
            {
                MessageBox.Show("请输入有效的id", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
      
            Dao dao = new Dao();
            dao.connect();
            //检查职位是否存在
            string sql = $"SELECT COUNT(*) FROM Positions WHERE PositionID =  '{int.Parse(textpositionid.Text)}'";
            SqlCommand cmd = new SqlCommand(sql, dao.connect());
            int positionCount = (int)cmd.ExecuteScalar();
            if (positionCount >0)
            {
                MessageBox.Show("该职位ID已经存在，不能再添加", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dao.DaoClose();
                return;
            }
            sql = $"SET IDENTITY_INSERT positions ON;"+$"insert into positions(positionid,positiontitle) values('{int.Parse(textpositionid.Text)}','{textpositionname.Text}')"+ $"SET IDENTITY_INSERT positions off;";
            if (dao.Execute(sql) > 0)
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
    }
}
