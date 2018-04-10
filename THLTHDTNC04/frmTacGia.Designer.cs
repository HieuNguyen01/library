namespace THLTHDTNC04
{
    partial class frmTacGia
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
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.MSTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(684, 68);
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
            this.lblTitle.Size = new System.Drawing.Size(684, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tác giả";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 381);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(684, 48);
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
            this.btgNhomLenh.Location = new System.Drawing.Point(30, 8);
            this.btgNhomLenh.Mode = 0;
            this.btgNhomLenh.MsMau = "TG";
            this.btgNhomLenh.Name = "btgNhomLenh";
            this.btgNhomLenh.Position = 0;
            this.btgNhomLenh.Reccount = 0;
            this.btgNhomLenh.Size = new System.Drawing.Size(620, 36);
            this.btgNhomLenh.TabIndex = 0;
            this.btgNhomLenh.TableName = "";
            this.btgNhomLenh.Display += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_Display);
            this.btgNhomLenh.AddClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_AddClick);
            this.btgNhomLenh.EditClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_EditClick);
            this.btgNhomLenh.SaveClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_SaveClick);
            this.btgNhomLenh.CancelClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_CancelClick);
            this.btgNhomLenh.DeleteClick += new THLTHDTNC04.ButtonGroupEventHandler(this.btgNhomLenh_DeleteClick);
            this.btgNhomLenh.PrintClick += new ButtonGroupEventHandler(this.btgNhomLenh_PrintClick);
            this.btgNhomLenh.Load += new System.EventHandler(this.btgNhomLenh_Load);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.dgvTacGia);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 68);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(684, 313);
            this.pnlCenter.TabIndex = 2;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSTacGia,
            this.HocVi,
            this.HoTacGia,
            this.TenTacGia});
            this.dgvTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTacGia.Location = new System.Drawing.Point(0, 0);
            this.dgvTacGia.MultiSelect = false;
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(684, 313);
            this.dgvTacGia.TabIndex = 0;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);
            // 
            // MSTacGia
            // 
            this.MSTacGia.DataPropertyName = "MSTacGia";
            this.MSTacGia.HeaderText = "MS Tác Giả";
            this.MSTacGia.MaxInputLength = 6;
            this.MSTacGia.Name = "MSTacGia";
            this.MSTacGia.ReadOnly = true;
            this.MSTacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HocVi
            // 
            this.HocVi.DataPropertyName = "HocVi";
            this.HocVi.HeaderText = "Học Vị";
            this.HocVi.MaxInputLength = 15;
            this.HocVi.Name = "HocVi";
            this.HocVi.ReadOnly = true;
            this.HocVi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HoTacGia
            // 
            this.HoTacGia.DataPropertyName = "HoTacGia";
            this.HoTacGia.HeaderText = "Họ Tác Giả";
            this.HoTacGia.MaxInputLength = 30;
            this.HoTacGia.MinimumWidth = 200;
            this.HoTacGia.Name = "HoTacGia";
            this.HoTacGia.ReadOnly = true;
            this.HoTacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HoTacGia.Width = 200;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.MaxInputLength = 10;
            this.TenTacGia.MinimumWidth = 100;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            this.TenTacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmTacGia";
            this.Text = "Tác giả";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private ButtonGroup btgNhomLenh;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
    }
}