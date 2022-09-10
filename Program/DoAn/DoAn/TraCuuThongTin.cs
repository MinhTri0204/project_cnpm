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
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;

namespace DoAn
{
    public partial class TraCuuThongTin : Form
    {
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        NhanVien nv = new NhanVien();
        public TraCuuThongTin()
        {
            InitializeComponent();
        }

        internal TraCuuThongTin(bool check, NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            
            if (check)
            {
                pnThongTin.Visible = false;
                pnTrangThai.Visible = true;
                lblTrangThai.Text = "THÔNG TIN NHÂN VIÊN";
                this.Text = "THÔNG TIN NHÂN VIÊN";
                txtMaNV.Text = this.nv.MaNV;
                txtTenNV.Text = this.nv.TenNV;
                txtNgaySinh.Value = DateTime.Parse(this.nv.NgaySinh);
                txtSdtNV.Text = this.nv.SdtNV;
                txtEmailNV.Text = this.nv.EmailNV;
                txtGTinh.Text = this.nv.GioiTinh;
                picAnh.Image = Image.FromFile(projectPath + this.nv.AnhNV);
            }
            else
            {
                pnThongTin.Visible = true;
                pnTrangThai.Visible = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv = NhanVien_DAO.tra_cuu_nhanvien(txtDK.Text);
            if (nv != null)
            {
                txtMaNV.Text = nv.MaNV;
                txtTenNV.Text = nv.TenNV;
                string d = nv.NgaySinh;
                txtNgaySinh.Value = DateTime.Parse(nv.NgaySinh);
                txtSdtNV.Text = nv.SdtNV;
                txtEmailNV.Text = nv.EmailNV;
                txtGTinh.Text = nv.GioiTinh;
                //Ảnh 
                picAnh.Image = Image.FromFile(projectPath + nv.AnhNV);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDK.Focus();txtDK.SelectAll();
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                txtNgaySinh.Text = "";
                txtSdtNV.Text = "";
                txtEmailNV.Text = "";
                txtGTinh.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TraCuuThongTin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }
    }
}
