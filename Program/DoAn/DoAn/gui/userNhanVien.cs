using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.gui;
using DoAn.doi_tuong;
using DoAn.dao_xu_ly;
using System.IO;
using ComponentFactory.Krypton.Toolkit;

namespace DoAn
{
    public partial class userNhanVien : UserControl
    {
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public userNhanVien()
        {
            InitializeComponent();
            load_data();
            this.ContextMenuStrip = mnuStripTTTT;
        }


        public void load_data()
        {
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanVien.AutoGenerateColumns = false;
            dataGridViewNhanVien.AllowUserToAddRows = false;

            dataGridViewNhanVien.DataSource = NhanVien_DAO.get_info_nhanvien();
            dataGridViewNhanVien.Columns[0].DataPropertyName = "maNV";
            dataGridViewNhanVien.Columns[1].DataPropertyName = "tenNV";
            dataGridViewNhanVien.Columns[2].DataPropertyName = "ngaySinh";
            dataGridViewNhanVien.Columns[3].DataPropertyName = "gioiTinh";
            dataGridViewNhanVien.Columns[4].DataPropertyName = "emailNV";
            dataGridViewNhanVien.Columns[5].DataPropertyName = "SoDT";
            dataGridViewNhanVien.Columns[6].DataPropertyName = "anhNV";
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmAdd_NV frmThemNV = new frmAdd_NV();
            frmThemNV.ShowDialog();
            load_data();
        }

        private void btnCapNhatThongTinNV_Click(object sender, EventArgs e)
        {
            int rsl = dataGridViewNhanVien.CurrentRow.Index;
            NhanVien nv = new NhanVien();
            nv.MaNV = dataGridViewNhanVien.Rows[rsl].Cells[0].Value.ToString();
            nv.TenNV = dataGridViewNhanVien.Rows[rsl].Cells[1].Value.ToString();
            nv.NgaySinh = dataGridViewNhanVien.Rows[rsl].Cells[2].Value.ToString();
            nv.GioiTinh = dataGridViewNhanVien.Rows[rsl].Cells[3].Value.ToString();
            nv.EmailNV = dataGridViewNhanVien.Rows[rsl].Cells[4].Value.ToString();
            nv.SdtNV = dataGridViewNhanVien.Rows[rsl].Cells[5].Value.ToString();
            nv.AnhNV = dataGridViewNhanVien.Rows[rsl].Cells[6].Value.ToString();

            //Truyền nhân viên vào frame Để cập nhật thông tin nhân viên
            frmAdd_NV frmThemNV = new frmAdd_NV(nv, true);
            frmThemNV.ShowDialog();
            load_data();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int rsl = dataGridViewNhanVien.CurrentRow.Index;
            string tennv = dataGridViewNhanVien.Rows[rsl].Cells[1].Value.ToString();
            if (KryptonMessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên [" + tennv + "] không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            string manv = dataGridViewNhanVien.Rows[rsl].Cells[0].Value.ToString();
            //Xóa nhân viên trong database
            if (NhanVien_DAO.delete_nv(manv))
            {
                KryptonMessageBox.Show("Xóa nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                KryptonMessageBox.Show("Xóa nhân viên KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load_data();
            }
        }

        private void mnuStripTTTT_Click(object sender, EventArgs e)
        {
            frmTK_NV tt = new frmTK_NV(false, null);
            tt.Show();
        }

        private void dataGridViewNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridViewNhanVien.CurrentRow.Index;
            NhanVien nv = new NhanVien();
            nv.MaNV = dataGridViewNhanVien.Rows[rsl].Cells[0].Value.ToString();
            nv.TenNV = dataGridViewNhanVien.Rows[rsl].Cells[1].Value.ToString();
            nv.NgaySinh = dataGridViewNhanVien.Rows[rsl].Cells[2].Value.ToString();
            nv.GioiTinh = dataGridViewNhanVien.Rows[rsl].Cells[3].Value.ToString();
            nv.EmailNV = dataGridViewNhanVien.Rows[rsl].Cells[4].Value.ToString();
            nv.SdtNV = dataGridViewNhanVien.Rows[rsl].Cells[5].Value.ToString();
            nv.AnhNV = dataGridViewNhanVien.Rows[rsl].Cells[6].Value.ToString();

            //Truyền nhân viên vào frame Để cập nhật thông tin nhân viên
            frmAdd_NV frmThemNV = new frmAdd_NV(nv, false);
            frmThemNV.ShowDialog();
        }
    }
}
