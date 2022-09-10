using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;

namespace DoAn.gui
{
    public partial class frmDoiMatKhau : Form
    {
        ToolStripProgressBar progressBar;
        ToolStripLabel labelStatus;


        public frmDoiMatKhau()
        {
            InitializeComponent();
            label3.BackColor = Color.Transparent;
            Button btnThoat = new Button();
            btnThoat.Click += BtnThoat_Click;
            //this.CancelButton = btnThoat;
            this.AcceptButton = btnDangNhap;
        }

        internal frmDoiMatKhau(ToolStripProgressBar progress, ToolStripLabel lbl)
        {
            InitializeComponent();
            label3.BackColor = Color.Transparent;
            Button btnThoat = new Button();
            btnThoat.Click += BtnThoat_Click;
            this.CancelButton = btnThoat;
            this.AcceptButton = btnDangNhap;
            this.progressBar = progress;
            this.labelStatus = lbl;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (NhanVien_DAO.check_dn(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                NhanVien nv = new NhanVien();
                nv = NhanVien_DAO.get_nhanvien(txtTaiKhoan.Text, txtMatKhau.Text);

                frmDMK dmk = new frmDMK(nv, progressBar, labelStatus);
                dmk.ShowDialog();
                this.Hide();
            }
            else
            {
                KryptonMessageBox.Show("Tài khoản mật khẩu sai ! Vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
            } 
        }

    }
}
