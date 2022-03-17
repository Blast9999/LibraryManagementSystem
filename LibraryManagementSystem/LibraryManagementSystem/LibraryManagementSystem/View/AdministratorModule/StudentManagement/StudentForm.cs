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
    public partial class StudentForm : UserControl
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        private void StudentForm_Load(object sender, EventArgs e)
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
            StudentRequest request = new StudentRequest()
            {
                StudentCode = tb_StudentCode.Text,
                Name = tb_Name.Text,
                PageNum = StudentManagementBLL.PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)

            };


            List<StudentModel> response = null;
            BackgroundWorker worker = new BackgroundWorker();//使用了worker线程，加快了页面的响应速度，从而使页面响应更加流程
            worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
            {
                response = StudentManagementBLL.GetStudent(request, out totalPage);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
                if (response != null)
                {
                    this.dgv_Student.AutoGenerateColumns = false;
                    this.label4.Text = string.Format("{0}/{1}", StudentManagementBLL.PageNum, totalPage);
                    dgv_Student.DataSource = response;
                }
                else
                {
                    dgv_Student.DataSource = null;
                }
            };
            worker.RunWorkerAsync();

        }


        #region 分页数据
        int totalPage;//总页数
        #endregion


        private void dgv_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentManagementBLL.ID = dgv_Student.SelectedRows[0].Cells[0].Value.ToString();
            StudentManagementBLL.StudentCode = dgv_Student.SelectedRows[0].Cells[1].Value.ToString();
            StudentManagementBLL.Password = dgv_Student.SelectedRows[0].Cells[2].Value.ToString();
            StudentManagementBLL.StudentName = dgv_Student.SelectedRows[0].Cells[3].Value.ToString();
            StudentManagementBLL.Phone = dgv_Student.SelectedRows[0].Cells[4].Value.ToString();
            StudentManagementBLL.Sex = dgv_Student.SelectedRows[0].Cells[5].Value.ToString();
            StudentManagementBLL.Mail = dgv_Student.SelectedRows[0].Cells[6].Value.ToString();
            StudentManagementBLL.ViolationStatusName = dgv_Student.SelectedRows[0].Cells[7].Value.ToString();
            StudentManagementBLL.NumberBooksBorrowed = dgv_Student.SelectedRows[0].Cells[8].Value.ToString();
            StudentManagementBLL.OverdueReturnNum = dgv_Student.SelectedRows[0].Cells[9].Value.ToString();
            StudentManagementBLL.Remark = dgv_Student.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            tb_StudentCode.Text = null;
            tb_Name.Text = null;
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            if (!string.IsNullOrEmpty(StudentManagementBLL.ID))
            {
                editStudent.ShowDialog();
                dgv_Student.DataSource = null;
                bt_Inquire_Click(null, null);
            }
            else
            {
                MessageBox.Show("请先选择数据！");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            dgv_Student.DataSource = null;
            bt_Inquire_Click(null, null);

        }

        private void dgv_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_Student.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "删除")
            {
                string Name = dgv_Student.SelectedRows[0].Cells[3].Value.ToString();
                DialogResult result = MessageBox.Show($"确定要删除学生:《{Name}》的账号信息！", "提示：",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    var ID = dgv_Student.SelectedRows[0].Cells[0].Value.ToString();
                    var Response = StudentManagementBLL.DelStaff(ID);
                    if (Response.IsSuccess)
                    {
                        dgv_Student.DataSource = null;
                        bt_Inquire_Click(null, null);
                        MessageBox.Show(Response.Info);
                    }
                    else
                    {
                        MessageBox.Show(Response.Info);
                    }
                }
            }
        }

        private void btn_FrontPage_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                if (btn.Text == "首页")
                {
                    StudentManagementBLL.PageNum = 1;
                }
                else if (btn.Text == "上一页")
                {
                    StudentManagementBLL.PageNum--;
                    if (StudentManagementBLL.PageNum <= 0)
                    {
                        StudentManagementBLL.PageNum = 1;
                    }
                }
                else if (btn.Text == "下一页")
                {
                    StudentManagementBLL.PageNum++;
                    if (StudentManagementBLL.PageNum >= totalPage)
                    {
                        StudentManagementBLL.PageNum = totalPage;
                    }
                }
                else if (btn.Text == "尾页")
                {
                    StudentManagementBLL.PageNum = totalPage;
                }
                else
                {
                    StudentManagementBLL.PageNum = 1;
                }
            }


            StudentRequest request = new StudentRequest()
            {
                StudentCode = tb_StudentCode.Text,
                Name = tb_Name.Text,
                PageNum = StudentManagementBLL.PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)

            };

            var Response = StudentManagementBLL.GetStudent(request, out totalPage);

            if (Response != null)
            {
                this.dgv_Student.AutoGenerateColumns = false;
                this.label4.Text = string.Format("{0}/{1}", StudentManagementBLL.PageNum, totalPage);
                dgv_Student.DataSource = Response;
            }
            else
            {
                dgv_Student.DataSource = null;
            }
        }


    }
}
