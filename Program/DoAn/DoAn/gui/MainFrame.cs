using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn.doi_tuong;

namespace DoAn.gui
{
    public partial class MainFrame : Form
    {
        NhanVien nv;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public MainFrame()
        {
            InitializeComponent();
        }

        public void Hower_Control(Label label)
        {
            label.ForeColor = Color.GreenYellow;
        }

        public void Leave_Control(Label label)
        {
            label.ForeColor = Color.White;
        }



        internal MainFrame(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            lblNVDangNhap.Text = nv.TenNV;
            picANHNVDangNhap.Image = Image.FromFile(projectPath + nv.AnhNV);
            timer2.Start();
            int id_role = this.nv.ID_ROEL;
            if (id_role == 2)
            {
                mnuThongTinNhanVien.Enabled = false;
                mnuThongTinNCC.Enabled = false;
                mnuThongTinKH.Enabled = false;
            }
        }

        #region HIỂN THỊ USERCONTROL
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát phiên đăng nhập ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            this.Hide();
            frmDangNhap dn = new frmDangNhap();
            dn.Visible = true;
        }

        private void mnuThongTinNhanVien_Click(object sender, EventArgs e)
        {
            userNhanVien nv = new userNhanVien();
            nv.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(nv);
            nv.BringToFront();
        }

        private void mnuThongTinNCC_Click(object sender, EventArgs e)
        {
            userNhaCungCap ncc = new userNhaCungCap();
            ncc.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(ncc);
            ncc.BringToFront();
        }

        private void mnuThongTinKH_Click(object sender, EventArgs e)
        {
            userKhachHang kh = new userKhachHang();
            kh.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(kh);
            kh.BringToFront();
        }

        private void mnuThemNCC_Click(object sender, EventArgs e)
        {
            frmAdd_NCC frmThemNCC = new frmAdd_NCC();
            frmThemNCC.ShowDialog();
        }

        private void mnuThemKH_Click(object sender, EventArgs e)
        {
            frmAdd_KH frmThemKH = new frmAdd_KH();
            frmThemKH.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau(progress, toolStripLabel);
            doiMatKhau.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point location = lblGioiThieu.Location;
            if (location.X > this.Width)
            {
                location = new Point(20, location.Y);
            }
            lblGioiThieu.Location = new Point(location.X + 10, location.Y);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (picSilde4.Visible)
            {
                picSilde4.Visible = false;
                picSilde3.Visible = true;
                lblgt.ForeColor = Color.LightGreen;
            }
            else if (picSilde3.Visible)
            {
                picSilde3.Visible = false;
                picSilde2.Visible = true;
                lblgt.ForeColor = Color.GreenYellow;
            }
            else if (picSilde2.Visible)
            {
                picSilde2.Visible = false;
                picSlide1.Visible = true;
                lblgt.ForeColor = Color.Yellow;
            }
            else if (picSlide1.Visible)
            {
                picSlide1.Visible = false;
                picSilde4.Visible = true;
                lblgt.ForeColor = Color.LimeGreen;
            }
        }
        #endregion

        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (KryptonMessageBox.Show("Bạn có muốn THOÁT chương trình", "Thông báo", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            Application.Exit();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Bạn có muốn THOÁT chương trình", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            Application.Exit();
        }

        private void picANHNVDangNhap_Click(object sender, EventArgs e)
        {
            frmTK_NV tt = new frmTK_NV(true, this.nv);
            tt.ShowDialog();
        }

        #region Menu_Control_Left

        private void lblTrangChu_MouseHover(object sender, EventArgs e)
        {
            Hower_Control(lblTrangChu);
        }

        private void lblThongTinSach_MouseHover(object sender, EventArgs e)
        {
            Hower_Control(lblThongTinSach);
        }

        private void lblHDBan_MouseHover(object sender, EventArgs e)
        {
            Hower_Control(lblHDBan);
        }

        private void lblHDNhap_MouseHover(object sender, EventArgs e)
        {
            Hower_Control(lblHDNhap);
        }

        private void lblNhapSach_MouseHover(object sender, EventArgs e)
        {
            Hower_Control(lblNhapSach);
        }

        private void lblDoanhThu_MouseHover(object sender, EventArgs e)
        {
            Hower_Control(lblDoanhThu);
        }

        private void lblTrangChu_MouseLeave(object sender, EventArgs e)
        {
            Leave_Control(lblTrangChu);
        }

        private void lblThongTinSach_MouseLeave(object sender, EventArgs e)
        {
            Leave_Control(lblThongTinSach);
        }

        private void lblHDBan_MouseLeave(object sender, EventArgs e)
        {
            Leave_Control(lblHDBan);
        }

        private void lblHDNhap_MouseLeave(object sender, EventArgs e)
        {
            Leave_Control(lblHDNhap);
        }

        private void lblNhapSach_MouseLeave(object sender, EventArgs e)
        {
            Leave_Control(lblNhapSach);
        }

        private void lblDoanhThu_MouseLeave(object sender, EventArgs e)
        {
            Leave_Control(lblDoanhThu);
        }

        private void lblTrangChu_Click(object sender, EventArgs e)
        {
            controlTrangChu trangChu = new controlTrangChu(progress, toolStripLabel, nv, lblGioiThieu);
            trangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(trangChu);
            trangChu.BringToFront(); timer2.Stop();
        }

        private void lblThongTinSach_Click(object sender, EventArgs e)
        {
            controlThongTinSach us1 = new controlThongTinSach("abc", progress, toolStripLabel, this.nv.ID_ROEL);
            us1.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(us1);
            us1.BringToFront();
        }

        private void lblHDBan_Click(object sender, EventArgs e)
        {
            userHDBan hd = new userHDBan();
            hd.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(hd);
            hd.BringToFront();
        }

        private void lblHDNhap_Click(object sender, EventArgs e)
        {
            userHDNhapSach ns = new userHDNhapSach();
            ns.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(ns);
            ns.BringToFront();
        }

        private void lblNhapSach_Click(object sender, EventArgs e)
        {
            userNhapSach nhapSach = new userNhapSach(nv.MaNV, progress, toolStripLabel);
            nhapSach.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(nhapSach);
            nhapSach.BringToFront();
        }

        private void lblDoanhThu_Click(object sender, EventArgs e)
        {
            userBaoCao bc = new userBaoCao();
            bc.Dock = System.Windows.Forms.DockStyle.Fill;
            pnRight.Controls.Add(bc);
            bc.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Bạn có muốn Thoát phiên đăng nhập ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            this.Hide();
            frmDangNhap dn = new frmDangNhap();
            dn.Visible = true;
        }

        #endregion
    }
}
