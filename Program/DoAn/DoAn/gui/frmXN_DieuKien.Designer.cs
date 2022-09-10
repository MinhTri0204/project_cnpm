
namespace DoAn.gui
{
    partial class frmXN_DieuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXN_DieuKien));
            this.lblNhapSoLuong = new System.Windows.Forms.Label();
            this.txtXN = new System.Windows.Forms.TextBox();
            this.btnXN = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapSoLuong
            // 
            this.lblNhapSoLuong.AutoSize = true;
            this.lblNhapSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSoLuong.Location = new System.Drawing.Point(11, 27);
            this.lblNhapSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapSoLuong.Name = "lblNhapSoLuong";
            this.lblNhapSoLuong.Size = new System.Drawing.Size(146, 28);
            this.lblNhapSoLuong.TabIndex = 0;
            this.lblNhapSoLuong.Text = "Nhập số lượng:";
            // 
            // txtXN
            // 
            this.txtXN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXN.Location = new System.Drawing.Point(164, 24);
            this.txtXN.Name = "txtXN";
            this.txtXN.Size = new System.Drawing.Size(153, 34);
            this.txtXN.TabIndex = 1;
            // 
            // btnXN
            // 
            this.btnXN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXN.Image = ((System.Drawing.Image)(resources.GetObject("btnXN.Image")));
            this.btnXN.Location = new System.Drawing.Point(376, 20);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(174, 42);
            this.btnXN.TabIndex = 2;
            this.btnXN.Text = "XÁC NHẬN";
            this.btnXN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.Image")));
            this.btnThemKH.Location = new System.Drawing.Point(323, 24);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(38, 34);
            this.btnThemKH.TabIndex = 3;
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Visible = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // frmXN_DieuKien
            // 
            this.AcceptButton = this.btnXN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 78);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.txtXN);
            this.Controls.Add(this.lblNhapSoLuong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXN_DieuKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập số lượng mua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSoLuongMua_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapSoLuong;
        private System.Windows.Forms.TextBox txtXN;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.Button btnThemKH;
    }
}