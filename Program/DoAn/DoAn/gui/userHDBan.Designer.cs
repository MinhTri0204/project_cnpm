
namespace DoAn
{
    partial class userHDBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userHDBan));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_HDban = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTKKH_NV = new System.Windows.Forms.TextBox();
            this.radMa_Ban = new System.Windows.Forms.RadioButton();
            this.dataNgayLapDon = new System.Windows.Forms.DateTimePicker();
            this.radNgayBan = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.elipseControl1 = new DoAn.gui.ElipseControl();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDban)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 920);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1548, 39);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1548, 920);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_HDban);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1548, 817);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView_HDban
            // 
            this.dataGridView_HDban.AllowUserToAddRows = false;
            this.dataGridView_HDban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HDban.ColumnHeadersHeight = 50;
            this.dataGridView_HDban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_HDban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HDban.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dataGridView_HDban.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.dataGridView_HDban.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_HDban.Name = "dataGridView_HDban";
            this.dataGridView_HDban.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.dataGridView_HDban.ReadOnly = true;
            this.dataGridView_HDban.RowHeadersWidth = 51;
            this.dataGridView_HDban.RowTemplate.Height = 30;
            this.dataGridView_HDban.Size = new System.Drawing.Size(1548, 817);
            this.dataGridView_HDban.TabIndex = 3;
            this.dataGridView_HDban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HDban_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maDonBan";
            this.Column1.HeaderText = "Mã đơn bán";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenKH";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayBan";
            this.Column4.HeaderText = "Ngày bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "soLuong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tongTien";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTKKH_NV);
            this.panel1.Controls.Add(this.radMa_Ban);
            this.panel1.Controls.Add(this.dataNgayLapDon);
            this.panel1.Controls.Add(this.radNgayBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 58);
            this.panel1.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1006, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btnTimKiem.Size = new System.Drawing.Size(171, 46);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Values.Image")));
            this.btnTimKiem.Values.Text = "TÌM KIẾM";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTKKH_NV
            // 
            this.txtTKKH_NV.Location = new System.Drawing.Point(763, 13);
            this.txtTKKH_NV.Name = "txtTKKH_NV";
            this.txtTKKH_NV.Size = new System.Drawing.Size(225, 30);
            this.txtTKKH_NV.TabIndex = 6;
            // 
            // radMa_Ban
            // 
            this.radMa_Ban.AutoSize = true;
            this.radMa_Ban.Location = new System.Drawing.Point(437, 15);
            this.radMa_Ban.Name = "radMa_Ban";
            this.radMa_Ban.Size = new System.Drawing.Size(286, 27);
            this.radMa_Ban.TabIndex = 5;
            this.radMa_Ban.Text = "Thông tin Khách hàng_Nhân viên";
            this.radMa_Ban.UseVisualStyleBackColor = true;
            this.radMa_Ban.CheckedChanged += new System.EventHandler(this.radMaKH_CheckedChanged);
            // 
            // dataNgayLapDon
            // 
            this.dataNgayLapDon.Enabled = false;
            this.dataNgayLapDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNgayLapDon.Location = new System.Drawing.Point(179, 13);
            this.dataNgayLapDon.Name = "dataNgayLapDon";
            this.dataNgayLapDon.Size = new System.Drawing.Size(225, 30);
            this.dataNgayLapDon.TabIndex = 4;
            // 
            // radNgayBan
            // 
            this.radNgayBan.AutoSize = true;
            this.radNgayBan.Location = new System.Drawing.Point(21, 15);
            this.radNgayBan.Name = "radNgayBan";
            this.radNgayBan.Size = new System.Drawing.Size(134, 27);
            this.radNgayBan.TabIndex = 3;
            this.radNgayBan.Text = "Ngày lập đơn";
            this.radNgayBan.UseVisualStyleBackColor = true;
            this.radNgayBan.CheckedChanged += new System.EventHandler(this.radNgayLapDon_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1548, 45);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(34, 42);
            this.btnReload.Text = "toolStripButton1";
            this.btnReload.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 35;
            this.elipseControl1.TargetControl = this.btnTimKiem;
            // 
            // userHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "userHDBan";
            this.Size = new System.Drawing.Size(1548, 959);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDban)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTKKH_NV;
        private System.Windows.Forms.RadioButton radMa_Ban;
        private System.Windows.Forms.DateTimePicker dataNgayLapDon;
        private System.Windows.Forms.RadioButton radNgayBan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView_HDban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private gui.ElipseControl elipseControl1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
    }
}
