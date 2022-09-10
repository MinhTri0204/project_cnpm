using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;
using DoAn_DOTNET.doi_tuong;
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

namespace DoAn.gui
{
    public partial class GioHang : Form
    {
        DataTable dtKhachHang, dtKhachhang_Coppy;
        ToolStripProgressBar progress;
        ToolStripLabel lbl;
        Label lblGioiThieu;
        string tenKHMua = "";
        int tong_soluong_mua = 0;
        int tong_tien_mua = 0;
        int slkh = 0;
        string manv = string.Empty;
        string[] ds_mua_thongbao;


        bool check_mua_hang;

        public bool Check_mua_hang { get => check_mua_hang; set => check_mua_hang = value; }

        public GioHang()
        {
            InitializeComponent();
        }

        internal GioHang(DataGridView gridSP_Mua, string manv, ToolStripProgressBar progress, ToolStripLabel lbl, Label lblGioiThieu)
        {
            InitializeComponent();
            this.progress = progress;
            this.lbl = lbl;
            this.manv = manv;
            this.lblGioiThieu = lblGioiThieu;

            //Hiển thị sản phẩm được mua lên DataGridView
            foreach (DataGridViewRow row in gridSP_Mua.Rows)
            {
                int n = dataGridDS_mua.Rows.Add();
                foreach (DataGridViewColumn col in gridSP_Mua.Columns)
                {
                    dataGridDS_mua.Rows[n].Cells[col.Index].Value = gridSP_Mua.Rows[row.Index].Cells[col.Index].Value.ToString();
                }
            }

            //Lấy tổng số lượng mua
            for (int i = 0; i < dataGridDS_mua.RowCount; i++)
            {
                tong_soluong_mua += int.Parse(dataGridDS_mua.Rows[i].Cells[2].Value.ToString());
            }

            //Lấy tổng tiền
            for (int i = 0; i < dataGridDS_mua.RowCount; i++)
            {
                tong_tien_mua += int.Parse(dataGridDS_mua.Rows[i].Cells[4].Value.ToString());
            }
            txtTongTien.Text = tong_tien_mua.ToString();

            dtKhachHang = KhachHang_DAO.get_info_khachhang();
            dtKhachhang_Coppy = dtKhachHang.Copy();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridDS_mua.Rows.Count <= 0)
            {
                KryptonMessageBox.Show(this, "Bạn chưa mua sản phầm nào nào ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmXN_DieuKien thongTin = new frmXN_DieuKien(true);
            thongTin.ShowDialog();
            string makh = thongTin.MaKH;
            tenKHMua = thongTin.TenKH;

            if (makh.Equals(""))
            {
                KryptonMessageBox.Show(" Hãy thêm Khách hàng thành viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KryptonMessageBox.Show("Bạn có muốn thanh toán hóa đơn đã mua không ?", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            Random rd = new Random();
            int ms = rd.Next(0, 999);
            string madonban = "HD" + ms;


            DateTime date = DateTime.Now;
            string ngay_ld = date.ToString();
            int soluongban = tong_soluong_mua;
            int tongtien = tong_tien_mua;
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
                DialogResult rs = KryptonMessageBox.Show("Bạn Có Muốn In Hóa Đơn Không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    new Gui_BaoCao.Form_BaoCao("THANHTOAN", CT_DonBanHang_DAO.baocao_theomahoadon(madonban)).Show();
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
                Check_mua_hang = true;
                this.Close();
                md();
            }
            else
            {
                progress_sc();
                KryptonMessageBox.Show("Thanh toán hóa đơn KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridDS_mua.Rows.Clear();
                md();
            }
        }

        private double giam_gia_vip(string makh, int tongtien)
        {
            double giam_gia = 0;
            dtKhachhang_Coppy.Rows.Clear();
            foreach (DataRow r in dtKhachHang.Rows)
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

        public void update_tinh_trang_kh(string makh)
        {
            int so_hd = DonBanHang_DAO.get_dh_kh(makh);
            if (so_hd == 5) // Update tình trạng khách hàng thành Thành viên Vip
            {
                KhachHang_DAO.update_tinhtrang_kh(makh);
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

        private void md()
        {
            tong_soluong_mua = 0;
            txtTongTien.Text = "";

            ds_mua_thongbao = null;
            ds_mua_thongbao = new string[dataGridDS_mua.Rows.Count];
        }
    }
}
