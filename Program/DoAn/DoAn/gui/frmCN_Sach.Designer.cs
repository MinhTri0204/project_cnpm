
namespace DoAn.gui
{
    partial class frmCN_Sach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCN_Sach));
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.picAnhSach = new System.Windows.Forms.PictureBox();
            this.openAnh = new System.Windows.Forms.OpenFileDialog();
            this.btnThoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTenSach = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTacGia = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNXB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtGiaBan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTonKho = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTheloai = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNamXB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(235, 224);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(64, 30);
            this.txtMaSach.TabIndex = 21;
            this.txtMaSach.Visible = false;
            // 
            // picAnhSach
            // 
            this.picAnhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picAnhSach.Location = new System.Drawing.Point(21, 17);
            this.picAnhSach.Name = "picAnhSach";
            this.picAnhSach.Size = new System.Drawing.Size(208, 248);
            this.picAnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhSach.TabIndex = 22;
            this.picAnhSach.TabStop = false;
            this.picAnhSach.Click += new System.EventHandler(this.picAnhSach_Click);
            // 
            // openAnh
            // 
            this.openAnh.FileName = "openFileDialog1";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(414, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 45);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Values.Image")));
            this.btnThoat.Values.Text = "ĐÓNG";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(241, 29);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 24);
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(360, 26);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtTenSach.Size = new System.Drawing.Size(451, 27);
            this.txtTenSach.TabIndex = 26;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(241, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel2.Size = new System.Drawing.Size(67, 24);
            this.kryptonLabel2.TabIndex = 25;
            this.kryptonLabel2.Values.Text = "Tác giả:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(360, 60);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtTacGia.Size = new System.Drawing.Size(451, 27);
            this.txtTacGia.TabIndex = 26;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(241, 97);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel3.Size = new System.Drawing.Size(113, 24);
            this.kryptonLabel3.TabIndex = 25;
            this.kryptonLabel3.Values.Text = "Nhà xuất bản:";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(360, 94);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtNXB.Size = new System.Drawing.Size(451, 27);
            this.txtNXB.TabIndex = 26;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(241, 165);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel4.Size = new System.Drawing.Size(71, 24);
            this.kryptonLabel4.TabIndex = 25;
            this.kryptonLabel4.Values.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(360, 162);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtGiaBan.Size = new System.Drawing.Size(178, 27);
            this.txtGiaBan.TabIndex = 26;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(554, 165);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel5.Size = new System.Drawing.Size(75, 24);
            this.kryptonLabel5.TabIndex = 25;
            this.kryptonLabel5.Values.Text = "Tồn kho:";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(633, 162);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtTonKho.ReadOnly = true;
            this.txtTonKho.Size = new System.Drawing.Size(178, 27);
            this.txtTonKho.TabIndex = 26;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(554, 130);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel6.Size = new System.Drawing.Size(73, 24);
            this.kryptonLabel6.TabIndex = 25;
            this.kryptonLabel6.Values.Text = "Thể loại:";
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(633, 127);
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtTheloai.Size = new System.Drawing.Size(178, 27);
            this.txtTheloai.TabIndex = 26;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(241, 131);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel7.Size = new System.Drawing.Size(118, 24);
            this.kryptonLabel7.TabIndex = 25;
            this.kryptonLabel7.Values.Text = "Năm xuất bản:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(360, 128);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtNamXB.Size = new System.Drawing.Size(178, 27);
            this.txtNamXB.TabIndex = 26;
            // 
            // btnCN
            // 
            this.btnCN.Location = new System.Drawing.Point(623, 220);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(188, 45);
            this.btnCN.TabIndex = 24;
            this.btnCN.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCN.Values.Image")));
            this.btnCN.Values.Text = "CẬP NHẬT";
            this.btnCN.Click += new System.EventHandler(this.btnCapNhatThongTinSach_Click);
            // 
            // frmCN_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(823, 286);
            this.Controls.Add(this.txtTheloai);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.picAnhSach);
            this.Controls.Add(this.txtMaSach);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCN_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin sách";
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnhSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.OpenFileDialog openAnh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThoat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenSach;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTacGia;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNXB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGiaBan;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTonKho;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTheloai;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNamXB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCN;
    }
}