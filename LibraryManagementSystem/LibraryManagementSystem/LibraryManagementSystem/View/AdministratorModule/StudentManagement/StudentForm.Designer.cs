
namespace LibraryManagementSystem
{
    partial class StudentForm
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
            this.bt_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.bt_Inquire = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_StudentCode = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_FrontPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_LastPage = new System.Windows.Forms.Button();
            this.bt_PrePage = new System.Windows.Forms.Button();
            this.bt_NextPage = new System.Windows.Forms.Button();
            this.lb_Page = new System.Windows.Forms.Label();
            this.cb_PageSize = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Update
            // 
            this.bt_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Update.ForeColor = System.Drawing.Color.White;
            this.bt_Update.Location = new System.Drawing.Point(379, 13);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(102, 45);
            this.bt_Update.TabIndex = 6;
            this.bt_Update.Text = "修改";
            this.bt_Update.UseVisualStyleBackColor = false;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(259, 13);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(102, 45);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "新增";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // bt_Inquire
            // 
            this.bt_Inquire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Inquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Inquire.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Inquire.ForeColor = System.Drawing.Color.White;
            this.bt_Inquire.Location = new System.Drawing.Point(19, 13);
            this.bt_Inquire.Name = "bt_Inquire";
            this.bt_Inquire.Size = new System.Drawing.Size(102, 45);
            this.bt_Inquire.TabIndex = 3;
            this.bt_Inquire.Text = "查询";
            this.bt_Inquire.UseVisualStyleBackColor = false;
            this.bt_Inquire.Click += new System.EventHandler(this.bt_Inquire_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_Update);
            this.panel4.Controls.Add(this.btn_Add);
            this.panel4.Controls.Add(this.bt_Reset);
            this.panel4.Controls.Add(this.bt_Inquire);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1115, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 70);
            this.panel4.TabIndex = 52;
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reset.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Reset.ForeColor = System.Drawing.Color.White;
            this.bt_Reset.Location = new System.Drawing.Point(139, 13);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(102, 45);
            this.bt_Reset.TabIndex = 4;
            this.bt_Reset.Text = "重置";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(255, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "姓名";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Name.Location = new System.Drawing.Point(310, 20);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(131, 27);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "学号";
            // 
            // tb_StudentCode
            // 
            this.tb_StudentCode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_StudentCode.Location = new System.Drawing.Point(75, 26);
            this.tb_StudentCode.Name = "tb_StudentCode";
            this.tb_StudentCode.Size = new System.Drawing.Size(134, 27);
            this.tb_StudentCode.TabIndex = 1;
            this.tb_StudentCode.Tag = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.tb_Name);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tb_StudentCode);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 70);
            this.panel5.TabIndex = 53;
            // 
            // btn_FrontPage
            // 
            this.btn_FrontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_FrontPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FrontPage.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_FrontPage.ForeColor = System.Drawing.Color.White;
            this.btn_FrontPage.Location = new System.Drawing.Point(755, 11);
            this.btn_FrontPage.Name = "btn_FrontPage";
            this.btn_FrontPage.Size = new System.Drawing.Size(91, 32);
            this.btn_FrontPage.TabIndex = 8;
            this.btn_FrontPage.Text = "首页";
            this.btn_FrontPage.UseVisualStyleBackColor = false;
            this.btn_FrontPage.Click += new System.EventHandler(this.btn_FrontPage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_FrontPage);
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
            // bt_LastPage
            // 
            this.bt_LastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_LastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LastPage.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_LastPage.ForeColor = System.Drawing.Color.White;
            this.bt_LastPage.Location = new System.Drawing.Point(1111, 10);
            this.bt_LastPage.Name = "bt_LastPage";
            this.bt_LastPage.Size = new System.Drawing.Size(91, 32);
            this.bt_LastPage.TabIndex = 11;
            this.bt_LastPage.Text = "尾页";
            this.bt_LastPage.UseVisualStyleBackColor = false;
            this.bt_LastPage.Click += new System.EventHandler(this.btn_FrontPage_Click);
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
            this.bt_PrePage.TabIndex = 9;
            this.bt_PrePage.Text = "上一页";
            this.bt_PrePage.UseVisualStyleBackColor = false;
            this.bt_PrePage.Click += new System.EventHandler(this.btn_FrontPage_Click);
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
            this.bt_NextPage.TabIndex = 10;
            this.bt_NextPage.Text = "下一页";
            this.bt_NextPage.UseVisualStyleBackColor = false;
            this.bt_NextPage.Click += new System.EventHandler(this.btn_FrontPage_Click);
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
            this.cb_PageSize.TabIndex = 7;
            this.cb_PageSize.SelectedIndexChanged += new System.EventHandler(this.btn_FrontPage_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Student);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 612);
            this.panel1.TabIndex = 1;
            // 
            // dgv_Student
            // 
            this.dgv_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgv_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column12,
            this.Column11,
            this.Column13,
            this.Column9,
            this.Column10});
            this.dgv_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Student.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Student.Location = new System.Drawing.Point(0, 70);
            this.dgv_Student.MultiSelect = false;
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.ReadOnly = true;
            this.dgv_Student.RowHeadersVisible = false;
            this.dgv_Student.RowHeadersWidth = 51;
            this.dgv_Student.RowTemplate.Height = 27;
            this.dgv_Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Student.Size = new System.Drawing.Size(1616, 485);
            this.dgv_Student.TabIndex = 36;
            this.dgv_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Student_CellClick);
            this.dgv_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Student_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "学生ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StudentCode";
            this.Column2.HeaderText = "学号";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Password";
            this.Column3.HeaderText = "密码";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StudentName";
            this.Column4.HeaderText = "学生姓名";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Phone";
            this.Column5.HeaderText = "电话号码";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sex";
            this.Column6.HeaderText = "性别";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Mail";
            this.Column7.HeaderText = "邮箱";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ViolationStatusName";
            this.Column8.HeaderText = "违章状态";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "NumberBooksBorrowed";
            this.Column12.HeaderText = "累计借书量";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "OverdueReturnNum";
            this.Column11.HeaderText = "逾期归还次数";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Overdue";
            this.Column13.HeaderText = "是否存在逾期未还书籍";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Remark";
            this.Column9.HeaderText = "备注";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Del";
            this.Column10.FillWeight = 50F;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column10.HeaderText = "操作";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Size = new System.Drawing.Size(1616, 612);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button bt_Inquire;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_StudentCode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_FrontPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_LastPage;
        private System.Windows.Forms.Button bt_PrePage;
        private System.Windows.Forms.Button bt_NextPage;
        private System.Windows.Forms.Label lb_Page;
        private System.Windows.Forms.ComboBox cb_PageSize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}
