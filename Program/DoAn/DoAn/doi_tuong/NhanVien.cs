using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class NhanVien
    {
        string taiKhoan, matKhau, maNV, tenNV;
        string ngaySinh, gioiTinh;
        string sdtNV, emailNV;
        string anhNV;
        int id_role;

        public NhanVien()
        {

        }

        public NhanVien(string taiKhoan, string matKhau, string maNV, string tenNV, string ngaySinh, string gioiTinh, string sdtNV,
            string emailNV, string anhNV, int id_role)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sdtNV = sdtNV;
            this.emailNV = emailNV;
            this.anhNV = anhNV;
            this.id_role = id_role;
        }
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string SdtNV
        {
            get { return sdtNV; }
            set { sdtNV = value; }
        }
        public string EmailNV
        {
            get { return emailNV; }
            set { emailNV = value; }
        }
        public string AnhNV
        {
            get { return anhNV; }
            set { anhNV = value; }
        }
        public int ID_ROEL
        {
            get { return id_role; }
            set { id_role = value; }
        }

    }
}


