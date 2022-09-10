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
using DoAn.gui;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;
using DoAn_DOTNET.doi_tuong;


namespace DoAn
{
    public partial class userTrangChu : UserControl
    {
        ToolStripProgressBar progress;
        ToolStripLabel lbl;
        Label lblGioiThieu;
        NhanVien nv;
        string manv = "";
        int sosp = 0;
        string[] sach_da_mua;
        string[] ds_mua_thongbao;
        string tenKHMua = ""; int slkh = 0;
        DataTable dt_DS_Sach, dt_DS_Sach_Coppy, dtKhachHang, dtKhachhang_Coppy;

        public userTrangChu()
        {
            InitializeComponent();
            cboGiaBan.Visible = false;
            load_data();
            sach_da_mua = new string[gridTrangChuSach.Rows.Count];
        }

        internal userTrangChu(ToolStripProgressBar progress, ToolStripLabel lbl, NhanVien nv, Label lblGioiThieu)
        {
            InitializeComponent();
            this.progress = progress;
            this.lbl = lbl;
            this.nv = nv;
            manv = nv.MaNV;
            cboGiaBan.Visible = false;
            load_data();
            dtKhachHang = KhachHang_DAO.get_info_khachhang();
            dtKhachhang_Coppy = dtKhachHang.Copy();
            sach_da_mua = new string[gridTrangChuSach.Rows.Count];
            this.lblGioiThieu = lblGioiThieu;
            dt_DS_Sach = Sach_DAO.get_info_sach_trangchu();
            dt_DS_Sach_Coppy = dt_DS_Sach.Copy();
            hint_cbo();
        }

