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
using DoAn.doi_tuong;

namespace DoAn.gui
{
    public partial class controlThongTinSach : UserControl
    {
        DataTable dt_DS_Sach, dt_DS_Sach_Coppy;
        ToolStripProgressBar progress;
        ToolStripLabel label;
        int id_role;
        public controlThongTinSach()
        {
            InitializeComponent();
        }

        public controlThongTinSach(string a, ToolStripProgressBar progress, ToolStripLabel lbl, int id_role)
        {
            InitializeComponent();
            load_data();
            load_combobox();
            dt_DS_Sach = Sach_DAO.get_info_ThongTinSach();
            dt_DS_Sach_Coppy = dt_DS_Sach.Copy();
            //show_CT_Sach();
            this.progress = progress;
            this.label = lbl;
            this.id_role = id_role;
        }

        public void load_data()
        {
            dataSach.AutoGenerateColumns = false;
            dataSach.AllowUserToAddRows = false;

            dataSach.DataSource = Sach_DAO.get_info_ThongTinSach();


            for (int i = 0; i < dataSach.Rows.Count; i++)
            {
                if (dataSach.Rows[i].Cells[6].Value.ToString().Equals(""))
                {
                    dataSach.Rows[i].Cells[6].Value = 0;
                }
            }
            dt_DS_Sach = Sach_DAO.get_info_ThongTinSach();
            dt_DS_Sach_Coppy = dt_DS_Sach.Copy();
        }

        public void load_combobox()
        {
            for (int i = 0; i < dataSach.Rows.Count; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cboTK.Items.Add(dataSach.Rows[i].Cells[j].Value.ToString());
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Dòng được chọn
            int id = dataSach.CurrentRow.Index;
            //Lấy thông tin sách hiển thị lên form CT
            ThongTinSach sach = new ThongTinSach();
            sach.MaSach = dataSach.Rows[id].Cells[0].Value.ToString();
            sach.TenSach = dataSach.Rows[id].Cells[1].Value.ToString();
            sach.TacGia = dataSach.Rows[id].Cells[2].Value.ToString();
            sach.NhaXB = dataSach.Rows[id].Cells[3].Value.ToString();
            sach.NamXB = int.Parse(dataSach.Rows[id].Cells[4].Value.ToString());
            sach.TheLoai = dataSach.Rows[id].Cells[5].Value.ToString();
            sach.GiaBan = int.Parse(dataSach.Rows[id].Cells[6].Value.ToString());
            sach.SoLuongTon = int.Parse(dataSach.Rows[id].Cells[7].Value.ToString());
            sach.AnhSach = dataSach.Rows[id].Cells[8].Value.ToString();

            frmCN_Sach cn_sach = new frmCN_Sach(sach, progress, label, id_role);
            cn_sach.ShowDialog();

            load_data();
        }

        private void dataSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dòng được chọn
            int id = dataSach.CurrentRow.Index;
            //Lấy thông tin sách hiển thị lên form CT
            ThongTinSach sach = new ThongTinSach();
            sach.MaSach = dataSach.Rows[id].Cells[0].Value.ToString();
            sach.TenSach = dataSach.Rows[id].Cells[1].Value.ToString();
            sach.TacGia = dataSach.Rows[id].Cells[2].Value.ToString();
            sach.NhaXB = dataSach.Rows[id].Cells[3].Value.ToString();
            sach.NamXB = int.Parse(dataSach.Rows[id].Cells[4].Value.ToString());
            sach.TheLoai = dataSach.Rows[id].Cells[5].Value.ToString();
            sach.GiaBan = int.Parse(dataSach.Rows[id].Cells[6].Value.ToString());
            sach.SoLuongTon = int.Parse(dataSach.Rows[id].Cells[7].Value.ToString());
            sach.AnhSach = dataSach.Rows[id].Cells[8].Value.ToString();

            frmCN_Sach cn_sach = new frmCN_Sach(sach, progress, label, id_role);
            cn_sach.ShowDialog();

            load_data();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string dk_tk = cboTK.Text.ToUpper();

            dt_DS_Sach_Coppy.Rows.Clear();
            foreach (DataRow r in dt_DS_Sach.Rows)
            {
                string dk1 = r[1].ToString().Trim().ToUpper();
                string dk2 = r[2].ToString().Trim().ToUpper();
                string dk3 = r[3].ToString().Trim().ToUpper();
                string dk4 = r[4].ToString().Trim().ToUpper();
                string dk5 = r[5].ToString().Trim().ToUpper();
                string dk6 = r[6].ToString().Trim().ToUpper();
                string dk7 = r[7].ToString().Trim().ToUpper();
                
                if (dk1.Contains(dk_tk) || dk2.Contains(dk_tk) || dk3.Contains(dk_tk) || dk4.Contains(dk_tk) 
                    || dk5.Contains(dk_tk) || dk6.Contains(dk_tk) || dk7.Contains(dk_tk))
                {
                    DataRow new_r = dt_DS_Sach_Coppy.NewRow();
                    new_r[0] = r[0];
                    new_r[1] = r[1];
                    new_r[2] = r[2];
                    new_r[3] = r[3];
                    new_r[4] = r[4];
                    new_r[5] = r[5];
                    new_r[6] = r[6];
                    new_r[7] = r[7];
                    new_r[8] = r[8];


                    dt_DS_Sach_Coppy.Rows.Add(new_r);
                }

                dataSach.DataSource = dt_DS_Sach_Coppy;
            }
        }
    }
}
