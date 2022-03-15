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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            List<string> Sex = new List<string>();
            Sex.Add("男");
            Sex.Add("女");
            cb_Sex.DataSource = Sex;

            List<string> Status = new List<string>();
            Status.Add("未违章");
            Status.Add("已违章");
            cb_Status.DataSource = Status;


            tb_StaffCode.Text = StudentManagementBLL.StudentCode;
            tb_Password.Text = StudentManagementBLL.Password;
            tb_Name.Text = StudentManagementBLL.StudentName;
            TB_Phone.Text = StudentManagementBLL.Phone;
            cb_Sex.SelectedIndex = StudentManagementBLL.Sex == "男" ? 0 : 1;
            tb_Mail.Text = StudentManagementBLL.Mail;
            cb_Status.SelectedIndex = StudentManagementBLL.ViolationStatusName == "未违章" ? 0 : 1;
            tb_Num.Text = StudentManagementBLL.NumberBooksBorrowed;
            tb_OverdueReturnNum.Text = StudentManagementBLL.OverdueReturnNum;
            tb_Remark.Text = StudentManagementBLL.Remark;
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            ReviseStudentRequest request = new ReviseStudentRequest()
            {
                ID = StudentManagementBLL.ID,
                StudentCode = tb_StaffCode.Text,
                Password = tb_Password.Text,
                StudentName = tb_Name.Text,
                Phone = TB_Phone.Text,
                Sex = cb_Sex.Text,
                Mail = tb_Mail.Text,
                ViolationStatus = cb_Status.Text == "未违章" ? "0" : "1",
                NumberBooksBorrowed = tb_Num.Text == "" ? "0" : tb_Num.Text,
                OverdueReturnNum = tb_OverdueReturnNum.Text == "" ? "0" : tb_OverdueReturnNum.Text,
                Remark = tb_Remark.Text
            };

            if (!string.IsNullOrEmpty(tb_StaffCode.Text) && !string.IsNullOrEmpty(tb_Password.Text) && !string.IsNullOrEmpty(tb_Name.Text) && !string.IsNullOrEmpty(TB_Phone.Text))
            {
                if (tb_StaffCode.Text.Length < 10)
                {
                    MessageBox.Show("学生学号应为十位数！");
                    return;
                }
                else
                {
                    var Response = StudentManagementBLL.UpdateStudent(request, "0");
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


            }
            else
            {
                MessageBox.Show("请填入所有必填项！");
            }

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
