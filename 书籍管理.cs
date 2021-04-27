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
    public partial class 书籍管理 : Form
    {
        public 书籍管理()
        {
            InitializeComponent();
        }
        DataSet dataSet;
        SqlDataAdapter dataAdapter;

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=liujie.database.windows.net;Initial Catalog=kujie;User Id=liujie;Pwd=kujie2001.";
            SqlConnection conn = new SqlConnection(connString);//创建SqlConnection对象
            string sql = string.Format("select * from Books");
            dataAdapter = new SqlDataAdapter(sql, conn);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "MyData");
            dataGridView1.DataSource = dataSet.Tables[0];
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataSet, "MyData");
        }
    }
}

      