        private void load_data()
        {
            dataGridDS_mua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDS_mua.AutoGenerateColumns = false;
            dataGridDS_mua.AllowUserToAddRows = false;

            gridTrangChuSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTrangChuSach.AutoGenerateColumns = false;
            gridTrangChuSach.AllowUserToAddRows = false;

            gridTrangChuSach.DataSource = Sach_DAO.get_info_sach_trangchu();
            gridTrangChuSach.Columns[0].DataPropertyName = "tenSach";
            gridTrangChuSach.Columns[1].DataPropertyName = "tacGia";
            gridTrangChuSach.Columns[2].DataPropertyName = "nhaXB";
            gridTrangChuSach.Columns[3].DataPropertyName = "namXB";
            gridTrangChuSach.Columns[4].DataPropertyName = "theLoai";
            gridTrangChuSach.Columns[5].DataPropertyName = "giaBan";
            gridTrangChuSach.Columns[6].DataPropertyName = "maSach";
            gridTrangChuSach.Columns[6].Visible = false;
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

        private void cbkGiaBan_CheckedChanged(object sender, EventArgs e)
        {
            cboGiaBan.Visible = !cboGiaBan.Visible;
            if (cboGiaBan.Visible)
                cboGiaBan.SelectedIndex = 0;
        }

        int tong = 0;
        int tong_soluong_mua = 0;

        private void btnMuaSach_Click(object sender, EventArgs e)
        {
            if (gridTrangChuSach.CurrentRow.Index < 0)
            {
                MessageBox.Show("Hãy chọn sản phẩm muốn mua ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Lấy dòng được chọn
            int id = gridTrangChuSach.CurrentRow.Index;

            //Kiểm tra sách có được mua hay chưa
            if (dataGridDS_mua.Rows.Count > 0)
            {
                foreach (string item in sach_da_mua)
                {
                    if (gridTrangChuSach.Rows[id].Cells[6].Value.ToString().Equals(item))
                    {
                        if (MessageBox.Show("Sách [" + gridTrangChuSach.Rows[id].Cells[0].Value.ToString() + "] đã được mua bạn có muốn CẬP NHẬT lại số lượng mua không ?", "Thông báo",
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

            //Lấy số lượng mua
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
            txtTongtien.Text = string.Format("{0:0,0}", tong);
            sach_da_mua[sosp] = gridTrangChuSach.Rows[id].Cells[6].Value.ToString();
            sosp++;
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

            txtTongtien.Text = string.Format("{0:0,0}", tong);
        }

        private void btnHuyMua_Click(object sender, EventArgs e)
        {
            if (dataGridDS_mua.Rows.Count <= 0)
            {
                MessageBox.Show("Bạn chưa mua sản phẩm nào !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rsl = dataGridDS_mua.CurrentRow.Index;
            if (rsl < 0)
            {
                MessageBox.Show("Hãy chọn sản phẩm muốn XÓA khỏi hóa đơn ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn Xóa [" + dataGridDS_mua.Rows[rsl].Cells[1].Value.ToString() + "] không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            int sl = int.Parse(dataGridDS_mua.Rows[rsl].Cells[2].Value.ToString());
            tong_soluong_mua -= sl;
            tong -= int.Parse(dataGridDS_mua.Rows[rsl].Cells[4].Value.ToString());
            txtTongtien.Text = string.Format("{0:0,0}", tong);
            dataGridDS_mua.Rows.RemoveAt(rsl);
        }

        private void btnLMTimKiem_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            if (!cbkGiaBan.Checked)
            {
                find_sach_hai_dk(true, 0, 0);
                if (gridTrangChuSach.Rows.Count <= 0)
                {
                    MessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else if (cboGiaBan.SelectedItem.Equals("> 10,000"))
                {
                    find_sach_hai_dk(false, 10000, 50000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else if (cboGiaBan.SelectedItem.Equals("> 50,000"))
                {
                    find_sach_hai_dk(false, 50000, 100000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else if (cboGiaBan.SelectedItem.Equals("> 100,000"))
                {
                    find_sach_hai_dk(false, 100000, 200000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else
                {
                    gridTrangChuSach.DataSource = Sach_DAO.tim_kiem_sach_trang_chu_hai_dk(txtTimKiemSach.Text, 100000, 1000000);
                    find_sach_hai_dk(false, 200000, 1000000);
                    if (gridTrangChuSach.Rows.Count <= 0)
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng & Hãy chọn sản phẩm khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridDS_mua.Rows.Count <= 0)
            {
                MessageBox.Show("Bạn chưa mua sản phầm nào nào ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmXN_DieuKien thongTin = new frmXN_DieuKien(true);
            thongTin.ShowDialog();
            string makh = thongTin.MaKH;
            tenKHMua = thongTin.TenKH;
      
            if (makh.Equals(""))
            {
                MessageBox.Show(" Hãy thêm Khách hàng thành viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn đã mua không ?", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            Random rd = new Random();
            int ms = rd.Next(0, 999);
            string madonban = "HD" + ms;


            DateTime date = DateTime.Now;
            string ngay_ld = date.ToString();
            int soluongban = tong_soluong_mua;
            int tongtien = int.Parse(get_tong_tien(txtTongtien.Text));
            tongtien = tongtien - (int)giam_gia_vip(makh, tongtien);

            DonBanHang dbh = new DonBanHang();
            dbh.MaDonBan = madonban.Trim();
            dbh.MaNV = manv.Trim();
            dbh.MaKH = makh.Trim();
            dbh.NgayBan = ngay_ld.Trim();
            dbh.SoLuongBan = soluongban;
            dbh.TongTien = tongtien;

            DonBanHang_DAO.insert_HDBanSach(dbh);

            foreach (DataGridViewRow row in dataGridDS_mua.Rows)
            {
                CT_DonBanHang ct_dbh = new CT_DonBanHang();
                ct_dbh.MaDonBan = madonban;
                ct_dbh.MaSach = row.Cells[0].Value.ToString();
                ct_dbh.SoLuongBan = int.Parse(row.Cells[2].Value.ToString());
                ct_dbh.GiaBan = int.Parse(row.Cells[3].Value.ToString());
                ct_dbh.ThanhTien = int.Parse(row.Cells[4].Value.ToString());

                CT_DonBanHang_DAO.insert_CT_HDBanSach(ct_dbh);

                TonKho tk = new TonKho();
                tk.MaSach = row.Cells[0].Value.ToString();
                tk.SoLuongTon = int.Parse(row.Cells[2].Value.ToString());
                TonKho_DAO.update_SachTonKho(tk, false);
            }

            if (DonBanHang_DAO.up_db_DonBanHang() && CT_DonBanHang_DAO.up_db_CT_DonBanHang() && TonKho_DAO.up_db_TonKho())
            {
                progress_sc();
                DialogResult rs = MessageBox.Show("Bạn Có Muốn In Hóa Đơn Không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {   
                     new Gui_BaoCao.Form_BaoCao("THANHTOAN",CT_DonBanHang_DAO.baocao_theomahoadon(madonban)).Show();
                }
               
                if (slkh < 2)
                {
                    this.lblGioiThieu.Text += "    -   " + ds_da_mua() + " Tổng cộng: " + string.Format("{0:0,0} VNĐ", tongtien);
                    slkh++;
                }
                else
                {
                    this.lblGioiThieu.Text = ds_da_mua() + " Tổng cộng: " + string.Format("{0:0,0} VNĐ", tongtien);
                    slkh = 0;
                }

                dataGridDS_mua.Rows.Clear();
                update_tinh_trang_kh(makh);
                md();
            }
            else
            {
                progress_sc();
                MessageBox.Show("Thanh toán hóa đơn KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridDS_mua.Rows.Clear();
                md();
            }
        }

        private double giam_gia_vip(string makh, int tongtien)
        {
            double giam_gia = 0;
            dtKhachhang_Coppy.Rows.Clear();
            foreach(DataRow r in dtKhachHang.Rows)
            {
                if (makh.Equals(r[0]))
                {
                    string dk = r[5].ToString().Trim().ToUpper();
                    if (dk.Equals("Thành viên Vip".Trim().ToUpper()))
                        return giam_gia = (tongtien * 0.03);
                }
                else
                {
                    giam_gia = 0;
                }
            }

            return giam_gia;
        }

        private string ds_da_mua()
        {
            string s;
            lblGioiThieu.Text = "";
            s = "Khách hàng " + tenKHMua + " đã mua:";

            for (int i = 0; i < dataGridDS_mua.Rows.Count; i++)
            {
                s += "_" + dataGridDS_mua.Rows[i].Cells[1].Value.ToString();
            }
            return s;
        }

        public void update_tinh_trang_kh(string makh)
        {
            int so_hd = DonBanHang_DAO.get_dh_kh(makh);
            if (so_hd == 5) // Update tình trạng khách hàng thành Thành viên Vip
            {
                KhachHang_DAO.update_tinhtrang_kh(makh);
            }
        }

        private void md()
        {
            tong = 0;
            tong_soluong_mua = 0;
            sosp = 0;
            txtTongtien.Text = "";
            sach_da_mua = null;
            sach_da_mua = new string[gridTrangChuSach.Rows.Count];
            ds_mua_thongbao = null;
            ds_mua_thongbao = new string[gridTrangChuSach.Rows.Count];
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (dataGridDS_mua.Rows.Count > 0)
            {
                int rowSL = dataGridDS_mua.CurrentRow.Index;
                if (MessageBox.Show("Bạn có muốn Cập nhật lại số lượng nhập cho sản phẩm [" + dataGridDS_mua.Rows[rowSL].Cells[1].Value.ToString() + "] không ?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                update_so_luong_nhap(rowSL);
            }
        }

        private void update_so_luong_nhap(int item) //Truyền vào item nào cần update số lượng _ tổng tiền
        {
            frmXN_DieuKien up_sl = new frmXN_DieuKien(false);
            up_sl.ShowDialog();
            int sl_moi = up_sl.SoLuong; // Lấy số lượng thêm

            // Lấy thành tiền cũ & số lượng cũ
            int sl_cu = int.Parse(dataGridDS_mua.Rows[item].Cells[2].Value.ToString());
            int thanh_tien_cu = int.Parse(dataGridDS_mua.Rows[item].Cells[4].Value.ToString());
            // Trừ thành tiền cũ khỏi tổng tiền & trừ số lượng cũ
            tong -= thanh_tien_cu;
            tong_soluong_mua -= sl_cu;

            //Lấy giá của sách đó
            int gia_sach = int.Parse(gridTrangChuSach.Rows[item].Cells[5].Value.ToString());
            // Tính lại thành tiền với số lượng mới
            int thanh_tien_moi = gia_sach * sl_moi;

            dataGridDS_mua.Rows[item].Cells[2].Value = sl_moi; // Hiển thị lại số lượng
            dataGridDS_mua.Rows[item].Cells[4].Value = thanh_tien_moi; // Hiển thị lại thành tiền 
            tong += thanh_tien_moi;
            tong_soluong_mua += sl_moi;
            txtTongtien.Text = string.Format("{0:0,0}", tong);
        }

        private void cậpNhậtSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridDS_mua.Rows.Count <= 0)
                return;
            if (MessageBox.Show("Bạn có muốn Hủy đơn hàng hiện tại ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            load_data();
            dataGridDS_mua.Rows.Clear();
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

        private string get_tong_tien(string tt)
        {
            string[] t = tt.Split(',');
            string tong_tien = "";
            foreach (string item in t)
            {
                tong_tien += item;
            }

            return tong_tien;
        }
    }
}
