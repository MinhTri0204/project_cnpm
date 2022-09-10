using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.dao_xu_ly;

namespace DoAn.gui
{
    public partial class CT_HoaDon : MetroFramework.Forms.MetroForm
    {
        public CT_HoaDon()
        {
            InitializeComponent();
        }

        internal CT_HoaDon(DataTable data, bool check)
        {
            InitializeComponent();
            
            //true -> CT_DONBAN
            if (check)
            {
                data_CT_HD.DataSource = data;
                data_CT_HD.Columns[0].DataPropertyName = "maDonBan";
                data_CT_HD.Columns[1].DataPropertyName = "tenSach";
                data_CT_HD.Columns[2].DataPropertyName = "soLuong";
                data_CT_HD.Columns[3].DataPropertyName = "DonGiaBan";
                data_CT_HD.Columns[4].DataPropertyName = "TongTien";
                data_CT_HD.Columns[0].Visible = false;

                data_CT_HD.Columns[0].HeaderText = "Mã hóa đơn";
                data_CT_HD.Columns[1].HeaderText = "Tên sản phẩm";
                data_CT_HD.Columns[2].HeaderText = "Số lượng";
                data_CT_HD.Columns[3].HeaderText = "Đơn giá";
                data_CT_HD.Columns[4].HeaderText = "Tổng tiền";
            }
            //false -> CT_DONNHAP
            else
            {
                data_CT_HD.DataSource = data;
                data_CT_HD.Columns[0].DataPropertyName = "maDonNhap";
                data_CT_HD.Columns[1].DataPropertyName = "tenSach";
                data_CT_HD.Columns[2].DataPropertyName = "soLuongNhap";
                data_CT_HD.Columns[3].DataPropertyName = "giaNhap";
                data_CT_HD.Columns[4].DataPropertyName = "thanhtien";
                data_CT_HD.Columns[0].Visible = false;

                data_CT_HD.Columns[0].HeaderText = "Mã hóa đơn";
                data_CT_HD.Columns[1].HeaderText = "Tên sản phẩm";
                data_CT_HD.Columns[2].HeaderText = "Số lượng";
                data_CT_HD.Columns[3].HeaderText = "Đơn giá";
                data_CT_HD.Columns[4].HeaderText = "Tổng tiền";
            }
        }
    }
}
