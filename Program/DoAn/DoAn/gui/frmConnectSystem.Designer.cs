namespace DoAn.gui
{
    partial class frmConnectSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectSystem));
            this.pnCN = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lbP = new System.Windows.Forms.Label();
            this.lbUID = new System.Windows.Forms.Label();
            this.lbDN = new System.Windows.Forms.Label();
            this.lbSN = new System.Windows.Forms.Label();
            this.pnCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCN
            // 
            this.pnCN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnCN.Controls.Add(this.btnSave);
            this.pnCN.Controls.Add(this.btnTest);
            this.pnCN.Controls.Add(this.txtP);
            this.pnCN.Controls.Add(this.txtUID);
            this.pnCN.Controls.Add(this.txtDN);
            this.pnCN.Controls.Add(this.txtSN);
            this.pnCN.Controls.Add(this.lbP);
            this.pnCN.Controls.Add(this.lbUID);
            this.pnCN.Controls.Add(this.lbDN);
            this.pnCN.Controls.Add(this.lbSN);
            this.pnCN.Location = new System.Drawing.Point(155, 67);
            this.pnCN.Name = "pnCN";
            this.pnCN.Size = new System.Drawing.Size(798, 474);
            this.pnCN.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(410, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.Control;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.Location = new System.Drawing.Point(225, 384);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(171, 43);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "TEST";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(244, 304);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(412, 30);
            this.txtP.TabIndex = 7;
            this.txtP.Text = "123";
            this.txtP.UseSystemPasswordChar = true;
            // 
            // txtUID
            // 
            this.txtUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUID.Location = new System.Drawing.Point(244, 220);
            this.txtUID.Multiline = true;
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(412, 34);
            this.txtUID.TabIndex = 6;
            this.txtUID.Text = "sa";
            // 
            // txtDN
            // 
            this.txtDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDN.Location = new System.Drawing.Point(244, 136);
            this.txtDN.Multiline = true;
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(412, 34);
            this.txtDN.TabIndex = 5;
            this.txtDN.Text = "QL_BSach";
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(244, 57);
            this.txtSN.Multiline = true;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(412, 34);
            this.txtSN.TabIndex = 4;
            this.txtSN.Text = "PHAMTUANDAT\\SERVER";
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP.ForeColor = System.Drawing.SystemColors.Control;
            this.lbP.Location = new System.Drawing.Point(106, 313);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(98, 25);
            this.lbP.TabIndex = 3;
            this.lbP.Text = "Password";
            // 
            // lbUID
            // 
            this.lbUID.AutoSize = true;
            this.lbUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUID.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUID.Location = new System.Drawing.Point(127, 229);
            this.lbUID.Name = "lbUID";
            this.lbUID.Size = new System.Drawing.Size(77, 25);
            this.lbUID.TabIndex = 2;
            this.lbUID.Text = "User ID";
            // 
            // lbDN
            // 
            this.lbDN.AutoSize = true;
            this.lbDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDN.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDN.Location = new System.Drawing.Point(51, 145);
            this.lbDN.Name = "lbDN";
            this.lbDN.Size = new System.Drawing.Size(153, 25);
            this.lbDN.TabIndex = 1;
            this.lbDN.Text = "Database Name";
            // 
            // lbSN
            // 
            this.lbSN.AutoSize = true;
            this.lbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSN.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSN.Location = new System.Drawing.Point(77, 66);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(127, 25);
            this.lbSN.TabIndex = 0;
            this.lbSN.Text = "Server Name";
            // 
            // frmConnectSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 633);
            this.Controls.Add(this.pnCN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConnectSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect System";
            this.pnCN.ResumeLayout(false);
            this.pnCN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbUID;
        private System.Windows.Forms.Label lbDN;
        private System.Windows.Forms.Label lbSN;

    }
}