using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_HR
{
    internal class Dao
    {
        SqlConnection sc;//数据库连接对象
        public SqlConnection connect()//连接数据库
        {
            string str = @"Data Source=.;Initial Catalog=SchoolHR;Integrated Security=True";//
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)//执行一条sq1语句
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//获取执行sq1语句后
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)//读取数据库中的数据
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()//关闭数据库
        {
            sc.Close();
        }
    }
}