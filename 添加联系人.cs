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
    public partial class 添加联系人 : Form

    {
        public 添加联系人()
        {
            InitializeComponent();
        }
        string connString = "Data Source=liujie.database.windows.net;Initial Catalog=kujie;User Id=liujie;Pwd=kujie2001.";
        SqlConnection conn;//声明连接对象
        SqlCommand comm;//声明命令对象
    
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToString();
            string phone = textBox2.Text.ToString();
            string email = textBox3.Text.ToString();
            string qq = textBox4.Text.ToString();
            string fenzuID = comboBox1.Text.ToString();
            string familyPhone = textBox7.Text.ToString();
            string companyPhone = textBox6.Text.ToString();
            string beizhu = richTextBox1.Text.ToString();
            string sql = string.Format("insert into tel(name,phone,email,qq,fenzuID,familyPhone,companyPhone,beizhu)values"
                + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", name, phone, email, qq, fenzuID, familyPhone, companyPhone, beizhu);
            try
            {
                conn.Open();
                comm.CommandText = sql;
                int count = comm.ExecuteNonQuery();
                if (count > 0)
                    MessageBox.Show("添加联系人成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("添加联系人失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库失败！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 添加联系人_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
        }
    }
}

