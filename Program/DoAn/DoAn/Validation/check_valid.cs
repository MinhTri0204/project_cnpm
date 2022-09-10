using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAn.Validation
{
    class check_valid
    {
        internal static bool IsValidYear(string year)
        {
            if (string.IsNullOrEmpty(year))
                return false;
            int y;
            DateTime time = DateTime.Now;
            int nam = time.Year;
            try
            {
                y = int.Parse(year);
                if (y < nam && y > 1500)
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

        internal static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            string s = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            return Regex.IsMatch(email.Trim(), s);
        }

        internal static bool IsNumberPhone_VN(string sdt)
        {
            if (string.IsNullOrEmpty(sdt))
                return false;
            string s = @"^((09(\d){8})|(086(\d){7})|(088(\d){7})|(089(\d){7})|(01(\d){9}))$";
            return Regex.IsMatch(sdt.Trim(), s);
        }

        internal static bool IsValid_HoTen(string hoten)
        {
            if (string.IsNullOrEmpty(hoten))
                return false;
            string s = @"[a-zA-Z\p{L}\s]{1,50}";
            return Regex.IsMatch(hoten.Trim(), s);
        }

        internal static bool IsValid_DC(string dc)
        {
            if (string.IsNullOrEmpty(dc))
                return false;
            string s = @"[a-zA-Z0-9\p{L}\s\:\,\-\.]{1,100}";
            return Regex.IsMatch(dc.Trim(), s);
        }

        internal static bool IsValid_Number(string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;
            string s = @"^[-+]?[0-9]*.?[0-9]+$";
            return Regex.IsMatch(number, s);
        }

        internal static bool IsValid_MA(string ma)
        {
            if (string.IsNullOrEmpty(ma))
                return false;
            string s = @"[A-Z0-9]{1,20}";
            return Regex.IsMatch(ma, s);
        }
    }
}
