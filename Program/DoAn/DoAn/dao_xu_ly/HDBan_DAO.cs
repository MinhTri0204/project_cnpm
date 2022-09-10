using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using System.Data;

namespace DoAn.dao_xu_ly
{
    class HDBan_DAO
    {
        static SQLProvider data = new SQLProvider();
        internal static DataTable get_info_hdBan()
        {
            DataTable dt = new DataTable();
            string sql = "select maDonBan, nv.tenNV, kh.tenKH, ngayBan, soLuong, tongTien  " +
                "from DonBanHang db, NhanVien nv, KhachHang kh where db.maNV = nv.maNV and db.maKH = kh.maKH";
            dt = data.get_data(sql, "DonBanHang");

            return dt;
        }

        internal static DataTable Get_All_CT_HDBan()
        {
            DataTable dt = new DataTable();
            string sql = "select CT_DonBanHang.maDonBan, tenSach, soLuong, DonGiaBan, TongTien" +
                " from CT_DonBanHang, THONGTINSACH where CT_DonBanHang.maSach = THONGTINSACH.maSach";
            dt = data.get_data(sql, "CT_DonBanHang");

            return dt;
        }

        internal static DataTable get_info_CT_hdBan(string madonban)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("select maDonBan, THONGTINSACH.tenSach, soLuong, DonGiaBan, TongTien " +
                "from CT_DonBanHang, THONGTINSACH where CT_DonBanHang.maSach = THONGTINSACH.maSach and maDonBan = '{0}'", madonban);
            dt = data.get_data(sql, "CT_DonBanHang");

            return dt;
        }

        internal static DataTable search_manv_makh()
        {
            DataTable dt = new DataTable();
            string sql = string.Format("exec tim_kiem_don_ban_manv_kh");
            dt = data.get_data(sql, "DBH_MA");

            return dt;
        }
    }
}
