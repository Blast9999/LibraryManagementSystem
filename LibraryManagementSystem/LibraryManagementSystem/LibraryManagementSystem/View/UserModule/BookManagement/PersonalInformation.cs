using BLL;
using Model;
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
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        #region 用户数据
        /// <summary>
        /// 学生学号
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string UserName { get; set; }
        public StudentModel StudentInformation { get; set; }
        #endregion
        /// <summary>
        /// 是否可以修改
        /// </summary>
        public bool IsturnOn { get; set; } = false;
        /// <summary>
        /// 是否已经显示密码
        /// </summary>
        public bool IsShow { get; set; } = false;

        private void PersonalInformation_Load(object sender, EventArgs e)
        {

            StudentInformation = StudentManagementBLL.GetStudentPersonalInformation(UserCode, UserName);
            if (StudentInformation != null)
            {
                tb_StudentCode.Text = StudentInformation.StudentCode;
                tb_Name.Text = StudentInformation.StudentName;
                tb_Phone.Text = StudentInformation.Phone;
                cb_Sex.Text = StudentInformation.Sex;
                tb_Mail.Text = StudentInformation.Mail;
                tb_NumberBooksBorrowed.Text = StudentInformation.NumberBooksBorrowed;
                tb_IsViolation.Text = StudentInformation.ViolationStatusName;
                tb_OverdueNumber.Text = StudentInformation.OverdueReturnNum;
                tb_Password.Text = StudentInformation.Password;

            }
            else
            {
                MessageBox.Show("查询个人信息异常，请联系管理员！");
            }


        }
        /// <summary>
        /// 点击开放修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsturnOn)//如果不可以修改则打开
            {
                tb_Phone.Enabled = true;
                cb_Sex.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Password.Enabled = true;
                IsturnOn = true;
            }
            else
            {
                tb_Phone.Enabled = false;
                cb_Sex.Enabled = false;
                tb_Mail.Enabled = false;
                tb_Password.Enabled = false;
                IsturnOn = false;
            };


        }
        /// <summary>
        /// 显示密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!IsShow)//如果没有显示密码则将其显示出来
            {
                tb_Password.UseSystemPasswordChar = false;
                IsShow = true;
                this.pb_Password.Image = Image.FromFile(@"..\..\Resources\不可见.png");
            }
            else
            {
                tb_Password.UseSystemPasswordChar = true;
                this.pb_Password.Image = Image.FromFile(@"..\..\Resources\可见.png");
                IsShow = false;
            }
        }
        /// <summary>
        /// 提交修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Submit_Click(object sender, EventArgs e)
        {
            ReviseStudentRequest request = new ReviseStudentRequest()
            {
                ID = StudentInformation.ID.ToString(),
                Phone = tb_Phone.Text,
                Sex = cb_Sex.Text,
                Mail = tb_Mail.Text,
                Password = tb_Password.Text
            };

            var Response = StudentManagementBLL.UpdateStudent(request, "1");
            if (Response.IsSuccess)
            {
                MessageBox.Show(Response.Info);
                this.Close();
            }
            else
            {
                MessageBox.Show(Response.Info);
            }

        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
