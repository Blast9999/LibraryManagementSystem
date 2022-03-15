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
    public partial class HistoryLendInfoForm : UserControl
    {
        public HistoryLendInfoForm()
        {
            InitializeComponent();
        }
        private void HistoryLendInfoForm_Load(object sender, EventArgs e)
        {
            List<string> PageSize = new List<string>();
            PageSize.Add("1");
            PageSize.Add("5");
            PageSize.Add("10");
            PageSize.Add("20");
            PageSize.Add("50");
            cb_PageSize.DataSource = PageSize;
            cb_PageSize.SelectedIndex = 3;
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

        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            HistoryLendInfoRequest request = new HistoryLendInfoRequest()
            {
                Title = tb_Title.Text,
                StudentName = tb_StudentName.Text,
                PageNum = PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)
            };

            var Response = BookManagementBLL.GetHistoryLendInfoList(request, out totalPage);

            if (Response != null)
            {
                this.dgv_Book.AutoGenerateColumns = false;
                this.label4.Text = string.Format("{0}/{1}", PageNum, totalPage);
                dgv_Book.DataSource = Response;
            }
            else
            {
                dgv_Book.DataSource = null;
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

            HistoryLendInfoRequest request = new HistoryLendInfoRequest()
            {
                Title = tb_Title.Text,
                StudentName = tb_StudentName.Text,
                PageNum = PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)
            };

            var Response = BookManagementBLL.GetHistoryLendInfoList(request, out totalPage);

            if (Response != null)
            {
                this.dgv_Book.AutoGenerateColumns = false;
                this.label4.Text = string.Format("{0}/{1}", PageNum, totalPage);
                dgv_Book.DataSource = Response;
            }
            else
            {
                dgv_Book.DataSource = null;
            }


        }

        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Title.Text = null;
            tb_StudentName.Text = null;
        }

        private void dgv_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_Book.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "删除")
            {
                var Name = dgv_Book.SelectedRows[0].Cells[2].Value.ToString();
                var Title = dgv_Book.SelectedRows[0].Cells[3].Value.ToString();
                DialogResult result = MessageBox.Show($"确定要删除学生【{Name}】借阅的书籍:《{Title}》的借阅记录\r\n提示：删除操作不可逆！", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    var ID = dgv_Book.SelectedRows[0].Cells[0].Value.ToString();
                    var Response = BookManagementBLL.DelHistoryLendInfo(ID);
                    if (Response.IsSuccess)
                    {
                        dgv_Book.DataSource = null;
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
    }
}
