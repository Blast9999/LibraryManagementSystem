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
    public partial class ClassificationForm : UserControl
    {
        public ClassificationForm()
        {
            InitializeComponent();
        }
        #region 页面数据
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 分类代码
        /// </summary>
        public string TypeCode { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string TypeName { get; set; }
        #endregion
        private void ClassificationForm_Load(object sender, EventArgs e)
        {
            bt_Inquire_Click(null, null);
        }
        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            BookTypeRequest request = new BookTypeRequest()
            {
                Code = tb_Code.Text,
                Name = tb_BookType.Text
            };


            List<BookType> Response = null;
            BackgroundWorker worker = new BackgroundWorker();//使用了worker线程，加快了页面的响应速度，从而使页面响应更加流程
            worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
            {
                Response = BookManagementBLL.GetBookType(request);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
                if (Response != null)
                {
                    this.dgv_BookType.AutoGenerateColumns = false;
                    dgv_BookType.DataSource = Response;
                }
                else
                {
                    dgv_BookType.DataSource = null;
                }
            };
            worker.RunWorkerAsync();



        }

        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Code.Text = null;
            tb_BookType.Text = null;
        }
        /// <summary>
        /// 新增弹框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (pan_Operate.Visible != true)
            {
                lb_Title.Text = "新增分类";
                bt_Operate.Text = "新增";
                tb_TypeCode.Text = null;
                tb_TypeName.Text = null;
                pan_Operate.Visible = true;
            }
        }
        /// <summary>
        /// 修改弹框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (pan_Operate.Visible != true)
            {
                if (!string.IsNullOrEmpty(ID))
                {
                    lb_Title.Text = "修改分类";
                    bt_Operate.Text = "修改";
                    tb_TypeCode.Text = TypeCode;
                    tb_TypeName.Text = TypeName;
                    tb_TypeCode.Enabled = false;
                    pan_Operate.Visible = true;
                }
                else
                {
                    MessageBox.Show("未选择数据！");
                }
            }
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Close_Click(object sender, EventArgs e)
        {
            pan_Operate.Visible = false;
        }

        private void dgv_BookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dgv_BookType.SelectedRows[0].Cells[0].Value.ToString();
            TypeCode = dgv_BookType.SelectedRows[0].Cells[1].Value.ToString();
            TypeName = dgv_BookType.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void bt_Operate_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "新增")
            {
                if (string.IsNullOrEmpty(tb_TypeCode.Text))
                {
                    MessageBox.Show("分类编码不能为空！");
                    return;
                }
                else if (string.IsNullOrEmpty(tb_TypeName.Text))
                {
                    MessageBox.Show("分类名称不能为空！");
                    return;
                }

                BookTypeRequest request = new BookTypeRequest()
                {
                    Code = tb_TypeCode.Text,
                    Name = tb_TypeName.Text
                };

                var Response = BookManagementBLL.AddBookType(request);
                if (Response.IsSuccess)
                {
                    MessageBox.Show(Response.Info);
                    tb_TypeCode.Text = null;
                    tb_TypeName.Text = null;
                    dgv_BookType.DataSource = null;
                    bt_Inquire_Click(null, null);
                }
                else
                {
                    MessageBox.Show(Response.Info);
                }
            }
            else if (button.Text == "修改")
            {
                if (string.IsNullOrEmpty(tb_TypeName.Text))
                {
                    MessageBox.Show("分类名称不能为空！");
                    return;
                }

                BookTypeRequest request = new BookTypeRequest()
                {
                    ID = ID,
                    Code = tb_TypeCode.Text,
                    Name = tb_TypeName.Text
                };
                var Response = BookManagementBLL.UpdateBookType(request);
                if (Response.IsSuccess)
                {
                    MessageBox.Show(Response.Info);
                    pan_Operate.Visible = false;
                    dgv_BookType.DataSource = null;
                    bt_Inquire_Click(null, null);
                }
                else
                {
                    MessageBox.Show(Response.Info);
                }
            }

        }

        private void dgv_BookType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_BookType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "删除")
            {
                string Name = dgv_BookType.SelectedRows[0].Cells[2].Value.ToString();
                DialogResult result = MessageBox.Show($"确定要删除名为:《{Name}》的图书分类？\r\n删除后该图书分类下的图书将无分类名称！", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    ID = dgv_BookType.SelectedRows[0].Cells[0].Value.ToString();
                    var Response = BookManagementBLL.DelBookType(ID);
                    if (Response.IsSuccess)
                    {
                        MessageBox.Show(Response.Info);
                        dgv_BookType.DataSource = null;
                        bt_Inquire_Click(null, null);
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
