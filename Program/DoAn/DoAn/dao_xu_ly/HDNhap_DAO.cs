using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using System.Data;
using DoAn.doi_tuong;

namespace DoAn.dao_xu_ly
{
    class HDNhap_DAO
    { 
        static SQLProvider data = new SQLProvider();
        internal static DataTable get_info_hdNhap()
        {
            DataTable dt = new DataTable();
            string sql = "	select maDonNhap, tenNV, tenNCC, ngayNhap, soLuong, tongTienHD from HoaDonNhapSach, NhanVien, NhaCungCap " +
                "where HoaDonNhapSach.maNV = NhanVien.maNV and HoaDonNhapSach.maNCC = NhaCungCap.maNCC";
            dt = data.get_data(sql, "HoaDonNhapSach");

            return dt;
        }

        internal static DataTable Get_All_CT_HDNhap()
        {
            DataTable dt = new DataTable();
            string sql = "select maDonNhap, tenSach, soLuongNhap, giaNhap, thanhtien " +
                "from CT_HoaDonNhapSach, THONGTINSACH where CT_HoaDonNhapSach.maSach = THONGTINSACH.maSach";
            dt = data.get_data(sql, "HoaDonNhapSach");

            return dt;
        }

        internal static DataTable get_info_CT_hdNhap(string maDonNhap)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("select maDonNhap, tenSach, soLuongNhap, giaNhap, thanhtien from CT_HoaDonNhapSach, THONGTINSACH " +
                "where CT_HoaDonNhapSach.maSach = THONGTINSACH.maSach and maDonNhap = '{0}'", maDonNhap);
            dt = data.get_data(sql, "CT_HoaDonNhapSach");

            return dt;
        }

        internal static bool insert_donnhaphang(DonNhapHang dnh)
        {
            string sql = string.Format("set dateformat DMY" +
                                        " insert into HoaDonNhapSach values ('{0}', '{1}', '{2}', '{3}', {4}, {5} )",
                                        dnh.MaDonNhap, dnh.MaNV, dnh.MaNCC, dnh.NgayNhap, dnh.SoLuong, dnh.TongTienHD);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static DataTable search_manv_mancc()
        {
            DataTable dt = new DataTable();
            string sql = ("exec tim_kiem_don_nhap_manv_ncc");
            dt = data.get_data(sql, "DNH_MA");

            return dt;
        }
    }
}
