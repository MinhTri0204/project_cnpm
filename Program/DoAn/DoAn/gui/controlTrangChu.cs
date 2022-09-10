using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;


namespace DoAn.gui
{
    public partial class controlTrangChu : UserControl
    {
        ToolStripProgressBar progress;
        ToolStripLabel lbl;
        Label lblGioiThieu;
        NhanVien nv;
        string manv;
        DataTable dt_DS_Sach, dt_DS_Sach_Coppy, dtKhachHang, dtKhachhang_Coppy;
        int tong_soluong_mua = 0;
        int tong = 0;
        int sosp = 0;
        string[] sach_da_mua;
        string[] ds_mua_thongbao;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public controlTrangChu()
        {
            InitializeComponent();
            load_data();
        }

        internal controlTrangChu(ToolStripProgressBar progress, ToolStripLabel lbl, NhanVien nv, Label lblGioiThieu)
        {
            InitializeComponent();
            this.progress = progress;
            this.lbl = lbl;
            this.nv = nv;
            manv = nv.MaNV;
            load_data();
            dtKhachHang = KhachHang_DAO.get_info_khachhang();
            dtKhachhang_Coppy = dtKhachHang.Copy();
            sach_da_mua = new string[gridTrangChuSach.Rows.Count];
            this.lblGioiThieu = lblGioiThieu;
            dt_DS_Sach = Sach_DAO.get_info_sach_trangchu();
            dt_DS_Sach_Coppy = dt_DS_Sach.Copy();
            hint_cbo();
            id_table();
        }

        private void load_data()
        {
            gridTrangChuSach.AutoGenerateColumns = false;
            gridTrangChuSach.AllowUserToAddRows = false;

            gridTrangChuSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTrangChuSach.AutoGenerateColumns = false;
            gridTrangChuSach.AllowUserToAddRows = false;

            gridTrangChuSach.DataSource = Sach_DAO.get_info_sach_trangchu();

            id_table();
        }

