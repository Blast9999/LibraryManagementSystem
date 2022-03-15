using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StudentHomepage : Form
    {
        public StudentHomepage()
        {
            InitializeComponent();
        }
        //show传入的参数
        public static string UserName = null;
        private string use;
        public static string UserCode = null;
        public StudentHomepage(string use,string userCode)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.use = use;
            UserName = use;
            UserCode = userCode;
        }
        private void StudentHomepage_Load(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("欢迎回来：{0}({1})", UserName, UserCode);
            this.label2.Text = "当前时间:" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = "当前时间:" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        #region 页面设计
        #region 窗体拖动
        Point mPoint;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);

            }
        }


        #endregion
        /// <summary>
        /// 鼠标进入关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_ZoomOut_MouseEnter(object sender, EventArgs e)
        {
            var pbName = sender as PictureBox;
            pbName.BackColor = Color.LightGray;
        }
        /// <summary>
        /// 鼠标移出关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_ZoomOut_MouseLeave(object sender, EventArgs e)
        {
            var pbName = sender as PictureBox;
            pbName.BackColor = Color.Transparent;
        }
        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_ZoomOut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = true;

        }
        private void pb_Closure_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                DialogResult result = MessageBox.Show("确定要退出系统？", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    //如果用户选择了“是”,则执行窗体关闭事件
                    Application.Exit();
                }
                else
                {
                    //如果选择了否，则取消窗体关闭事件

                }

            }
        }


        #endregion

        private void 借阅图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            BorrowBooks borrowBooks = new BorrowBooks();
            pan_Content.Controls.Add(borrowBooks);
            borrowBooks.Dock = DockStyle.Fill;
        }
        private void 归还图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            ReturnBooksForm returnBooksForm = new ReturnBooksForm();
            returnBooksForm.UserName = UserName;
            returnBooksForm.UserCode = UserCode;
            pan_Content.Controls.Add(returnBooksForm);
            returnBooksForm.Dock = DockStyle.Fill;
        }
        private void 预约管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            UserAppointmentManagement management = new UserAppointmentManagement();
            management.UserName = UserName;
            management.UserCode = UserCode;
            pan_Content.Controls.Add(management);
            management.Dock = DockStyle.Fill;
        }
        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInformation personalInformation = new PersonalInformation();
            personalInformation.UserName = UserName;
            personalInformation.UserCode = UserCode;
            personalInformation.ShowDialog();
        }
        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要注销？", "提示：",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //判断用户最终点击那个按钮
            if (result == DialogResult.Yes)
            {
                //如果用户选择了“是”,则执行窗体关闭事件
                Login login = new Login();
                Program.context.MainForm = login;
                login.Show();
                this.Close();
            }
            else
            {
                //如果选择了否，则取消窗体关闭事件

            }
        }

       
    }
}
