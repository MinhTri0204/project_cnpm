using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.gui
{
    public partial class frmTim_Kiem_KH_NCC : MetroFramework.Forms.MetroForm
    {
        bool check = false;
        public frmTim_Kiem_KH_NCC()
        {
            InitializeComponent();
        }

        public frmTim_Kiem_KH_NCC(bool check)
        {
            InitializeComponent();
            this.check = check;
            if (check)
            {
                this.Text = "TRA CỨU THÔNG TIN KHÁCH HÀNG";
                txtTinhTrang.Visible = true;
                lblTinhTrang.Visible = true;
                lblThongTin.Text = "Nhập thông tin:";
                lblMa.Text = "Mã khách hàng:";
                lblTen.Text = "Tên khách hàng:";

            }
            else
            {
                this.Text = "TRA CỨU THÔNG TIN NHÀ CUNG CẤP";
                txtTinhTrang.Visible = false;
                lblTinhTrang.Visible = false;
                lblThongTin.Text = "Nhập thông tin:";
                lblMa.Text = "Mã nhà cung cấp:";
                lblTen.Text = "Tên nhà cung cấp:";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (check) // true --> Tìm khách hàng
            {
                KhachHang kh = new KhachHang();
                kh = KhachHang_DAO.get_KH(txtDK.Text);
                if (kh != null)
                {
                    txtMa.Text = kh.MaKH;
                    txtTen.Text = kh.TenKH;
                    txtSdt.Text = kh.SdtKH;
                    txtEmail.Text = kh.EmailKH;
                    txtDC.Text = kh.DiaChi;
                    txtTinhTrang.Text = kh.TinhTrang;
                }
                else
                {
                    KryptonMessageBox.Show("Không thấy dữ liệu cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDK.Focus(); txtDK.SelectAll();
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtSdt.Text = "";
                    txtEmail.Text = "";
                    txtDC.Text = "";
                    txtTinhTrang.Text = "";
                }
            }
            else // false --> Tìm nhà cung cấp
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc = NhaCungCap_DAO.get_ncc(txtDK.Text);
                if (ncc != null)
                {
                    txtMa.Text = ncc.MaNCC;
                    txtTen.Text = ncc.TenNCC;
                    txtDC.Text = ncc.DiaChi;
                    txtSdt.Text = ncc.SdtNCC;
                    txtEmail.Text = ncc.EmailNCC;
                }
                else
                {
                    KryptonMessageBox.Show("Không thấy dữ liệu cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDK.Focus(); txtDK.SelectAll();
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtSdt.Text = "";
                    txtEmail.Text = "";
                    txtDC.Text = "";
                }
            }
        }
    }
}
