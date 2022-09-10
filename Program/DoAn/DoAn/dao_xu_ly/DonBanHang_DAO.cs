using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using DoAn.doi_tuong;

namespace DoAn.dao_xu_ly
{
    class DonBanHang_DAO
    {
        static SQLProvider data = new SQLProvider();
        static DataTable dtDonBanHang = data.get_data("select *from DonBanHang", "DonBanHang");

        internal static void insert_HDBanSach(DonBanHang don_ban_hang)
        {
            DataRow add_r = dtDonBanHang.NewRow();
            add_r[0] = don_ban_hang.MaDonBan;
            add_r[1] = don_ban_hang.MaNV;
            add_r[2] = don_ban_hang.MaKH;
            add_r[3] = don_ban_hang.NgayBan;
            add_r[4] = don_ban_hang.SoLuongBan;
            add_r[5] = don_ban_hang.TongTien;

            dtDonBanHang.Rows.Add(add_r);
        }

        internal static int get_dh_kh(string makh)
        {
            int count = 0;
            string sql = string.Format("select COUNT(*) from DonBanHang where maKH = '{0}'", makh);
            count = data.get_result_int(sql);
            return count;
        }

        internal static bool up_db_DonBanHang()
        {
            try
            {
                data.update_database("select * from DonBanHang", dtDonBanHang);
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
