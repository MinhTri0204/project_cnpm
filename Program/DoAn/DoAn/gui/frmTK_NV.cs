using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;
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

namespace DoAn.gui
{
    public partial class frmTK_NV : MetroFramework.Forms.MetroForm
    {
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        NhanVien nv = new NhanVien();
        public frmTK_NV()
        {
            InitializeComponent();
        }

        internal frmTK_NV(bool check, NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;

            if (check)
            {
                pnThongTin.Visible = false;
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
                KryptonMessageBox.Show("Không tìm thấy dữ liệu phù hợp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDK.Focus(); txtDK.SelectAll();
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                txtNgaySinh.Text = "";
                txtSdtNV.Text = "";
                txtEmailNV.Text = "";
                txtGTinh.Text = "";
            }
        }
    }
}
