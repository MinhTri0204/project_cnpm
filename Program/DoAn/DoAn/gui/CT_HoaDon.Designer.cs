
namespace DoAn.gui
{
    partial class CT_HoaDon
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
            this.data_CT_HD = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_CT_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // data_CT_HD
            // 
            this.data_CT_HD.AllowUserToAddRows = false;
            this.data_CT_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_CT_HD.ColumnHeadersHeight = 35;
            this.data_CT_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_CT_HD.Location = new System.Drawing.Point(20, 60);
            this.data_CT_HD.Name = "data_CT_HD";
            this.data_CT_HD.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.data_CT_HD.RowHeadersWidth = 51;
            this.data_CT_HD.RowTemplate.Height = 30;
            this.data_CT_HD.Size = new System.Drawing.Size(833, 268);
            this.data_CT_HD.TabIndex = 0;
            // 
            // CT_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 348);
            this.Controls.Add(this.data_CT_HD);
            this.Name = "CT_HoaDon";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.data_CT_HD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView data_CT_HD;
    }
}