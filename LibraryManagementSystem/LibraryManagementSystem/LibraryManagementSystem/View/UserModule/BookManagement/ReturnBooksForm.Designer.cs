
namespace LibraryManagementSystem
{
    partial class ReturnBooksForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_BorrowInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_BookCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_Reset = new System.Windows.Forms.Button();
            this.bt_Inquire = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_BorrowInfo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 637);
            this.panel1.TabIndex = 2;
            // 
            // dgv_BorrowInfo
            // 
            this.dgv_BorrowInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BorrowInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgv_BorrowInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BorrowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BorrowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_BorrowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BorrowInfo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_BorrowInfo.Location = new System.Drawing.Point(0, 70);
            this.dgv_BorrowInfo.MultiSelect = false;
            this.dgv_BorrowInfo.Name = "dgv_BorrowInfo";
            this.dgv_BorrowInfo.ReadOnly = true;
            this.dgv_BorrowInfo.RowHeadersVisible = false;
            this.dgv_BorrowInfo.RowHeadersWidth = 51;
            this.dgv_BorrowInfo.RowTemplate.Height = 27;
            this.dgv_BorrowInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BorrowInfo.Size = new System.Drawing.Size(1377, 510);
            this.dgv_BorrowInfo.TabIndex = 36;
            this.dgv_BorrowInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BorrowInfo_CellContentClick);
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
            this.Column2.DataPropertyName = "Title";
            this.Column2.HeaderText = "书名";
            this.Column2.MinimumWidth = 172;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BookCode";
            this.Column3.HeaderText = "图书编号";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ISBN";
            this.Column4.HeaderText = "ISBN";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BorrowingBookTime";
            this.Column5.HeaderText = "借书时间";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ReturnBookTime";
            this.Column6.HeaderText = "还书时间";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RemainingDate";
            this.Column7.HeaderText = "剩余天数";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Overdue";
            this.Column8.HeaderText = "是否逾期";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.DataPropertyName = "Escheat";
            this.Column9.HeaderText = "操作";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column9.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 580);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1377, 57);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1377, 70);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.tb_BookCode);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tb_Title);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 70);
            this.panel5.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(225, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "图书编号";
            // 
            // tb_BookCode
            // 
            this.tb_BookCode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_BookCode.Location = new System.Drawing.Point(331, 22);
            this.tb_BookCode.Name = "tb_BookCode";
            this.tb_BookCode.Size = new System.Drawing.Size(131, 27);
            this.tb_BookCode.TabIndex = 49;
            this.tb_BookCode.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "书名";
            // 
            // tb_Title
            // 
            this.tb_Title.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Title.Location = new System.Drawing.Point(75, 22);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(134, 27);
            this.tb_Title.TabIndex = 43;
            this.tb_Title.Tag = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb_Reset);
            this.panel4.Controls.Add(this.bt_Inquire);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(876, 0);
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
            this.tb_Reset.Location = new System.Drawing.Point(349, 11);
            this.tb_Reset.Name = "tb_Reset";
            this.tb_Reset.Size = new System.Drawing.Size(102, 45);
            this.tb_Reset.TabIndex = 53;
            this.tb_Reset.Text = "重置";
            this.tb_Reset.UseVisualStyleBackColor = false;
            this.tb_Reset.Click += new System.EventHandler(this.tb_Reset_Click);
            // 
            // bt_Inquire
            // 
            this.bt_Inquire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Inquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Inquire.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Inquire.ForeColor = System.Drawing.Color.White;
            this.bt_Inquire.Location = new System.Drawing.Point(224, 13);
            this.bt_Inquire.Name = "bt_Inquire";
            this.bt_Inquire.Size = new System.Drawing.Size(102, 45);
            this.bt_Inquire.TabIndex = 52;
            this.bt_Inquire.Text = "查询";
            this.bt_Inquire.UseVisualStyleBackColor = false;
            this.bt_Inquire.Click += new System.EventHandler(this.bt_Inquire_Click);
            // 
            // ReturnBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReturnBooksForm";
            this.Size = new System.Drawing.Size(1377, 637);
            this.Load += new System.EventHandler(this.ReturnBooksForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_BorrowInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_BookCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_Inquire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.Button tb_Reset;
    }
}
