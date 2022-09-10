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
    public partial class userNhaCungCap : UserControl
    {
        public userNhaCungCap()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            dataGridView_NCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_NCC.AutoGenerateColumns = false;
            dataGridView_NCC.AllowUserToAddRows = false;

            dataGridView_NCC.DataSource = NhaCungCap_DAO.get_info_nhacungcap();
            dataGridView_NCC.Columns[0].DataPropertyName = "maNCC";
            dataGridView_NCC.Columns[1].DataPropertyName = "tenNCC";
            dataGridView_NCC.Columns[2].DataPropertyName = "sdt";
            dataGridView_NCC.Columns[3].DataPropertyName = "email";
            dataGridView_NCC.Columns[4].DataPropertyName = "diaChi";
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmAdd_NCC ncc = new frmAdd_NCC();
            ncc.ShowDialog();
            load_data();
        }

        private void btnCapNhatThongTinNCC_Click(object sender, EventArgs e)
        {
            int rsl = dataGridView_NCC.CurrentRow.Index;
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = dataGridView_NCC.Rows[rsl].Cells[0].Value.ToString();
            ncc.TenNCC = dataGridView_NCC.Rows[rsl].Cells[1].Value.ToString();
            ncc.DiaChi = dataGridView_NCC.Rows[rsl].Cells[4].Value.ToString();
            ncc.EmailNCC = dataGridView_NCC.Rows[rsl].Cells[3].Value.ToString();
            ncc.SdtNCC = dataGridView_NCC.Rows[rsl].Cells[2].Value.ToString();
            frmAdd_NCC frm = new frmAdd_NCC(ncc, true);
            frm.ShowDialog();
            load_data();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            int rsl = dataGridView_NCC.CurrentRow.Index;
            string mancc = dataGridView_NCC.Rows[rsl].Cells[0].Value.ToString();
            string tenncc = dataGridView_NCC.Rows[rsl].Cells[1].Value.ToString();
            if (KryptonMessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp [" + tenncc + "] không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            if (NhaCungCap_DAO.delete_ncc(mancc))
            {
                KryptonMessageBox.Show("Xóa nhà cung cấp thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                KryptonMessageBox.Show("Xóa nhà cung cấp KHÔNG thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load_data();
            }
        }

        private void mnuStripTTNCC_Click(object sender, EventArgs e)
        {
            frmTim_Kiem_KH_NCC tt = new frmTim_Kiem_KH_NCC(false);
            tt.Show();
        }

        private void dataGridView_NCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridView_NCC.CurrentRow.Index;
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = dataGridView_NCC.Rows[rsl].Cells[0].Value.ToString();
            ncc.TenNCC = dataGridView_NCC.Rows[rsl].Cells[1].Value.ToString();
            ncc.DiaChi = dataGridView_NCC.Rows[rsl].Cells[2].Value.ToString();
            ncc.EmailNCC = dataGridView_NCC.Rows[rsl].Cells[3].Value.ToString();
            ncc.SdtNCC = dataGridView_NCC.Rows[rsl].Cells[4].Value.ToString();
            frmAdd_NCC frm = new frmAdd_NCC(ncc, false);
            frm.ShowDialog();
        }
    }
}
