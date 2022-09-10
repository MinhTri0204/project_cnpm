using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.doi_tuong;

namespace DoAn.gui
{
    public partial class CT_Sach : Form
    {
        bool check_mua;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public CT_Sach()
        {
            InitializeComponent();
        }

        internal CT_Sach(ThongTinSach sach)
        {
            InitializeComponent();
            txtTenSach.Text = sach.TenSach;
            txtTG.Text = sach.TacGia;
            txtNXB.Text = sach.NhaXB;
            txtNamXB.Text = sach.NamXB.ToString();
            txtTL.Text = sach.TheLoai;
            txtGB.Text = sach.GiaBan.ToString();
            //ảnh
            picAnhSach.Image = Image.FromFile(projectPath + sach.AnhSach);
        }

        public bool Check_mua { get => check_mua; set => check_mua = value; }

        private void btnMua_Click(object sender, EventArgs e)
        {
            Check_mua = true;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            check_mua = false;
            this.Close();
        }
    }
}
