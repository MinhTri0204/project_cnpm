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
using DoAn.gui;

namespace DoAn
{
    public partial class userHDBan : UserControl
    {
        DataTable dtHDBan, dtHDBanCoppy, dtTK_DB_NV_KH, dtTK_DB_NV_KH_Coppy; // dt.. để lấy dữ liệu đọc được từ database - dt..Coppy sao chép bảng dt...
        DataTable dt_CT_HDBan, dt_CT_HDBan_Coppy;
        public userHDBan()
        {
            InitializeComponent();
            txtTKKH_NV.Enabled = false;
            dataNgayLapDon.Enabled = false;
            load_data();

            dtHDBan = HDBan_DAO.get_info_hdBan();
            dtHDBanCoppy = dtHDBan.Copy();

            dtTK_DB_NV_KH = HDBan_DAO.search_manv_makh();               //Tạo bảng chứa dữ liệu tìm kiếm
            dtTK_DB_NV_KH_Coppy = HDBan_DAO.get_info_hdBan().Copy();    //Tạo bảng có cấu trúc giống dataGridView gồm các cột ....

            dt_CT_HDBan = HDBan_DAO.Get_All_CT_HDBan();
            dt_CT_HDBan_Coppy = dt_CT_HDBan.Copy();

        }

        private void load_data()
        {
            dataGridView_HDban.AutoGenerateColumns = false;
            dataGridView_HDban.AllowUserToAddRows = false;

            dataGridView_HDban.DataSource = HDBan_DAO.get_info_hdBan();
            dataGridView_HDban.Columns[0].DataPropertyName = "maDonBan";
            dataGridView_HDban.Columns[1].DataPropertyName = "tenNV";
            dataGridView_HDban.Columns[2].DataPropertyName = "tenKH";
            dataGridView_HDban.Columns[3].DataPropertyName = "ngayBan";
            dataGridView_HDban.Columns[4].DataPropertyName = "soLuong";
            dataGridView_HDban.Columns[5].DataPropertyName = "tongTien";
        }

        private void radMaKH_CheckedChanged(object sender, EventArgs e)
        {
            load_data();
            txtTKKH_NV.Enabled = true;
            txtTKKH_NV.Focus(); txtTKKH_NV.SelectAll();
            dataNgayLapDon.Enabled = false;
        }

        private void radNgayLapDon_CheckedChanged(object sender, EventArgs e)
        {
            load_data();
            txtTKKH_NV.Enabled = false;
            dataNgayLapDon.Enabled = true;
        }

        private void tim_hd_ban(string dk, bool check) // true là sắp xếp , false là tìm kiếm
        {
            if (dk.Equals("Ngay"))
            {
                dtHDBanCoppy.Rows.Clear();
                foreach (DataRow r in dtHDBan.Rows)
                {
                    string ngay_in_datatable = string.Format("{0:dd/MMM/yy}", r[3].ToString().Trim());
                    string ngay_tim = string.Format("{0:dd/MMM/yy}", dataNgayLapDon.Value);
                    if (ngay_in_datatable.Contains(ngay_tim))
                    {
                        DataRow new_r = dtHDBanCoppy.NewRow();
                        new_r[0] = r[0];
                        new_r[1] = r[1];
                        new_r[2] = r[2];
                        new_r[3] = r[3];
                        new_r[4] = r[4];
                        new_r[5] = r[5];

                        dtHDBanCoppy.Rows.Add(new_r);
                    }
                }
                dataGridView_HDban.DataSource = dtHDBanCoppy;
            }
            else
            {
                dtTK_DB_NV_KH_Coppy.Rows.Clear();
                foreach (DataRow r in dtTK_DB_NV_KH.Rows)
                {
                    string dk1 = r[6].ToString().Trim().ToUpper(); // Lấy mã nv
                    string dk2 = r[7].ToString().Trim().ToUpper(); // Lấy mã kh
                    string dk3 = r[2].ToString().Trim().ToUpper(); // Lấy tên nv
                    string dk4 = r[1].ToString().Trim().ToUpper(); // Lấy tên khách hàng
                    string dk5 = r[8].ToString().Trim().ToUpper(); // Lấy sdt nv
                    string dk6 = r[9].ToString().Trim().ToUpper(); // Lấy sdt kh

                    if (dk1.Contains(txtTKKH_NV.Text.Trim().ToUpper()) || dk2.Contains(txtTKKH_NV.Text.Trim().ToUpper())
                        || dk3.Contains(txtTKKH_NV.Text.Trim().ToUpper()) || dk4.Contains(txtTKKH_NV.Text.Trim().ToUpper())
                        || dk5.Contains(txtTKKH_NV.Text.Trim().ToUpper()) || dk6.Contains(txtTKKH_NV.Text.Trim().ToUpper()))
                    {
                        DataRow new_r = dtTK_DB_NV_KH_Coppy.NewRow();
                        new_r[0] = r[0];
                        new_r[1] = r[1];
                        new_r[2] = r[2];
                        new_r[3] = r[3];
                        new_r[4] = r[4];
                        new_r[5] = r[5];

                        dtTK_DB_NV_KH_Coppy.Rows.Add(new_r);
                    }
                }
                dataGridView_HDban.DataSource = dtTK_DB_NV_KH_Coppy;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radNgayBan.Checked)
            {
                tim_hd_ban("Ngay", false);
                if (dataGridView_HDban.Rows.Count <= 0)
                {
                    KryptonMessageBox.Show("Không có hóa đơn nào được lập trong ngày [" + string.Format("{0:dd/MM/yyyy}", dataNgayLapDon.Value) + "] !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load_data();
                    return;
                }
            }
            else if (radMa_Ban.Checked)
            {
                tim_hd_ban("Ma", false);
                if (dataGridView_HDban.Rows.Count <= 0)
                {
                    KryptonMessageBox.Show("Không có hóa đơn nào được lập bởi [" + txtTKKH_NV.Text + "] !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load_data();
                    return;
                }
            }
        }

        private void dataGridView_HDban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridView_HDban.CurrentRow.Index;
            string ma_hd = dataGridView_HDban.Rows[rsl].Cells[0].Value.ToString();
            dt_CT_HDBan_Coppy.Rows.Clear();
            foreach (DataRow row in dt_CT_HDBan.Rows)
            {
                if (ma_hd.ToUpper().Trim().Equals(row[0].ToString().ToUpper().Trim()))
                {
                    DataRow new_r = dt_CT_HDBan_Coppy.NewRow();
                    new_r[0] = row[0];
                    new_r[1] = row[1];
                    new_r[2] = row[2];
                    new_r[3] = row[3];
                    new_r[4] = row[4];

                    dt_CT_HDBan_Coppy.Rows.Add(new_r);
                }
            }
            CT_HoaDon ct = new CT_HoaDon(dt_CT_HDBan_Coppy, true);
            ct.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}