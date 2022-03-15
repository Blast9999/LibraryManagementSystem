using BLL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
        #region 防止Form背景图片闪烁
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
        #endregion
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


        #endregion

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string LoginCode = tb_Name.Text;
            string Password = tb_Password.Text;
            string Type;
            if (!string.IsNullOrEmpty(LoginCode) && !string.IsNullOrEmpty(Password))
            {
                if (LoginCode.Length == 10)
                {
                    Type = "1";//学生
                }
                else
                {
                    Type = "0";//管理员
                }
                var log = LoginBLL.Login(LoginCode, Password, Type);

                if (log != null)
                {

                    if (Type == "1") //学生
                    {
                        StudentHomepage home = new StudentHomepage(log.Name,log.LoginCode);
                        Program.context.MainForm = home;
                        home.Show();
                        this.Close();
                    }
                    else if (Type == "0")//管理员
                    {
                        AdministratorHome home = new AdministratorHome(log.Name);
                        Program.context.MainForm = home;
                        home.Show();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("账号或密码不正确！");
                }
            }
            else
            {
                MessageBox.Show("请输入账号密码！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            AdminRegistration Registration = new AdminRegistration();
            //Registration.Show();
            Registration.ShowDialog();
        }

        
    }
}
