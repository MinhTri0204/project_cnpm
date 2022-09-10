using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using System.Data.SqlClient;
using System.Data;
using DoAn.doi_tuong;

namespace DoAn.dao_xu_ly
{
    public class Sach_DAO
    {
        static SQLProvider data = new SQLProvider();

        internal static DataTable get_info_sach_trangchu()
        {
            DataTable dt = new DataTable();
            string sql = "select maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan, anhSach from THONGTINSACH where giaBan is not null and giaBan > 0";
            dt = data.get_data(sql, "TrangChu");

            return dt;
        }

        internal static DataTable tim_kiem_sach_trang_chu_mot_dk(string dk)
        {
            DataTable dt = new DataTable();

            int nam = 0;
            bool convert = false;
            try
            {
                nam = int.Parse(dk);
                convert = true;
            }
            catch { convert = false; }

            if (convert) // Nếu là năm 
            {
                string sql = string.Format("exec tim_kiem_sach_theo_namxb {0}", nam);
                dt = data.get_data(sql, "TrangChu_TK_NAM");
            }
            else //Không phải năm
            {
                string sql = string.Format("exec tim_kiem_sach N'{0}'", dk);
                dt = data.get_data(sql, "TrangChu_TK");
            }

            return dt;
        }

        internal static DataTable tim_kiem_sach_trang_chu_hai_dk(string dk, int giabanmin, int giabanmax)
        {
            DataTable dt = new DataTable();

            int nam = 0;
            bool convert = false;
            try
            {
                nam = int.Parse(dk);
                convert = true;
            }
            catch { convert = false; }

            if (convert) // Nếu là năm 
            {
                string sql = string.Format("exec tim_kiem_sach_namxb_giaban {0}, {1}, {2}", dk, giabanmin, giabanmax);
                dt = data.get_data(sql, "TrangChu_TK_NXB_GIABAN");
            }
            else //Không phải năm
            {
                string sql = string.Format("exec tim_kiem_sach_giaban N'{0}', {1}, {2}", dk, giabanmin, giabanmax);
                dt = data.get_data(sql, "TrangChu_TK_GIABAN");
            }

            return dt;
        }

        internal static DataTable get_info_ThongTinSach()
        {
            DataTable dtSach = new DataTable();
            string sql = "select THONGTINSACH.maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan, SoLuongTon, anhSach" + 
                            " from THONGTINSACH, SachTonKho" +
                            " where THONGTINSACH.maSach = SachTonKho.maSach";
            dtSach = data.get_data(sql, "ThongTinSach");

            return dtSach;
        }

        internal static List<string> get_ds_mas()
        {
            List<string> lst_ms = new List<string>();
            DataTable dtSach = new DataTable();
            string sql = "select maSach from THONGTINSACH";
            dtSach = data.get_data(sql, "MaSach");

            foreach (DataRow r in dt_SACH.Rows)
            {
                lst_ms.Add(r[0].ToString());
            }

            return lst_ms;
        }

        internal static ThongTinSach get_Sach(string mas)
        {
            string sql = string.Format("select maSach, tenSach, tacGia, nhaXB, namXB, theLoai from THONGTINSACH where maSach = '{0}'", mas);
            ThongTinSach sach = data.get_Sach(sql);

            return sach;
        }

        internal static bool update_sach(ThongTinSach sach)
        {
            string sql = string.Format("update THONGTINSACH set tenSach = N'{0}', tacGia = N'{1}', nhaXB = N'{2}', namXB = {3}, theLoai = N'{4}', giaBan = {5}, anhSach = N'{6}' where maSach = '{7}' ",
                                            sach.TenSach, sach.TacGia, sach.NhaXB, sach.NamXB, sach.TheLoai, sach.GiaBan, sach.AnhSach, sach.MaSach);
            int kq = data.insert_update_delete(sql);
            if (kq > -1)
                return true;
            return false;
        }


        static DataTable dt_SACH = data.get_data("select *from THONGTINSACH", "THONGTINSACH2");
        internal static void insert_sach(ThongTinSach sach)
        {
            DataRow add_r_CT = dt_SACH.NewRow();
            add_r_CT[0] = sach.MaSach;
            add_r_CT[1] = sach.TenSach;
            add_r_CT[2] = sach.TacGia;
            add_r_CT[3] = sach.NhaXB;
            add_r_CT[4] = sach.NamXB;
            add_r_CT[5] = sach.TheLoai;
            add_r_CT[7] = @"\img\nocontentyet.jpg";

            dt_SACH.Rows.Add(add_r_CT);
        }

        internal static bool up_db_ThongTinSach()
        {
            try
            {
                data.update_database("select *from THONGTINSACH", dt_SACH);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
    }
}
