
namespace LibraryManagementSystem
{
    partial class ClassificationForm
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
            this.tb_Reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_BookType = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan_Operate = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.tb_TypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TypeCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_Operate = new System.Windows.Forms.Button();
            this.tb_BookType = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookType)).BeginInit();
            this.panel1.SuspendLayout();
            this.pan_Operate.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.bt_Update.TabIndex = 55;
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
            this.btn_Add.TabIndex = 54;
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
            this.bt_Inquire.TabIndex = 52;
            this.bt_Inquire.Text = "查询";
            this.bt_Inquire.UseVisualStyleBackColor = false;
            this.bt_Inquire.Click += new System.EventHandler(this.bt_Inquire_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_Update);
            this.panel4.Controls.Add(this.btn_Add);
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
            this.tb_Reset.Location = new System.Drawing.Point(139, 13);
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
            this.label6.Location = new System.Drawing.Point(3, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "分类编码";
            // 
            // tb_Code
            // 
            this.tb_Code.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Code.Location = new System.Drawing.Point(109, 26);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(131, 27);
            this.tb_Code.TabIndex = 49;
            this.tb_Code.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(275, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "分类名称";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tb_BookType);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.tb_Code);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 70);
            this.panel5.TabIndex = 53;
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
            // dgv_BookType
            // 
            this.dgv_BookType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BookType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgv_BookType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BookType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column13});
            this.dgv_BookType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BookType.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_BookType.Location = new System.Drawing.Point(0, 70);
            this.dgv_BookType.MultiSelect = false;
            this.dgv_BookType.Name = "dgv_BookType";
            this.dgv_BookType.ReadOnly = true;
            this.dgv_BookType.RowHeadersVisible = false;
            this.dgv_BookType.RowHeadersWidth = 51;
            this.dgv_BookType.RowTemplate.Height = 27;
            this.dgv_BookType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BookType.Size = new System.Drawing.Size(1616, 542);
            this.dgv_BookType.TabIndex = 36;
            this.dgv_BookType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BookType_CellClick);
            this.dgv_BookType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BookType_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Code";
            this.Column2.FillWeight = 84.89305F;
            this.Column2.HeaderText = "分类编码";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Name";
            this.Column3.FillWeight = 84.89305F;
            this.Column3.HeaderText = "分类名称";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column13.DataPropertyName = "Del";
            this.Column13.FillWeight = 80.21391F;
            this.Column13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column13.HeaderText = "操作";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pan_Operate);
            this.panel1.Controls.Add(this.dgv_BookType);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 612);
            this.panel1.TabIndex = 1;
            // 
            // pan_Operate
            // 
            this.pan_Operate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Operate.Controls.Add(this.panel6);
            this.pan_Operate.Controls.Add(this.tb_TypeName);
            this.pan_Operate.Controls.Add(this.label1);
            this.pan_Operate.Controls.Add(this.tb_TypeCode);
            this.pan_Operate.Controls.Add(this.label3);
            this.pan_Operate.Controls.Add(this.bt_Close);
            this.pan_Operate.Controls.Add(this.bt_Operate);
            this.pan_Operate.Location = new System.Drawing.Point(615, 151);
            this.pan_Operate.Name = "pan_Operate";
            this.pan_Operate.Size = new System.Drawing.Size(320, 353);
            this.pan_Operate.TabIndex = 37;
            this.pan_Operate.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lb_Title);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 41);
            this.panel6.TabIndex = 61;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Title.Location = new System.Drawing.Point(4, 10);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(89, 20);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "新增分类";
            // 
            // tb_TypeName
            // 
            this.tb_TypeName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_TypeName.Location = new System.Drawing.Point(140, 191);
            this.tb_TypeName.Name = "tb_TypeName";
            this.tb_TypeName.Size = new System.Drawing.Size(131, 27);
            this.tb_TypeName.TabIndex = 60;
            this.tb_TypeName.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "分类编码";
            // 
            // tb_TypeCode
            // 
            this.tb_TypeCode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_TypeCode.Location = new System.Drawing.Point(140, 88);
            this.tb_TypeCode.Name = "tb_TypeCode";
            this.tb_TypeCode.Size = new System.Drawing.Size(131, 27);
            this.tb_TypeCode.TabIndex = 59;
            this.tb_TypeCode.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "分类名称";
            // 
            // bt_Close
            // 
            this.bt_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Close.ForeColor = System.Drawing.Color.White;
            this.bt_Close.Location = new System.Drawing.Point(169, 286);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(102, 45);
            this.bt_Close.TabIndex = 55;
            this.bt_Close.Text = "关闭";
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_Operate
            // 
            this.bt_Operate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Operate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Operate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Operate.ForeColor = System.Drawing.Color.White;
            this.bt_Operate.Location = new System.Drawing.Point(38, 286);
            this.bt_Operate.Name = "bt_Operate";
            this.bt_Operate.Size = new System.Drawing.Size(102, 45);
            this.bt_Operate.TabIndex = 54;
            this.bt_Operate.Text = "新增";
            this.bt_Operate.UseVisualStyleBackColor = false;
            this.bt_Operate.Click += new System.EventHandler(this.bt_Operate_Click);
            // 
            // tb_BookType
            // 
            this.tb_BookType.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_BookType.Location = new System.Drawing.Point(381, 22);
            this.tb_BookType.Name = "tb_BookType";
            this.tb_BookType.Size = new System.Drawing.Size(131, 27);
            this.tb_BookType.TabIndex = 50;
            this.tb_BookType.Tag = "";
            // 
            // ClassificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ClassificationForm";
            this.Size = new System.Drawing.Size(1616, 612);
            this.Load += new System.EventHandler(this.ClassificationForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pan_Operate.ResumeLayout(false);
            this.pan_Operate.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button bt_Inquire;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button tb_Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_BookType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column13;
        private System.Windows.Forms.Panel pan_Operate;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Operate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TypeCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TypeName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox tb_BookType;
    }
}
