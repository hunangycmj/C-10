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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=kuxiaojie.database.windows.net;Initial Catalog=kuxiaojie;User Id=kuxiaojie;Pwd=kujie2001.";
            SqlConnection conn = new SqlConnection(connString);
            string sql = string.Format("select * from Books");
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString(1) + "\n");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库加载错误");
            }
            finally
            {
                conn.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

       