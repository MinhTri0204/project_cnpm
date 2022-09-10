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
using ComponentFactory.Krypton.Toolkit;

namespace DoAn.gui
{
    public partial class userKhachHang : UserControl
    {
        public userKhachHang()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            dataGridView_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_KhachHang.AutoGenerateColumns = false;
            dataGridView_KhachHang.AllowUserToAddRows = false;

            dataGridView_KhachHang.DataSource = KhachHang_DAO.get_info_khachhang();
            dataGridView_KhachHang.Columns[0].DataPropertyName = "maKH";
            dataGridView_KhachHang.Columns[1].DataPropertyName = "tenKH";
            dataGridView_KhachHang.Columns[2].DataPropertyName = "sdt";
            dataGridView_KhachHang.Columns[3].DataPropertyName = "email";
            dataGridView_KhachHang.Columns[4].DataPropertyName = "diaChi";
            dataGridView_KhachHang.Columns[5].DataPropertyName = "tinhTrang";
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmAdd_KH themKH = new frmAdd_KH();
            themKH.ShowDialog();
            load_data();
        }

        private void btnCapNhatThongTinKhachHang_Click(object sender, EventArgs e)
        {
            int rsl = dataGridView_KhachHang.CurrentRow.Index;
            KhachHang kh = new KhachHang();
            kh.MaKH = dataGridView_KhachHang.Rows[rsl].Cells[0].Value.ToString();
            kh.TenKH = dataGridView_KhachHang.Rows[rsl].Cells[1].Value.ToString();
            kh.DiaChi = dataGridView_KhachHang.Rows[rsl].Cells[4].Value.ToString();
            kh.SdtKH = dataGridView_KhachHang.Rows[rsl].Cells[2].Value.ToString();
            kh.EmailKH = dataGridView_KhachHang.Rows[rsl].Cells[3].Value.ToString();
            kh.TinhTrang = dataGridView_KhachHang.Rows[rsl].Cells[5].Value.ToString();
            frmAdd_KH themKH = new frmAdd_KH(kh, true);
            themKH.ShowDialog();
            load_data();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            int rsl = dataGridView_KhachHang.CurrentRow.Index;
            string makh = dataGridView_KhachHang.Rows[rsl].Cells[0].Value.ToString();
            string tenkh = dataGridView_KhachHang.Rows[rsl].Cells[1].Value.ToString();
            if (KryptonMessageBox.Show("Bạn có chắc muốn xóa khách hàng [" + tenkh + "] không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            if (KhachHang_DAO.delete_kh(makh))
            {
                KryptonMessageBox.Show("Xóa khách hàng thành viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                KryptonMessageBox.Show("Xóa khách hàng thành viên KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load_data();
            }
        }

        private void mnuStripTT_Click(object sender, EventArgs e)
        {
            frmTim_Kiem_KH_NCC tt = new frmTim_Kiem_KH_NCC(true);
            tt.Show();
        }

        private void dataGridView_KhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridView_KhachHang.CurrentRow.Index;
            KhachHang kh = new KhachHang();
            kh.MaKH = dataGridView_KhachHang.Rows[rsl].Cells[0].Value.ToString();
            kh.TenKH = dataGridView_KhachHang.Rows[rsl].Cells[1].Value.ToString();
            kh.DiaChi = dataGridView_KhachHang.Rows[rsl].Cells[4].Value.ToString();
            kh.SdtKH = dataGridView_KhachHang.Rows[rsl].Cells[2].Value.ToString();
            kh.EmailKH = dataGridView_KhachHang.Rows[rsl].Cells[3].Value.ToString();
            kh.TinhTrang = dataGridView_KhachHang.Rows[rsl].Cells[5].Value.ToString();
            frmAdd_KH themKH = new frmAdd_KH(kh, false);
            themKH.ShowDialog();
        }
    }
}
