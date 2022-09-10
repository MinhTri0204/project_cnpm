using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.connect_database;
using DoAn.doi_tuong;
using System.Data;
using System.Windows.Forms;

namespace DoAn.dao_xu_ly
{
    class NhaCungCap_DAO
    {
        static SQLProvider data = new SQLProvider();
        internal static DataTable get_info_nhacungcap()
        {
            DataTable dt = new DataTable();
            string sql = "select *from NhaCungCap";
            dt = data.get_data(sql, "NhaCungCap");

            return dt;
        }

        internal static DataTable get_ma_ten_ncc()
        {
            DataTable dt = new DataTable();
            string sql = "select maNCC, tenNCC from NhaCungCap";
            dt = data.get_data(sql, "NhaCungCap2");

            return dt;
        }

        internal static NhaCungCap get_ncc(string dk)
        {
            string sql = string.Format("select * from NhaCungCap where sdt = '{0}' or maNCC = '{1}'", dk, dk);
            NhaCungCap ncc = new NhaCungCap(); 
            ncc = data.get_ncc(sql);
                
            return ncc;
        }

        internal static bool insert_ncc (NhaCungCap ncc)
        {
            string sql = string.Format("insert into NhaCungCap values ('{0}', N'{1}', '{2}', '{3}', N'{4}')", 
                                        ncc.MaNCC, ncc.TenNCC, ncc.SdtNCC, ncc.EmailNCC, ncc.DiaChi);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static bool update_ncc(NhaCungCap ncc)
        {
            string sql = string.Format("update NhaCungCap set tenNCC = N'{0}', sdt = '{1}', email = '{2}', diaChi = N'{3}' where maNCC = '{4}'",
                                        ncc.TenNCC, ncc.SdtNCC, ncc.EmailNCC, ncc.DiaChi, ncc.MaNCC);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
        }

        internal static bool delete_ncc(string mancc)
        {
            string sql = string.Format("delete from NhaCungCap where maNCC = '{0}'", mancc);
            if (data.insert_update_delete(sql) > -1)
                return true;
            return false;
            
        }

    }
}
