using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class CT_DonBanHang
    {
        string maDonBan, maSach;
        int soLuongBan, giaBan, thanhTien;
        public CT_DonBanHang()
        {

        }
        public CT_DonBanHang(string maDonBan, string maSach, int soLuongBan, int giaBan, int thanhTien)
        {
            this.maDonBan = maDonBan;
            this.maSach = maSach;
            this.soLuongBan = soLuongBan;
            this.giaBan = giaBan;
            this.thanhTien = thanhTien;
        }
        public string MaDonBan
        {
            get { return maDonBan; }
            set { maDonBan = value; }
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public int SoLuongBan
        {
            get { return soLuongBan; }
            set { soLuongBan = value; }
        }
        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public int ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
