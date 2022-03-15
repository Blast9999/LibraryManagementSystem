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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            var Type = RegistrationBLL.GetStaffType();

            List<string> TypeName = new List<string>();
            foreach (var item in Type)
            {
                TypeName.Add(item.TypeNane);
            }
            cb_Type.DataSource = TypeName;
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {
            ReviseStaffRequest request = new ReviseStaffRequest()
            {
                StaffCode = tb_StaffCode.Text,
                Password = tb_Password.Text,
                Name = tb_Name.Text,
                Phone = TB_Phone.Text,
                TypeName = cb_Type.Text,
                JobNumber = tb_JobNumber.Text
            };

            var response = StaffManagementBLL.AddStaff(request);

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
