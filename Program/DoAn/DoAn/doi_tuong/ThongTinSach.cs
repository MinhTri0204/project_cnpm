using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class ThongTinSach
    {
        string maSach, tenSach, tacGia, nhaXB, theLoai, anhSach;
        int namXB, giaBan, soLuongTon;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public ThongTinSach()
        {

        }
        public ThongTinSach(string maSach, string tenSach, string tacGia, string nhaXB, int namXB, string theLoai, int giaBan, int soLuongTon, string anhSach)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.nhaXB = nhaXB;
            this.namXB = namXB;
            this.theLoai = theLoai;
            this.giaBan = giaBan;
            this.soLuongTon = soLuongTon;
            this.anhSach = anhSach;
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        public string NhaXB
        {
            get { return nhaXB; }
            set { nhaXB = value; }
        }
        public string TheLoai
        {
            get { return theLoai; }
            set { theLoai = value; }
        }
        public int NamXB
        {
            get { return namXB; }
            set { namXB = value; }
        }
        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        public string AnhSach
        {
            get { return anhSach; }
            set { anhSach = value; }
        }
    }
}
