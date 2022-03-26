using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();

        }
        #region 防止Form背景图片闪烁
        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams cp = base.CreateParams;

                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED    

                if (this.IsXpOr2003 == true)
                {
                    cp.ExStyle |= 0x00080000;  // Turn on WS_EX_LAYERED  
                    this.Opacity = 1;
                }

                return cp;

            }

        }  //防止闪烁  

        private Boolean IsXpOr2003
        {
            get
            {
                OperatingSystem os = Environment.OSVersion;
                Version vs = os.Version;

                if (os.Platform == PlatformID.Win32NT)
                    if ((vs.Major == 5) && (vs.Minor != 0))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
        }
        #endregion
        #region 页面事件

        #region 窗体拖动事件
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
        #region 关闭按钮鼠标经过事件
        private void pb_Closure_MouseEnter(object sender, EventArgs e)
        {
            var pbName = sender as PictureBox;
            pbName.BackColor = Color.LightGray;
        }

        private void pb_Closure_MouseLeave(object sender, EventArgs e)
        {
            var pbName = sender as PictureBox;
            pbName.BackColor = Color.Transparent;
        }
        #endregion


        #endregion
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_Closure_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AdminRegistration_Load(object sender, EventArgs e)
        {
            var Type = RegistrationBLL.GetStaffType();

            List<string> TypeName = new List<string>();
            foreach (var item in Type)
            {
                TypeName.Add(item.TypeNane);
            }
            cb_Type.DataSource = TypeName;
        }

        /// <summary>
        /// 管理员注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!Acccount)
            {
                MessageBox.Show("请填入登录账号！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!Password)
            {
                MessageBox.Show("请填入登录密码！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!CnPassword)
            {
                MessageBox.Show("两次密码不一致！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!ActualName)
            {
                MessageBox.Show("请填入真实姓名！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Phone)
            {
                MessageBox.Show("电话号码不正确！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!JobNumber)
            {
                MessageBox.Show("请填入职工工号！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            Administrator administrator = new Administrator()
            {
                LoginCode = tb_Account.Text,
                Password = tb_Password.Text,
                Name = tb_Name.Text,
                Phone = tb_Phone.Text,
                StaffType = cb_Type.SelectedIndex.ToString(),
                JobNumber = tb_JobNumber.Text

            };
            if (Judge)
            {

                var response = RegistrationBLL.AddAdministrator(administrator);

                if (response.IsSuccess)
                {
                    this.Close();
                    MessageBox.Show("用户注册成功！");
                    return;
                }
                else
                {
                    MessageBox.Show(response.Info);
                }

            }

        }
        /// <summary>
        /// 管理员注册验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Account_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Account.Text))
            {
                this.pb_Account.Image = Image.FromFile(@"..\..\Resources\正确.png");
                Acccount = true;
            }
            else
            {
                this.pb_Account.Image = Image.FromFile(@"..\..\Resources\错误.png");
                Acccount = false;
            }

            tb_Password.Text = tb_Password.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_Password.Text))
            {
                this.pb_Password.Image = Image.FromFile(@"..\..\Resources\正确.png");
                Password = true;
            }
            else
            {
                this.pb_Password.Image = Image.FromFile(@"..\..\Resources\错误.png");
                Password = false;
            }

            tb_ConfirmPassword.Text = tb_ConfirmPassword.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_ConfirmPassword.Text) && tb_ConfirmPassword.Text == tb_Password.Text)
            {
                this.pb_CnPassword.Image = Image.FromFile(@"..\..\Resources\正确.png");
                CnPassword = true;
            }
            else
            {
                this.pb_CnPassword.Image = Image.FromFile(@"..\..\Resources\错误.png");
                CnPassword = false;
            }

            tb_Name.Text = tb_Name.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_Name.Text))
            {
                this.pb_Name.Image = Image.FromFile(@"..\..\Resources\正确.png");
                ActualName = true;
            }
            else
            {
                this.pb_Name.Image = Image.FromFile(@"..\..\Resources\错误.png");
                ActualName = false;
            }


            Regex rx = new Regex(@"^((13[0-9])|(14[5,7,9])|(15[^4])|(18[0-9])|(17[0,1,3,5,6,7,8]))[0-9]{8}$");
            if (rx.IsMatch(tb_Phone.Text)) //匹配
            {
                this.pb_Phone.Image = Image.FromFile(@"..\..\Resources\正确.png");
                Phone = true;
            }
            else
            {
                this.pb_Phone.Image = Image.FromFile(@"..\..\Resources\错误.png");
                Phone = false;
            }

            tb_JobNumber.Text = tb_JobNumber.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_JobNumber.Text))
            {
                this.pb_JobNumber.Image = Image.FromFile(@"..\..\Resources\正确.png");
                JobNumber = true;
            }
            else
            {
                this.pb_JobNumber.Image = Image.FromFile(@"..\..\Resources\错误.png");
                JobNumber = false;
            }


            if (Acccount && Password && CnPassword && ActualName && Phone && JobNumber)
            {
                Judge = true;
            }
            else
            {
                Judge = false;
            }
        }


        /// <summary>
        /// 学生注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (!StudentCode)
            {
                MessageBox.Show("请正确填入登录账号(学生学号)——十位数！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!StudentPassword)
            {
                MessageBox.Show("请填入登录密码！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!StudentCnPassword)
            {
                MessageBox.Show("两次密码不一致！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!StudentName)
            {
                MessageBox.Show("请填入学生姓名！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!StudentPhone)
            {
                MessageBox.Show("电话号码不正确！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!Sex)
            {
                MessageBox.Show("请选择学生性别！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!StudentMail)
            {
                MessageBox.Show("请输入正确的邮箱！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!VerificationCode)
            {
                MessageBox.Show("请输入正确的验证码！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            };

            StudentRegistration student = new StudentRegistration()
            {
                LoginCode = tb_StudentCode.Text,
                Password = tb_StudentPassword.Text,
                Name = tb_StudentName.Text,
                Phone = tb_StudentPhone.Text,
                Sex = cb_Sex.Text,
                Mail = tb_Mail.Text,
                Remark = null

            };
            if (Judge)
            {
                var response = RegistrationBLL.AddStudent(student);

                if (response.IsSuccess)
                {
                    this.Close();
                    MessageBox.Show("学生注册成功！");
                    return;
                }
                else
                {
                    MessageBox.Show(response.Info);
                }

            }

        }
        /// <summary>
        /// 学生注册验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_StudentCode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_StudentCode.Text) && tb_StudentCode.Text.Length == 10)
            {
                this.pb_StudentCode.Image = Image.FromFile(@"..\..\Resources\正确.png");
                StudentCode = true;
            }
            else
            {
                this.pb_StudentCode.Image = Image.FromFile(@"..\..\Resources\错误.png");
                StudentCode = false;
            }

            tb_StudentPassword.Text = tb_StudentPassword.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_StudentPassword.Text))
            {
                this.pb_StudentPassword.Image = Image.FromFile(@"..\..\Resources\正确.png");
                StudentPassword = true;
            }
            else
            {
                this.pb_StudentPassword.Image = Image.FromFile(@"..\..\Resources\错误.png");
                StudentPassword = false;
            }

            tb_StudentCnPassword.Text = tb_StudentCnPassword.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_StudentCnPassword.Text) && tb_StudentCnPassword.Text == tb_StudentPassword.Text)
            {
                this.pb_StudentCnPassword.Image = Image.FromFile(@"..\..\Resources\正确.png");
                StudentCnPassword = true;
            }
            else
            {
                this.pb_StudentCnPassword.Image = Image.FromFile(@"..\..\Resources\错误.png");
                StudentCnPassword = false;
            }

            tb_StudentName.Text = tb_StudentName.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_StudentName.Text))
            {
                this.pb_StudentName.Image = Image.FromFile(@"..\..\Resources\正确.png");
                StudentName = true;
            }
            else
            {
                this.pb_StudentName.Image = Image.FromFile(@"..\..\Resources\错误.png");
                StudentName = false;
            }


            Regex rx = new Regex(@"^((13[0-9])|(14[5,7,9])|(15[^4])|(18[0-9])|(17[0,1,3,5,6,7,8]))[0-9]{8}$");
            if (rx.IsMatch(tb_StudentPhone.Text)) //匹配
            {
                this.pb_StudentPhone.Image = Image.FromFile(@"..\..\Resources\正确.png");
                StudentPhone = true;
            }
            else
            {
                this.pb_StudentPhone.Image = Image.FromFile(@"..\..\Resources\错误.png");
                StudentPhone = false;
            }

            //Regex re = new Regex(@"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?");
            Regex re = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");//w 英文字母或数字的字符串，和 [a-zA-Z0-9] 语法一样
            if (re.IsMatch(tb_Mail.Text)) //匹配
            {
                this.pb_Mail.Image = Image.FromFile(@"..\..\Resources\正确.png");
                StudentMail = true;
            }
            else
            {
                this.pb_Mail.Image = Image.FromFile(@"..\..\Resources\错误.png");
                StudentMail = false;
            }

            tb_Num.Text = tb_Num.Text.Replace(" ", "");//去空格
            if (!string.IsNullOrEmpty(tb_Num.Text) && tb_Num.Text == Num)
            {
                this.pb_Num.Image = Image.FromFile(@"..\..\Resources\正确.png");
                VerificationCode = true;
            }
            else
            {
                this.pb_Num.Image = Image.FromFile(@"..\..\Resources\错误.png");
                VerificationCode = false;
            }

            if (StudentCode && StudentPassword && StudentCnPassword && StudentName && StudentPhone && StudentMail && Sex && VerificationCode)
            {
                Judge = true;
            }
            else
            {
                Judge = false;
            }
        }
        private void cb_Sex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_Sex.Text))
            {
                this.pb_Sex.Image = Image.FromFile(@"..\..\Resources\正确.png");
                Sex = true;
            }
            else
            {
                this.pb_Sex.Image = Image.FromFile(@"..\..\Resources\错误.png");
                Sex = false;
            }

            if (StudentCode && StudentPassword && StudentCnPassword && StudentName && StudentPhone && Sex)
            {
                Judge = true;
            }
            else
            {
                Judge = false;
            }
        }

        private void tb_StudentCode_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                (sender as TextBox).SelectAll();
            });
        }


        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_VerificationCode_Click(object sender, EventArgs e)
        {
            if (Timing == 60)
            {
                if (StudentMail)
                {
                    Random random = new Random();
                    Num = null;
                    for (int i = 0; i <= 5; i++)
                    {
                        var x = random.Next(1, 10);
                        Num += x;
                    }


                    //bool IsMail = false;
                    //BackgroundWorker worker = new BackgroundWorker();//使用了多线程，加快了页面的响应速度，从而使页面响应更加流程
                    //worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
                    //{
                    //    //await Task.Run(() =>
                    //    //{
                    //    string Title = $"您的【YY图书馆】学生注册验证码为{Num}";
                    //    string Content = $"您注册验证码为【{Num}】，切勿将验证码泄露与他人，本条验证码有效期限2分钟，关闭程序需重新获取验证码！！";
                    //    IsMail = SendEmail(tb_Mail.Text, Title, Content);
                    //    //});

                    //};
                    //worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
                    //{


                    //    this.timer1.Enabled = true;
                    //    //this.timer1.Start();
                    //    this.timer2.Enabled = true;

                    //    if (!IsMail)
                    //    {
                    //        MessageBox.Show("验证码发送失败！请联系管理员查看！");
                    //    }

                    //};
                    //worker.RunWorkerAsync();


                    //if (IsMail)
                    //{
                    //    this.timer1.Enabled = true;
                    //    //this.timer1.Start();
                    //    this.timer2.Enabled = true;
                    //}


                    Task task = Task.Run(() =>
                    {
                        string Title = $"您的【YY图书馆】学生注册验证码为{Num}";
                        string Content = $"您注册验证码为【{Num}】，切勿将验证码泄露与他人，本条验证码有效期限2分钟，关闭程序需重新获取验证码！！";
                        //IsMail = SendEmail(tb_Mail.Text, Title, Content);
                        SendEmail(tb_Mail.Text, Title, Content);
                    });

                    this.timer1.Enabled = true;
                    this.timer2.Enabled = true;

                    //if (!IsMail)
                    //{
                    //    MessageBox.Show("验证码发送失败！请联系管理员查看！");
                    //}

                }
                else
                {
                    MessageBox.Show("请输入正确的邮箱信息！");

                }
            }
            else
            {
                MessageBox.Show("请勿频繁发送验证码！");
            }


        }


        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_VerificationCode.Text = $"{Timing}秒后重发";
            Timing--;
            if (Timing < 0)
            {
                //this.timer1.Stop();
                this.timer1.Enabled = false;
                lb_VerificationCode.Text = "重新发送";
                Timing = 60;
                IsSend = true;
            }
            else
            {
                IsSend = false;
            }
        }
        /// <summary>
        /// 发送验证码后2分钟刷新一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsSend)
            {
                Random random = new Random();
                for (int i = 0; i <= 5; i++)
                {
                    var x = random.Next(1, 10);
                    Num += x;
                }
            }
        }
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="mailTo">要发送的邮箱</param>
        /// <param name="mailSubject">邮箱主题</param>
        /// <param name="mailContent">邮箱内容</param>
        /// <returns>返回发送邮箱的结果</returns>
        public static bool SendEmail(string mailTo, string mailSubject, string mailContent)
        {
            // 设置发送方的邮件信息,例如使用网易的smtp
            string smtpServer = "smtp.163.com"; //SMTP服务器
            string mailFrom = "yy361641626@163.com"; //登陆用户名
            string userPassword = "BNGTSVCSSXVRALZL";//登陆密码() TWXSPSSXOKGDUWSF
            string recipientsDisplayName = "YY图书馆";//收件人显示名称

            // 邮件服务设置

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            smtpClient.Host = smtpServer; //指定SMTP服务器
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential(mailFrom, userPassword);//用户名和密码

            MailAddress from = new MailAddress(mailFrom, recipientsDisplayName);

            MailAddress to = new MailAddress(mailTo, "mailTo");

            // 发送邮件设置        

            MailMessage mailMessage = new MailMessage(from, to); // 发送人和收件人
            mailMessage.Subject = mailSubject;//主题
            mailMessage.Body = mailContent;//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.IsBodyHtml = true;//设置为HTML格式
            mailMessage.Priority = MailPriority.Low;//优先级
            try
            {
                //double qq = 0;
                //for (double i = 0; i < 10000000000000000000; i++)
                //{
                //    qq += i;
                //}
                smtpClient.Send(mailMessage); // 发送邮件

                return true;
            }
            catch (SmtpException ex)
            {
                return false;
            }

        }
        #region 判断页面数据是否正确


        #region 管理员数据
        private static bool Acccount = false;
        private static bool Password = false;
        private static bool CnPassword = false;
        private static bool ActualName = false;
        private static bool Phone = false;
        private static bool JobNumber = false;
        #endregion


        #region 学生数据
        private static bool StudentCode = false;
        private static bool StudentPassword = false;
        private static bool StudentCnPassword = false;
        private static bool StudentName = false;
        private static bool StudentPhone = false;
        private static bool StudentMail = false;
        private static bool VerificationCode = false;
        private static bool Sex = false;
        #endregion

        /// <summary>
        /// 全体通过
        /// </summary>
        private static bool Judge = false;
        /// <summary>
        /// 验证码
        /// </summary>
        private string Num { get; set; }
        /// <summary>
        /// 计时多少秒后可以获取验证码
        /// </summary>
        public int Timing { get; set; } = 60;
        /// <summary>
        /// 是否点击获取验证码
        /// </summary>
        public bool IsSend { get; set; } = false;


        #endregion


    }
}
