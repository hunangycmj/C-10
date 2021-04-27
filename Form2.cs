using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 新建联系人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            添加联系人 AddItemsFrm = new 添加联系人();
            AddItemsFrm.MdiParent = this;
            AddItemsFrm.Show();
            menuStrip1.Text = AddItemsFrm.Text;

        }

        private void 查询联系人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查看联系人 aboutFrm = new 查看联系人();
            aboutFrm.MdiParent = this;
            aboutFrm.Show();
            menuStrip2.Text = aboutFrm.Text;

        }
    }
}
