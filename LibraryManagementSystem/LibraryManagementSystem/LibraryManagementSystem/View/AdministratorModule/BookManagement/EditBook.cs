using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            var Response = BookManagementBLL.GetBookType();
            List<string> TypeName = new List<string>();
            foreach (var item in Response)
            {
                TypeName.Add(item.Name);
            }

            tb_Title.Text = BookManagementBLL.Title;
            tb_Author.Text = BookManagementBLL.Author;
            tb_ISBN.Text = BookManagementBLL.ISBN;
            TB_PublishingHouse.Text = BookManagementBLL.PublishingHouse;
            dtp_PublicationDate.Value = Convert.ToDateTime(BookManagementBLL.PublicationDate);
            cb_BookType.DataSource = TypeName;
            cb_BookType.SelectedItem = BookManagementBLL.BookType;
            tb_BookCode.Text = BookManagementBLL.BookCode;
            var Picture = BookManagementBLL.Picture == "" ? "noImg.jpg" : BookManagementBLL.Picture;
            this.pb_BookPictures.Image = Image.FromFile(@"..\..\Resources\BookPictures\" + Picture);
            tb_Picture.Text = BookManagementBLL.Picture;
        }
        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                //分割图片路径
                int lastIndex = ofd.FileName.LastIndexOf("\\");  //  \\的意思是，一个是转义，一个是代表斜杠
                string pFilePath = ofd.FileName.Substring(0, lastIndex);  //文件路径
                string pFileName = ofd.FileName.Substring(lastIndex + 1);  //文件名
                //获取图片路径
                //给到控件
                this.tb_Picture.Text = pFileName;
                string lujing = ofd.FileName;//文件夹路径
                string lujing2 = this.tb_Picture.Text;//图片路径
                //复制文件
                 pLocalFilePath = lujing;//要复制的文件夹路径         
                 pSaveFilePath = @"..\..\Resources\BookPictures\" + lujing2;//指定存储的路径

                //if (File.Exists(pLocalFilePath))//必须判断要复制的文件是否存在
                //{
                //    File.Copy(pLocalFilePath, pSaveFilePath, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                //}

                this.pb_BookPictures.Image = Image.FromFile(pLocalFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n未选择图片！");
            }
        }
       

        private void bt_Update_Click(object sender, EventArgs e)
        {
            var Title = tb_Title.Text;
            var Author = tb_Author.Text;
            var ISBN = tb_ISBN.Text;
            var PublishingHouse = TB_PublishingHouse.Text;
            var PublicationDate = DateTimeHelper.DateTimeConvertToTimestamp(Convert.ToDateTime(dtp_PublicationDate.Value.ToString("yyyy-MM-dd 00:00:01")));
            var BookType = cb_BookType.Text;
            var BookCode = tb_BookCode.Text;
            var Picture = tb_Picture.Text;
            ReviseBookRequest request = new ReviseBookRequest()
            {
                ID = BookManagementBLL.ID,
                Title = Title,
                Author = Author,
                ISBN = ISBN,
                PublishingHouse = PublishingHouse,
                PublicationDate = PublicationDate,
                BookType = BookType,
                BookCode = BookCode,
                Picture = Picture
            };

            if (!string.IsNullOrEmpty(request.ID))
            {
                if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(Author) && !string.IsNullOrEmpty(ISBN) && !string.IsNullOrEmpty(PublishingHouse) &&
                !string.IsNullOrEmpty(PublicationDate) && !string.IsNullOrEmpty(BookType) && !string.IsNullOrEmpty(BookCode))
                {
                    var response = BookManagementBLL.UpdateBook(request);
                    if (response.IsSuccess)
                    {
                        try
                        {
                            //修改成功将图片存入指定位置
                            if (File.Exists(pLocalFilePath))//必须判断要复制的文件是否存在
                            {
                                File.Copy(pLocalFilePath, pSaveFilePath, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                            }
                            MessageBox.Show(response.Info);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(response.Info);
                    }

                }
                else
                {
                    MessageBox.Show("请填入所有必填数据");
                }
            }
            else
            {
                MessageBox.Show("图书ID获取失败，请重新选择！");
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region 图片数据
        /// <summary>
        /// 要复制的文件夹路径
        /// </summary>
        string pLocalFilePath;
        /// <summary>
        /// 指定存储的路径
        /// </summary>
        string pSaveFilePath;
        #endregion
    }
}
