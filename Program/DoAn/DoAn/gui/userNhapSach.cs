using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;
using DoAn.gui;
using DoAn.Validation;
using DoAn_DOTNET.doi_tuong;

namespace DoAn
{
    public partial class userNhapSach : UserControl
    {
        ToolStripProgressBar progress;
        ToolStripLabel lbl;
        int tongtienhd = 0;
        int tongslban = 0;
        string manv = "";

        // Danh sách mã sách đã có trong Database
        List<string> lst; 
        // Danh sách mã sách đã được nhập
        List<string> sach_nhap;

        public userNhapSach()
        {
            InitializeComponent();
            get_Ngay();
            dataGridView_HDNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView_HDNhap.AutoGenerateColumns = false;
            //dataGridView_HDNhap.AllowUserToAddRows = false;

            lst = Sach_DAO.get_ds_mas();
            sach_nhap = new List<string>();

            load_ncc();

            //Gắn mnuStrip cho datagridview
            dataGridView_HDNhap.ContextMenuStrip = mnuStrip_UPSL;
        }

        public userNhapSach(string manv, ToolStripProgressBar progress, ToolStripLabel lbl)
        {
            InitializeComponent();
            this.progress = progress;
            this.lbl = lbl;
            get_Ngay();
            dataGridView_HDNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView_HDNhap.AutoGenerateColumns = false;
            //dataGridView_HDNhap.AllowUserToAddRows = false;

            this.manv = manv;
            lst = Sach_DAO.get_ds_mas();
            sach_nhap = new List<string>();

            load_ncc();

            //Gắn mnuStrip cho datagridview
            dataGridView_HDNhap.ContextMenuStrip = mnuStrip_UPSL;
        }

        private void load_ncc()
        {
            cboNCC.DataSource = NhaCungCap_DAO.get_ma_ten_ncc();
            cboNCC.DisplayMember = "tenNCC";
            cboNCC.ValueMember = "maNCC";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridView_HDNhap.Rows.Count <= 0)
                return;

