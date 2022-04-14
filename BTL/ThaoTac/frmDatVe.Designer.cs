
namespace BTL.ThaoTac
{
    partial class frmDatVe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.pnChonPhim = new System.Windows.Forms.Panel();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnDat = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.cboGio = new System.Windows.Forms.ComboBox();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGhe = new System.Windows.Forms.GroupBox();
            this.gbPhong = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnMan = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.pnChonPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.gbPhong.SuspendLayout();
            this.pnMan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThongTin);
            this.panel1.Controls.Add(this.pnChonPhim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 723);
            this.panel1.TabIndex = 2;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTin.Location = new System.Drawing.Point(0, 454);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 62;
            this.dgvThongTin.RowTemplate.Height = 28;
            this.dgvThongTin.Size = new System.Drawing.Size(742, 269);
            this.dgvThongTin.TabIndex = 1;
            // 
            // pnChonPhim
            // 
            this.pnChonPhim.BackColor = System.Drawing.SystemColors.Control;
            this.pnChonPhim.Controls.Add(this.picAnh);
            this.pnChonPhim.Controls.Add(this.btnDat);
            this.pnChonPhim.Controls.Add(this.btnBoChon);
            this.pnChonPhim.Controls.Add(this.cboNgay);
            this.pnChonPhim.Controls.Add(this.cboRap);
            this.pnChonPhim.Controls.Add(this.cboGio);
            this.pnChonPhim.Controls.Add(this.cboPhim);
            this.pnChonPhim.Controls.Add(this.label4);
            this.pnChonPhim.Controls.Add(this.label3);
            this.pnChonPhim.Controls.Add(this.label2);
            this.pnChonPhim.Controls.Add(this.label1);
            this.pnChonPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChonPhim.Location = new System.Drawing.Point(0, 0);
            this.pnChonPhim.Name = "pnChonPhim";
            this.pnChonPhim.Size = new System.Drawing.Size(742, 454);
            this.pnChonPhim.TabIndex = 0;
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAnh.Location = new System.Drawing.Point(431, 12);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(283, 418);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 11;
            this.picAnh.TabStop = false;
            // 
            // btnDat
            // 
            this.btnDat.Location = new System.Drawing.Point(168, 359);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(106, 43);
            this.btnDat.TabIndex = 10;
            this.btnDat.Text = "Đặt ";
            this.btnDat.UseVisualStyleBackColor = true;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(12, 359);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(106, 43);
            this.btnBoChon.TabIndex = 9;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // cboNgay
            // 
            this.cboNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Location = new System.Drawing.Point(118, 251);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(156, 33);
            this.cboNgay.TabIndex = 8;
            this.cboNgay.SelectionChangeCommitted += new System.EventHandler(this.cboNgay_SelectionChangeCommitted);
            // 
            // cboRap
            // 
            this.cboRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(118, 194);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(288, 33);
            this.cboRap.TabIndex = 7;
            this.cboRap.SelectionChangeCommitted += new System.EventHandler(this.cboRap_SelectionChangeCommitted_1);
            // 
            // cboGio
            // 
            this.cboGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGio.FormattingEnabled = true;
            this.cboGio.Location = new System.Drawing.Point(118, 303);
            this.cboGio.Name = "cboGio";
            this.cboGio.Size = new System.Drawing.Size(156, 33);
            this.cboGio.TabIndex = 6;
            this.cboGio.SelectionChangeCommitted += new System.EventHandler(this.cboGio_SelectionChangeCommitted);
            // 
            // cboPhim
            // 
            this.cboPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(118, 143);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(288, 33);
            this.cboPhim.TabIndex = 4;
            this.cboPhim.SelectionChangeCommitted += new System.EventHandler(this.cboPhim_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn giờ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn rạp:";
            // 
            // gbGhe
            // 
            this.gbGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGhe.Location = new System.Drawing.Point(3, 60);
            this.gbGhe.Name = "gbGhe";
            this.gbGhe.Size = new System.Drawing.Size(1176, 660);
            this.gbGhe.TabIndex = 1;
            this.gbGhe.TabStop = false;
            // 
            // gbPhong
            // 
            this.gbPhong.Controls.Add(this.gbGhe);
            this.gbPhong.Controls.Add(this.pnMan);
            this.gbPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPhong.Location = new System.Drawing.Point(742, 0);
            this.gbPhong.Name = "gbPhong";
            this.gbPhong.Size = new System.Drawing.Size(1182, 723);
            this.gbPhong.TabIndex = 3;
            this.gbPhong.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(496, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Màn ảnh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMan
            // 
            this.pnMan.BackColor = System.Drawing.Color.Black;
            this.pnMan.Controls.Add(this.label5);
            this.pnMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMan.Location = new System.Drawing.Point(3, 22);
            this.pnMan.Name = "pnMan";
            this.pnMan.Size = new System.Drawing.Size(1176, 38);
            this.pnMan.TabIndex = 0;
            // 
            // frmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 723);
            this.Controls.Add(this.gbPhong);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatVe";
            this.Text = "Đặt vé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.pnChonPhim.ResumeLayout(false);
            this.pnChonPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.gbPhong.ResumeLayout(false);
            this.pnMan.ResumeLayout(false);
            this.pnMan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Panel pnChonPhim;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.ComboBox cboGio;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.GroupBox gbGhe;
        private System.Windows.Forms.GroupBox gbPhong;
        private System.Windows.Forms.Panel pnMan;
        private System.Windows.Forms.Label label5;
    }
}