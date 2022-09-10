using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn.doi_tuong;
using DoAn.connect_database;

namespace DoAn.dao_xu_ly
{
    class CT_DonBanHang_DAO
    {
        static SQLProvider data = new SQLProvider();
        static DataTable dtCT_DonBanHang = data.get_data("select *from CT_DonBanHang", "CT_DonBanHang");
        internal static void insert_CT_HDBanSach(CT_DonBanHang ct_donHang)
        {
            DataRow add_r_CT = dtCT_DonBanHang.NewRow();
            add_r_CT[0] = ct_donHang.MaDonBan;
            add_r_CT[1] = ct_donHang.MaSach;
            add_r_CT[2] = ct_donHang.SoLuongBan;
            add_r_CT[3] = ct_donHang.GiaBan;
            add_r_CT[4] = ct_donHang.ThanhTien;

            dtCT_DonBanHang.Rows.Add(add_r_CT);
        }
        internal static DataTable baocao_theomahoadon(string mahoadon)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("show_thanhtoan '{0}' ", mahoadon);
            dt = data.get_data(sql, "inthanhtoan");

            return dt;
        }

        internal static bool up_db_CT_DonBanHang()
        {
            try
            {
                data.update_database("select *from CT_DonBanHang", dtCT_DonBanHang);
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
