namespace TOSApp
{
    partial class f1000_login
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
            this.m_txt_password = new System.Windows.Forms.TextBox();
            this.m_lab_eror = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_dang_nhap = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // m_txt_password
            // 
            this.m_txt_password.Location = new System.Drawing.Point(345, 121);
            this.m_txt_password.Name = "m_txt_password";
            this.m_txt_password.PasswordChar = '*';
            this.m_txt_password.Size = new System.Drawing.Size(176, 20);
            this.m_txt_password.TabIndex = 17;
            // 
            // m_lab_eror
            // 
            this.m_lab_eror.AutoSize = true;
            this.m_lab_eror.ForeColor = System.Drawing.Color.Red;
            this.m_lab_eror.Location = new System.Drawing.Point(238, 172);
            this.m_lab_eror.Name = "m_lab_eror";
            this.m_lab_eror.Size = new System.Drawing.Size(35, 13);
            this.m_lab_eror.TabIndex = 23;
            this.m_lab_eror.Text = "dfsfsd";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::TOSApp.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(446, 209);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_thoat.TabIndex = 19;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // m_cmd_dang_nhap
            // 
            this.m_cmd_dang_nhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m_cmd_dang_nhap.Location = new System.Drawing.Point(348, 209);
            this.m_cmd_dang_nhap.Name = "m_cmd_dang_nhap";
            this.m_cmd_dang_nhap.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_dang_nhap.TabIndex = 18;
            this.m_cmd_dang_nhap.Text = "Đăng nhập ";
            this.m_cmd_dang_nhap.Click += new System.EventHandler(this.m_cmd_dang_nhap_Click);
            // 
            // m_txt_user
            // 
            this.m_txt_user.Location = new System.Drawing.Point(345, 63);
            this.m_txt_user.Name = "m_txt_user";
            this.m_txt_user.Size = new System.Drawing.Size(176, 20);
            this.m_txt_user.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên đăng nhập";
            // 
            // f1000_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 244);
            this.Controls.Add(this.m_txt_password);
            this.Controls.Add(this.m_lab_eror);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_dang_nhap);
            this.Controls.Add(this.m_txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f1000_login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_password;
        private System.Windows.Forms.Label m_lab_eror;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dang_nhap;
        private System.Windows.Forms.TextBox m_txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}