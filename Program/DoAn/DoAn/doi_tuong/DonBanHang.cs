using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class DonBanHang
    {
        string maDonBan, maNV, maKH;
        string ngayBan;
        int soLuongBan, tongTien;

        public DonBanHang()
        {

        }
        public DonBanHang(string maDonBan, string maNV, string maKH, string ngayBan, int soLuongBan, int tongTien)
        {
            this.maDonBan = maDonBan;
            this.maNV = maNV;
            this.maKH = maKH;
            this.ngayBan = ngayBan;
            this.soLuongBan = soLuongBan;
            this.tongTien = tongTien;
        }
        public string MaDonBan
        {
            get { return maDonBan; }
            set { maDonBan = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        public int SoLuongBan
        {
            get { return soLuongBan; }
            set { soLuongBan = value; }
        }
        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
