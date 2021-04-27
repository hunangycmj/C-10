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

namespace WindowsFormsApp1
{
    public partial class AddIteme : Form
    {
        public AddIteme()
        {
            InitializeComponent();
        }
        string connString = "Data Source=liujie.database.windows.net;Initial Catalog=kujie;User Id=liujie;Pwd=kujie2001.";
        SqlConnection conn;//声明连接对象
        SqlCommand comm;//声明命令对象
        SqlDataReader dr;//声明数据读取器对象


        private void button2_Click(object sender, EventArgs e)
        {
            //名称没填
            if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请填写分组名！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;//进入确认信息
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text.Trim();
            string sql = String.Format("INSERT INTO fenzu(fenzuName)Values('{0}')", name);
            try
            {
                conn.Open();
                comm.CommandText = sql;
                int count = comm.ExecuteNonQuery();//执行更新命令，返回值为更新的行数
                if (count > 0)
                {
                    MessageBox.Show("添加分组成功！", "添加成功", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加分组失败！", "添加失败", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AddIteme_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);//创建对象
            comm = new SqlCommand();
            comm.Connection = conn;//设置connand对象使用的connection对象

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (comboBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请填写分组名称！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    richTextBox1.Clear();
                    richTextBox1.AppendText("要添加的分组名为:");
                    richTextBox1.AppendText(comboBox1.Text);
                }
            }
        }

    }
}


