using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class 查看联系人 : Form
    {
        public 查看联系人()
        {
            InitializeComponent();
        }
        string connString = "Data Source=liujie.database.windows.net;Initial Catalog=kujie;User Id=liujie;Pwd=kujie2001.";
        SqlConnection conn;//声明连接对象
      
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from tel";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);//填充DataSet
            dgvList.DataSource = ds.Tables[0];

        }

        private void 查看联系人_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }
    }
}
