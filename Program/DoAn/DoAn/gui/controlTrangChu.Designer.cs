
namespace DoAn.gui
{
    partial class controlTrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlTrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbkGiaBan = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cboGiaBan = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTimKiemSach = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridTrangChuSach = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridDS_mua = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnHuyDon = new System.Windows.Forms.ToolStripButton();
            this.btnGioHang = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemSach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrangChuSach)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDS_mua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 101);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Controls.Add(this.cbkGiaBan);
            this.panel2.Controls.Add(this.cboGiaBan);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.txtTimKiemSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 53);
            this.panel2.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.kryptonButton1.Location = new System.Drawing.Point(713, 8);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(54, 36);
            this.kryptonButton1.TabIndex = 11;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.btnTimKiemSach_Click);
            // 
            // cbkGiaBan
            // 
            this.cbkGiaBan.Location = new System.Drawing.Point(435, 16);
            this.cbkGiaBan.Name = "cbkGiaBan";
            this.cbkGiaBan.Size = new System.Drawing.Size(80, 24);
            this.cbkGiaBan.TabIndex = 10;
            this.cbkGiaBan.Values.Text = "Giá bán:";
            // 
            // cboGiaBan
            // 
            this.cboGiaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaBan.DropDownWidth = 173;
            this.cboGiaBan.Items.AddRange(new object[] {
            "< 10,000",
            "> 10,000",
            "> 50,000",
            "> 100,000",
            "> 200,000"});
            this.cboGiaBan.Location = new System.Drawing.Point(534, 14);
            this.cboGiaBan.Name = "cboGiaBan";
            this.cboGiaBan.Size = new System.Drawing.Size(173, 25);
            this.cboGiaBan.TabIndex = 9;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "Tìm kiếm:";
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimKiemSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTimKiemSach.DropDownWidth = 287;
            this.txtTimKiemSach.FormattingEnabled = true;
            this.txtTimKiemSach.Location = new System.Drawing.Point(112, 14);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(287, 25);
            this.txtTimKiemSach.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload,
            this.btnHuyDon,
            this.btnGioHang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1329, 48);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridTrangChuSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1329, 692);
            this.panel3.TabIndex = 3;
            // 
            // gridTrangChuSach
            // 
            this.gridTrangChuSach.AllowUserToAddRows = false;
            this.gridTrangChuSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTrangChuSach.ColumnHeadersHeight = 50;
            this.gridTrangChuSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column13});
            this.gridTrangChuSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTrangChuSach.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.gridTrangChuSach.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.gridTrangChuSach.Location = new System.Drawing.Point(0, 0);
            this.gridTrangChuSach.Name = "gridTrangChuSach";
            this.gridTrangChuSach.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.gridTrangChuSach.ReadOnly = true;
            this.gridTrangChuSach.RowHeadersWidth = 51;
            this.gridTrangChuSach.RowTemplate.Height = 30;
            this.gridTrangChuSach.Size = new System.Drawing.Size(1329, 692);
            this.gridTrangChuSach.TabIndex = 1;
            this.gridTrangChuSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTrangChuSach_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenSach";
            this.Column1.HeaderText = "Tên sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tacGia";
            this.Column2.HeaderText = "Tác giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NhaXB";
            this.Column3.HeaderText = "Nhà xuất bản";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "namXB";
            this.Column4.HeaderText = "Năm xuất bản";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "theLoai";
            this.Column5.HeaderText = "Thể loại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "giaBan";
            this.Column6.HeaderText = "Giá bán";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "maSach";
            this.Column7.HeaderText = "Mã sách";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "anhSach";
            this.Column13.HeaderText = "Ảnh bìa";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column13.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridDS_mua);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 762);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1329, 31);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // dataGridDS_mua
            // 
            this.dataGridDS_mua.AllowUserToAddRows = false;
            this.dataGridDS_mua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDS_mua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDS_mua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridDS_mua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDS_mua.Location = new System.Drawing.Point(0, 0);
            this.dataGridDS_mua.Name = "dataGridDS_mua";
            this.dataGridDS_mua.ReadOnly = true;
            this.dataGridDS_mua.RowHeadersWidth = 51;
            this.dataGridDS_mua.RowTemplate.Height = 24;
            this.dataGridDS_mua.Size = new System.Drawing.Size(1329, 31);
            this.dataGridDS_mua.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã sách";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tên sách";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Số lượng";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Giá bán";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Thành tiền";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(34, 45);
            this.btnReload.Text = "Tải dữ liệu";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHuyDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDon.Image")));
            this.btnHuyDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyDon.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(29, 45);
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btnGioHang.Image")));
            this.btnGioHang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGioHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGioHang.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(34, 45);
            this.btnGioHang.Text = "Giỏ hàng";
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // controlTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "controlTrangChu";
            this.Size = new System.Drawing.Size(1329, 793);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemSach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrangChuSach)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDS_mua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cbkGiaBan;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboGiaBan;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox txtTimKiemSach;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnHuyDon;
        private System.Windows.Forms.ToolStripButton btnGioHang;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridTrangChuSach;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridDS_mua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}
