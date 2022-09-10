using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;
using DoAn.Validation;

namespace DoAn.gui
{
    public partial class frmAdd_NV : MetroFramework.Forms.MetroForm
    {
        NhanVien nhanVien;
        bool check;
        Random rd = new Random();
        string file_path_PT = "";
        bool click = false;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public frmAdd_NV()
        {
            InitializeComponent();
        }

        internal frmAdd_NV(NhanVien nv, bool check)
        {
            InitializeComponent();
            this.nhanVien = nv;
            this.check = check;
            
            if (check)
            {
                this.Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN";
                txtTenNV.Text = nhanVien.TenNV;
                txtNgaySinh.Value = DateTime.Parse(nhanVien.NgaySinh);
                if (nhanVien.GioiTinh.Equals("Nam"))
                    radNam.Checked = true;
                else radNu.Checked = true;
                txtEmailNV.Text = nhanVien.EmailNV;
                txtSdtNV.Text = nhanVien.SdtNV;
                picAnhNV.Image = Image.FromFile(projectPath + this.nhanVien.AnhNV);
            }
            else
            {
                this.Text = "THÔNG TIN NHÂN VIÊN";
                this.btnXN.Visible = false;
                this.btnThoat.Visible = false;
                txtTenNV.Text = nhanVien.TenNV;
                txtNgaySinh.Value = DateTime.Parse(nhanVien.NgaySinh);
                if (nhanVien.GioiTinh.Equals("Nam"))
                    radNam.Checked = true;
                else radNu.Checked = true;
                txtEmailNV.Text = nhanVien.EmailNV;
                txtSdtNV.Text = nhanVien.SdtNV;
                picAnhNV.Image = Image.FromFile(projectPath + this.nhanVien.AnhNV);
            }
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (!check) // Thêm nhân viên mới
            {
                insert_nv();
            }
            else // Cập nhật thông tin nhân viên
            {
                update_nv();
            }
        }

        private void update_nv()
        {
            if (!IsValid_Name(txtTenNV.Text))
            {
                KryptonMessageBox.Show("Hãy nhập TÊN nhân viên không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                txtTenNV.SelectAll();
                return;
            }
            if (!IsValid_NUMBER_PHONE(txtSdtNV.Text))
            {
                KryptonMessageBox.Show("Số điện thoại không chính xác - Hãy nhập định dạng số điện thoại Việt Nam !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdtNV.Focus();
                txtSdtNV.SelectAll();
                return;
            }
            if (!IsValid_EMAIL(txtEmailNV.Text))
            {
                KryptonMessageBox.Show("Sai định dạng Email. *Example@gmail.com !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailNV.Focus();
                txtEmailNV.SelectAll();
                return;
            }
            if (KryptonMessageBox.Show("Bạn có muốn Cập nhật thông nhân viên [" + txtTenNV.Text + "] không ?", "Thông báo",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            NhanVien nv = new NhanVien();
            nv.MaNV = this.nhanVien.MaNV;
            nv.TenNV = txtTenNV.Text; ;
            nv.NgaySinh = txtNgaySinh.Text;
            if (radNam.Checked)
                nv.GioiTinh = "Nam";
            else nv.GioiTinh = "Nữ";
            nv.EmailNV = txtEmailNV.Text;
            nv.SdtNV = txtSdtNV.Text;

            //Kiểm tra nếu hình được chọn thì lưu hình ảnh
            //Ngược lại thì thêm ảnh mặc định
            if (click)
            {
                if (!file_path_PT.Equals("")) //Nếu có sự lựa chọn ảnh và được chọn ảnh
                {
                    string img_path = @"\img\" + file_path_PT;
                    nv.AnhNV = img_path;
                }
                else
                {
                    nv.AnhNV = nhanVien.AnhNV;
                }
            }
            else
            {
                if (nhanVien.AnhNV.Equals(@"\img\nv1_1.jpg"))
                {
                    string img_path = @"\img\nv1_1.jpg";
                    nv.AnhNV = img_path;
                }
                else
                {
                    nv.AnhNV = nhanVien.AnhNV;
                }
            }

            if (NhanVien_DAO.update_nv(nv))
            {
                KryptonMessageBox.Show("Cập nhật thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                KryptonMessageBox.Show("Cập nhật thông tin nhân viên KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
        }

        private string chuyen_khong_dau(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private void insert_nv()
        {
            if (!IsValid_Name(txtTenNV.Text))
            {
                KryptonMessageBox.Show("Hãy nhập TÊN nhân viên không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                txtTenNV.SelectAll();
                return;
            }
            if (!IsValid_NUMBER_PHONE(txtSdtNV.Text))
            {
                KryptonMessageBox.Show("Số điện thoại không chính xác - Hãy nhập định dạng số điện thoại Việt Nam !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdtNV.Focus();
                txtSdtNV.SelectAll();
                return;
            }
            if (!IsValid_EMAIL(txtEmailNV.Text))
            {
                KryptonMessageBox.Show("Sai định dạng Email. *Example@gmail.com !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailNV.Focus();
                txtEmailNV.SelectAll();
                return;
            }
            if (KryptonMessageBox.Show("Bạn có muốn thêm nhân viên [" + txtTenNV.Text + "] không ?", "Thông báo",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            //Tạo tài khoản mật khẩu giống tên của nhân viên
            string tk, mk;
            string[] ten = txtTenNV.Text.Split(' ');
            if (ten.Length == 1)
                tk = mk = chuyen_khong_dau(ten[0]);
            else
                tk = mk = chuyen_khong_dau((ten[(ten.Length - 1) - 1] + ten[ten.Length - 1]).ToLower());

            //Tạo mã số nhân viên tự động
            int maso = rd.Next(100, 999);

            NhanVien nv = new NhanVien();
            nv.MaNV = "NV" + maso;
            nv.TaiKhoan = tk;
            nv.MatKhau = mk;
            nv.TenNV = txtTenNV.Text; ;
            nv.NgaySinh = txtNgaySinh.Text;
            if (radNam.Checked)
                nv.GioiTinh = "Nam";
            else nv.GioiTinh = "Nữ";
            nv.EmailNV = txtEmailNV.Text;
            nv.SdtNV = txtSdtNV.Text;

            //Kiểm tra nếu hình được chọn thì lưu hình
            //Ngược lại thì lưu hình mặc định
            if (click)
            {
                if (!file_path_PT.Equals("")) //Nếu có sự lựa chọn ảnh và được chọn ảnh
                {
                    string img_path = @"\img\" + file_path_PT;
                    nv.AnhNV = img_path;
                }
                else
                {
                    nv.AnhNV = @"\img\nv1_1.jpg";
                }
            }
            else
            {
                string img_path = "/img/nv1_1.jpg";
                nv.AnhNV = img_path;
            }


            if (NhanVien_DAO.insert_nv(nv))
            {
                KryptonMessageBox.Show("Thêm nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                KryptonMessageBox.Show("Thêm nhân viên KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAnhNV_Click(object sender, EventArgs e)
        {
            click = true;
            openFile_Picture.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile_Picture.FilterIndex = 1;
            openFile_Picture.RestoreDirectory = true;
            if (openFile_Picture.ShowDialog() == DialogResult.OK)
            {
                file_path_PT = openFile_Picture.SafeFileName;
                Image img = Image.FromFile(openFile_Picture.FileName);
                picAnhNV.Image = img;
            }
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
    }
}
