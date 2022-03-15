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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LendInfoForm : UserControl
    {
        public LendInfoForm()
        {
            InitializeComponent();
        }

        #region 分页数据
        /// <summary>
        /// 当前页
        /// </summary>
        public static int? PageNum { get; set; } = 1;
        /// <summary>
        /// 每页数量
        /// </summary>
        public static int? PageSize { get; set; } = 10;
        int totalPage;//总页数
        #endregion
        #region 页面数据
        /// <summary>
        /// 借书数据
        /// </summary>
        public List<LendInfoModel> LendInfo { get; set; }
        #endregion
        private void LendInfoForm_Load(object sender, EventArgs e)
        {
            List<string> PageSize = new List<string>();
            PageSize.Add("1");
            PageSize.Add("5");
            PageSize.Add("10");
            PageSize.Add("20");
            PageSize.Add("50");
            cb_PageSize.DataSource = PageSize;
            cb_PageSize.SelectedIndex = 3;
            bt_Inquire_Click(null, null);
        }

        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            LendInfoRequest request = new LendInfoRequest()
            {
                Title = tb_Title.Text,
                StudentName = tb_StudentName.Text,
                PageNum = PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)
            };

            LendInfo = BookManagementBLL.GetLendInfoList(request, out totalPage);
            if (LendInfo != null)
            {
                this.dgv_BookLendInfo.AutoGenerateColumns = false;
                this.label4.Text = string.Format("{0}/{1}", PageNum, totalPage);
                dgv_BookLendInfo.DataSource = LendInfo;
            }
            else
            {
                dgv_BookLendInfo.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LendInfo != null)
            {
                int num = 0;
                foreach (var item in LendInfo)
                {
                    if (Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(item.EndTime)) < Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:01")))
                    {
                        dgv_BookLendInfo.Rows[num].DefaultCellStyle.BackColor = Color.Red;
                    }
                    num++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                if (btn.Text == "首页")
                {
                    PageNum = 1;
                }
                else if (btn.Text == "上一页")
                {
                    PageNum--;
                    if (PageNum <= 0)
                    {
                        PageNum = 1;
                    }
                }
                else if (btn.Text == "下一页")
                {
                    PageNum++;
                    if (PageNum >= totalPage)
                    {
                        PageNum = totalPage;
                    }
                }
                else if (btn.Text == "尾页")
                {
                    PageNum = totalPage;
                }
                else
                {
                    PageNum = 1;
                }
            }
            else
            {
                PageNum = 1;
            }

            LendInfoRequest request = new LendInfoRequest()
            {
                Title = tb_Title.Text,
                StudentName = tb_StudentName.Text,
                PageNum = PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)
            };

            LendInfo = BookManagementBLL.GetLendInfoList(request, out totalPage);
            if (LendInfo != null)
            {
                this.dgv_BookLendInfo.AutoGenerateColumns = false;
                this.label4.Text = string.Format("{0}/{1}", PageNum, totalPage);
                dgv_BookLendInfo.DataSource = LendInfo;
            }
            else
            {
                dgv_BookLendInfo.DataSource = null;
            }

        }

        private async void dgv_BookLendInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_BookLendInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "提醒还书")
            {
                var UserCode = dgv_BookLendInfo.SelectedRows[0].Cells[1].Value.ToString();
                var Name = dgv_BookLendInfo.SelectedRows[0].Cells[2].Value.ToString();
                var Title = dgv_BookLendInfo.SelectedRows[0].Cells[3].Value.ToString();
                var EndDate = DateTimeHelper.DateTimeConvertToTimestamp(Convert.ToDateTime(dgv_BookLendInfo.SelectedRows[0].Cells[7].Value.ToString()));
                string Mail = null;
                DialogResult result = MessageBox.Show($"确定要提醒学生【{Name}】归还书籍:《{Title}》！", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                await Task.Run(() =>
                {
                    Mail = StudentManagementBLL.GetStudentPersonalInformation(UserCode, Name).Mail;
                });
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(Mail))
                    {

                        string Remind = null;
                        if (
                            DateTimeHelper.TimestampConvertToDateTime(EndDate) > Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:01")) &&
                            DateTimeHelper.TimestampConvertToDateTime(EndDate) < Convert.ToDateTime(DateTime.Now.AddDays(7).ToString("yyyy-MM-dd 00:00:01"))
                            )
                        {
                            ///到期提醒：剩余7天提醒读者图书将要到期；
                            Remind = "1";
                        }
                        else if (DateTimeHelper.TimestampConvertToDateTime(EndDate) < Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:01")))
                        {
                            //逾期提醒：过期1天提醒读者归还图书；
                            Remind = "2";
                        }
                        else if (DateTimeHelper.TimestampConvertToDateTime(EndDate) > Convert.ToDateTime(DateTime.Now.AddDays(7).ToString("yyyy-MM-dd 00:00:01")))
                        {
                            //结束日期大于七天，提醒用户还有还有多久到期！
                            Remind = "3";
                        }


                        bool IsSucceed = false;//是否发送成功
                        BackgroundWorker worker = new BackgroundWorker();//使用了多线程，加快了页面的响应速度，从而使页面响应更加流程
                        worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
                        {
                            string content = "";//邮箱内容
                            if (Remind == "1")
                            {
                                DateTime dt1 = Convert.ToDateTime(dgv_BookLendInfo.SelectedRows[0].Cells[7].Value.ToString());
                                DateTime dt2 = DateTime.Now;
                                TimeSpan Span = dt1.Subtract(dt2);
                                int time = Span.Days + 1;

                                content = $"您借阅的图书【{Title}】还有({time})天到期，请在规定还书日期[{dt1.ToString("yyyy-MM-dd")}]之前归还书籍！！";
                                IsSucceed = SendEmail(Mail, $"图书【{Title}】到期提醒", content);


                                //if (SendEmail(Mail, $"图书【{Title}】到期提醒", content))
                                //{
                                //    MessageBox.Show($"图书【{Title}】到期提醒成功！");
                                //}
                                //else
                                //{
                                //    MessageBox.Show($"图书【{Title}】到期提醒失败，请联系管理员！");
                                //}
                            }
                            else if (Remind == "2")
                            {
                                DateTime dt1 = Convert.ToDateTime(dgv_BookLendInfo.SelectedRows[0].Cells[7].Value.ToString());
                                DateTime dt2 = DateTime.Now;
                                TimeSpan Span = dt2.Subtract(dt1);
                                int time = Span.Days + 1;

                                content = $"您借阅的图书【{Title}】已逾期({time})天未还，请及时归还！";
                                IsSucceed = SendEmail(Mail, $"图书【{Title}】逾期提醒", content);

                                //if (SendEmail(Mail, $"图书【{Title}】逾期提醒", content))
                                //{
                                //    MessageBox.Show($"图书【{Title}】逾期提醒成功！");
                                //}
                                //else
                                //{
                                //    MessageBox.Show($"图书【{Title}】逾期提醒失败，请联系管理员！");
                                //}

                            }
                            else if (Remind == "3")
                            {
                                DateTime dt1 = Convert.ToDateTime(dgv_BookLendInfo.SelectedRows[0].Cells[7].Value.ToString());
                                DateTime dt2 = DateTime.Now;
                                TimeSpan Span = dt1.Subtract(dt2);
                                int time = Span.Days + 1;
                                content = $"您借阅的图书【{Title}】还有({time})天到期！";
                                IsSucceed = SendEmail(Mail, $"图书【{Title}】剩余日期提醒", content);

                                //if (SendEmail(Mail, $"图书【{Title}】剩余日期提醒", content))
                                //{
                                //    MessageBox.Show($"图书【{Title}】剩余日期提醒成功！");
                                //}
                                //else
                                //{
                                //    MessageBox.Show($"图书【{Title}】剩余日期提醒失败，请联系管理员！");
                                //}

                            }
                        };
                        worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
                        {
                            if (Remind == "1")
                            {
                                if (!IsSucceed)
                                {
                                    MessageBox.Show($"图书【{Title}】到期提醒失败，请联系管理员！");
                                    return;
                                }

                                MessageBox.Show($"图书【{Title}】到期提醒成功！");

                            }
                            else if (Remind == "2")
                            {

                                if (!IsSucceed)
                                {
                                    MessageBox.Show($"图书【{Title}】逾期提醒失败，请联系管理员！");
                                }
                                MessageBox.Show($"图书【{Title}】逾期提醒成功！");

                            }
                            else if (Remind == "3")
                            {

                                if (!IsSucceed)
                                {
                                    MessageBox.Show($"图书【{Title}】剩余日期提醒失败，请联系管理员！");
                                }
                                MessageBox.Show($"图书【{Title}】剩余日期提醒成功！");

                            }

                        };
                        worker.RunWorkerAsync();

                    }
                    else
                    {
                        MessageBox.Show($"学生【{Name}】未绑定邮箱，无法发送邮箱提醒！");
                    }

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
                smtpClient.Send(mailMessage); // 发送邮件
                return true;
            }
            catch (SmtpException ex)
            {
                return false;
            }

        }
    }
}
