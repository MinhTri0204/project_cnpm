
namespace DoAn.gui
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemKH = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGioiThieu = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnLamMoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picSlide1 = new System.Windows.Forms.PictureBox();
            this.picSilde2 = new System.Windows.Forms.PictureBox();
            this.picSilde4 = new System.Windows.Forms.PictureBox();
            this.picSilde3 = new System.Windows.Forms.PictureBox();
            this.lblgt = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.lblNhapSach = new System.Windows.Forms.Label();
            this.lblHDNhap = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblHDBan = new System.Windows.Forms.Label();
            this.lblThongTinSach = new System.Windows.Forms.Label();
            this.lblTrangChu = new System.Windows.Forms.Label();
            this.pnNVDangNhap = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNVDangNhap = new System.Windows.Forms.Label();
            this.picANHNVDangNhap = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.userBaoCao1 = new DoAn.gui.userBaoCao();
            this.elipseControl1 = new DoAn.gui.ElipseControl();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde3)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnNVDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picANHNVDangNhap)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuNhanVien,
            this.mnuNCC,
            this.mnuKH});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1534, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(88, 24);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangXuat.Image")));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(160, 26);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(160, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinNhanVien,
            this.mnuDoiMatKhau});
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(89, 24);
            this.mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuThongTinNhanVien
            // 
            this.mnuThongTinNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongTinNhanVien.Image")));
            this.mnuThongTinNhanVien.Name = "mnuThongTinNhanVien";
            this.mnuThongTinNhanVien.Size = new System.Drawing.Size(222, 26);
            this.mnuThongTinNhanVien.Text = "Thông tin nhân viên";
            this.mnuThongTinNhanVien.Click += new System.EventHandler(this.mnuThongTinNhanVien_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiMatKhau.Image")));
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(222, 26);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuNCC
            // 
            this.mnuNCC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinNCC,
            this.mnuThemNCC});
            this.mnuNCC.Name = "mnuNCC";
            this.mnuNCC.Size = new System.Drawing.Size(114, 24);
            this.mnuNCC.Text = "Nhà cung cấp";
            // 
            // mnuThongTinNCC
            // 
            this.mnuThongTinNCC.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongTinNCC.Image")));
            this.mnuThongTinNCC.Name = "mnuThongTinNCC";
            this.mnuThongTinNCC.Size = new System.Drawing.Size(247, 26);
            this.mnuThongTinNCC.Text = "Thông tin nhà cung cấp";
            this.mnuThongTinNCC.Click += new System.EventHandler(this.mnuThongTinNCC_Click);
            // 
            // mnuThemNCC
            // 
            this.mnuThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("mnuThemNCC.Image")));
            this.mnuThemNCC.Name = "mnuThemNCC";
            this.mnuThemNCC.Size = new System.Drawing.Size(247, 26);
            this.mnuThemNCC.Text = "Thêm nhà cung cấp";
            this.mnuThemNCC.Click += new System.EventHandler(this.mnuThemNCC_Click);
            // 
            // mnuKH
            // 
            this.mnuKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinKH,
            this.mnuThemKH});
            this.mnuKH.Name = "mnuKH";
            this.mnuKH.Size = new System.Drawing.Size(100, 24);
            this.mnuKH.Text = "Khách hàng";
            // 
            // mnuThongTinKH
            // 
            this.mnuThongTinKH.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongTinKH.Image")));
            this.mnuThongTinKH.Name = "mnuThongTinKH";
            this.mnuThongTinKH.Size = new System.Drawing.Size(234, 26);
            this.mnuThongTinKH.Text = "Thông tin khách hàng";
            this.mnuThongTinKH.Click += new System.EventHandler(this.mnuThongTinKH_Click);
            // 
            // mnuThemKH
            // 
            this.mnuThemKH.Image = ((System.Drawing.Image)(resources.GetObject("mnuThemKH.Image")));
            this.mnuThemKH.Name = "mnuThemKH";
            this.mnuThemKH.Size = new System.Drawing.Size(234, 26);
            this.mnuThemKH.Text = "Thêm khách hàng";
            this.mnuThemKH.Click += new System.EventHandler(this.mnuThemKH_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblGioiThieu);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1534, 40);
            this.panel2.TabIndex = 3;
            // 
            // lblGioiThieu
            // 
            this.lblGioiThieu.AutoSize = true;
            this.lblGioiThieu.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiThieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiThieu.Location = new System.Drawing.Point(57, 7);
            this.lblGioiThieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiThieu.Name = "lblGioiThieu";
            this.lblGioiThieu.Size = new System.Drawing.Size(193, 22);
            this.lblGioiThieu.TabIndex = 0;
            this.lblGioiThieu.Text = "Xin chào tất cả các bạn";
            this.lblGioiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnLamMoi,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1532, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbtnLamMoi
            // 
            this.toolbtnLamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnLamMoi.Image")));
            this.toolbtnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnLamMoi.Name = "toolbtnLamMoi";
            this.toolbtnLamMoi.Size = new System.Drawing.Size(29, 35);
            this.toolbtnLamMoi.Text = "Làm mới";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pnRight);
            this.panel1.Controls.Add(this.pnLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 881);
            this.panel1.TabIndex = 4;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnRight.Controls.Add(this.panel3);
            this.pnRight.Controls.Add(this.lblgt);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(346, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(1188, 881);
            this.pnRight.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.picSlide1);
            this.panel3.Controls.Add(this.picSilde2);
            this.panel3.Controls.Add(this.picSilde4);
            this.panel3.Controls.Add(this.picSilde3);
            this.panel3.Location = new System.Drawing.Point(37, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 615);
            this.panel3.TabIndex = 5;
            // 
            // picSlide1
            // 
            this.picSlide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSlide1.Image = global::DoAn.Properties.Resources.banner_201806;
            this.picSlide1.Location = new System.Drawing.Point(0, 0);
            this.picSlide1.Name = "picSlide1";
            this.picSlide1.Size = new System.Drawing.Size(1125, 615);
            this.picSlide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlide1.TabIndex = 0;
            this.picSlide1.TabStop = false;
            // 
            // picSilde2
            // 
            this.picSilde2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSilde2.Image = global::DoAn.Properties.Resources.banner_hoi_sach;
            this.picSilde2.Location = new System.Drawing.Point(0, 0);
            this.picSilde2.Name = "picSilde2";
            this.picSilde2.Size = new System.Drawing.Size(1125, 615);
            this.picSilde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSilde2.TabIndex = 1;
            this.picSilde2.TabStop = false;
            // 
            // picSilde4
            // 
            this.picSilde4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSilde4.Image = global::DoAn.Properties.Resources.carouse03;
            this.picSilde4.Location = new System.Drawing.Point(0, 0);
            this.picSilde4.Name = "picSilde4";
            this.picSilde4.Size = new System.Drawing.Size(1125, 615);
            this.picSilde4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSilde4.TabIndex = 3;
            this.picSilde4.TabStop = false;
            // 
            // picSilde3
            // 
            this.picSilde3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSilde3.Image = ((System.Drawing.Image)(resources.GetObject("picSilde3.Image")));
            this.picSilde3.Location = new System.Drawing.Point(0, 0);
            this.picSilde3.Name = "picSilde3";
            this.picSilde3.Size = new System.Drawing.Size(1125, 615);
            this.picSilde3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSilde3.TabIndex = 2;
            this.picSilde3.TabStop = false;
            // 
            // lblgt
            // 
            this.lblgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgt.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgt.Location = new System.Drawing.Point(0, 0);
            this.lblgt.Name = "lblgt";
            this.lblgt.Size = new System.Drawing.Size(1188, 146);
            this.lblgt.TabIndex = 4;
            this.lblgt.Text = "Welcome to BookStore";
            this.lblgt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnLeft.Controls.Add(this.lblNhapSach);
            this.pnLeft.Controls.Add(this.lblHDNhap);
            this.pnLeft.Controls.Add(this.lblDoanhThu);
            this.pnLeft.Controls.Add(this.lblHDBan);
            this.pnLeft.Controls.Add(this.lblThongTinSach);
            this.pnLeft.Controls.Add(this.lblTrangChu);
            this.pnLeft.Controls.Add(this.pnNVDangNhap);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(346, 881);
            this.pnLeft.TabIndex = 0;
            // 
            // lblNhapSach
            // 
            this.lblNhapSach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNhapSach.Image = ((System.Drawing.Image)(resources.GetObject("lblNhapSach.Image")));
            this.lblNhapSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNhapSach.Location = new System.Drawing.Point(34, 372);
            this.lblNhapSach.Name = "lblNhapSach";
            this.lblNhapSach.Size = new System.Drawing.Size(289, 62);
            this.lblNhapSach.TabIndex = 9;
            this.lblNhapSach.Text = " Nhập sách";
            this.lblNhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNhapSach.Click += new System.EventHandler(this.lblNhapSach_Click);
            this.lblNhapSach.MouseLeave += new System.EventHandler(this.lblNhapSach_MouseLeave);
            this.lblNhapSach.MouseHover += new System.EventHandler(this.lblNhapSach_MouseHover);
            // 
            // lblHDNhap
            // 
            this.lblHDNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHDNhap.Image = ((System.Drawing.Image)(resources.GetObject("lblHDNhap.Image")));
            this.lblHDNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHDNhap.Location = new System.Drawing.Point(34, 310);
            this.lblHDNhap.Name = "lblHDNhap";
            this.lblHDNhap.Size = new System.Drawing.Size(289, 62);
            this.lblHDNhap.TabIndex = 8;
            this.lblHDNhap.Text = "       Hóa đơn nhập";
            this.lblHDNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHDNhap.Click += new System.EventHandler(this.lblHDNhap_Click);
            this.lblHDNhap.MouseLeave += new System.EventHandler(this.lblHDNhap_MouseLeave);
            this.lblHDNhap.MouseHover += new System.EventHandler(this.lblHDNhap_MouseHover);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("lblDoanhThu.Image")));
            this.lblDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDoanhThu.Location = new System.Drawing.Point(34, 434);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(289, 62);
            this.lblDoanhThu.TabIndex = 7;
            this.lblDoanhThu.Text = " Doanh thu";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoanhThu.Click += new System.EventHandler(this.lblDoanhThu_Click);
            this.lblDoanhThu.MouseLeave += new System.EventHandler(this.lblDoanhThu_MouseLeave);
            this.lblDoanhThu.MouseHover += new System.EventHandler(this.lblDoanhThu_MouseHover);
            // 
            // lblHDBan
            // 
            this.lblHDBan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDBan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHDBan.Image = ((System.Drawing.Image)(resources.GetObject("lblHDBan.Image")));
            this.lblHDBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHDBan.Location = new System.Drawing.Point(34, 248);
            this.lblHDBan.Name = "lblHDBan";
            this.lblHDBan.Size = new System.Drawing.Size(289, 62);
            this.lblHDBan.TabIndex = 5;
            this.lblHDBan.Text = "     Hóa đơn bán";
            this.lblHDBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHDBan.Click += new System.EventHandler(this.lblHDBan_Click);
            this.lblHDBan.MouseLeave += new System.EventHandler(this.lblHDBan_MouseLeave);
            this.lblHDBan.MouseHover += new System.EventHandler(this.lblHDBan_MouseHover);
            // 
            // lblThongTinSach
            // 
            this.lblThongTinSach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblThongTinSach.Image = ((System.Drawing.Image)(resources.GetObject("lblThongTinSach.Image")));
            this.lblThongTinSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThongTinSach.Location = new System.Drawing.Point(35, 186);
            this.lblThongTinSach.Name = "lblThongTinSach";
            this.lblThongTinSach.Size = new System.Drawing.Size(289, 62);
            this.lblThongTinSach.TabIndex = 4;
            this.lblThongTinSach.Text = "       Thông tin sách";
            this.lblThongTinSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongTinSach.Click += new System.EventHandler(this.lblThongTinSach_Click);
            this.lblThongTinSach.MouseLeave += new System.EventHandler(this.lblThongTinSach_MouseLeave);
            this.lblThongTinSach.MouseHover += new System.EventHandler(this.lblThongTinSach_MouseHover);
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangChu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("lblTrangChu.Image")));
            this.lblTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrangChu.Location = new System.Drawing.Point(35, 124);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(289, 62);
            this.lblTrangChu.TabIndex = 3;
            this.lblTrangChu.Text = "         Trang chủ         ";
            this.lblTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrangChu.Click += new System.EventHandler(this.lblTrangChu_Click);
            this.lblTrangChu.MouseLeave += new System.EventHandler(this.lblTrangChu_MouseLeave);
            this.lblTrangChu.MouseHover += new System.EventHandler(this.lblTrangChu_MouseHover);
            // 
            // pnNVDangNhap
            // 
            this.pnNVDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnNVDangNhap.Controls.Add(this.label1);
            this.pnNVDangNhap.Controls.Add(this.lblNVDangNhap);
            this.pnNVDangNhap.Controls.Add(this.picANHNVDangNhap);
            this.pnNVDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNVDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnNVDangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnNVDangNhap.Name = "pnNVDangNhap";
            this.pnNVDangNhap.Size = new System.Drawing.Size(346, 117);
            this.pnNVDangNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(134, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thoát";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNVDangNhap
            // 
            this.lblNVDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNVDangNhap.Location = new System.Drawing.Point(133, 30);
            this.lblNVDangNhap.Name = "lblNVDangNhap";
            this.lblNVDangNhap.Size = new System.Drawing.Size(199, 27);
            this.lblNVDangNhap.TabIndex = 1;
            this.lblNVDangNhap.Text = "HỌ VÀ TÊN NHÂN VIÊN";
            this.lblNVDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picANHNVDangNhap
            // 
            this.picANHNVDangNhap.BackColor = System.Drawing.Color.Gainsboro;
            this.picANHNVDangNhap.Location = new System.Drawing.Point(12, 7);
            this.picANHNVDangNhap.Name = "picANHNVDangNhap";
            this.picANHNVDangNhap.Size = new System.Drawing.Size(106, 93);
            this.picANHNVDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picANHNVDangNhap.TabIndex = 0;
            this.picANHNVDangNhap.TabStop = false;
            this.picANHNVDangNhap.Click += new System.EventHandler(this.picANHNVDangNhap_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progress,
            this.toolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 920);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1534, 31);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 25);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(313, 23);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(0, 25);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // userBaoCao1
            // 
            this.userBaoCao1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.userBaoCao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBaoCao1.Location = new System.Drawing.Point(0, 0);
            this.userBaoCao1.Name = "userBaoCao1";
            this.userBaoCao1.Size = new System.Drawing.Size(1188, 881);
            this.userBaoCao1.TabIndex = 0;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 190;
            this.elipseControl1.TargetControl = this.picANHNVDangNhap;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 951);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "Cửa hàng bán sách Ly Thúy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSlide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde3)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnNVDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picANHNVDangNhap)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuKH;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinKH;
        private System.Windows.Forms.ToolStripMenuItem mnuThemKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGioiThieu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbtnLamMoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnNVDangNhap;
        private System.Windows.Forms.Label lblNVDangNhap;
        private System.Windows.Forms.PictureBox picANHNVDangNhap;
        private System.Windows.Forms.Timer timer1;

        private userBaoCao userBaoCao1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label lblgt;
        private System.Windows.Forms.PictureBox picSilde4;
        private System.Windows.Forms.PictureBox picSilde3;
        private System.Windows.Forms.PictureBox picSilde2;
        private System.Windows.Forms.PictureBox picSlide1;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrangChu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblHDBan;
        private System.Windows.Forms.Label lblThongTinSach;
        private System.Windows.Forms.Label lblHDNhap;
        private System.Windows.Forms.Label lblNhapSach;
        private System.Windows.Forms.Panel panel3;
    }
}