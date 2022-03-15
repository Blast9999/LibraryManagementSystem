
namespace LibraryManagementSystem
{
    partial class AdministratorHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pb_ZoomOut = new System.Windows.Forms.PictureBox();
            this.pb_Closure = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预约信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借出信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借出历史信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.试试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Content = new System.Windows.Forms.Panel();
            this.bookForm1 = new LibraryManagementSystem.BookForm();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Closure)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pan_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 680);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 27);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "YY科技有限公司";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1319, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 27);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前时间";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 27);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎回来：管理员";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1616, 32);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.pb_ZoomOut);
            this.panel8.Controls.Add(this.pb_Closure);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1516, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 32);
            this.panel8.TabIndex = 2;
            // 
            // pb_ZoomOut
            // 
            this.pb_ZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.pb_ZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ZoomOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("pb_ZoomOut.Image")));
            this.pb_ZoomOut.Location = new System.Drawing.Point(19, 0);
            this.pb_ZoomOut.Name = "pb_ZoomOut";
            this.pb_ZoomOut.Size = new System.Drawing.Size(39, 32);
            this.pb_ZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ZoomOut.TabIndex = 1;
            this.pb_ZoomOut.TabStop = false;
            this.pb_ZoomOut.Click += new System.EventHandler(this.pb_ZoomOut_Click);
            this.pb_ZoomOut.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pb_ZoomOut.MouseLeave += new System.EventHandler(this.pb_Closure_MouseLeave);
            // 
            // pb_Closure
            // 
            this.pb_Closure.BackColor = System.Drawing.Color.Transparent;
            this.pb_Closure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Closure.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_Closure.Image = ((System.Drawing.Image)(resources.GetObject("pb_Closure.Image")));
            this.pb_Closure.Location = new System.Drawing.Point(58, 0);
            this.pb_Closure.Name = "pb_Closure";
            this.pb_Closure.Size = new System.Drawing.Size(42, 32);
            this.pb_Closure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Closure.TabIndex = 0;
            this.pb_Closure.TabStop = false;
            this.pb_Closure.Click += new System.EventHandler(this.pb_Closure_Click);
            this.pb_Closure.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pb_Closure.MouseLeave += new System.EventHandler(this.pb_Closure_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1616, 36);
            this.panel3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页ToolStripMenuItem,
            this.试试ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.注销ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1616, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.预约信息ToolStripMenuItem,
            this.借出信息ToolStripMenuItem,
            this.借出历史信息ToolStripMenuItem1});
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.主页ToolStripMenuItem.Text = "图书管理";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            this.图书管理ToolStripMenuItem.Click += new System.EventHandler(this.图书管理ToolStripMenuItem_Click);
            // 
            // 预约信息ToolStripMenuItem
            // 
            this.预约信息ToolStripMenuItem.Name = "预约信息ToolStripMenuItem";
            this.预约信息ToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.预约信息ToolStripMenuItem.Text = "预约信息";
            this.预约信息ToolStripMenuItem.Click += new System.EventHandler(this.预约信息ToolStripMenuItem_Click);
            // 
            // 借出信息ToolStripMenuItem
            // 
            this.借出信息ToolStripMenuItem.Name = "借出信息ToolStripMenuItem";
            this.借出信息ToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.借出信息ToolStripMenuItem.Text = "借出信息";
            this.借出信息ToolStripMenuItem.Click += new System.EventHandler(this.借出信息ToolStripMenuItem_Click);
            // 
            // 借出历史信息ToolStripMenuItem1
            // 
            this.借出历史信息ToolStripMenuItem1.Name = "借出历史信息ToolStripMenuItem1";
            this.借出历史信息ToolStripMenuItem1.Size = new System.Drawing.Size(196, 28);
            this.借出历史信息ToolStripMenuItem1.Text = "借出历史信息";
            this.借出历史信息ToolStripMenuItem1.Click += new System.EventHandler(this.借出历史信息ToolStripMenuItem1_Click);
            // 
            // 试试ToolStripMenuItem
            // 
            this.试试ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.职员管理ToolStripMenuItem});
            this.试试ToolStripMenuItem.Name = "试试ToolStripMenuItem";
            this.试试ToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.试试ToolStripMenuItem.Text = "用户管理";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            this.学生管理ToolStripMenuItem.Click += new System.EventHandler(this.学生管理ToolStripMenuItem_Click);
            // 
            // 职员管理ToolStripMenuItem
            // 
            this.职员管理ToolStripMenuItem.Name = "职员管理ToolStripMenuItem";
            this.职员管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.职员管理ToolStripMenuItem.Text = "职员管理";
            this.职员管理ToolStripMenuItem.Click += new System.EventHandler(this.职员管理ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.注销ToolStripMenuItem.Text = "分类管理";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.分类管理ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem1
            // 
            this.注销ToolStripMenuItem1.Name = "注销ToolStripMenuItem1";
            this.注销ToolStripMenuItem1.Size = new System.Drawing.Size(58, 27);
            this.注销ToolStripMenuItem1.Text = "注销";
            this.注销ToolStripMenuItem1.Click += new System.EventHandler(this.注销ToolStripMenuItem1_Click);
            // 
            // pan_Content
            // 
            this.pan_Content.Controls.Add(this.bookForm1);
            this.pan_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Content.Location = new System.Drawing.Point(0, 68);
            this.pan_Content.Name = "pan_Content";
            this.pan_Content.Size = new System.Drawing.Size(1616, 612);
            this.pan_Content.TabIndex = 3;
            // 
            // bookForm1
            // 
            this.bookForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookForm1.Location = new System.Drawing.Point(0, 0);
            this.bookForm1.Name = "bookForm1";
            this.bookForm1.Size = new System.Drawing.Size(1616, 612);
            this.bookForm1.TabIndex = 0;
            // 
            // AdministratorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 707);
            this.Controls.Add(this.pan_Content);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministratorHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorHome";
            this.Load += new System.EventHandler(this.AdministratorHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Closure)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pan_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_ZoomOut;
        private System.Windows.Forms.PictureBox pb_Closure;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 试试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职员管理ToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan_Content;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预约信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借出信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借出历史信息ToolStripMenuItem1;
        private BookForm bookForm1;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem1;
    }
}