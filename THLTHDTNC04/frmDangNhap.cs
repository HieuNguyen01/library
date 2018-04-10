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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                //MainForm.ConnStr = "Persist Security Info = False; Integrated Security = true; "
//+ "Initial Catalog = CSDLThuVien; server = (local)";
                MainForm.ConnStr = "Persist Security Info = false; Integrated Security = true; "
+ "Initial Catalog = CSDLThuVien;server=DUATCOMPUTER; user id=sa; password=123456";
                // Khi chạy thử
                // MainForm.ConnStr = 
                // "Persist Security Info = False; Integrated Security=true;Initial Catalog = CSDLThuVien; server = (local)";
                // Khi chạy thực
                
                KetNoiCSDL kncsdl = new KetNoiCSDL(MainForm.ConnStr);
                kncsdl.KetNoi();
                char TuCach = (rbDocGia.Checked) ? '1' : '2';
                String sql = "Select MSThamChieu from DangNhap where TenDangNhap='" + txtTenDangNhap.Text
                + "' and MatKhau='" + txtMatKhau.Text + "'"
                + " and TuCach=" + TuCach;
                SqlCommand cmd = new SqlCommand(sql, kncsdl.Connection);
                // int kq = (int)cmd.ExecuteScalar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "DangNhap");
                if (ds.Tables["DangNhap"].Rows.Count > 0)
                {
                    MainForm.TuCach = TuCach;
                    ((MainForm)(this.MdiParent)).EnableMenu(TuCach, true);
                    MainForm.MSThamChieu = ds.Tables["DangNhap"].Rows[0]["MSThamChieu"].ToString();
                    this.Close();
                }
                else
                    MessageBox.Show("Sai tên đăng nhập/mật khẩu", "Mật khẩu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
