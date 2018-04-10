using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THLTHDTNC04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Khai báo biến
        public static String ConnStr = "";
        public static char TuCach = ' ';
        public static String MSThamChieu = "";
        private static SqlConnection conn;
        #endregion

        public void EnableMenu(char TuCach, bool b)
        {
            mnuMuonSach.Enabled = b && (TuCach == '1');
            mnuDocGia.Enabled = b;
            mnuDanhMuc.Enabled = b;
            mnuQuanLy.Enabled = b && (TuCach == '2');
            mnuDangNhap.Enabled = !b;
            mnuDangXuat.Enabled = b;
        }

        public Form FormExist(String FormName)
        {
            foreach (Form frm in MdiChildren)
                if (frm.Name == FormName) return frm;
            return null;
        }

        public void CloseAllWindows()
        {
            foreach (Form frm in MdiChildren)
                frm.Close();
        }

        public static bool CoQuyen(char TuCach, string MsMau)
        {
            string s = QuyenNguoiSuDung(TuCach, MsMau);
            if (s != null)
                for (int i = 0; i < s.Length; i++)
                    if (s[i] == '1') return true;
            return false;
        }

        public static bool QuyenNguoiSuDung(char TuCach, string MsMau, char TacVu)
        { // Hình thái thứ nhất của quyền người sử dụng
            string s = QuyenNguoiSuDung(TuCach, MsMau); // Áp dụng hình thái thứ hai
            if (s != null)
                switch (TacVu)
                {
                    case 'A': return s[0] == '1'; // Tác vụ A=Add (Thêm)
                    case 'E': return s[1] == '1'; // Tác vụ E=Edit (Sửa)
                    case 'D': return s[2] == '1'; // Tác vụ D=Delete (Xóa)
                    case 'P': return s[3] == '1'; // Tác vụ P=Print (In)
                }
            return false;
        }

        public static string QuyenNguoiSuDung(char TuCach, string MsMau)
        { // Hình thái thứ hai của quyền người sử dụng
            try
            { // Thử
                string SQL = "select Quyen from CapQuyen where TuCach='" + TuCach
                + "' and MsMau='" + MsMau.Trim() + "'";
                conn = new SqlConnection(ConnStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                string s = (string)cmd.ExecuteScalar();
                conn.Close();
                return s;
            }
            catch
            { // Đón bắt lỗi sai
                return "";
            }
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            ConnStr = "";
            MSThamChieu = "";
            TuCach = ' ';
            EnableMenu(TuCach, false);
            CloseAllWindows();
        }

        private void mnuNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan frm = (frmNhaXuatBan)FormExist("frmNhaXuatBan");
            if (frm == null)
            {
                frm = new frmNhaXuatBan();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();
        }

        private void mnuTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia frm = (frmTacGia)FormExist("frmTacGia");
            if (frm == null)
            {
                frm = new frmTacGia();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            frmSach frm = (frmSach)FormExist("frmSach");
            if (frm == null)
            {
                frm = new frmSach();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("bạn có chắc chắn muốn thoát?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }
    }
}
