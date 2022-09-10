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
    public partial class userBaoCao : UserControl
    {
        public userBaoCao()
        {
            InitializeComponent();
            cboThang.Visible = false;
            cboQuy.Visible = false;
            dataGridView_BC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_BC.AutoGenerateColumns = false;
            dataGridView_BC.AllowUserToAddRows = false;
        }

        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtNgay.Visible = true;
            cboThang.Visible = false;
            cboQuy.Visible = false;
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            dtNgay.Visible = false;
            cboThang.Visible = true;
            cboThang.SelectedIndex = 0;
            cboQuy.Visible = false;
        }

        private void radQuy_CheckedChanged(object sender, EventArgs e)
        {
            dtNgay.Visible = false;
            cboThang.Visible = false;
            cboQuy.Visible = true;
            cboQuy.SelectedIndex = 0;
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            if (radQuy.Checked)
            {
                if (cboQuy.SelectedItem.ToString().Equals("Quý 1"))
                {

                    new Gui_BaoCao.Form_BaoCao("QUI1", BaoCao_DAO.get_DB_Quy_1()).Show();
                }
                else
                {
                    new Gui_BaoCao.Form_BaoCao("QUI2", BaoCao_DAO.get_DB_Quy_2()).Show();
                }
            }
            else
                if(radNgay.Checked)
                {
                    DateTime d = dtNgay.Value.Date;
                    new Gui_BaoCao.Form_BaoCao("NGAY", BaoCao_DAO.get_DB_Ngay(d)).Show();
                }
                else
                    if(radThang.Checked)
                    {
                        int thang = int.Parse(cboThang.SelectedItem.ToString());
                        new Gui_BaoCao.Form_BaoCao("NGAY", BaoCao_DAO.get_DB_Thang(thang)).Show();
                    }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked)
            {
                DateTime d = dtNgay.Value.Date;
                dataGridView_BC.DataSource = BaoCao_DAO.get_DB_Ngay(d);
                if (dataGridView_BC.Rows.Count > 0)
                {
                    show_BC();
                    tinh_tong(dataGridView_BC.Rows.Count);
                }
                else 
                {
                    KryptonMessageBox.Show("Không có hóa đơn nào được lập trong trong ngày [" + string.Format("{0:dd/MM/yyyy}", d) + "] !",
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblTongDoanhThu.Text = "";
                }
            }
            else if (radThang.Checked)
            {
                int thang = int.Parse(cboThang.SelectedItem.ToString());
                dataGridView_BC.DataSource = BaoCao_DAO.get_DB_Thang(thang);
                if (dataGridView_BC.Rows.Count > 0)
                {
                    show_BC();
                    tinh_tong(dataGridView_BC.Rows.Count);
                }
                else
                {
                    KryptonMessageBox.Show("Không có hóa đơn nào được lập trong trong Tháng [" + thang + "] !",
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblTongDoanhThu.Text = "";
                }

            }
            else if (radQuy.Checked)
            {
                if (cboQuy.SelectedItem.ToString().Equals("Quý 1"))
                {
                    dataGridView_BC.DataSource = BaoCao_DAO.get_DB_Quy_1();
                    if (dataGridView_BC.Rows.Count > 0)
                    {
                        show_BC();
                        tinh_tong(dataGridView_BC.Rows.Count);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Không có hóa đơn nào được lập trong trong Quý 1 !",
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblTongDoanhThu.Text = "";
                    }
                }
                else
                {
                    dataGridView_BC.DataSource = BaoCao_DAO.get_DB_Quy_2();
                    if (dataGridView_BC.Rows.Count > 0)
                    {
                        show_BC();
                        tinh_tong(dataGridView_BC.Rows.Count);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Không có hóa đơn nào được lập trong trong Quý 2 !",
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblTongDoanhThu.Text = "";
                    }
                }
            }
            else
            {
                KryptonMessageBox.Show("Hãy chọn điều kiện để báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tinh_tong(int sodong)
        {
            int tong = 0;
            for (int i = 0; i < sodong; i++)
            {
                tong += int.Parse(dataGridView_BC.Rows[i].Cells[5].Value.ToString());
            }
            lblTongDoanhThu.Text = string.Format("{0:0,0}", tong);
        }

        private void show_BC()
        {
            dataGridView_BC.Columns[0].DataPropertyName = "tenSach";
            dataGridView_BC.Columns[1].DataPropertyName = "tenNCC";
            dataGridView_BC.Columns[2].DataPropertyName = "tongSLBan";
            dataGridView_BC.Columns[3].DataPropertyName = "trungBinhGiaBan";
            dataGridView_BC.Columns[4].DataPropertyName = "trungBinhGiaNhap";
            dataGridView_BC.Columns[5].DataPropertyName = "doanhThu";
        }
    }
}
