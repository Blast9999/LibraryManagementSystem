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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            List<string> Sex = new List<string>();
            Sex.Add("男");
            Sex.Add("女");
            cb_Sex.DataSource = Sex;
        }


        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
           
            ReviseStudentRequest request = new ReviseStudentRequest()
            {
                ID = StudentManagementBLL.ID,
                StudentCode = tb_StaffCode.Text,
                Password = tb_Password.Text,
                StudentName = tb_Name.Text,
                Phone = TB_Phone.Text,
                Sex = cb_Sex.Text,
                Mail = tb_Mail.Text
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
                    var Response = StudentManagementBLL.AddStudent(request);
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
    }
}
