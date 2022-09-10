using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DoAn.doi_tuong;
using DoAn.dao_xu_ly;
using DoAn.Validation;
using System.IO;
using ComponentFactory.Krypton.Toolkit;

namespace DoAn.gui
{
    public partial class frmCN_Sach : Form
    {
        ToolStripProgressBar progress;
        ToolStripLabel lbl;
        ThongTinSach sach;
        bool click = false;
        string file_path_PT = "";
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public frmCN_Sach()
        {
            InitializeComponent();
        }

        internal frmCN_Sach(ThongTinSach sach, ToolStripProgressBar progress, ToolStripLabel label, int id_role)
        {
            InitializeComponent();
            this.sach = sach;
            txtMaSach.Text = sach.MaSach;
            txtTenSach.Text = sach.TenSach;
            txtTacGia.Text = sach.TacGia;
            txtNXB.Text = sach.NhaXB;
            txtNamXB.Text = sach.NamXB + "";
            txtTheloai.Text = sach.TheLoai;
            txtGiaBan.Text = sach.GiaBan + "";
            txtTonKho.Text = sach.SoLuongTon + "";
            picAnhSach.Image = Image.FromFile(projectPath + sach.AnhSach);

            this.progress = progress;
            this.lbl = label;
            int r = id_role;
            if (r == 2)
            {
                txtGiaBan.ReadOnly = true;
            }
        }

        private void btnCapNhatThongTinSach_Click(object sender, EventArgs e)
        {
            if (!IsValid_Name(txtTenSach.Text))
            {
                KryptonMessageBox.Show("Hãy nhập tên sách là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                txtTenSach.SelectAll();
                return;
            }
            if (!IsValid_Name(txtTacGia.Text))
            {
                KryptonMessageBox.Show("Hãy nhập Tác giả là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTacGia.Focus();
                txtTacGia.SelectAll();
                return;
            }
            if (!IsValid_Name(txtNXB.Text))
            {
                KryptonMessageBox.Show("Hãy nhập Nhà xuất bản là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNXB.Focus();
                txtNXB.SelectAll();
                return;
            }
            if (!IsValid_Name(txtTheloai.Text))
            {
                KryptonMessageBox.Show("Hãy nhập Thể loại là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTheloai.Focus();
                txtTheloai.SelectAll();
                return;
            }
            if (!IsValid_NUMBER(txtGiaBan.Text))
            {
                KryptonMessageBox.Show("Hãy nhập Giá bán là SỐ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                txtGiaBan.SelectAll();
                return;
            }
            if (!IsValid_NUMBER(txtNamXB.Text))
            {
                KryptonMessageBox.Show("Hãy nhập Năm xuất bản là SỐ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamXB.Focus();
                txtNamXB.SelectAll();
                return;
            }
            if (txtGiaBan.Text.Equals("0"))
            {
                if (KryptonMessageBox.Show("Giá bán đang là 0 ! Bạn có muốn cập nhật giá bán ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtGiaBan.SelectAll();
                    txtGiaBan.Focus();
                    return;
                }
            }


            if (KryptonMessageBox.Show("Bạn có muốn cập nhật thông tin sách [ " + txtTenSach.Text + " ] không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            ThongTinSach up_sach = new ThongTinSach();
            up_sach.MaSach = txtMaSach.Text;
            up_sach.TenSach = txtTenSach.Text;
            up_sach.TacGia = txtTacGia.Text;
            up_sach.NhaXB = txtNXB.Text;
            up_sach.NamXB = int.Parse(txtNamXB.Text);
            up_sach.TheLoai = txtTheloai.Text;
            up_sach.GiaBan = int.Parse(txtGiaBan.Text);
            if (click)
            {
                if (!file_path_PT.Equals(""))
                {
                    string img_path = @"\img\" + file_path_PT;
                    up_sach.AnhSach = img_path;
                }
                else
                {
                    up_sach.AnhSach = sach.AnhSach;
                }
                
            }
            else
            {
                if (sach.AnhSach.Equals(@"\img\nocontentyet.jpg"))
                {
                    string img_path = @"\img\nocontentyet.jpg";
                    up_sach.AnhSach = img_path;
                }
                else
                {
                    up_sach.AnhSach = sach.AnhSach;
                }
            }


            if (Sach_DAO.update_sach(up_sach))
            {
                progress_sc();
                KryptonMessageBox.Show("Cập nhật thông tin sách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                progress_sc();
                KryptonMessageBox.Show("Sửa đổi thông tin sách KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
        }

        private bool IsValid_Name(string name)
        {
            if (!check_valid.IsValid_HoTen(name))
                return false;
            return true;
        }

        private bool IsValid_NUMBER(string number)
        {
            if (!check_valid.IsValid_Number(number))
                return false;
            return true;
        }

        private void picAnhSach_Click(object sender, EventArgs e)
        {
            click = true;
            openAnh.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openAnh.FilterIndex = 1;
            openAnh.RestoreDirectory = true;
            if (openAnh.ShowDialog() == DialogResult.OK)
            {
                file_path_PT = openAnh.SafeFileName;
                Image img = Image.FromFile(openAnh.FileName);
                picAnhSach.Image = img;
            }
        }

        private void progress_sc()
        {
            if (!(progress.Visible))
            {
                progress.Visible = true;
            }
            lbl.Text = "";
            for (int i = progress.Minimum; i <= progress.Maximum; i += 10)
            {
                progress.Value = i;
                Thread.Sleep(100);
            }
            progress.Value = 0;
            progress.Visible = false;
            lbl.Text = "Success";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
