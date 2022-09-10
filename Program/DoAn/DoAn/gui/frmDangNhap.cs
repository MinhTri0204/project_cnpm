using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;

namespace DoAn.gui
{
    public partial class frmDangNhap : Form
    {
        public static string UserName = "";
        NhanVien nv = new NhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
            pnDN.BackColor = Color.FromArgb(100, 0, 0, 0);
            label3.BackColor = Color.Transparent;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (NhanVien_DAO.check_dn(txtTaiKhoan.Text, txtMatKhau.Text))
            {
               
                nv = NhanVien_DAO.get_nhanvien(txtTaiKhoan.Text, txtMatKhau.Text);
                UserName = nv.TenNV;
                MainFrame mainFrame = new MainFrame(nv);
                this.Hide();
                mainFrame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu sai ! Vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }
    }
}
