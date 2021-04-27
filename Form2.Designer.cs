
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.通讯录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通讯录ToolStripMenuItem,
            this.新建分组ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1190, 32);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 通讯录ToolStripMenuItem
            // 
            this.通讯录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建联系人ToolStripMenuItem,
            this.查询联系人ToolStripMenuItem});
            this.通讯录ToolStripMenuItem.Name = "通讯录ToolStripMenuItem";
            this.通讯录ToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.通讯录ToolStripMenuItem.Text = "通讯录";
            // 
            // 新建联系人ToolStripMenuItem
            // 
            this.新建联系人ToolStripMenuItem.Name = "新建联系人ToolStripMenuItem";
            this.新建联系人ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.新建联系人ToolStripMenuItem.Text = "新建联系人";
            this.新建联系人ToolStripMenuItem.Click += new System.EventHandler(this.新建联系人ToolStripMenuItem_Click);
            // 
            // 查询联系人ToolStripMenuItem
            // 
            this.查询联系人ToolStripMenuItem.Name = "查询联系人ToolStripMenuItem";
            this.查询联系人ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.查询联系人ToolStripMenuItem.Text = "查询联系人";
            this.查询联系人ToolStripMenuItem.Click += new System.EventHandler(this.查询联系人ToolStripMenuItem_Click);
            // 
            // 新建分组ToolStripMenuItem
            // 
            this.新建分组ToolStripMenuItem.Name = "新建分组ToolStripMenuItem";
            this.新建分组ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.新建分组ToolStripMenuItem.Text = "新建分组";
            this.新建分组ToolStripMenuItem.Click += new System.EventHandler(this.新建分组ToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 762);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 通讯录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建联系人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询联系人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建分组ToolStripMenuItem;
    }
}