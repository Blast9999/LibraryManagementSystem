
namespace LibraryManagementSystem
{
    partial class HistoryLendInfoForm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Inquire = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_Reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_StudentName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Book = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_LastPage = new System.Windows.Forms.Button();
            this.bt_PrePage = new System.Windows.Forms.Button();
            this.bt_NextPage = new System.Windows.Forms.Button();
            this.lb_Page = new System.Windows.Forms.Label();
            this.cb_PageSize = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Inquire
            // 
            this.bt_Inquire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Inquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Inquire.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Inquire.ForeColor = System.Drawing.Color.White;
            this.bt_Inquire.Location = new System.Drawing.Point(228, 8);
            this.bt_Inquire.Name = "bt_Inquire";
            this.bt_Inquire.Size = new System.Drawing.Size(102, 45);
            this.bt_Inquire.TabIndex = 52;
            this.bt_Inquire.Text = "查询";
            this.bt_Inquire.UseVisualStyleBackColor = false;
            this.bt_Inquire.Click += new System.EventHandler(this.bt_Inquire_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb_Reset);
            this.panel4.Controls.Add(this.bt_Inquire);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1115, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 70);
            this.panel4.TabIndex = 52;
            // 
            // tb_Reset
            // 
            this.tb_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.tb_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_Reset.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Reset.ForeColor = System.Drawing.Color.White;
            this.tb_Reset.Location = new System.Drawing.Point(348, 8);
            this.tb_Reset.Name = "tb_Reset";
            this.tb_Reset.Size = new System.Drawing.Size(102, 45);
            this.tb_Reset.TabIndex = 53;
            this.tb_Reset.Text = "重置";
            this.tb_Reset.UseVisualStyleBackColor = false;
            this.tb_Reset.Click += new System.EventHandler(this.tb_Reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(14, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "学生姓名";
            // 
            // tb_StudentName
            // 
            this.tb_StudentName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_StudentName.Location = new System.Drawing.Point(120, 25);
            this.tb_StudentName.Name = "tb_StudentName";
            this.tb_StudentName.Size = new System.Drawing.Size(131, 27);
            this.tb_StudentName.TabIndex = 49;
            this.tb_StudentName.Tag = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tb_Title);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.tb_StudentName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 70);
            this.panel5.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(293, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "书名";
            // 
            // tb_Title
            // 
            this.tb_Title.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Title.Location = new System.Drawing.Point(348, 26);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(134, 27);
            this.tb_Title.TabIndex = 51;
            this.tb_Title.Tag = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1616, 70);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(755, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "首页";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(650, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "1/1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(318, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "每页";
            // 
            // dgv_Book
            // 
            this.dgv_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Book.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgv_Book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column13});
            this.dgv_Book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Book.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Book.Location = new System.Drawing.Point(0, 70);
            this.dgv_Book.MultiSelect = false;
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.ReadOnly = true;
            this.dgv_Book.RowHeadersVisible = false;
            this.dgv_Book.RowHeadersWidth = 51;
            this.dgv_Book.RowTemplate.Height = 27;
            this.dgv_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Book.Size = new System.Drawing.Size(1616, 485);
            this.dgv_Book.TabIndex = 36;
            this.dgv_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Book_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ReaderID";
            this.Column2.HeaderText = "学生学号";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ReaderName";
            this.Column3.HeaderText = "学生姓名";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Title";
            this.Column4.HeaderText = "书名";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BookCode";
            this.Column5.HeaderText = "图书代码";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ISBN";
            this.Column8.HeaderText = "ISBN";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BegintDate";
            this.Column6.HeaderText = "借出时间";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EndDate";
            this.Column7.HeaderText = "规定归还时间";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ActualDate";
            this.Column9.HeaderText = "实际归还时间";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Overdue";
            this.Column10.HeaderText = "是否逾期归还";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Del";
            this.Column13.FillWeight = 50F;
            this.Column13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column13.HeaderText = "操作";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Book);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 612);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.bt_LastPage);
            this.panel3.Controls.Add(this.bt_PrePage);
            this.panel3.Controls.Add(this.bt_NextPage);
            this.panel3.Controls.Add(this.lb_Page);
            this.panel3.Controls.Add(this.cb_PageSize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 555);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1616, 57);
            this.panel3.TabIndex = 1;
            // 
            // bt_LastPage
            // 
            this.bt_LastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_LastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LastPage.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_LastPage.ForeColor = System.Drawing.Color.White;
            this.bt_LastPage.Location = new System.Drawing.Point(1111, 10);
            this.bt_LastPage.Name = "bt_LastPage";
            this.bt_LastPage.Size = new System.Drawing.Size(91, 32);
            this.bt_LastPage.TabIndex = 41;
            this.bt_LastPage.Text = "尾页";
            this.bt_LastPage.UseVisualStyleBackColor = false;
            this.bt_LastPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_PrePage
            // 
            this.bt_PrePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_PrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PrePage.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_PrePage.ForeColor = System.Drawing.Color.White;
            this.bt_PrePage.Location = new System.Drawing.Point(873, 11);
            this.bt_PrePage.Name = "bt_PrePage";
            this.bt_PrePage.Size = new System.Drawing.Size(91, 32);
            this.bt_PrePage.TabIndex = 44;
            this.bt_PrePage.Text = "上一页";
            this.bt_PrePage.UseVisualStyleBackColor = false;
            this.bt_PrePage.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_NextPage
            // 
            this.bt_NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NextPage.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_NextPage.ForeColor = System.Drawing.Color.White;
            this.bt_NextPage.Location = new System.Drawing.Point(992, 11);
            this.bt_NextPage.Name = "bt_NextPage";
            this.bt_NextPage.Size = new System.Drawing.Size(91, 32);
            this.bt_NextPage.TabIndex = 42;
            this.bt_NextPage.Text = "下一页";
            this.bt_NextPage.UseVisualStyleBackColor = false;
            this.bt_NextPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Page
            // 
            this.lb_Page.AutoSize = true;
            this.lb_Page.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Page.Location = new System.Drawing.Point(474, 20);
            this.lb_Page.Name = "lb_Page";
            this.lb_Page.Size = new System.Drawing.Size(149, 20);
            this.lb_Page.TabIndex = 45;
            this.lb_Page.Text = "条，当前页数：";
            // 
            // cb_PageSize
            // 
            this.cb_PageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PageSize.FormattingEnabled = true;
            this.cb_PageSize.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.cb_PageSize.Location = new System.Drawing.Point(373, 17);
            this.cb_PageSize.Name = "cb_PageSize";
            this.cb_PageSize.Size = new System.Drawing.Size(95, 23);
            this.cb_PageSize.TabIndex = 40;
            this.cb_PageSize.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // HistoryLendInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HistoryLendInfoForm";
            this.Size = new System.Drawing.Size(1616, 612);
            this.Load += new System.EventHandler(this.HistoryLendInfoForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_Inquire;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button tb_Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_StudentName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Book;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_LastPage;
        private System.Windows.Forms.Button bt_PrePage;
        private System.Windows.Forms.Button bt_NextPage;
        private System.Windows.Forms.Label lb_Page;
        private System.Windows.Forms.ComboBox cb_PageSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column13;
    }
}
