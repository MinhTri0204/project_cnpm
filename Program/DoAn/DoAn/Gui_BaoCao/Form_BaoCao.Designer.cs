namespace DoAn.Gui_BaoCao
{
    partial class Form_BaoCao
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
            this.FromBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FromBaoCao
            // 
            this.FromBaoCao.ActiveViewIndex = -1;
            this.FromBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.FromBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromBaoCao.Location = new System.Drawing.Point(0, 0);
            this.FromBaoCao.Name = "FromBaoCao";
            this.FromBaoCao.Size = new System.Drawing.Size(726, 510);
            this.FromBaoCao.TabIndex = 0;
            this.FromBaoCao.Load += new System.EventHandler(this.FromBaoCao_Load);
            // 
            // Form_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 510);
            this.Controls.Add(this.FromBaoCao);
            this.Name = "Form_BaoCao";
            this.Text = "Form_BaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_BaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FromBaoCao;
    }
}