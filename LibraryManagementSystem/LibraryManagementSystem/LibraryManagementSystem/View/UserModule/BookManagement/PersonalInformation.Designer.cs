
namespace LibraryManagementSystem
{
    partial class PersonalInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Sex = new System.Windows.Forms.ComboBox();
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.bt_Return = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_OverdueNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NumberBooksBorrowed = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_IsViolation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_StudentCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_Sex);
            this.panel1.Controls.Add(this.pb_Password);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bt_Submit);
            this.panel1.Controls.Add(this.bt_Return);
            this.panel1.Controls.Add(this.tb_Password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_OverdueNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_NumberBooksBorrowed);
            this.panel1.Controls.Add(this.tb_Mail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tb_IsViolation);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_Phone);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tb_StudentCode);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 441);
            this.panel1.TabIndex = 0;
            // 
            // cb_Sex
            // 
            this.cb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sex.Enabled = false;
            this.cb_Sex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_Sex.FormattingEnabled = true;
            this.cb_Sex.Items.AddRange(new object[] {
            "男",
            "女",
            "未知"});
            this.cb_Sex.Location = new System.Drawing.Point(456, 124);
            this.cb_Sex.Name = "cb_Sex";
            this.cb_Sex.Size = new System.Drawing.Size(189, 28);
            this.cb_Sex.TabIndex = 90;
            // 
            // pb_Password
            // 
            this.pb_Password.Image = ((System.Drawing.Image)(resources.GetObject("pb_Password.Image")));
            this.pb_Password.Location = new System.Drawing.Point(312, 328);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(30, 30);
            this.pb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Password.TabIndex = 89;
            this.pb_Password.TabStop = false;
            this.pb_Password.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(345, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 49);
            this.panel2.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = " 提示：点击修改信息按钮即可对个人信\r\n 息进行编辑修改";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(91, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 87;
            this.button2.Text = "修改信息";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Submit
            // 
            this.bt_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Submit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Submit.ForeColor = System.Drawing.Color.White;
            this.bt_Submit.Location = new System.Drawing.Point(279, 387);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(105, 34);
            this.bt_Submit.TabIndex = 86;
            this.bt_Submit.Text = "提交修改";
            this.bt_Submit.UseVisualStyleBackColor = false;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // bt_Return
            // 
            this.bt_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.bt_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Return.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Return.ForeColor = System.Drawing.Color.White;
            this.bt_Return.Location = new System.Drawing.Point(474, 387);
            this.bt_Return.Name = "bt_Return";
            this.bt_Return.Size = new System.Drawing.Size(105, 34);
            this.bt_Return.TabIndex = 85;
            this.bt_Return.Text = "返回";
            this.bt_Return.UseVisualStyleBackColor = false;
            this.bt_Return.Click += new System.EventHandler(this.bt_Return_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Password.Location = new System.Drawing.Point(121, 328);
            this.tb_Password.MaxLength = 30;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(189, 30);
            this.tb_Password.TabIndex = 83;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "登录密码";
            // 
            // tb_OverdueNumber
            // 
            this.tb_OverdueNumber.Enabled = false;
            this.tb_OverdueNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OverdueNumber.Location = new System.Drawing.Point(456, 266);
            this.tb_OverdueNumber.MaxLength = 30;
            this.tb_OverdueNumber.Name = "tb_OverdueNumber";
            this.tb_OverdueNumber.Size = new System.Drawing.Size(189, 30);
            this.tb_OverdueNumber.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(341, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "逾期归还数";
            // 
            // tb_NumberBooksBorrowed
            // 
            this.tb_NumberBooksBorrowed.Enabled = false;
            this.tb_NumberBooksBorrowed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_NumberBooksBorrowed.Location = new System.Drawing.Point(456, 198);
            this.tb_NumberBooksBorrowed.MaxLength = 20;
            this.tb_NumberBooksBorrowed.Name = "tb_NumberBooksBorrowed";
            this.tb_NumberBooksBorrowed.Size = new System.Drawing.Size(189, 30);
            this.tb_NumberBooksBorrowed.TabIndex = 80;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Enabled = false;
            this.tb_Mail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Mail.Location = new System.Drawing.Point(121, 198);
            this.tb_Mail.MaxLength = 20;
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(189, 30);
            this.tb_Mail.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(8, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 79;
            this.label9.Text = "学生邮箱";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(341, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 77;
            this.label11.Text = "借阅总量";
            // 
            // tb_IsViolation
            // 
            this.tb_IsViolation.Enabled = false;
            this.tb_IsViolation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_IsViolation.Location = new System.Drawing.Point(121, 269);
            this.tb_IsViolation.MaxLength = 30;
            this.tb_IsViolation.Name = "tb_IsViolation";
            this.tb_IsViolation.Size = new System.Drawing.Size(189, 30);
            this.tb_IsViolation.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 75;
            this.label10.Text = "是否违规";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Enabled = false;
            this.tb_Phone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Phone.Location = new System.Drawing.Point(121, 127);
            this.tb_Phone.MaxLength = 20;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(189, 30);
            this.tb_Phone.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(8, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 74;
            this.label12.Text = "手机号码";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(341, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 73;
            this.label13.Text = "学生性别";
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Name.Location = new System.Drawing.Point(456, 54);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(189, 30);
            this.tb_Name.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(341, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "学生姓名";
            // 
            // tb_StudentCode
            // 
            this.tb_StudentCode.Enabled = false;
            this.tb_StudentCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_StudentCode.Location = new System.Drawing.Point(121, 52);
            this.tb_StudentCode.MaxLength = 10;
            this.tb_StudentCode.Name = "tb_StudentCode";
            this.tb_StudentCode.Size = new System.Drawing.Size(189, 30);
            this.tb_StudentCode.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(8, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 71;
            this.label15.Text = "学生学号";
            // 
            // PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 465);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.PersonalInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_IsViolation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_StudentCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_OverdueNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NumberBooksBorrowed;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.Button bt_Return;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.ComboBox cb_Sex;
    }
}