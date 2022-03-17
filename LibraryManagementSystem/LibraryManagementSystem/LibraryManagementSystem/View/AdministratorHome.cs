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
    public partial class AdministratorHome : Form
    {
        public AdministratorHome()
        {
            InitializeComponent();
        }
        //show传入的参数
        public static string UserName = null;
        private string use;
        public AdministratorHome(string use)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.use = use;
            UserName = use;
        }

        private void AdministratorHome_Load(object sender, EventArgs e)
        {
            this.label1.Text = $"欢迎回来【{UserName}】";
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
        #region 页面设计
        #region 窗体拖动
        Point mPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            var pbName = sender as PictureBox;
            pbName.BackColor = Color.LightGray;
        }
        /// <summary>
        /// 鼠标移出关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_Closure_MouseLeave(object sender, EventArgs e)
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
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0014)  //禁止清除背景消息
                return;
            base.WndProc(ref m);
        }
        #endregion
        //#region 防止Form背景图片闪烁
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {

        //        CreateParams cp = base.CreateParams;

        //        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED    

        //        if (this.IsXpOr2003 == true)
        //        {
        //            cp.ExStyle |= 0x00080000;  // Turn on WS_EX_LAYERED  
        //            this.Opacity = 1;
        //        }

        //        return cp;

        //    }

        //}  //防止闪烁  

        //private Boolean IsXpOr2003
        //{
        //    get
        //    {
        //        OperatingSystem os = Environment.OSVersion;
        //        Version vs = os.Version;

        //        if (os.Platform == PlatformID.Win32NT)
        //            if ((vs.Major == 5) && (vs.Minor != 0))
        //                return true;
        //            else
        //                return false;
        //        else
        //            return false;
        //    }
        //}
        //#endregion

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            StudentForm studentForm = new StudentForm();
            pan_Content.Controls.Add(studentForm);
            studentForm.Dock = DockStyle.Fill;
        }

        private void 职员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            StaffForm staffForm = new StaffForm();
            pan_Content.Controls.Add(staffForm);
            staffForm.Dock = DockStyle.Fill;
        }


        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            BookForm bookForm = new BookForm();
            pan_Content.Controls.Add(bookForm);
            bookForm.Dock = DockStyle.Fill;
        }

        private void 借出历史信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            HistoryLendInfoForm historyLendInfoForm = new HistoryLendInfoForm();
            pan_Content.Controls.Add(historyLendInfoForm);
            historyLendInfoForm.Dock = DockStyle.Fill;
        }

        private void 预约信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            BookingInfoForm bookingInfoForm = new BookingInfoForm();
            pan_Content.Controls.Add(bookingInfoForm);
            bookingInfoForm.Dock = DockStyle.Fill;
        }

        private void 借出信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            LendInfoForm lendInfoForm = new LendInfoForm();
            pan_Content.Controls.Add(lendInfoForm);
            lendInfoForm.Dock = DockStyle.Fill;
        }

        private void 分类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_Content.Controls.Clear();
            ClassificationForm classificationForm = new ClassificationForm();
            pan_Content.Controls.Add(classificationForm);
            classificationForm.Dock = DockStyle.Fill;
        }

        private void 注销ToolStripMenuItem1_Click(object sender, EventArgs e)
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
