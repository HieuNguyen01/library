namespace THLTHDTNC04
{
    partial class frmSach
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
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.MSSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanDeSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhBia = new System.Windows.Forms.DataGridViewImageColumn();
            this.btgNhomLenh = new THLTHDTNC04.ButtonGroup();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(642, 47);
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
            this.lblTitle.Size = new System.Drawing.Size(642, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sách";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 282);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(642, 52);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.dgvSach);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 47);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(642, 235);
            this.pnlCenter.TabIndex = 2;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSach,
            this.NhanDeSach,
            this.MSNXB,
            this.NamXB,
            this.SoTrang,
            this.HinhBia});
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSach.Size = new System.Drawing.Size(642, 235);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            this.dgvSach.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSach_EditingControlShowing);
            // 
            // MSSach
            // 
            this.MSSach.DataPropertyName = "MSSach";
            this.MSSach.HeaderText = "MS Sách";
            this.MSSach.MaxInputLength = 6;
            this.MSSach.Name = "MSSach";
            this.MSSach.ReadOnly = true;
            this.MSSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NhanDeSach
            // 
            this.NhanDeSach.DataPropertyName = "NhanDeSach";
            this.NhanDeSach.HeaderText = "Nhan Đề Sách";
            this.NhanDeSach.MaxInputLength = 50;
            this.NhanDeSach.Name = "NhanDeSach";
            this.NhanDeSach.ReadOnly = true;
            this.NhanDeSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NhanDeSach.Width = 200;
            // 
            // MSNXB
            // 
            this.MSNXB.DataPropertyName = "MSNXB";
            this.MSNXB.HeaderText = "MSNXB";
            this.MSNXB.MaxInputLength = 6;
            this.MSNXB.Name = "MSNXB";
            this.MSNXB.ReadOnly = true;
            this.MSNXB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MSNXB.Width = 75;
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.HeaderText = "Năm xuất bản";
            this.NamXB.MaxInputLength = 4;
            this.NamXB.Name = "NamXB";
            this.NamXB.ReadOnly = true;
            this.NamXB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NamXB.Width = 50;
            // 
            // SoTrang
            // 
            this.SoTrang.DataPropertyName = "SoTrang";
            this.SoTrang.HeaderText = "Số trang";
            this.SoTrang.MaxInputLength = 4;
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.ReadOnly = true;
            this.SoTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoTrang.Width = 50;
            // 
            // HinhBia
            // 
            this.HinhBia.DataPropertyName = "HinhBia";
            this.HinhBia.HeaderText = "Hình bìa";
            this.HinhBia.MinimumWidth = 300;
            this.HinhBia.Name = "HinhBia";
            this.HinhBia.ReadOnly = true;
            this.HinhBia.Width = 300;
            // 
            // btgNhomLenh
            // 
            this.btgNhomLenh.AddEnabled = true;
            this.btgNhomLenh.AutoNumber = false;
            this.btgNhomLenh.dgv = null;
            this.btgNhomLenh.ds = null;
            this.btgNhomLenh.EditEnabled = true;
            this.btgNhomLenh.Extra2Enabled = true;
            this.btgNhomLenh.Extra2Text = "Tác giả";
            this.btgNhomLenh.Extra2Visible = true;
            this.btgNhomLenh.ExtraEnabled = true;
            this.btgNhomLenh.ExtraText = "Hình bìa";
            this.btgNhomLenh.ExtraVisible = true;
            this.btgNhomLenh.Location = new System.Drawing.Point(4, 12);
            this.btgNhomLenh.Mode = 0;
            this.btgNhomLenh.MsMau = "S";
            this.btgNhomLenh.Name = "btgNhomLenh";
            this.btgNhomLenh.Position = 0;
            this.btgNhomLenh.Reccount = 0;
            this.btgNhomLenh.Size = new System.Drawing.Size(635, 36);
            this.btgNhomLenh.TabIndex = 0;
            this.btgNhomLenh.TableName = "";
            this.btgNhomLenh.Display += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_Display);
            this.btgNhomLenh.AddClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_AddClick);
            this.btgNhomLenh.EditClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_EditClick);
            this.btgNhomLenh.SaveClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_SaveClick);
            this.btgNhomLenh.CancelClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_CancelClick);
            this.btgNhomLenh.DeleteClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_DeleteClick);
            this.btgNhomLenh.PrintClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_PrintClick);
            this.btgNhomLenh.ExtraClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_ExtraClick);
            this.btgNhomLenh.Extra2Click += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_Extra2Click);
            this.btgNhomLenh.Load += new System.EventHandler(this.btgNhomLenh_Load);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 334);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmSach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private ButtonGroup btgNhomLenh;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanDeSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTrang;
        private System.Windows.Forms.DataGridViewImageColumn HinhBia;
    }
}