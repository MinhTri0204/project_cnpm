using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.doi_tuong
{
    class NhaCungCap
    {
        string maNCC, tenNCC, sdtNCC, emailNCC, diaChi;

        public NhaCungCap()
        {

        }
        public NhaCungCap(string maNCC, string tenNCC, string sdtNCC, string emailNCC, string diaChi)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.sdtNCC = sdtNCC;
            this.emailNCC = emailNCC;
            this.diaChi = diaChi;
        }
        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        public string SdtNCC
        {
            get { return sdtNCC; }
            set { sdtNCC = value; }
        }
        public string EmailNCC
        {
            get { return emailNCC; }
            set { emailNCC = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
    }
}
