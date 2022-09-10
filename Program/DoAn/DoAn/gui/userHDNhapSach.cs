using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;

namespace DoAn.gui
{
    public partial class userHDNhapSach : UserControl
    {
        DataTable dtHDNhap, dtHDNhapCoppy, dtTK_DN_NCC_NV, dtTK_DN_NCC_NV_Coppy;
        DataTable dt_CT_HDNhap, dt_CT_HDNhap_Coppy;
        public userHDNhapSach()
        {
            InitializeComponent();
            txtTK.Enabled = false;
            dtNgayLapDon.Enabled = false;
            load_data();

            dtHDNhap = HDNhap_DAO.get_info_hdNhap();
            dtHDNhapCoppy = dtHDNhap.Copy();

            dtTK_DN_NCC_NV = HDNhap_DAO.search_manv_mancc();
            dtTK_DN_NCC_NV_Coppy = HDNhap_DAO.get_info_hdNhap().Copy();

            dt_CT_HDNhap = HDNhap_DAO.Get_All_CT_HDNhap();
            dt_CT_HDNhap_Coppy = dt_CT_HDNhap.Copy();
        }

        private void load_data()
        {
            dataGridView_HDNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_HDNhap.AutoGenerateColumns = false;
            dataGridView_HDNhap.AllowUserToAddRows = false;

            dataGridView_HDNhap.DataSource = HDNhap_DAO.get_info_hdNhap();
            dataGridView_HDNhap.Columns[0].DataPropertyName = "maDonNhap";
            dataGridView_HDNhap.Columns[1].DataPropertyName = "tenNV";
            dataGridView_HDNhap.Columns[2].DataPropertyName = "tenNCC";
            dataGridView_HDNhap.Columns[3].DataPropertyName = "ngayNhap";
            dataGridView_HDNhap.Columns[4].DataPropertyName = "soLuong";
            dataGridView_HDNhap.Columns[5].DataPropertyName = "tongTienHD";
        }

        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {
            load_data();
            txtTK.Enabled = false;
            dtNgayLapDon.Enabled = true;
        }

        private void radMa_Nhap_CheckedChanged(object sender, EventArgs e)
        {
            load_data();
            txtTK.Enabled = true;
            txtTK.SelectAll(); txtTK.Focus();
            dtNgayLapDon.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked)
            {
                tim_hd_nhap("Ngay", false);
                if (dataGridView_HDNhap.Rows.Count <= 0)
                {
                    KryptonMessageBox.Show("Không có hóa đơn nào được lập trong ngày [" + string.Format("{0:dd/MM/yyyy}", dtNgayLapDon.Value) + "] !", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load_data();
                    return;
                }

            }
            else if (radMa_Nhap.Checked)
            {
                tim_hd_nhap("Ma", false);
                if (dataGridView_HDNhap.Rows.Count <= 0)
                {
                    KryptonMessageBox.Show("Không có hóa đơn nào được lập bởi [" + txtTK.Text + "] !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load_data();
                    return;
                }

            }
        }

        private void tim_hd_nhap(string dk, bool check) // true là sắp xếp , false là tìm kiếm
        {
            if (dk.Equals("Ngay"))
            {
                dtHDNhapCoppy.Rows.Clear();
                foreach (DataRow r in dtHDNhap.Rows)
                {
                    string ngay = string.Format("{0:dd/MMM/yy}", r[3].ToString().Trim());
                    string ngay_tim = string.Format("{0:dd/MMM/yy}", dtNgayLapDon.Value);
                    if (ngay.Contains(ngay_tim))
                    {
                        DataRow new_r = dtHDNhapCoppy.NewRow();
                        new_r[0] = r[0];
                        new_r[1] = r[1];
                        new_r[2] = r[2];
                        new_r[3] = r[3];
                        new_r[4] = r[4];
                        new_r[5] = r[5];

                        dtHDNhapCoppy.Rows.Add(new_r);
                    }
                }
                dataGridView_HDNhap.DataSource = dtHDNhapCoppy;
            }
            else
            {
                dtTK_DN_NCC_NV_Coppy.Rows.Clear();
                foreach (DataRow r in dtTK_DN_NCC_NV.Rows)
                {
                    string dk1 = r[6].ToString().Trim().ToUpper();
                    string dk2 = r[7].ToString().Trim().ToUpper();
                    string dk3 = r[2].ToString().Trim().ToUpper();
                    string dk4 = r[1].ToString().Trim().ToUpper();
                    string dk5 = r[8].ToString().Trim().ToUpper();
                    string dk6 = r[9].ToString().Trim().ToUpper();

                    if (dk1.Contains(txtTK.Text.Trim().ToUpper()) || dk2.Contains(txtTK.Text.Trim().ToUpper())
                        || dk3.Contains(txtTK.Text.Trim().ToUpper()) || dk4.Contains(txtTK.Text.Trim().ToUpper())
                        || dk5.Contains(txtTK.Text.Trim().ToUpper()) || dk6.Contains(txtTK.Text.Trim().ToUpper()))
                    {
                        DataRow new_r = dtTK_DN_NCC_NV_Coppy.NewRow();
                        new_r[0] = r[0];
                        new_r[1] = r[1];
                        new_r[2] = r[2];
                        new_r[3] = r[3];
                        new_r[4] = r[4];
                        new_r[5] = r[5];

                        dtTK_DN_NCC_NV_Coppy.Rows.Add(new_r);
                    }
                }
                dataGridView_HDNhap.DataSource = dtTK_DN_NCC_NV_Coppy;
            }
        }

        private void dataGridView_HDNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridView_HDNhap.CurrentRow.Index;
            string ma_hd = dataGridView_HDNhap.Rows[rsl].Cells[0].Value.ToString();
            dt_CT_HDNhap_Coppy.Rows.Clear();
            foreach (DataRow row in dt_CT_HDNhap.Rows)
            {
                if (ma_hd.ToUpper().Trim().Equals(row[0].ToString().ToUpper().Trim()))
                {
                    DataRow new_r = dt_CT_HDNhap_Coppy.NewRow();
                    new_r[0] = row[0];
                    new_r[1] = row[1];
                    new_r[2] = row[2];
                    new_r[3] = row[3];
                    new_r[4] = row[4];

                    dt_CT_HDNhap_Coppy.Rows.Add(new_r);
                }
            }
            CT_HoaDon ct = new CT_HoaDon(dt_CT_HDNhap_Coppy, false);
            ct.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
