using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.gui;
using DoAn.dao_xu_ly;
using DoAn.doi_tuong;
using System.IO;

namespace DoAn
{
    public partial class userThongTinSach : UserControl
    {
        ToolStripProgressBar progress;
        ToolStripLabel label;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        int id_role;
        public userThongTinSach()
        {
            InitializeComponent();
            load_data();
            show_CT_Sach();
        }

        public userThongTinSach(string a, ToolStripProgressBar progress, ToolStripLabel lbl, int id_role)
        {
            InitializeComponent();
            load_data();
            show_CT_Sach();
            this.progress = progress;
            this.label = lbl;
            this.id_role = id_role;
        }

        public void load_data()
        {
            dataGridView_ThongTinSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ThongTinSach.AutoGenerateColumns = false;
            dataGridView_ThongTinSach.AllowUserToAddRows = false;

            dataGridView_ThongTinSach.DataSource = Sach_DAO.get_info_ThongTinSach();
            dataGridView_ThongTinSach.Columns[0].DataPropertyName = "tenSach";
            dataGridView_ThongTinSach.Columns[1].DataPropertyName = "tacGia";
            dataGridView_ThongTinSach.Columns[2].DataPropertyName = "nhaXB";
            dataGridView_ThongTinSach.Columns[3].DataPropertyName = "namXB";
            dataGridView_ThongTinSach.Columns[4].DataPropertyName = "theLoai";
            dataGridView_ThongTinSach.Columns[5].DataPropertyName = "giaBan";
            dataGridView_ThongTinSach.Columns[6].DataPropertyName = "SoLuongTon";
            dataGridView_ThongTinSach.Columns[7].DataPropertyName = "maSach";
            dataGridView_ThongTinSach.Columns[8].DataPropertyName = "anhSach";
            dataGridView_ThongTinSach.Columns[7].Visible = false;
            
            for (int i = 0; i < dataGridView_ThongTinSach.Rows.Count; i++)
            {
                if (dataGridView_ThongTinSach.Rows[i].Cells[5].Value.ToString().Equals(""))
                {
                    dataGridView_ThongTinSach.Rows[i].Cells[5].Value = 0;
                }
            }
        }

        private void dataGridView_ThongTinSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridView_ThongTinSach.CurrentRow.Index;
            txtMaSach.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[7].Value.ToString();
            txtTenSach.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[0].Value.ToString();
            txtTG.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[1].Value.ToString();
            txtNXB.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[2].Value.ToString();
            txtNamXB.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[3].Value.ToString();
            txtTheloai.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[4].Value.ToString();
            txtGiaBan.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[5].Value.ToString();
            txtTonKho.Text = dataGridView_ThongTinSach.Rows[rsl].Cells[6].Value.ToString();
            picAnhSach.Image = Image.FromFile(projectPath + dataGridView_ThongTinSach.Rows[rsl].Cells[8].Value.ToString());
        }

        private void btnCapNhatThongTinSach_Click(object sender, EventArgs e)
        {
            int rsl = dataGridView_ThongTinSach.CurrentRow.Index;
            ThongTinSach sach = new ThongTinSach();
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.TacGia = txtTG.Text;
            sach.NhaXB = txtNXB.Text;
            sach.NamXB = int.Parse(txtNamXB.Text);
            sach.TheLoai = txtTheloai.Text;
            sach.GiaBan = int.Parse(txtGiaBan.Text);
            sach.SoLuongTon = int.Parse(txtTonKho.Text);
            sach.AnhSach = dataGridView_ThongTinSach.Rows[rsl].Cells[8].Value.ToString();


            frmCN_Sach cn = new frmCN_Sach(sach, progress, label, this.id_role);
            cn.Show();
            load_data();
        }

        private void show_CT_Sach()
        {
            txtMaSach.Text = dataGridView_ThongTinSach.Rows[0].Cells[7].Value.ToString();
            txtTenSach.Text = dataGridView_ThongTinSach.Rows[0].Cells[0].Value.ToString();
            txtTG.Text = dataGridView_ThongTinSach.Rows[0].Cells[1].Value.ToString();
            txtNXB.Text = dataGridView_ThongTinSach.Rows[0].Cells[2].Value.ToString();
            txtNamXB.Text = dataGridView_ThongTinSach.Rows[0].Cells[3].Value.ToString();
            txtTheloai.Text = dataGridView_ThongTinSach.Rows[0].Cells[4].Value.ToString();
            txtGiaBan.Text = dataGridView_ThongTinSach.Rows[0].Cells[5].Value.ToString();
            txtTonKho.Text = dataGridView_ThongTinSach.Rows[0].Cells[6].Value.ToString();
            string f = projectPath + dataGridView_ThongTinSach.Rows[0].Cells[8].Value.ToString();
            picAnhSach.Image = Image.FromFile(f, true);
        }
    }
}
