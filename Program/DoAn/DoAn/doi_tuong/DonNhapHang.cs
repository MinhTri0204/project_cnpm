using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class DonNhapHang
    {
        string maDonNhap, maNV, maNCC;
        string ngayNhap;
        int soLuong, tongTienHD;

        public DonNhapHang()
        {

        }
        public DonNhapHang(string maDonNhap, string maNV, string maNCC, string ngayNhap, int soLuong, int tongTienHD)
        {
            this.maDonNhap = maDonNhap;
            this.maNV = maNV;
            this.maNCC = maNCC;
            this.ngayNhap = ngayNhap;
            this.soLuong = soLuong;
            this.tongTienHD = tongTienHD;
        }
        public string MaDonNhap
        {
            get { return maDonNhap; }
            set { maDonNhap = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int TongTienHD
        {
            get { return tongTienHD; }
            set { tongTienHD = value; }
        }
    }
}
