using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_DOTNET.doi_tuong
{
    class TonKho
    {
        string maSach;
        int soLuongTon;
        public TonKho()
        {

        }
        public TonKho(string maSach, int soLuongTon)
        {
            this.maSach = maSach;
            this.soLuongTon = soLuongTon;
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
    }
}
