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
    class NhanVien_DAO
    {
        static SQLProvider data = new SQLProvider();

        internal static DataTable get_info_nhanvien()
        {
            DataTable dt = new DataTable();
            string sql = "select maNV, tenNV, ngaySinh, gioiTinh, emailNV, SoDT, anhNV from NhanVien";
            dt = data.get_data(sql, "NhanVien");

            return dt;
        }

        internal static bool insert_nv(NhanVien nv)
        {
            if (nv.AnhNV != null) //có ảnh thì insert thêm ảnh
            {
                string sql = string.Format("SET DATEFORMAT DMY " +
                            "INSERT INTO NhanVien(maNV, taiKhoan, matKhau, tenNV, ngaySinh, gioiTinh, emailNV, SoDT, anhNV, ID_ROLE) " +
                            "VALUES ('{0}', '{1}', '{2}', N'{3}', '{4}', N'{5}', N'{6}', '{7}', '{8}', 2)",
                            nv.MaNV, nv.TaiKhoan, nv.MatKhau, nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.EmailNV, nv.SdtNV, nv.AnhNV);
                if (data.insert_update_delete(sql) > -1)
                    return true;
            }
            else //Nếu k có thì k thêm ảnh -> bổ sung sau
            {
                string sql2 = string.Format("SET DATEFORMAT DMY " +
                            "INSERT INTO NhanVien(maNV, taiKhoan, matKhau, tenNV, ngaySinh, gioiTinh, emailNV, SoDT, ID_ROLE) " +
                            "VALUES ('{0}', '{1}', '{2}', N'{3}', '{4}', N'{5}', N'{6}', '{7}', 2)",
                            nv.MaNV, nv.TaiKhoan, nv.MatKhau, nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.EmailNV, nv.SdtNV);
                if (data.insert_update_delete(sql2) > -1)
                    return true;

            }
            return false;
        }

        internal static bool update_nv(NhanVien nv)
        {
            string sql = string.Format("set dateformat DMY " +
                                    "update NhanVien set tenNV = N'{0}', ngaySinh = '{1}', gioiTinh = N'{2}', emailNV = N'{3}', SoDT = '{4}', anhNV = N'{5}' " +
                                    "where maNV = '{6}' ",
                                        nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.EmailNV, nv.SdtNV, nv.AnhNV, nv.MaNV);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static bool delete_nv(string manv)
        {
            string sql = string.Format("delete from NhanVien where maNV = '{0}' ", manv);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static bool check_dn(string tk, string mk)
        {
            string sql = string.Format("select COUNT(*) from NhanVien where taiKhoan = '{0}' and matKhau = '{1}'",tk, mk);
            if (data.get_result_int(sql) > 0)
                return true;
            return false;
        }

        internal static NhanVien get_nhanvien(string tk, string mk)
        {
            string sql = string.Format("select * from NhanVien where taiKhoan = '{0}' and matKhau = '{1}'", tk, mk);
            NhanVien nv = new NhanVien();
            nv = data.get_nv(sql);
            if (nv != null)
                return nv;
            return null;
        }

        internal static NhanVien tra_cuu_nhanvien(string dk)
        { 
            string sql = string.Format("select *from NhanVien where maNV = '{0}' or SoDT = '{1}'", dk, dk);
            NhanVien nv = new NhanVien();
            nv = data.get_nv(sql);
            
            return nv;
        }

        internal static bool doi_mat_khau (string mk, string manv)
        {
            string sql = string.Format("update NhanVien set matKhau = '{0}' where maNV = '{1}' ", mk, manv);
            if (data.insert_update_delete(sql) > 0)
                return true;
            return false;
        }
    }
}
