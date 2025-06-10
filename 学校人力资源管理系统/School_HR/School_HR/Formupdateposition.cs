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
    public partial class Formupdateposition : Form
    {
        public Formupdateposition()
        {
            InitializeComponent();
        }

        private void positionconsel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formupdateposition_Load(object sender, EventArgs e)
        {
            
            textupdatepositionname.Text=Formpositionchange.positname.ToString();
        }

        private void positionupdate_Click(object sender, EventArgs e)
        {
            if (textupdatepositionname.Text == "")
            {
                MessageBox.Show("修改不能有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            string sql = $"UPDATE positions  SET " +
            $"positiontitle = '{textupdatepositionname.Text}' " +
            $"WHERE positionid ='{int.Parse(Formpositionchange.positid.ToString())}'; ";                                                 //
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
