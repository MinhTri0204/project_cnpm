using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using DoAn.doi_tuong;
using System.Data;
using DoAn_DOTNET.doi_tuong;

namespace DoAn.dao_xu_ly
{
    class TonKho_DAO
    {
        static SQLProvider data = new SQLProvider();
        static DataTable dtTonKho = data.get_data("select *from SachTonKho", "SachTonKho");
        static DataColumn[] pr_key = new DataColumn[1];

        internal static void insert_SachTonKho(TonKho tonKho)
        {
            DataRow add_r_CT = dtTonKho.NewRow();
            add_r_CT[0] = tonKho.MaSach;
            add_r_CT[1] = tonKho.SoLuongTon;

            dtTonKho.Rows.Add(add_r_CT);
        }

        internal static void update_SachTonKho(TonKho tonKho, bool check)
        {
            pr_key[0] = dtTonKho.Columns[0];
            dtTonKho.PrimaryKey = pr_key;
            DataRow modify = dtTonKho.Rows.Find(tonKho.MaSach);
            if (check) // true thì update thêm sách
            {
                if (modify != null)
                    modify[1] = int.Parse(modify[1].ToString()) + tonKho.SoLuongTon;
            }
            else // false giảm số lượng sách
            {
                if (modify != null)
                    modify[1] = int.Parse(modify[1].ToString()) - tonKho.SoLuongTon;
            }

        }

        internal static bool up_db_TonKho()
        {
            try
            {
                data.update_database("select *from SachTonKho", dtTonKho);
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
