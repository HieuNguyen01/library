namespace THLTHDTNC04
{
    partial class frmNhaXuatBan
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
            this.dgvNhaXuatBan = new System.Windows.Forms.DataGridView();
            this.MSNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXuatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(621, 64);
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
            this.lblTitle.Size = new System.Drawing.Size(621, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhà Xuất Bản";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 329);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(621, 76);
            this.pnlBottom.TabIndex = 1;
            // 
            // btgNhomLenh
            // 
            this.btgNhomLenh.AddEnabled = true;
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
            this.btgNhomLenh.Location = new System.Drawing.Point(6, 24);
            this.btgNhomLenh.Mode = 0;
            this.btgNhomLenh.MsMau = "NXB";
            this.btgNhomLenh.Name = "btgNhomLenh";
            this.btgNhomLenh.Position = 0;
            this.btgNhomLenh.Reccount = 0;
            this.btgNhomLenh.Size = new System.Drawing.Size(732, 36);
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
            this.pnlCenter.Controls.Add(this.dgvNhaXuatBan);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 64);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(621, 265);
            this.pnlCenter.TabIndex = 2;
            // 
            // dgvNhaXuatBan
            // 
            this.dgvNhaXuatBan.AllowUserToAddRows = false;
            this.dgvNhaXuatBan.AllowUserToDeleteRows = false;
            this.dgvNhaXuatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaXuatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSNXB,
            this.TenNXB});
            this.dgvNhaXuatBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhaXuatBan.Location = new System.Drawing.Point(0, 0);
            this.dgvNhaXuatBan.MultiSelect = false;
            this.dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            this.dgvNhaXuatBan.ReadOnly = true;
            this.dgvNhaXuatBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNhaXuatBan.Size = new System.Drawing.Size(621, 265);
            this.dgvNhaXuatBan.TabIndex = 0;
            this.dgvNhaXuatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaXuatBan_CellClick);
            // 
            // MSNXB
            // 
            this.MSNXB.DataPropertyName = "MSNXB";
            this.MSNXB.HeaderText = "MSNXB";
            this.MSNXB.MaxInputLength = 6;
            this.MSNXB.Name = "MSNXB";
            this.MSNXB.ReadOnly = true;
            this.MSNXB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên nhà xuất bản";
            this.TenNXB.MaxInputLength = 40;
            this.TenNXB.MinimumWidth = 300;
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            this.TenNXB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenNXB.Width = 300;
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 405);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmNhaXuatBan";
            this.Text = "Nhà xuất bản";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXuatBan)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private ButtonGroup btgNhomLenh;
    }
}