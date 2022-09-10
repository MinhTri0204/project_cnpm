using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.doi_tuong;
using System.Threading;
using DoAn.dao_xu_ly;
using ComponentFactory.Krypton.Toolkit;

namespace DoAn.gui
{
    public partial class frmDMK : Form
    {
        NhanVien nv;
        ToolStripProgressBar progress;
        ToolStripLabel lbl;
        public frmDMK()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            lblMaNV.BackColor = Color.Transparent;
            lblTenNV.BackColor = Color.Transparent;
            pnDN.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        internal frmDMK(NhanVien nv, ToolStripProgressBar progress, ToolStripLabel lbl)
        {
            this.nv = nv;
            this.progress = progress;
            this.lbl = lbl;

            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            lblMaNV.BackColor = Color.Transparent;
            lblTenNV.BackColor = Color.Transparent;
            pnDN.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void frmDMK_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = nv.MaNV;
            lblTenNV.Text = nv.TenNV;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Bạn có muốn Hủy bỏ thao tác ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            this.Close();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtMatKhau.Text, txtXNMatKhau.Text) != 0)
            {
                KryptonMessageBox.Show("Mật khẩu không khớp !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                if (KryptonMessageBox.Show("Bạn có muốn thay đổi mật khẩu không !", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                if (NhanVien_DAO.doi_mat_khau(txtXNMatKhau.Text, lblMaNV.Text))
                {
                    progress.Visible = true;
                    lbl.Text = "";
                    for (int i = progress.Minimum; i <= progress.Maximum; i += 10)
                    {
                        progress.Value = i;
                        Thread.Sleep(200);
                    }
                    progress.Value = 0;
                    progress.Visible = false;
                    lbl.Text = "Success";

                    KryptonMessageBox.Show("Thay đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    progress.Visible = true;
                    lbl.Text = "";
                    for (int i = progress.Minimum; i <= progress.Maximum; i += 10)
                    {
                        progress.Value = i;
                        Thread.Sleep(200);
                    }
                    progress.Value = 0;
                    progress.Visible = false;
                    lbl.Text = "Success";

                    KryptonMessageBox.Show("Thay đổi mật khẩu KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
