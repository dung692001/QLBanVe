
namespace BTL
{
    partial class Form1
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
            this.panelTC = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnDatDoAn = new System.Windows.Forms.Button();
            this.btnThuPhim = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnLuongNV = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnQLPhim = new System.Windows.Forms.Button();
            this.btnPhongChieu = new System.Windows.Forms.Button();
            this.btnRapChieu = new System.Windows.Forms.Button();
            this.btnLichChieu = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnPhim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnHien = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDoanhThuNam = new System.Windows.Forms.Button();
            this.gbButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnHien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTC
            // 
            this.panelTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTC.Location = new System.Drawing.Point(197, 79);
            this.panelTC.Name = "panelTC";
            this.panelTC.Size = new System.Drawing.Size(961, 908);
            this.panelTC.TabIndex = 7;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 35);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(197, 46);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.btnDatDoAn);
            this.gbButton.Controls.Add(this.btnDoanhThuNam);
            this.gbButton.Controls.Add(this.btnThuPhim);
            this.gbButton.Controls.Add(this.btnThang);
            this.gbButton.Controls.Add(this.btnLuongNV);
            this.gbButton.Controls.Add(this.btnNhanVien);
            this.gbButton.Controls.Add(this.btnQLPhim);
            this.gbButton.Controls.Add(this.btnPhongChieu);
            this.gbButton.Controls.Add(this.btnRapChieu);
            this.gbButton.Controls.Add(this.btnLichChieu);
            this.gbButton.Controls.Add(this.btnDatVe);
            this.gbButton.Controls.Add(this.btnPhim);
            this.gbButton.Controls.Add(this.btnTrangChu);
            this.gbButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbButton.Location = new System.Drawing.Point(0, 79);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(197, 908);
            this.gbButton.TabIndex = 6;
            this.gbButton.TabStop = false;
            // 
            // btnDatDoAn
            // 
            this.btnDatDoAn.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDatDoAn.ForeColor = System.Drawing.Color.Black;
            this.btnDatDoAn.Location = new System.Drawing.Point(-1, 238);
            this.btnDatDoAn.Name = "btnDatDoAn";
            this.btnDatDoAn.Size = new System.Drawing.Size(196, 49);
            this.btnDatDoAn.TabIndex = 20;
            this.btnDatDoAn.Text = "Đặt đồ ăn";
            this.btnDatDoAn.UseVisualStyleBackColor = false;
            this.btnDatDoAn.Click += new System.EventHandler(this.btnDatDoAn_Click);
            // 
            // btnThuPhim
            // 
            this.btnThuPhim.BackColor = System.Drawing.Color.Cornsilk;
            this.btnThuPhim.ForeColor = System.Drawing.Color.Black;
            this.btnThuPhim.Location = new System.Drawing.Point(0, 847);
            this.btnThuPhim.Name = "btnThuPhim";
            this.btnThuPhim.Size = new System.Drawing.Size(196, 49);
            this.btnThuPhim.TabIndex = 19;
            this.btnThuPhim.Text = "Doanh thu theo phim";
            this.btnThuPhim.UseVisualStyleBackColor = false;
            this.btnThuPhim.Click += new System.EventHandler(this.btnThuPhim_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.Cornsilk;
            this.btnThang.ForeColor = System.Drawing.Color.Black;
            this.btnThang.Location = new System.Drawing.Point(-1, 712);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(197, 46);
            this.btnThang.TabIndex = 18;
            this.btnThang.Text = "Doanh thu theo tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnLuongNV
            // 
            this.btnLuongNV.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLuongNV.ForeColor = System.Drawing.Color.Black;
            this.btnLuongNV.Location = new System.Drawing.Point(0, 651);
            this.btnLuongNV.Name = "btnLuongNV";
            this.btnLuongNV.Size = new System.Drawing.Size(197, 46);
            this.btnLuongNV.TabIndex = 17;
            this.btnLuongNV.Text = "Lương nhân viên";
            this.btnLuongNV.UseVisualStyleBackColor = false;
            this.btnLuongNV.Click += new System.EventHandler(this.btnLuongNV_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Cornsilk;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Location = new System.Drawing.Point(-1, 583);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(197, 46);
            this.btnNhanVien.TabIndex = 16;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnQLPhim
            // 
            this.btnQLPhim.BackColor = System.Drawing.Color.Cornsilk;
            this.btnQLPhim.ForeColor = System.Drawing.Color.Black;
            this.btnQLPhim.Location = new System.Drawing.Point(0, 512);
            this.btnQLPhim.Name = "btnQLPhim";
            this.btnQLPhim.Size = new System.Drawing.Size(196, 46);
            this.btnQLPhim.TabIndex = 15;
            this.btnQLPhim.Text = "Quản lý phim";
            this.btnQLPhim.UseVisualStyleBackColor = false;
            this.btnQLPhim.Click += new System.EventHandler(this.btnQLPhim_Click);
            // 
            // btnPhongChieu
            // 
            this.btnPhongChieu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPhongChieu.ForeColor = System.Drawing.Color.Black;
            this.btnPhongChieu.Location = new System.Drawing.Point(-1, 373);
            this.btnPhongChieu.Name = "btnPhongChieu";
            this.btnPhongChieu.Size = new System.Drawing.Size(197, 46);
            this.btnPhongChieu.TabIndex = 14;
            this.btnPhongChieu.Text = "Phòng chiếu";
            this.btnPhongChieu.UseVisualStyleBackColor = false;
            this.btnPhongChieu.Click += new System.EventHandler(this.btnPhongChieu_Click);
            // 
            // btnRapChieu
            // 
            this.btnRapChieu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRapChieu.ForeColor = System.Drawing.Color.Black;
            this.btnRapChieu.Location = new System.Drawing.Point(-1, 304);
            this.btnRapChieu.Name = "btnRapChieu";
            this.btnRapChieu.Size = new System.Drawing.Size(196, 46);
            this.btnRapChieu.TabIndex = 13;
            this.btnRapChieu.Text = "Rạp chiếu";
            this.btnRapChieu.UseVisualStyleBackColor = false;
            this.btnRapChieu.Click += new System.EventHandler(this.btnRapChieu_Click);
            // 
            // btnLichChieu
            // 
            this.btnLichChieu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLichChieu.ForeColor = System.Drawing.Color.Black;
            this.btnLichChieu.Location = new System.Drawing.Point(0, 439);
            this.btnLichChieu.Name = "btnLichChieu";
            this.btnLichChieu.Size = new System.Drawing.Size(197, 46);
            this.btnLichChieu.TabIndex = 12;
            this.btnLichChieu.Text = "Lịch chiếu";
            this.btnLichChieu.UseVisualStyleBackColor = false;
            this.btnLichChieu.Click += new System.EventHandler(this.btnLichChieu_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDatVe.ForeColor = System.Drawing.Color.Black;
            this.btnDatVe.Location = new System.Drawing.Point(0, 172);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(197, 46);
            this.btnDatVe.TabIndex = 1;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPhim.ForeColor = System.Drawing.Color.Black;
            this.btnPhim.Location = new System.Drawing.Point(0, 107);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(197, 46);
            this.btnPhim.TabIndex = 2;
            this.btnPhim.Text = "Phim";
            this.btnPhim.UseVisualStyleBackColor = false;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnHien);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pnHien
            // 
            this.pnHien.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnHien.Controls.Add(this.label1);
            this.pnHien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHien.Location = new System.Drawing.Point(535, 22);
            this.pnHien.Name = "pnHien";
            this.pnHien.Size = new System.Drawing.Size(262, 54);
            this.pnHien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang Chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(797, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 54);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(271, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 48);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnDoiMK);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(174, 8);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(120, 38);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(9, 8);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(139, 38);
            this.btnDoiMK.TabIndex = 3;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(319, 8);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(124, 38);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDoanhThuNam
            // 
            this.btnDoanhThuNam.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDoanhThuNam.ForeColor = System.Drawing.Color.Black;
            this.btnDoanhThuNam.Location = new System.Drawing.Point(-1, 778);
            this.btnDoanhThuNam.Name = "btnDoanhThuNam";
            this.btnDoanhThuNam.Size = new System.Drawing.Size(196, 49);
            this.btnDoanhThuNam.TabIndex = 21;
            this.btnDoanhThuNam.Text = "Doanh thu theo năm";
            this.btnDoanhThuNam.UseVisualStyleBackColor = false;
            this.btnDoanhThuNam.Click += new System.EventHandler(this.btnDoanhThuNam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 987);
            this.Controls.Add(this.panelTC);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnHien.ResumeLayout(false);
            this.pnHien.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTC;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnPhongChieu;
        private System.Windows.Forms.Button btnRapChieu;
        private System.Windows.Forms.Button btnLichChieu;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnPhim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnQLPhim;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnThuPhim;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnLuongNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnHien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnDatDoAn;
        private System.Windows.Forms.Button btnDoanhThuNam;
    }
}

