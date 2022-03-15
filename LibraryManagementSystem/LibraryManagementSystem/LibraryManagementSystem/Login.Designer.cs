
namespace LibraryManagementSystem
{
    partial class Login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_ZoomOut = new System.Windows.Forms.PictureBox();
            this.pb_Closure = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Closure)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pb_ZoomOut);
            this.panel1.Controls.Add(this.pb_Closure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pb_ZoomOut
            // 
            this.pb_ZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.pb_ZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ZoomOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("pb_ZoomOut.Image")));
            this.pb_ZoomOut.Location = new System.Drawing.Point(761, 0);
            this.pb_ZoomOut.Name = "pb_ZoomOut";
            this.pb_ZoomOut.Size = new System.Drawing.Size(39, 32);
            this.pb_ZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ZoomOut.TabIndex = 1;
            this.pb_ZoomOut.TabStop = false;
            this.pb_ZoomOut.Click += new System.EventHandler(this.pb_ZoomOut_Click);
            this.pb_ZoomOut.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pb_ZoomOut.MouseLeave += new System.EventHandler(this.pb_Closure_MouseLeave);
            // 
            // pb_Closure
            // 
            this.pb_Closure.BackColor = System.Drawing.Color.Transparent;
            this.pb_Closure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Closure.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_Closure.Image = ((System.Drawing.Image)(resources.GetObject("pb_Closure.Image")));
            this.pb_Closure.Location = new System.Drawing.Point(800, 0);
            this.pb_Closure.Name = "pb_Closure";
            this.pb_Closure.Size = new System.Drawing.Size(42, 32);
            this.pb_Closure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Closure.TabIndex = 0;
            this.pb_Closure.TabStop = false;
            this.pb_Closure.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pb_Closure.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pb_Closure.MouseLeave += new System.EventHandler(this.pb_Closure_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tb_Password);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.bt_Login);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_Name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(444, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 380);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.密匙;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Password.Location = new System.Drawing.Point(123, 208);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(189, 30);
            this.tb_Password.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(196, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "注册";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Login.Location = new System.Drawing.Point(54, 282);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(116, 37);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "登录";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "密码";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Name.Location = new System.Drawing.Point(123, 150);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(189, 30);
            this.tb_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "账号";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 380);
            this.panel3.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.云朵;
            this.ClientSize = new System.Drawing.Size(842, 412);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Closure)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Closure;
        private System.Windows.Forms.PictureBox pb_ZoomOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}