        public void id_table()
        {
            for (int i = 0; i < gridTrangChuSach.Rows.Count; i++)
            {
                gridTrangChuSach.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void hint_cbo()
        {
            for (int i = 0; i < gridTrangChuSach.Rows.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    txtTimKiemSach.Items.Add(gridTrangChuSach.Rows[i].Cells[j].Value.ToString());
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {

            GioHang gioHang = new GioHang(dataGridDS_mua, manv, progress, lbl, lblGioiThieu);
            gioHang.ShowDialog();
            if (gioHang.Check_mua_hang)
            {
                dataGridDS_mua.Rows.Clear();
            }
        }

        private void gridTrangChuSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //Dòng được chọn
            int id = gridTrangChuSach.CurrentRow.Index;
            //Lấy thông tin sách hiển thị lên form CT
            ThongTinSach sach = new ThongTinSach();
            sach.MaSach = gridTrangChuSach.Rows[id].Cells[6].Value.ToString();
            sach.TenSach = gridTrangChuSach.Rows[id].Cells[0].Value.ToString();
            sach.TacGia = gridTrangChuSach.Rows[id].Cells[1].Value.ToString();
            sach.NhaXB = gridTrangChuSach.Rows[id].Cells[2].Value.ToString();
            sach.NamXB = int.Parse(gridTrangChuSach.Rows[id].Cells[3].Value.ToString());
            sach.TheLoai = gridTrangChuSach.Rows[id].Cells[4].Value.ToString();
            sach.GiaBan = int.Parse(gridTrangChuSach.Rows[id].Cells[5].Value.ToString());
            sach.AnhSach = gridTrangChuSach.Rows[id].Cells[7].Value.ToString();

            CT_Sach ct_sach = new CT_Sach(sach);
            ct_sach.ShowDialog();

            if (ct_sach.Check_mua)
            {
                //Kiểm tra sách có được mua hay chưa
                if (dataGridDS_mua.Rows.Count > 0)
                {
                    foreach (string item in sach_da_mua)
                    {
                        if (gridTrangChuSach.Rows[id].Cells[6].Value.ToString().Equals(item))
                        {
                            if (KryptonMessageBox.Show("Sách [" + gridTrangChuSach.Rows[id].Cells[0].Value.ToString() + "] đã được mua bạn có muốn CẬP NHẬT lại số lượng mua không ?", "Thông báo",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                                return;
                            for (int i = 0; i < dataGridDS_mua.Rows.Count; i++)// Thay đối số lượng mua
                            {
                                if (dataGridDS_mua.Rows[i].Cells[0].Value.ToString() == item)
                                {
                                    update_so_luong_ban(i);
                                    return;
                                }
                            }
                        }
                    }
                }
                frmXN_DieuKien soLuongMua = new frmXN_DieuKien(false);
                soLuongMua.ShowDialog();
                int sl_mua = soLuongMua.SoLuong;
                if (sl_mua == 0)
                    return;

                tong_soluong_mua += sl_mua;
                float giaban = float.Parse(gridTrangChuSach.Rows[id].Cells[5].Value.ToString()); // Lấy giá bán
                float thanhtien = sl_mua * giaban; //Tính thành tiên
                                                   //Tạo row trong dataGridView
                string[] r = new string[] { gridTrangChuSach.Rows[id].Cells[6].Value.ToString(), gridTrangChuSach.Rows[id].Cells[0].Value.ToString(),
                sl_mua.ToString(), giaban.ToString() , thanhtien.ToString()};
                //Add row
                dataGridDS_mua.Rows.Add(r);
                tong += (int)thanhtien;
                //txtTongtien.Text = string.Format("{0:0,0}", tong);
                sach_da_mua[sosp] = gridTrangChuSach.Rows[id].Cells[6].Value.ToString();
                sosp++;
            }
            else
            {    
                
            }
        }

        private void update_so_luong_ban(int item) //Truyền vào item nào cần update số lượng _ tổng tiền
        {
            frmXN_DieuKien up_sl = new frmXN_DieuKien(false);
            up_sl.ShowDialog();
            int sl_moi = up_sl.SoLuong; // Lấy số lượng mới

            // Lấy thành tiền cũ & số lượng cũ
            int sl_cu = int.Parse(dataGridDS_mua.Rows[item].Cells[2].Value.ToString());
            int thanh_tien_cu = int.Parse(dataGridDS_mua.Rows[item].Cells[4].Value.ToString());
            // Trừ thành tiền cũ khỏi tổng tiền & trừ số lượng cũ
            tong -= thanh_tien_cu;
            tong_soluong_mua -= sl_cu;

            //Lấy giá của sách đó
            int gia_sach = int.Parse(dataGridDS_mua.Rows[item].Cells[3].Value.ToString());
            // Tính lại thành tiền với số lượng mới
            int thanh_tien_moi = gia_sach * sl_moi;

            dataGridDS_mua.Rows[item].Cells[2].Value = sl_moi; // Hiển thị lại số lượng
            dataGridDS_mua.Rows[item].Cells[4].Value = thanh_tien_moi; // Hiển thị lại thành tiền 

            tong += thanh_tien_moi;
            tong_soluong_mua += sl_moi;

            //txtTongtien.Text = string.Format("{0:0,0}", tong);
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(this, "Bạn có chắc chắn muốn HỦY đơn hiện tại không ?", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            dataGridDS_mua.Rows.Clear();
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            if (!cbkGiaBan.Checked)
            {
                find_sach_hai_dk(true, 0, 0);
                if (gridTrangChuSach.Rows.Count <= 0)
                {
                    KryptonMessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                }
            }
            else //Theo 2 điều kiện
            {
                if (cboGiaBan.SelectedItem.Equals("< 10,000"))
                {
                    find_sach_hai_dk(false, 0, 10000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        KryptonMessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else if (cboGiaBan.SelectedItem.Equals("> 10,000"))
                {
                    find_sach_hai_dk(false, 10000, 50000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        KryptonMessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else if (cboGiaBan.SelectedItem.Equals("> 50,000"))
                {
                    find_sach_hai_dk(false, 50000, 100000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        KryptonMessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else if (cboGiaBan.SelectedItem.Equals("> 100,000"))
                {
                    find_sach_hai_dk(false, 100000, 200000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        KryptonMessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else
                {
                    gridTrangChuSach.DataSource = Sach_DAO.tim_kiem_sach_trang_chu_hai_dk(txtTimKiemSach.Text, 100000, 1000000);
                    find_sach_hai_dk(false, 200000, 1000000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        KryptonMessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
            }
        }

        private void find_sach_hai_dk(bool check, int min_gb, int max_gb)
        {
            if (check) // Tìm 1 điều kiện
            {
                dt_DS_Sach_Coppy.Rows.Clear();
                foreach (DataRow r in dt_DS_Sach.Rows)
                {
                    string dk1 = r[1].ToString().Trim().ToUpper();
                    string dk2 = r[2].ToString().Trim().ToUpper();
                    string dk3 = r[3].ToString().Trim().ToUpper();
                    string dk4 = r[4].ToString().Trim().ToUpper();
                    string dk5 = r[5].ToString().Trim().ToUpper();
                    string dk6 = r[6].ToString().Trim().ToUpper();
                    string dk_tk = txtTimKiemSach.Text.Trim().ToUpper();
                    if (dk1.Contains(dk_tk) || dk2.Contains(dk_tk) || dk3.Contains(dk_tk) || dk4.Contains(dk_tk) || dk5.Contains(dk_tk) || dk6.Contains(dk_tk))
                    {
                        DataRow new_r = dt_DS_Sach_Coppy.NewRow();
                        new_r[0] = r[0];
                        new_r[1] = r[1];
                        new_r[2] = r[2];
                        new_r[3] = r[3];
                        new_r[4] = r[4];
                        new_r[5] = r[5];
                        new_r[6] = r[6];

                        dt_DS_Sach_Coppy.Rows.Add(new_r);
                    }
                }
                gridTrangChuSach.DataSource = dt_DS_Sach_Coppy;
            }
            else
            {
                dt_DS_Sach_Coppy.Rows.Clear();
                foreach (DataRow r in dt_DS_Sach.Rows)
                {
                    string dk1 = r[1].ToString().Trim().ToUpper();
                    string dk2 = r[2].ToString().Trim().ToUpper();
                    string dk3 = r[3].ToString().Trim().ToUpper();
                    string dk4 = r[4].ToString().Trim().ToUpper();
                    string dk5 = r[5].ToString().Trim().ToUpper();
                    int dk6 = int.Parse(r[6].ToString().Trim().ToUpper());
                    string dk_tk = txtTimKiemSach.Text.Trim().ToUpper();
                    if ((dk1.Contains(dk_tk) && dk6 > min_gb && dk6 < max_gb) || (dk2.Contains(dk_tk) && dk6 > min_gb && dk6 < max_gb)
                        || (dk3.Contains(dk_tk) && dk6 > min_gb && dk6 < max_gb) || (dk4.Contains(dk_tk) && dk6 > min_gb && dk6 < max_gb)
                        || (dk5.Contains(dk_tk) && dk6 > min_gb && dk6 < max_gb))
                    {
                        DataRow new_r = dt_DS_Sach_Coppy.NewRow();
                        new_r[0] = r[0];
                        new_r[1] = r[1];
                        new_r[2] = r[2];
                        new_r[3] = r[3];
                        new_r[4] = r[4];
                        new_r[5] = r[5];
                        new_r[6] = r[6];

                        dt_DS_Sach_Coppy.Rows.Add(new_r);
                    }
                }
                gridTrangChuSach.DataSource = dt_DS_Sach_Coppy;
            }
        }
    }
}