            if (KryptonMessageBox.Show("Bạn có muốn thanh toán đơn hàng", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int sod = dataGridView_HDNhap.Rows.Count;
            //Kiểm tra nếu mã sách chưa tồn tại trong Database thì insert sách mới
            for (int i = 0; i < sod - 1; i++)
            {
                if (!kiem_tra_ms_ton_tai(dataGridView_HDNhap.Rows[i].Cells[0].Value.ToString())) // false là chưa có
                {
                    ThongTinSach sach = new ThongTinSach();
                    sach.MaSach = dataGridView_HDNhap.Rows[i].Cells[0].Value.ToString();
                    sach.TenSach = dataGridView_HDNhap.Rows[i].Cells[1].Value.ToString();
                    sach.TacGia = dataGridView_HDNhap.Rows[i].Cells[2].Value.ToString();
                    sach.NhaXB = dataGridView_HDNhap.Rows[i].Cells[3].Value.ToString();
                    sach.NamXB = int.Parse(dataGridView_HDNhap.Rows[i].Cells[4].Value.ToString());
                    sach.TheLoai = dataGridView_HDNhap.Rows[i].Cells[5].Value.ToString();

                    Sach_DAO.insert_sach(sach);
                    TonKho tk = new TonKho();
                    tk.MaSach = dataGridView_HDNhap.Rows[i].Cells[0].Value.ToString();
                    tk.SoLuongTon = int.Parse(dataGridView_HDNhap.Rows[i].Cells[6].Value.ToString());
                    TonKho_DAO.insert_SachTonKho(tk);
                }
                else // true là đã có -> Update tồn kho
                {
                    TonKho tk = new TonKho();
                    tk.MaSach = dataGridView_HDNhap.Rows[i].Cells[0].Value.ToString();
                    tk.SoLuongTon = int.Parse(dataGridView_HDNhap.Rows[i].Cells[6].Value.ToString());
                    TonKho_DAO.update_SachTonKho(tk, true);
                }
            }
            if (Sach_DAO.up_db_ThongTinSach() && TonKho_DAO.up_db_TonKho())
            {
                //Thêm thông tin đơn nhập vào bảng HOADONNHAP
                Random rd = new Random();
                int ms = rd.Next(0, 999);

                DonNhapHang donNhapHang = new DonNhapHang();
                donNhapHang.MaDonNhap = "NH" + ms;
                donNhapHang.MaNV = manv;
                donNhapHang.MaNCC = cboNCC.SelectedValue.ToString();
                donNhapHang.NgayNhap = txtNgayNhap.Text;
                donNhapHang.SoLuong = tongslban;
                donNhapHang.TongTienHD = tongtienhd;

                if (HDNhap_DAO.insert_donnhaphang(donNhapHang))
                {
                    //Thêm thông tin bảng chi tiết hóa đơn
                    //foreach (DataGridViewRow row in dataGridView_HDNhap.Rows)
                    //{
                    //    CT_DonNhapHang ct_dnh = new CT_DonNhapHang();
                    //    ct_dnh.MaDonNhap = "NH" + ms;
                    //    ct_dnh.MaSach = row.Cells[0].Value.ToString();
                    //    ct_dnh.SoLuongNhap = int.Parse(row.Cells[6].Value.ToString());
                    //    ct_dnh.GiaNhap = int.Parse(row.Cells[7].Value.ToString());
                    //    ct_dnh.ThanhTien = int.Parse(row.Cells[8].Value.ToString());

                    //    CT_HoaDonNhap_DAO.insert_CT_HDNhapHang(ct_dnh);
                    //}

                    for (int i = 0; i < dataGridView_HDNhap.RowCount - 1; i++)
                    {
                        CT_DonNhapHang ct_dnh = new CT_DonNhapHang();
                        ct_dnh.MaDonNhap = "NH" + ms;
                        ct_dnh.MaSach = dataGridView_HDNhap.Rows[i].Cells[0].Value.ToString();
                        ct_dnh.SoLuongNhap = int.Parse(dataGridView_HDNhap.Rows[i].Cells[6].Value.ToString());
                        ct_dnh.GiaNhap = int.Parse(dataGridView_HDNhap.Rows[i].Cells[7].Value.ToString());
                        ct_dnh.ThanhTien = int.Parse(dataGridView_HDNhap.Rows[i].Cells[8].Value.ToString());

                        CT_HoaDonNhap_DAO.insert_CT_HDNhapHang(ct_dnh);
                    }
                    if (CT_HoaDonNhap_DAO.up_db_CT_HDNhap())
                    {
                        progress_sc();
                        KryptonMessageBox.Show("Thanh toán hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult rs = KryptonMessageBox.Show("Bạn Có Muốn In Hóa Đơn Không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            new Gui_BaoCao.Form_BaoCao("HOADONNHAP", CT_HoaDonNhap_DAO.baocao_hoadonhapsach(donNhapHang.MaDonNhap)).Show();
                        }
                        md(); 
                        dataGridView_HDNhap.Rows.Clear();
                        return;
                    }
                    else
                    {
                        progress_sc();
                        KryptonMessageBox.Show("Thanh toán hóa đơn KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        md(); dataGridView_HDNhap.Rows.Clear();
                        return;
                    }
                }
                else
                {
                    progress_sc();
                    KryptonMessageBox.Show("Thanh toán hóa đơn KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    md(); dataGridView_HDNhap.Rows.Clear();
                    return;
                }
            }    
            else
            {
                progress_sc();
                KryptonMessageBox.Show("Thanh toán hóa đơn KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                md(); dataGridView_HDNhap.Rows.Clear();
                return;
            }
        }

        private bool kiem_tra_ms_ton_tai(string ms)
        {   
            foreach (string item in lst)
            {
                if (ms.Trim().Equals(item.Trim()))
                    return true;
            }
            return false;
        }

        private void get_Ngay()
        {
            DateTime time = DateTime.Now;
            txtNgayNhap.Text = time.ToShortDateString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_HDNhap.Rows.Count <= 0)
                return;

            int rsl = dataGridView_HDNhap.CurrentRow.Index;

            if (rsl < 0)
            {
                KryptonMessageBox.Show("Hãy chọn sản phẩm muốn XÓA khỏi hóa đơn ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (KryptonMessageBox.Show("Bạn có muốn HỦY NHẬP [" + dataGridView_HDNhap.Rows[rsl].Cells[1].Value.ToString() + "] không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            int t = int.Parse(dataGridView_HDNhap.Rows[rsl].Cells[8].Value.ToString());
            tongtienhd -= t;
            int s = int.Parse(dataGridView_HDNhap.Rows[rsl].Cells[6].Value.ToString());
            tongslban -= s;
            txtTongtien.Text = string.Format("{0:0,0}", tongtienhd);
            dataGridView_HDNhap.Rows.RemoveAt(rsl);

            //Tạo row tổng tiền phía dưới cùng
            dataGridView_HDNhap.Rows[dataGridView_HDNhap.RowCount - 1].Cells[7].Value = "Tổng tiền:";
            dataGridView_HDNhap.Rows[dataGridView_HDNhap.RowCount - 1].Cells[8].Value = (string.Format("{0:0,0}", tongtienhd));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsValid_MA(txtMaSach.Text))
            {
                MessageBox.Show("Hãy nhập MÃ sách không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                txtMaSach.SelectAll();
                return;
            }
            if (!IsValid_Name(txtTenSach.Text))
            {
                MessageBox.Show("Hãy nhập Tên sách là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                txtTenSach.SelectAll();
                return;
            }
            if (!IsValid_Name(txtTG.Text))
            {
                MessageBox.Show("Hãy nhập Tác giả là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTG.Focus();
                txtTG.SelectAll();
                return;
            }
            if (!IsValid_Name(txtNXB.Text))
            {
                MessageBox.Show("Hãy nhập Nhà xuất bản là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNXB.Focus();
                txtNXB.SelectAll();
                return;
            }
            if (!IsValid_NUMBER(txtNamXB.Text))
            {
                MessageBox.Show("Hãy nhập Năm xuất bản là SỐ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamXB.Focus();
                txtNamXB.SelectAll();
                return;
            }
            if (!IsValid_Name(txtTheloai.Text))
            {
                MessageBox.Show("Hãy nhập Thể loại là Tiếng Việt có dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTheloai.Focus();
                txtTheloai.SelectAll();
                return;
            }
            if (!IsValid_NUMBER(txtSoLuongNhap.Text) || int.Parse(txtSoLuongNhap.Text) <= 0 )
            {
                MessageBox.Show("Hãy nhập Số lượng nhập là SỐ và LỚN HƠN 0 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongNhap.Focus();
                txtSoLuongNhap.SelectAll();
                return;
            }
            if (!IsValid_NUMBER(txtGiaNhap.Text) || int.Parse(txtGiaNhap.Text) <= 0)
            {
                MessageBox.Show("Hãy nhập Giá bán là SỐ và LỚN HƠN 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNhap.Focus();
                txtGiaNhap.SelectAll();
                return;
            }


            if (dataGridView_HDNhap.Rows.Count > 0)
            {
                foreach (string item in sach_nhap)
                {
                    if (txtMaSach.Text.Equals(item)) // Kiểm tra sách đã được thêm hay chưa -> Nếu có thì update số lượng nhập thêm
                    {
                        KryptonMessageBox.Show("Sách đã được Nhập! Hãy Nhập sách khác hoặc THÊM số lượng nhập ở dưới !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                        enable_tt(false);
                            return;
                    }
                }
            }

            int sln = int.Parse(txtSoLuongNhap.Text);
            int gn = int.Parse(txtGiaNhap.Text);
            string[] ct_hd = new string[] { txtMaSach.Text, txtTenSach.Text, txtTG.Text, txtNXB.Text, txtNamXB.Text,
                                            txtTheloai.Text, txtSoLuongNhap.Text, txtGiaNhap.Text, (sln * gn).ToString() };
            dataGridView_HDNhap.Rows.Add(ct_hd);
            tongtienhd += (sln * gn);
            tongslban += sln;
            txtTongtien.Text = string.Format("{0:0,0}",tongtienhd);
            
            sach_nhap.Add(txtMaSach.Text);

            enable_tt(false);

            //Tạo row tổng tiền phía dưới cùng
            dataGridView_HDNhap.Rows[dataGridView_HDNhap.RowCount - 1].Cells[7].Value = "Tổng tiền:";
            dataGridView_HDNhap.Rows[dataGridView_HDNhap.RowCount - 1].Cells[8].Value = (string.Format("{0:0,0}", tongtienhd));
        }

        private void md()
        {
            tongtienhd = 0;
            tongslban = 0;
            txtTongtien.Text = "";

            sach_nhap.Clear();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dataGridView_HDNhap.Rows.Count <= 0)
                return;
            if (KryptonMessageBox.Show("Bạn có muốn Hủy đơn hàng hiện tại ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            dataGridView_HDNhap.Rows.Clear();
        }

        private void txtMaSach_Leave(object sender, EventArgs e)
        {
            if (kiem_tra_ms_ton_tai(txtMaSach.Text))
            {
                ThongTinSach sach = Sach_DAO.get_Sach(txtMaSach.Text);
                txtTenSach.Text = sach.TenSach;
                txtTG.Text = sach.TacGia;
                txtNXB.Text = sach.NhaXB;
                txtNamXB.Text = sach.NamXB + "";
                txtTheloai.Text = sach.TheLoai;
                txtSoLuongNhap.Focus();
                enable_tt(true);
            }
        }

        private void enable_tt(bool kt)
        {
            if (kt)
            {
                txtMaSach.ReadOnly = true;
                txtTenSach.ReadOnly = true;
                txtTG.ReadOnly = true;
                txtNXB.ReadOnly = true;
                txtNamXB.ReadOnly = true;
                txtTheloai.ReadOnly = true;
            }
            else
            {
                txtMaSach.ReadOnly = false;
                txtTenSach.ReadOnly = false;
                txtTG.ReadOnly = false;
                txtNXB.ReadOnly = false;
                txtNamXB.ReadOnly =false;
                txtTheloai.ReadOnly = false;

                txtMaSach.Focus();
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtTG.Text = "";
                txtNXB.Text = "";
                txtNamXB.Text = "";
                txtTheloai.Text = "";
                txtSoLuongNhap.Text = "";
                txtGiaNhap.Text = "";
            }

        }

        private void thêmSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Có dữ liệu trong datagridview
            if (dataGridView_HDNhap.Rows.Count > 0)
            {
                int rowSL = dataGridView_HDNhap.CurrentRow.Index;
                if (KryptonMessageBox.Show("Bạn có muốn Cập nhật lại số lượng nhập cho sản phẩm [" + dataGridView_HDNhap.Rows[rowSL].Cells[1].Value.ToString() + "] không ?",
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
            int sl_cu = int.Parse(dataGridView_HDNhap.Rows[item].Cells[6].Value.ToString());
            int thanh_tien_cu = int.Parse(dataGridView_HDNhap.Rows[item].Cells[8].Value.ToString());
            // Trừ thành tiền cũ khỏi tổng tiền & trừ số lượng cũ
            tongtienhd -= thanh_tien_cu;
            tongslban -= sl_cu;
            
            //Lấy giá của sách đó
            int gia_sach = int.Parse(dataGridView_HDNhap.Rows[item].Cells[7].Value.ToString());
            // Tính lại thành tiền với số lượng mới
            int thanh_tien_moi = gia_sach * sl_moi;

            dataGridView_HDNhap.Rows[item].Cells[6].Value = sl_moi; // Hiển thị lại số lượng
            dataGridView_HDNhap.Rows[item].Cells[8].Value = thanh_tien_moi; // Hiển thị lại thành tiền 
            tongtienhd += thanh_tien_moi;
            tongslban += sl_moi;
            txtTongtien.Text = string.Format("{0:0,0}", tongtienhd);
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

        private bool IsValid_MA(string ma)
        {
            if (!check_valid.IsValid_MA(ma))
                return false;
            return true;
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

        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            frmAdd_NCC themncc = new frmAdd_NCC();
            themncc.ShowDialog();
            load_ncc();
        }
    }
}
