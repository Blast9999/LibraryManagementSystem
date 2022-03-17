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
    public partial class StaffForm : UserControl
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Text = null;
            cb_Type.SelectedIndex = 0;
            tb_JobNumber.Text = null;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            var Type = RegistrationBLL.GetStaffType();

            List<string> TypeName = new List<string>();
            TypeName.Add("全部");
            foreach (var item in Type)
            {
                TypeName.Add(item.TypeNane);
            }
            cb_Type.DataSource = TypeName;
            bt_Inquire_Click(null, null);
        }

        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            StaffRequest request = new StaffRequest()
            {
                Name = tb_Name.Text,
                Type = cb_Type.Text == "全部" ? "" : cb_Type.Text,
                JobNumber = tb_JobNumber.Text
            };



            List<StaffModel> Response = null;
            BackgroundWorker worker = new BackgroundWorker();//使用了worker线程，加快了页面的响应速度，从而使页面响应更加流程
            worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
            {
                Response = StaffManagementBLL.GetStudent(request);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
                if (Response != null)
                {
                    this.dgv_Staff.AutoGenerateColumns = false;
                    dgv_Staff.DataSource = Response;
                }
                else
                {
                    dgv_Staff.DataSource = null;
                }
            };
            worker.RunWorkerAsync();



        }

        private void dgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffManagementBLL.ID = dgv_Staff.SelectedRows[0].Cells[0].Value.ToString();
            StaffManagementBLL.StaffCode = dgv_Staff.SelectedRows[0].Cells[1].Value.ToString();
            StaffManagementBLL.Password = dgv_Staff.SelectedRows[0].Cells[2].Value.ToString();
            StaffManagementBLL.Name = dgv_Staff.SelectedRows[0].Cells[3].Value.ToString();
            StaffManagementBLL.Phone = dgv_Staff.SelectedRows[0].Cells[4].Value.ToString();
            StaffManagementBLL.TypeName = dgv_Staff.SelectedRows[0].Cells[5].Value.ToString();
            StaffManagementBLL.JobNumber = dgv_Staff.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dgv_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_Staff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "删除")
            {
                var Name = dgv_Staff.SelectedRows[0].Cells[3].Value.ToString();
                DialogResult result = MessageBox.Show($"确定要删除并取消职员【{Name}】的信息？", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    var ID = dgv_Staff.SelectedRows[0].Cells[0].Value.ToString();
                    var Response = StaffManagementBLL.DelStaff(ID);
                    if (Response.IsSuccess)
                    {
                        dgv_Staff.DataSource = null;
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

        private void bt_Update_Click(object sender, EventArgs e)
        {
            EditStaff editStaff = new EditStaff();
            if (!string.IsNullOrEmpty(StaffManagementBLL.ID))
            {
                editStaff.ShowDialog();
                dgv_Staff.DataSource = null;
                bt_Inquire_Click(null, null);
            }
            else
            {
                MessageBox.Show("请先选择数据！");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.ShowDialog();
            dgv_Staff.DataSource = null;
            bt_Inquire_Click(null, null);

        }
    }
}
