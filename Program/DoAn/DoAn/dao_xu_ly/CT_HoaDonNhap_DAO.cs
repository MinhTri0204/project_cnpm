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
    class CT_HoaDonNhap_DAO
    {
        static SQLProvider data = new SQLProvider();
        static DataTable dtCT_DonNhapHang = data.get_data("select *from CT_HoaDonNhapSach", "CT_HoaDonNhapSach");
        internal static void insert_CT_HDNhapHang(CT_DonNhapHang ct_donHang)
        {
            DataRow add_r_CT = dtCT_DonNhapHang.NewRow();
            add_r_CT[0] = ct_donHang.MaDonNhap;
            add_r_CT[1] = ct_donHang.MaSach;
            add_r_CT[2] = ct_donHang.SoLuongNhap;
            add_r_CT[3] = ct_donHang.GiaNhap;
            add_r_CT[4] = ct_donHang.ThanhTien;

            dtCT_DonNhapHang.Rows.Add(add_r_CT);
        }

        internal static bool up_db_CT_HDNhap()
        {
            try
            {
                data.update_database("select *from CT_HoaDonNhapSach", dtCT_DonNhapHang);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
        internal static DataTable baocao_hoadonhapsach(string mahoadon)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("show_hoadonnhaphang '{0}' ", mahoadon);
            dt = data.get_data(sql, "innhapsach");

            return dt;
        }
    }
}
