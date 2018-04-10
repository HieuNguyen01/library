namespace THLTHDTNC04
{
    partial class frmSachTacGia
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btgNhomLenh = new THLTHDTNC04.ButtonGroup();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.scSachTacGia = new System.Windows.Forms.SplitContainer();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtMSNXB = new System.Windows.Forms.TextBox();
            this.txtMSSach = new System.Windows.Forms.TextBox();
            this.txtNhanDeSach = new System.Windows.Forms.TextBox();
            this.pbHinhBia = new System.Windows.Forms.PictureBox();
            this.dgvSachTacGia = new System.Windows.Forms.DataGridView();
            this.MSTacGia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSachTacGia)).BeginInit();
            this.scSachTacGia.Panel1.SuspendLayout();
            this.scSachTacGia.Panel2.SuspendLayout();
            this.scSachTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhBia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(825, 56);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Cyan;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(825, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sách - Tác giả";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 360);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(825, 54);
            this.pnlBottom.TabIndex = 1;
            // 
            // btgNhomLenh
            // 
            this.btgNhomLenh.AddEnabled = true;
            this.btgNhomLenh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btgNhomLenh.AutoNumber = false;
            this.btgNhomLenh.dgv = null;
            this.btgNhomLenh.ds = null;
            this.btgNhomLenh.EditEnabled = true;
            this.btgNhomLenh.Extra2Enabled = true;
            this.btgNhomLenh.Extra2Text = "Phụ trội 2";
            this.btgNhomLenh.Extra2Visible = false;
            this.btgNhomLenh.ExtraEnabled = true;
            this.btgNhomLenh.ExtraText = "Phụ trội";
            this.btgNhomLenh.ExtraVisible = false;
            this.btgNhomLenh.Location = new System.Drawing.Point(103, 13);
            this.btgNhomLenh.Mode = 0;
            this.btgNhomLenh.MsMau = "S";
            this.btgNhomLenh.Name = "btgNhomLenh";
            this.btgNhomLenh.Position = 0;
            this.btgNhomLenh.Reccount = 0;
            this.btgNhomLenh.Size = new System.Drawing.Size(629, 36);
            this.btgNhomLenh.TabIndex = 0;
            this.btgNhomLenh.TableName = "";
            this.btgNhomLenh.Display += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_Display);
            this.btgNhomLenh.AddClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_AddClick);
            this.btgNhomLenh.EditClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_EditClick);
            this.btgNhomLenh.SaveClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_SaveClick);
            this.btgNhomLenh.CancelClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_CancelClick);
            this.btgNhomLenh.DeleteClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_DeleteClick);
            this.btgNhomLenh.PrintClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_PrintClick);
            this.btgNhomLenh.Load += new System.EventHandler(this.btgNhomLenh_Load);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.scSachTacGia);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 56);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(825, 304);
            this.pnlCenter.TabIndex = 2;
            // 
            // scSachTacGia
            // 
            this.scSachTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSachTacGia.Location = new System.Drawing.Point(0, 0);
            this.scSachTacGia.Name = "scSachTacGia";
            // 
            // scSachTacGia.Panel1
            // 
            this.scSachTacGia.Panel1.AccessibleName = "pnlLeft";
            this.scSachTacGia.Panel1.Controls.Add(this.txtSoTrang);
            this.scSachTacGia.Panel1.Controls.Add(this.txtNamXB);
            this.scSachTacGia.Panel1.Controls.Add(this.txtMSNXB);
            this.scSachTacGia.Panel1.Controls.Add(this.txtMSSach);
            this.scSachTacGia.Panel1.Controls.Add(this.txtNhanDeSach);
            this.scSachTacGia.Panel1.Controls.Add(this.pbHinhBia);
            this.scSachTacGia.Panel1MinSize = 320;
            // 
            // scSachTacGia.Panel2
            // 
            this.scSachTacGia.Panel2.AccessibleName = "pnlRight";
            this.scSachTacGia.Panel2.Controls.Add(this.dgvSachTacGia);
            this.scSachTacGia.Size = new System.Drawing.Size(825, 304);
            this.scSachTacGia.SplitterDistance = 364;
            this.scSachTacGia.TabIndex = 0;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(12, 167);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.ReadOnly = true;
            this.txtSoTrang.Size = new System.Drawing.Size(123, 20);
            this.txtSoTrang.TabIndex = 2;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(12, 128);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.ReadOnly = true;
            this.txtNamXB.Size = new System.Drawing.Size(123, 20);
            this.txtNamXB.TabIndex = 2;
            // 
            // txtMSNXB
            // 
            this.txtMSNXB.Location = new System.Drawing.Point(12, 90);
            this.txtMSNXB.Name = "txtMSNXB";
            this.txtMSNXB.ReadOnly = true;
            this.txtMSNXB.Size = new System.Drawing.Size(123, 20);
            this.txtMSNXB.TabIndex = 2;
            // 
            // txtMSSach
            // 
            this.txtMSSach.Location = new System.Drawing.Point(13, 53);
            this.txtMSSach.Name = "txtMSSach";
            this.txtMSSach.ReadOnly = true;
            this.txtMSSach.Size = new System.Drawing.Size(123, 20);
            this.txtMSSach.TabIndex = 2;
            // 
            // txtNhanDeSach
            // 
            this.txtNhanDeSach.Location = new System.Drawing.Point(13, 12);
            this.txtNhanDeSach.Name = "txtNhanDeSach";
            this.txtNhanDeSach.ReadOnly = true;
            this.txtNhanDeSach.Size = new System.Drawing.Size(348, 20);
            this.txtNhanDeSach.TabIndex = 1;
            // 
            // pbHinhBia
            // 
            this.pbHinhBia.Location = new System.Drawing.Point(142, 43);
            this.pbHinhBia.Name = "pbHinhBia";
            this.pbHinhBia.Size = new System.Drawing.Size(219, 255);
            this.pbHinhBia.TabIndex = 0;
            this.pbHinhBia.TabStop = false;
            // 
            // dgvSachTacGia
            // 
            this.dgvSachTacGia.AllowUserToAddRows = false;
            this.dgvSachTacGia.AllowUserToDeleteRows = false;
            this.dgvSachTacGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSachTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSTacGia,
            this.HocVi,
            this.HoTacGia,
            this.TenTacGia,
            this.Tim});
            this.dgvSachTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachTacGia.Location = new System.Drawing.Point(0, 0);
            this.dgvSachTacGia.MultiSelect = false;
            this.dgvSachTacGia.Name = "dgvSachTacGia";
            this.dgvSachTacGia.ReadOnly = true;
            this.dgvSachTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSachTacGia.Size = new System.Drawing.Size(457, 304);
            this.dgvSachTacGia.TabIndex = 0;
            this.dgvSachTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachTacGia_CellClick);
            this.dgvSachTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachTacGia_CellContentClick);
            this.dgvSachTacGia.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSachTacGia_EditingControlShowing);
            // 
            // MSTacGia
            // 
            this.MSTacGia.DataPropertyName = "MSTacGia";
            this.MSTacGia.HeaderText = "MS Tác giả";
            this.MSTacGia.MinimumWidth = 75;
            this.MSTacGia.Name = "MSTacGia";
            this.MSTacGia.ReadOnly = true;
            this.MSTacGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HocVi
            // 
            this.HocVi.DataPropertyName = "HocVi";
            this.HocVi.HeaderText = "Học vị";
            this.HocVi.MaxInputLength = 15;
            this.HocVi.MinimumWidth = 75;
            this.HocVi.Name = "HocVi";
            this.HocVi.ReadOnly = true;
            this.HocVi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HoTacGia
            // 
            this.HoTacGia.DataPropertyName = "HoTacGia";
            this.HoTacGia.HeaderText = "Họ tác giả";
            this.HoTacGia.MaxInputLength = 30;
            this.HoTacGia.MinimumWidth = 150;
            this.HoTacGia.Name = "HoTacGia";
            this.HoTacGia.ReadOnly = true;
            this.HoTacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HoTacGia.Width = 150;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên tác giả";
            this.TenTacGia.MaxInputLength = 10;
            this.TenTacGia.MinimumWidth = 75;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            this.TenTacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tim
            // 
            this.Tim.HeaderText = "Tìm";
            this.Tim.MinimumWidth = 30;
            this.Tim.Name = "Tim";
            this.Tim.ReadOnly = true;
            this.Tim.UseColumnTextForButtonValue = true;
            // 
            // frmSachTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 414);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmSachTacGia";
            this.Text = "Sách - Tác giả";
            this.Load += new System.EventHandler(this.frmSachTacGia_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.scSachTacGia.Panel1.ResumeLayout(false);
            this.scSachTacGia.Panel1.PerformLayout();
            this.scSachTacGia.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSachTacGia)).EndInit();
            this.scSachTacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhBia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private ButtonGroup btgNhomLenh;
        private System.Windows.Forms.SplitContainer scSachTacGia;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtMSNXB;
        private System.Windows.Forms.TextBox txtMSSach;
        private System.Windows.Forms.TextBox txtNhanDeSach;
        private System.Windows.Forms.PictureBox pbHinhBia;
        private System.Windows.Forms.DataGridView dgvSachTacGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn MSTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewButtonColumn Tim;
    }
}