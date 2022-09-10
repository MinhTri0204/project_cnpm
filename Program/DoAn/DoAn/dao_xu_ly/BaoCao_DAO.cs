using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using System.Data;

namespace DoAn.dao_xu_ly
{
    class BaoCao_DAO
    {
        static SQLProvider data = new SQLProvider();
        
        internal static DataTable get_DB_Ngay(DateTime ngay)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("set dateformat DMY exec show_DB '{0}' ", ngay);
            dt = data.get_data(sql, "BaoCaoNgay");

            return dt;
        }

        internal static DataTable get_DB_Thang(int thang)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("exec show_DB_Thang {0} ", thang);
            dt = data.get_data(sql, "BaoCaoThang");

            return dt;
        }

        internal static DataTable get_DB_Quy_1()
        {
            DataTable dt = new DataTable();
            string sql = "exec show_DB_Quy_1";
            dt = data.get_data(sql, "BaoCaoQuy_1");

            return dt;
        }

        internal static DataTable get_DB_Quy_2()
        {
            DataTable dt = new DataTable();
            string sql = "exec show_DB_Quy_2";
            dt = data.get_data(sql, "BaoCaoQuy_2");

            return dt;
        }
    }
}
