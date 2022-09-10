using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn.dao_xu_ly;

namespace DoAn.gui
{
    public partial class frmXN_DieuKien : Form
    {
        int soLuong = 0;
        string sodt_kh = "";
        bool check = false;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
          public string MaKH
        {
            get { return sodt_kh; }
            set { sodt_kh= value; }
        }
        public string TenKH { get; set; }

        public frmXN_DieuKien()
        {
            InitializeComponent();
        }

        public frmXN_DieuKien(bool check_kh_or_sl)
        {
            check = check_kh_or_sl;
            if (check)
            {
                InitializeComponent();
                this.Text = "Nhập mã khách hàng";
                lblNhapSoLuong.Text = "Số ĐT khách hàng:";
                btnThemKH.Visible = true;
            }   
            else
            {
                InitializeComponent();
            }
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (check)
            {
                MaKH = KhachHang_DAO.get_MaKH(txtXN.Text);
                TenKH = KhachHang_DAO.get_TenKH(txtXN.Text);
                this.Close();
            }
            else
            {
                try
                {
                    SoLuong = int.Parse(txtXN.Text.Trim());
                    if (SoLuong <= 0)
                    {
                        KryptonMessageBox.Show("Hãy nhập số lượng lớn hơn 0 !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtXN.Focus();
                        txtXN.SelectAll();
                        return;
                    }
                    this.Close();
                }
                catch
                {
                    KryptonMessageBox.Show("Hãy nhập số lượng là số và lớn hơn 0 !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtXN.Focus();
                    txtXN.SelectAll();
                    return;
                }
            }
        }

        private void frmSoLuongMua_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmAdd_KH them = new frmAdd_KH();
            them.ShowDialog();
            txtXN.Text = them.Makh;
        }
    }
}
