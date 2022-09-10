using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.doi_tuong;
using DoAn.dao_xu_ly;
using DoAn.Validation;
using ComponentFactory.Krypton.Toolkit;

namespace DoAn.gui
{
    public partial class frmAdd_NCC : MetroFramework.Forms.MetroForm
    {
        NhaCungCap ncc;
        bool check;
        public frmAdd_NCC()
        {
            InitializeComponent();
        }

        internal frmAdd_NCC(NhaCungCap nhaCungCap, bool check)
        {
            InitializeComponent();
            this.ncc = nhaCungCap;
            this.check = check;

            if (check)
            {
                txtTen.Text = ncc.TenNCC;
                txtsdt.Text = ncc.SdtNCC;
                txtdc.Text = ncc.DiaChi;
                txtEmail.Text = ncc.EmailNCC;

                this.Text = "CẬP NHẬT THÔNG TIN NHÀ CUNG CẤP";
            }
            else
            {
                txtTen.Text = ncc.TenNCC;
                txtsdt.Text = ncc.SdtNCC;
                txtdc.Text = ncc.DiaChi;
                txtEmail.Text = ncc.EmailNCC;

                this.Text = "THÔNG TIN NHÀ CUNG CẤP";
                btnThoat.Visible = false;
                btnXN.Visible = false;
            }
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (!IsValid_Name(txtTen.Text))
            {
                KryptonMessageBox.Show("Hãy nhập TÊN NHÀ CUNG CẤP không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                txtTen.SelectAll();
                return;
            }
            if (!IsValid_DC(txtdc.Text))
            {
                KryptonMessageBox.Show("Hãy nhập Địa chỉ không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                txtTen.SelectAll();
                return;
            }
            if (!IsValid_NUMBER_PHONE(txtsdt.Text))
            {
                KryptonMessageBox.Show("Số điện thoại không chính xác - Hãy nhập định dạng số điện thoại Việt Nam (09.., 086.., 089.., 088.., 01...) !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsdt.Focus();
                txtsdt.SelectAll();
                return;
            }
            if (!IsValid_EMAIL(txtEmail.Text))
            {
                KryptonMessageBox.Show("Sai định dạng Email. *Example@gmail.com !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }
            if (!check)
            {
                if (KryptonMessageBox.Show("Bạn có muốn thêm nhà cung cấp [" + txtTen.Text + "] không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                //Tạo mã nhà cung cấp tự động
                Random rd = new Random();
                int ms = rd.Next(1, 999);
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = "NCC" + ms;
                ncc.TenNCC = txtTen.Text;
                ncc.SdtNCC = txtsdt.Text;
                ncc.EmailNCC = txtEmail.Text;
                ncc.DiaChi = txtdc.Text;

                if (NhaCungCap_DAO.insert_ncc(ncc))
                {
                    KryptonMessageBox.Show("Thêm nhà cung cấp thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    KryptonMessageBox.Show("Thêm nhà cung cấp KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                }
            }
            else
            {
                if (KryptonMessageBox.Show("Bạn có muốn Cập nhật thông tin nhà cung cấp [" + txtTen.Text + "] không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = this.ncc.MaNCC;
                ncc.TenNCC = txtTen.Text;
                ncc.SdtNCC = txtsdt.Text;
                ncc.EmailNCC = txtEmail.Text;
                ncc.DiaChi = txtdc.Text;

                if (NhaCungCap_DAO.update_ncc(ncc))
                {
                    KryptonMessageBox.Show("Cập nhật thông tin nhà cung cấp thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    KryptonMessageBox.Show("Cập nhật thông tin nhà cung cấp KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Bạn có muốn đóng cửa sổ ?", "Thông báo",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            this.Close();
        }

        private bool IsValid_Name(string name)
        {
            if (!check_valid.IsValid_HoTen(name))
                return false;
            return true;
        }

        private bool IsValid_NUMBER_PHONE(string number)
        {
            if (!check_valid.IsNumberPhone_VN(number))
                return false;
            return true;
        }

        private bool IsValid_EMAIL(string email)
        {
            if (!check_valid.IsValidEmail(email))
                return false;
            return true;
        }

        private bool IsValid_DC(string dc)
        {
            if (!check_valid.IsValid_DC(dc))
                return false;
            return true;
        }
    }
}
