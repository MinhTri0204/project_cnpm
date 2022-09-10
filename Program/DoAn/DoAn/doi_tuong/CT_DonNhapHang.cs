
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class CT_DonNhapHang
    {
        string maDonNhap, maSach;
        int soLuongNhap, giaNhap, thanhtien;
        public CT_DonNhapHang()
        {

        }

        public CT_DonNhapHang(string maDonNhap, string maSach, int soLuongNhap, int giaNhap, int thanhTien)
        {
            this.maDonNhap = maDonNhap;
            this.maSach = maSach;
            this.soLuongNhap = soLuongNhap;
            this.giaNhap = giaNhap;
            this.thanhtien = thanhTien;
        }
        public string MaDonNhap
        {
            get { return maDonNhap; }
            set { maDonNhap = value; }
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public int SoLuongNhap
        {
            get { return soLuongNhap; }
            set { soLuongNhap = value; }
        }
        public int GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        public int ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}
