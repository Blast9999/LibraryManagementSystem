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
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            var Type = RegistrationBLL.GetStaffType();

            List<string> TypeName = new List<string>();
            foreach (var item in Type)
            {
                TypeName.Add(item.TypeNane);
            }
            tb_StaffCode.Text = StaffManagementBLL.StaffCode;
            tb_Password.Text = StaffManagementBLL.Password;
            tb_Name.Text = StaffManagementBLL.Name;
            TB_Phone.Text = StaffManagementBLL.Phone;
            cb_Type.DataSource = TypeName;
            cb_Type.SelectedItem = StaffManagementBLL.TypeName;
            tb_JobNumber.Text = StaffManagementBLL.JobNumber;
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            ReviseStaffRequest request = new ReviseStaffRequest()
            {
                ID = StaffManagementBLL.ID,
                StaffCode = tb_StaffCode.Text,
                Password = tb_Password.Text,
                Name = tb_Name.Text,
                Phone = TB_Phone.Text,
                TypeName = cb_Type.Text,
                JobNumber = tb_JobNumber.Text
            };
            if (!string.IsNullOrEmpty(request.ID))
            {
                var response = StaffManagementBLL.UpdateStaff(request);

                if (response.IsSuccess)
                {
                    MessageBox.Show(response.Info);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.Info);
                }
            }
            else
            {
                MessageBox.Show("获取职员ID失败，请联系管理员！");
            }


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            tb_StaffCode.Text = null;
            tb_Password.Text = null;
            tb_Name.Text = null;
            TB_Phone.Text = null;
            cb_Type.SelectedIndex = 0;
            tb_JobNumber.Text = null;
        }
    }
}
