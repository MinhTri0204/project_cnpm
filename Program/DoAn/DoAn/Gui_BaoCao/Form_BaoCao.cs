using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Gui_BaoCao
{
    public partial class Form_BaoCao : Form
    {
        public Form_BaoCao()
        {
            InitializeComponent();
        }
        public Form_BaoCao(string forname, DataTable dulieu)
        {
            InitializeComponent();
            if(forname=="QUI1")
            {
               
               XL_BaoCao.BaoCaoTheoQui1 bc = new XL_BaoCao.BaoCaoTheoQui1();
                bc.SetDataSource(dulieu);             
                bc.SetParameterValue("nguoilap", gui.frmDangNhap.UserName); 
                FromBaoCao.ReportSource = bc;
            }
            else
                if (forname == "QUI2")
                {
                    XL_BaoCao.BaoCaoTheoQui2 bc = new XL_BaoCao.BaoCaoTheoQui2();
                    bc.SetDataSource(dulieu);
                    bc.SetParameterValue("nguoilap", gui.frmDangNhap.UserName);
                    FromBaoCao.ReportSource = bc;
                }
                else
                    if (forname == "NGAY")
                    {
                        XL_BaoCao.BaocaoTheoNgay bc = new XL_BaoCao.BaocaoTheoNgay();
                        bc.SetDataSource(dulieu);
                        bc.SetParameterValue("nguoilap", gui.frmDangNhap.UserName);
                        FromBaoCao.ReportSource = bc;
                    }
                    else
                        if (forname == "THANG")
                        {   
                            XL_BaoCao.BaoCaoTheoThang bc = new XL_BaoCao.BaoCaoTheoThang();
                            bc.SetDataSource(dulieu);
                            bc.SetParameterValue("nguoilap", gui.frmDangNhap.UserName);
                            FromBaoCao.ReportSource = bc;
                            }
                        else
                            if (forname == "THANHTOAN")
                            {
                                XL_BaoCao.HoaDonThanhToan bc = new XL_BaoCao.HoaDonThanhToan();
                                bc.SetDataSource(dulieu);
                                bc.SetParameterValue("nguoilap", gui.frmDangNhap.UserName);
                                FromBaoCao.ReportSource = bc;
                            }
                            else
                                if (forname == "HOADONNHAP")
                                {
                                    XL_BaoCao.HoaDonNhapSachVao bc = new XL_BaoCao.HoaDonNhapSachVao();
                                    bc.SetDataSource(dulieu);
                                    bc.SetParameterValue("nguoilap", gui.frmDangNhap.UserName);
                                    FromBaoCao.ReportSource = bc;
                                }


            
        }

        private void Form_BaoCao_Load(object sender, EventArgs e)
        {

        }

        private void FromBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
