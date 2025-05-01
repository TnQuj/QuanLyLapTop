namespace QuanLyLapTop.Forms
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            btnHuyBo = new Button();
            btnXacNhan = new Button();
            txtMatKhauMoi = new TextBox();
            txtMatKhauCu = new TextBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            txtXacNhanLai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.user_account;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 353);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(428, 160);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(428, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(469, 129);
            label3.Name = "label3";
            label3.Size = new Size(146, 22);
            label3.TabIndex = 33;
            label3.Text = "Mật khẩu mới (*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(469, 59);
            label2.Name = "label2";
            label2.Size = new Size(133, 22);
            label2.TabIndex = 32;
            label2.Text = "Mật khẩu cũ (*)";
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(255, 128, 128);
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(606, 292);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(174, 50);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.FromArgb(128, 255, 128);
            btnXacNhan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.Black;
            btnXacNhan.Location = new Point(400, 292);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(181, 50);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác nhận..";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhauMoi.ForeColor = Color.DimGray;
            txtMatKhauMoi.Location = new Point(469, 160);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '⚫';
            txtMatKhauMoi.Size = new Size(280, 27);
            txtMatKhauMoi.TabIndex = 1;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhauCu.ForeColor = Color.DimGray;
            txtMatKhauCu.Location = new Point(469, 90);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '⚫';
            txtMatKhauCu.Size = new Size(280, 27);
            txtMatKhauCu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(507, 10);
            label1.Name = "label1";
            label1.Size = new Size(175, 33);
            label1.TabIndex = 36;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(428, 239);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(469, 202);
            label4.Name = "label4";
            label4.Size = new Size(216, 22);
            label4.TabIndex = 38;
            label4.Text = "Nhập lại mật khẩu mới (*)";
            // 
            // txtXacNhanLai
            // 
            txtXacNhanLai.BorderStyle = BorderStyle.FixedSingle;
            txtXacNhanLai.ForeColor = Color.DimGray;
            txtXacNhanLai.Location = new Point(469, 239);
            txtXacNhanLai.Name = "txtXacNhanLai";
            txtXacNhanLai.PasswordChar = '⚫';
            txtXacNhanLai.Size = new Size(280, 27);
            txtXacNhanLai.TabIndex = 2;
            txtXacNhanLai.KeyDown += txtXacNhanLai_KeyDown;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(txtXacNhanLai);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnHuyBo);
            Controls.Add(btnXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Button btnHuyBo;
        private Button btnXacNhan;
        public TextBox txtMatKhauMoi;
        public TextBox txtMatKhauCu;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label4;
        public TextBox txtXacNhanLai;
    }
}