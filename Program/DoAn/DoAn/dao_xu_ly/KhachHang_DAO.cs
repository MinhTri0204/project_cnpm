using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using DoAn.doi_tuong;
using System.Data;

namespace DoAn.dao_xu_ly
{
    class KhachHang_DAO
    {
        static SQLProvider data = new SQLProvider();
        internal static DataTable get_info_khachhang()
        {
            DataTable dt = new DataTable();
            string sql = "select *from KhachHang";
            dt = data.get_data(sql, "KhachHang");

            return dt;
        }

        internal static KhachHang get_KH(string dk)
        {
            string sql = string.Format("select * from KhachHang where sdt = '{0}' or maKH = '{1}' ", dk, dk);
            KhachHang kh = new KhachHang();
            kh = data.get_kh(sql);
            
            return kh;
            
        }

        internal static string get_MaKH(string sdt)
        {
            try
            {
                string sql = string.Format("select * from KhachHang where sdt = '{0}' ", sdt);
                KhachHang kh = data.get_kh(sql);
                if (kh != null)
                    return kh.MaKH;
            }
            catch (Exception e)
            {
                return "";
                throw new Exception(e.Message);
            }
            return "";
        }

        internal static string get_TenKH(string sdt)
        {
            try
            {
                string sql = string.Format("select * from KhachHang where sdt = '{0}' ", sdt);
                KhachHang kh = data.get_kh(sql);
                if (kh != null)
                    return kh.TenKH;
            }
            catch (Exception e)
            {
                return "";
                throw new Exception(e.Message);
            }
            return "";
        }

        internal static bool insert_kh(KhachHang khach)
        {
            string sql = string.Format("insert into KhachHang(maKH, tenKH, diaChi, sdt, email) values ('{0}', N'{1}', N'{2}', '{3}', '{4}')",
                                        khach.MaKH, khach.TenKH, khach.DiaChi, khach.SdtKH, khach.EmailKH);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static bool update_kh(KhachHang khach)
        {
            string sql = string.Format("update KhachHang set tenKH = N'{0}', diaChi = N'{1}', sdt = '{2}', email = '{3}' where maKH = '{4}'",
                                        khach.TenKH, khach.DiaChi, khach.SdtKH, khach.EmailKH, khach.MaKH);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static bool update_tinhtrang_kh(string makh)
        {
            string sql = string.Format("update KhachHang set tinhTrang = N'Thành viên VIP' where maKH = '{0}'", makh);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static bool delete_kh(string makh)
        {
            string sql = string.Format("delete from KhachHang where maKH = '{0}'", makh);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;

        }
    }
}
