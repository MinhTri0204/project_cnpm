using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class KhachHang
    {
        string maKH, tenKH, sdtKH, emailKH, diaChi, tinhTrang;
        public KhachHang()
        {

        }
        public KhachHang(string maKH, string tenKH, string sdtKH, string emailKH, string diaChi, string tinhTrang)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdtKH = sdtKH;
            this.emailKH = emailKH;
            this.diaChi = diaChi;
            this.tinhTrang = tinhTrang;
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public string SdtKH
        {
            get { return sdtKH; }
            set { sdtKH = value; }
        }
        public string EmailKH
        {
            get { return emailKH; }
            set { emailKH = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
    }
}
