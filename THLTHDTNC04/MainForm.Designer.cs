namespace THLTHDTNC04
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLapPhieuMuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaXuatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaiQuyetMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaPhieuMuonKhongThanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKSachMuonTrongNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKSachDaoHanChuaTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMuonSach,
            this.mnuDocGia,
            this.mnuDanhMuc,
            this.mnuQuanLy,
            this.mnuHeThong});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(622, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // mnuMuonSach
            // 
            this.mnuMuonSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLapPhieuMuonSach});
            this.mnuMuonSach.Enabled = false;
            this.mnuMuonSach.Name = "mnuMuonSach";
            this.mnuMuonSach.Size = new System.Drawing.Size(78, 20);
            this.mnuMuonSach.Text = "Mượn sách";
            // 
            // mnuLapPhieuMuonSach
            // 
            this.mnuLapPhieuMuonSach.Name = "mnuLapPhieuMuonSach";
            this.mnuLapPhieuMuonSach.Size = new System.Drawing.Size(188, 22);
            this.mnuLapPhieuMuonSach.Text = "Lập phiếu mượn sách";
            // 
            // mnuDocGia
            // 
            this.mnuDocGia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTheDocGia});
            this.mnuDocGia.Enabled = false;
            this.mnuDocGia.Name = "mnuDocGia";
            this.mnuDocGia.Size = new System.Drawing.Size(59, 20);
            this.mnuDocGia.Text = "Độc giả";
            // 
            // mnuTheDocGia
            // 
            this.mnuTheDocGia.Name = "mnuTheDocGia";
            this.mnuTheDocGia.Size = new System.Drawing.Size(136, 22);
            this.mnuTheDocGia.Text = "Thẻ độc giả";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhaXuatBan,
            this.mnuTacGia,
            this.mnuSach});
            this.mnuDanhMuc.Enabled = false;
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuNhaXuatBan
            // 
            this.mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            this.mnuNhaXuatBan.Size = new System.Drawing.Size(144, 22);
            this.mnuNhaXuatBan.Text = "Nhà xuất bản";
            this.mnuNhaXuatBan.Click += new System.EventHandler(this.mnuNhaXuatBan_Click);
            // 
            // mnuTacGia
            // 
            this.mnuTacGia.Name = "mnuTacGia";
            this.mnuTacGia.Size = new System.Drawing.Size(144, 22);
            this.mnuTacGia.Text = "Tác giả";
            this.mnuTacGia.Click += new System.EventHandler(this.mnuTacGia_Click);
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(144, 22);
            this.mnuSach.Text = "Sách";
            this.mnuSach.Click += new System.EventHandler(this.mnuSach_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGiaiQuyetMuon,
            this.mnuTraSach,
            this.mnuXoaPhieuMuonKhongThanh,
            this.mnuTKSachMuonTrongNgay,
            this.mnuTKSachDaoHanChuaTra});
            this.mnuQuanLy.Enabled = false;
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuGiaiQuyetMuon
            // 
            this.mnuGiaiQuyetMuon.Name = "mnuGiaiQuyetMuon";
            this.mnuGiaiQuyetMuon.Size = new System.Drawing.Size(247, 22);
            this.mnuGiaiQuyetMuon.Text = "Giải quyết mượn";
            // 
            // mnuTraSach
            // 
            this.mnuTraSach.Name = "mnuTraSach";
            this.mnuTraSach.Size = new System.Drawing.Size(247, 22);
            this.mnuTraSach.Text = "Trả sách";
            // 
            // mnuXoaPhieuMuonKhongThanh
            // 
            this.mnuXoaPhieuMuonKhongThanh.Name = "mnuXoaPhieuMuonKhongThanh";
            this.mnuXoaPhieuMuonKhongThanh.Size = new System.Drawing.Size(247, 22);
            this.mnuXoaPhieuMuonKhongThanh.Text = "Xóa phiếu mượn không thành";
            // 
            // mnuTKSachMuonTrongNgay
            // 
            this.mnuTKSachMuonTrongNgay.Name = "mnuTKSachMuonTrongNgay";
            this.mnuTKSachMuonTrongNgay.Size = new System.Drawing.Size(247, 22);
            this.mnuTKSachMuonTrongNgay.Text = "Thống kê sách mượn trong ngày";
            // 
            // mnuTKSachDaoHanChuaTra
            // 
            this.mnuTKSachDaoHanChuaTra.Name = "mnuTKSachDaoHanChuaTra";
            this.mnuTKSachDaoHanChuaTra.Size = new System.Drawing.Size(247, 22);
            this.mnuTKSachDaoHanChuaTra.Text = "Thống kê sách đáo hạn chưa trả";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.toolStripMenuItem2,
            this.mnuKetThuc});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(154, 22);
            this.mnuDangNhap.Text = "Đăng nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(154, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "________________";
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(154, 22);
            this.mnuKetThuc.Text = "Kết thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 397);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Ứng dụng Windows Form kết nối CSDL";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMuonSach;
        private System.Windows.Forms.ToolStripMenuItem mnuLapPhieuMuonSach;
        private System.Windows.Forms.ToolStripMenuItem mnuDocGia;
        private System.Windows.Forms.ToolStripMenuItem mnuTheDocGia;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaXuatBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTacGia;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaiQuyetMuon;
        private System.Windows.Forms.ToolStripMenuItem mnuTraSach;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaPhieuMuonKhongThanh;
        private System.Windows.Forms.ToolStripMenuItem mnuTKSachMuonTrongNgay;
        private System.Windows.Forms.ToolStripMenuItem mnuTKSachDaoHanChuaTra;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

