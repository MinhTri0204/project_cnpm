using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DoAn.doi_tuong;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAn.gui;
using DoAn.dao_xu_ly;

namespace DoAn.connect_database
{
    class SQLProvider
    {
       
        SqlConnection connect = null;
        AppSetting app = new AppSetting();

        public SQLProvider()
        {
            string connectString = app.getConnectionString("DoAn.Properties.Settings.QL_BSachConnectionString");
            connect = new SqlConnection(connectString);
        }

        public bool testConnection(string connectionString)
        {
            connect = new SqlConnection(connectionString);
            try
            {
                connect.Open();
                connect.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal DataTable get_data(string sql, string table_name)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                da.Fill(ds, table_name);
                return ds.Tables[table_name];
            }
            catch (SqlException ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        internal void update_database(string sql, DataTable tbl_up)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(tbl_up);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal int insert_update_delete(string sql)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                int kq = cmd.ExecuteNonQuery();
                connect.Close();

                return kq;
            }
            catch (SqlException ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }

        internal int get_result_int(string sql)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                int kq = (int)cmd.ExecuteScalar();
                connect.Close();

                return kq;
            }
            catch (SqlException ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }

        internal NhanVien get_nv(string sql)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = rs[0].ToString();
                    nv.MatKhau = rs[2].ToString();
                    nv.TenNV = rs[3].ToString();
                    nv.NgaySinh = rs[4].ToString();
                    nv.GioiTinh = rs[5].ToString();
                    nv.EmailNV = rs[6].ToString();
                    nv.SdtNV = rs[7].ToString();
                    nv.AnhNV = rs[8].ToString();
                    nv.ID_ROEL = int.Parse(rs[9].ToString());

                    connect.Close();
                    return nv;
                }

                connect.Close();

                return null;
            }
            catch (SqlException ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        internal KhachHang get_kh(string sql)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = rs[0].ToString();
                    kh.TenKH = rs[1].ToString();
                    kh.SdtKH = rs[2].ToString();
                    kh.EmailKH = rs[3].ToString();
                    kh.DiaChi = rs[4].ToString(); ;
                    kh.TinhTrang = rs[5].ToString();
                    connect.Close();
                    return kh;
                }
                connect.Close();
                return null;
            }
            catch (SqlException ex)
            {
                connect.Close();
                return null;
                throw new Exception(ex.Message);
            }
        }

        internal NhaCungCap get_ncc(string sql)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.MaNCC = rs[0].ToString();
                    ncc.TenNCC = rs[1].ToString();
                    ncc.SdtNCC = rs[2].ToString();
                    ncc.EmailNCC = rs[3].ToString();
                    ncc.DiaChi = rs[4].ToString(); ;

                    connect.Close();
                    return ncc;
                }

                connect.Close();

                return null;
            }
            catch (SqlException ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        internal ThongTinSach get_Sach(string sql)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    ThongTinSach sach = new ThongTinSach();
                    sach.MaSach = rs[0].ToString();
                    sach.TenSach = rs[1].ToString();
                    sach.TacGia = rs[2].ToString();
                    sach.NhaXB = rs[3].ToString();
                    sach.NamXB = int.Parse(rs[4].ToString());
                    sach.TheLoai = rs[5].ToString();

                    connect.Close();
                    return sach;
                }

                connect.Close();

                return null;
            }
            catch (SqlException ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
    }
}
