
namespace BTL.QuanLy
{
    partial class frmThongTinNV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinNV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemRap = new System.Windows.Forms.Button();
            this.txtSCMND = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateNVL = new System.Windows.Forms.DateTimePicker();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.btnAnh = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tt_TimKiemNV = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemMa = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Bán Vé",
            "Quản Lý"});
            this.cboChucVu.Location = new System.Drawing.Point(226, 631);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(264, 30);
            this.cboChucVu.TabIndex = 29;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(226, 815);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(264, 31);
            this.txtMatKhau.TabIndex = 28;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(97, 815);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 22);
            this.label.TabIndex = 27;
            this.label.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin nhân viên";
            // 
            // btnThemRap
            // 
            this.btnThemRap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemRap.Image = ((System.Drawing.Image)(resources.GetObject("btnThemRap.Image")));
            this.btnThemRap.Location = new System.Drawing.Point(493, 309);
            this.btnThemRap.Name = "btnThemRap";
            this.btnThemRap.Size = new System.Drawing.Size(65, 59);
            this.btnThemRap.TabIndex = 26;
            this.btnThemRap.UseVisualStyleBackColor = true;
            this.btnThemRap.Click += new System.EventHandler(this.btnThemRap_Click);
            // 
            // txtSCMND
            // 
            this.txtSCMND.Location = new System.Drawing.Point(226, 764);
            this.txtSCMND.Name = "txtSCMND";
            this.txtSCMND.Size = new System.Drawing.Size(264, 31);
            this.txtSCMND.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 725);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 31);
            this.txtEmail.TabIndex = 23;
            // 
            // dateNVL
            // 
            this.dateNVL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNVL.Location = new System.Drawing.Point(226, 672);
            this.dateNVL.Name = "dateNVL";
            this.dateNVL.Size = new System.Drawing.Size(261, 31);
            this.dateNVL.TabIndex = 22;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(226, 588);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(264, 31);
            this.txtDT.TabIndex = 20;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(226, 549);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(264, 31);
            this.txtDC.TabIndex = 19;
            // 
            // dateNS
            // 
            this.dateNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNS.Location = new System.Drawing.Point(226, 507);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(264, 31);
            this.dateNS.TabIndex = 18;
            this.dateNS.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(378, 468);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(58, 26);
            this.rdoNu.TabIndex = 17;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(226, 464);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(77, 26);
            this.rdoNam.TabIndex = 16;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnAnh
            // 
            this.btnAnh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnAnh.Image")));
            this.btnAnh.Location = new System.Drawing.Point(326, 117);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(67, 62);
            this.btnAnh.TabIndex = 27;
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(3, 3);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(309, 258);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(493, 695);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 96);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvNhanVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvNhanVien.Location = new System.Drawing.Point(31, 113);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(853, 537);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Location = new System.Drawing.Point(178, 699);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(265, 45);
            this.txtTimKiem.TabIndex = 28;
            this.tt_TimKiemNV.SetToolTip(this.txtTimKiem, "Nhập mã NV, Tên NV hay tên rạp mà bạn muốn tìm kiếm");
            // 
            // tt_TimKiemNV
            // 
            this.tt_TimKiemNV.AutomaticDelay = 1000;
            this.tt_TimKiemNV.AutoPopDelay = 5000;
            this.tt_TimKiemNV.InitialDelay = 100;
            this.tt_TimKiemNV.ReshowDelay = 200;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1483, 34);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(927, 656);
            this.panel5.TabIndex = 29;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(240, 420);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(250, 31);
            this.txtTenNV.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 974);
            this.panel1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(274, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(337, 36);
            this.label13.TabIndex = 30;
            this.label13.Text = "Danh sách nhân viên";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 930);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1483, 44);
            this.panel7.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Controls.Add(this.btnThemNV);
            this.panel6.Controls.Add(this.btnLamMoi);
            this.panel6.Controls.Add(this.btnSua);
            this.panel6.Font = new System.Drawing.Font("Sitka Heading", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 836);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(893, 100);
            this.panel6.TabIndex = 29;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(630, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 65);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemNV.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(23, 23);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(139, 65);
            this.btnThemNV.TabIndex = 0;
            this.btnThemNV.Text = "&Thêm";
            this.btnThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(421, 23);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(168, 65);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "  &Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(225, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 65);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "&Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.btnThemMa);
            this.panel2.Controls.Add(this.cboChucVu);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnThemRap);
            this.panel2.Controls.Add(this.txtSCMND);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.dateNVL);
            this.panel2.Controls.Add(this.txtDT);
            this.panel2.Controls.Add(this.txtDC);
            this.panel2.Controls.Add(this.dateNS);
            this.panel2.Controls.Add(this.rdoNu);
            this.panel2.Controls.Add(this.rdoNam);
            this.panel2.Controls.Add(this.txtTenNV);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.cboRap);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(902, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 899);
            this.panel2.TabIndex = 1;
            // 
            // btnThemMa
            // 
            this.btnThemMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMa.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMa.Image")));
            this.btnThemMa.Location = new System.Drawing.Point(507, 376);
            this.btnThemMa.Name = "btnThemMa";
            this.btnThemMa.Size = new System.Drawing.Size(51, 42);
            this.btnThemMa.TabIndex = 30;
            this.btnThemMa.UseVisualStyleBackColor = true;
            this.btnThemMa.Click += new System.EventHandler(this.btnThemMa_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(240, 383);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(250, 31);
            this.txtMaNV.TabIndex = 14;
            // 
            // cboRap
            // 
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(240, 333);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(247, 30);
            this.cboRap.TabIndex = 13;
            this.cboRap.SelectionChangeCommitted += new System.EventHandler(this.cboRap_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mã nhân viên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tên nhân viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 725);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chức vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày vào làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 768);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên rạp:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnAnh);
            this.panel3.Controls.Add(this.picAnh);
            this.panel3.Location = new System.Drawing.Point(97, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 264);
            this.panel3.TabIndex = 0;
            // 
            // frmThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 974);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongTinNV";
            this.Text = "Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.frmThongTinNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemRap;
        private System.Windows.Forms.TextBox txtSCMND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dateNVL;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.DateTimePicker dateNS;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ToolTip tt_TimKiemNV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThemMa;
    }
}