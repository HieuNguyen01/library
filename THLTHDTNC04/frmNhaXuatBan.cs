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
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        #region Khai báo biến
        private SqlConnection conn = new SqlConnection(MainForm.ConnStr);
        private String m_Table = "NhaXuatBan"; // Tên table không có dấu tiếng Việt
        private DataSet dsNhaXuatBan; // Không gán giá trị đầu ở đây
        private int m_CurrColumn = 0;
        private String m_MsNXB;
        private String[] OldNhaXuatBan;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            String SQL = "select MSNXB,TenNXB from NhaXuatBan order by MSNXB";
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsNhaXuatBan = new DataSet(); // Tạo thể hiện mới của dsNhaXuatBan
            da.Fill(dsNhaXuatBan, m_Table); // Từ data adapter da điền dữ liệu vào dsNhaXuatBan, 
                                            // và đặt tên datatable là NhaXuatBan
            dgvNhaXuatBan.DataSource = dsNhaXuatBan.Tables[m_Table];
            btgNhomLenh.Reccount = dsNhaXuatBan.Tables[m_Table].Rows.Count;
            btgNhomLenh.ds = dsNhaXuatBan;
        }
        private void DinhViLai(String MSNXB)
        {
            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dsNhaXuatBan.Tables[m_Table].Rows[i]["MSNXB"].ToString().Trim() == m_MsNXB.Trim())
                {
                    btgNhomLenh.Position = i;
                    dgvNhaXuatBan.CurrentCell = dgvNhaXuatBan.Rows[i].Cells[0];
                    return; // Đi về sớm
                }
        }
        #endregion

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            this.btgNhomLenh.CanSave += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanSave);
            this.btgNhomLenh.CanDelete += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanDelete);
            LoadData();
            btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvNhaXuatBan;
            btgNhomLenh.TableName = m_Table;
        }

        private void dgvNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btgNhomLenh.Mode != 0)
            {
                if (dgvNhaXuatBan.CurrentRow.Index != btgNhomLenh.Position)
                    dgvNhaXuatBan.CurrentCell = dgvNhaXuatBan.Rows[btgNhomLenh.Position].Cells[0];
            }
            if (dgvNhaXuatBan.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvNhaXuatBan.CurrentCell.RowIndex; // dgvNhaXuatBan.CurrentRow.Index;
                m_CurrColumn = dgvNhaXuatBan.CurrentCell.ColumnIndex;
            }
            m_MsNXB = dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
                dgvNhaXuatBan.CurrentCell = dgvNhaXuatBan.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            dsNhaXuatBan.Tables[m_Table].Rows.Add("", ""); // Có 2 cột 
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            dgvNhaXuatBan.CurrentCell = dgvNhaXuatBan.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            OldNhaXuatBan = new String[2]; // Dùng cho trường hợp phục hồi
            for (int i = 0; i < 2; i++)
                OldNhaXuatBan[i] = dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position][i].ToString();
        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1)
            { // Lưu lúc thêm
                String SQL = "Insert into NhaXuatBan(MSNXB,TenNXB) values('" + m_MsNXB
                + "',N'" + dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position]["TenNXB"].ToString() + "')";
                // MessageBox.Show(SQL);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                LoadData();
                DinhViLai(m_MsNXB);
            }
            else
            { // Lưu lúc sửa
                String SQL = "update NhaXuatBan set TenNXB=N'"
                + dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position]["TenNXB"].ToString()
                + "' where MSNXB='" + m_MsNXB.Trim() + "'";
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1)
            {
                // dgvNhaXuatBan.CurrentCell = dgvNhaXuatBan.Rows[btgNhomLenh.Reccount-1].Cells[0];
                // dsNhaXuatBan.Tables[m_Table].Rows.RemoveAt(btgNhomLenh.Reccount);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                    dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position][i] = OldNhaXuatBan[i];
            }
        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_MsNXB = dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString().Trim();
            if (MessageBox.Show(
            "Có chắc chắn hủy bỏ nhà xuất bản với mã số nhà xuất bản " + m_MsNXB + " không?",
            "Nhà xuất bản", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String SQL = "delete from NhaXuatBan where MSNXB='" + m_MsNXB + "'";
                // MessageBox.Show(SQL);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private bool btgNhomLenh_CanSave(object sender, ButtonGroupEventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            m_MsNXB = dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString().Trim();
            String TenNXB =
            dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position]["TenNXB"].ToString().Trim();
            if (btgNhomLenh.Mode == 1)
            {
                if (m_MsNXB.Trim() != "" && TenNXB.Trim() != "")
                {
                    String SQL = "select count(*) from NhaXuatBan where MSNXB='" + m_MsNXB.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    int So = (int)cmd.ExecuteScalar();
                    if (So == 0)
                    {
                        SQL = "select count(*) from NhaXuatBan where TenNXB='" + TenNXB
                        + "' and MSNXB<>'" + m_MsNXB.Trim() + "'";
                        cmd = new SqlCommand(SQL, conn);
                        return ((int)cmd.ExecuteScalar()) == 0;
                    }
                }
            }
            else
            {
                if (TenNXB.Trim() != "")
                {
                    String SQL = "select count(*) from NhaXuatBan where TenNXB='" + TenNXB
                    + "' and MSNXB<>'" + m_MsNXB.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    return ((int)cmd.ExecuteScalar()) == 0;
                }
            }
            return false; // Không thể lưu được
        }

        private bool btgNhomLenh_CanDelete(object sender, ButtonGroupEventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            m_MsNXB = dsNhaXuatBan.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString().Trim();
            String SQL = "select count(*) from Sach where MSNXB='" + m_MsNXB.Trim() + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            int So = (int)cmd.ExecuteScalar();
            return (So == 0);
        }

        private void btgNhomLenh_PrintClick(object sender, ButtonGroupEventArgs e)
        {
            MessageBox.Show("Chưa viết chương trình in", this.Text);
        }
    }
}
