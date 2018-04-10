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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        #region Khai báo biến
        private SqlConnection conn = new SqlConnection(MainForm.ConnStr);
        private String m_Table = "TacGia"; // Tên table không có dấu tiếng Việt
        private DataSet dsTacGia; // Không gán giá trị đầu ở đây
        private int m_CurrColumn = 0;
        private String m_MsTacGia;
        private String[] OldTacGia;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            String SQL = "select MSTacGia,HocVi,HoTacGia,TenTacGia from TacGia order by MSTacGia";
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsTacGia = new DataSet(); // Tạo thể hiện mới của dsTacGia
            da.Fill(dsTacGia, m_Table); // Từ data adapter da điền dữ liệu vào dsTacGia, 
                                        // và đặt tên datatable là TacGia
            dgvTacGia.DataSource = dsTacGia.Tables[m_Table];
            btgNhomLenh.Reccount = dsTacGia.Tables[m_Table].Rows.Count;
            btgNhomLenh.ds = dsTacGia;
        }
        private void DinhViLai(String MSTacGia)
        {
            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dsTacGia.Tables[m_Table].Rows[i]["MSTacGia"].ToString().Trim() == m_MsTacGia.Trim())
                {
                    btgNhomLenh.Position = i;
                    dgvTacGia.CurrentCell = dgvTacGia.Rows[i].Cells[0];
                    return; // Đi về sớm
                }
        }

        #endregion

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            this.btgNhomLenh.CanSave += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanSave);
            this.btgNhomLenh.CanDelete += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanDelete);
            LoadData();
            btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvTacGia;
            btgNhomLenh.TableName = m_Table;
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btgNhomLenh.Mode != 0)
            {
                if (dgvTacGia.CurrentRow.Index != btgNhomLenh.Position)
                    dgvTacGia.CurrentCell = dgvTacGia.Rows[btgNhomLenh.Position].Cells[0];
            }
            if (dgvTacGia.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvTacGia.CurrentCell.RowIndex; // dgvNhaXuatBan.CurrentRow.Index;
                m_CurrColumn = dgvTacGia.CurrentCell.ColumnIndex;
            }
            m_MsTacGia = dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
                dgvTacGia.CurrentCell = dgvTacGia.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            dsTacGia.Tables[m_Table].Rows.Add("", "", "", ""); // Có 4 cột 
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            dgvTacGia.CurrentCell = dgvTacGia.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            OldTacGia = new String[4]; // Dùng cho trường hợp phục hồi
            for (int i = 0; i < 4; i++)
                OldTacGia[i] = dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position][i].ToString();
        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1)
            { // Lưu lúc thêm
                String SQL = "Insert into TacGia(MSTacGia,HocVi,HoTacGia,TenTacGia) values('" + m_MsTacGia
                + "',N'" + dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["HocVi"].ToString()
                + "',N'" + dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["HoTacGia"].ToString()
                + "',N'" + dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["TenTacGia"].ToString()
                + "')";
                // MessageBox.Show(SQL);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                LoadData();
                DinhViLai(m_MsTacGia);
            }
            else
            { // Lưu lúc sửa
                String SQL = "update NhaXuatBan set "
                + "HocVi=N'" + dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["HocVi"].ToString()
                + "HoTacGia=N'" + dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["HoTacGia"].ToString()
                + "TenTacGia=N'" +
                dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["TenTacGia"].ToString()
                + "' where MSTacGia='" + m_MsTacGia.Trim() + "'";
                // MessageBox.Show(SQL);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1)
            {

            }
            else
            {
                for (int i = 0; i < 4; i++)
                    dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position][i] = OldTacGia[i];
            }
        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_MsTacGia = dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString().Trim();
            if (MessageBox.Show(
            "Có chắc chắn hủy bỏ tác giả với mã số tác giả " + m_MsTacGia + " không?",
            "Tác giả", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String SQL = "delete from TacGia where MSTacGia='" + m_MsTacGia + "'";
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
            m_MsTacGia = dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString().Trim();
            String HocVi = dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["HocVi"].ToString().Trim();
            String HoTacGia =
            dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["HoTacGia"].ToString().Trim();
            String TenTacGia =
            dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["TenTacGia"].ToString().Trim();
            if (btgNhomLenh.Mode == 1)
            {
                if (m_MsTacGia.Trim() != "" && HoTacGia.Trim() != "" && TenTacGia.Trim() != "")
                {
                    String SQL = "select count(*) from TacGia where MSTacGia='" + m_MsTacGia.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    int So = (int)cmd.ExecuteScalar();
                    if (So == 0)
                    {
                        SQL = "select count(*) from TacGia where HocVi=N'" + HocVi
                        + "' and HoTacGia=N'" + HoTacGia.Trim()
                        + "' and TenTacGia=N'" + TenTacGia.Trim()
                        + "' and MSTacGia<>'" + m_MsTacGia.Trim() + "'";
                        cmd = new SqlCommand(SQL, conn);
                        return ((int)cmd.ExecuteScalar()) == 0;
                    }
                }
            }
            else
            {
                if (HoTacGia.Trim() != "" && TenTacGia.Trim() != "")
                {
                    String SQL = "select count(*) from TacGia where HocVi=N'" + HocVi
                    + "' and HoTacGia=N'" + HoTacGia.Trim()
                    + "' and TenTacGia=N'" + TenTacGia.Trim()
                    + "' and MSTacGia<>'" + m_MsTacGia.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    return ((int)cmd.ExecuteScalar()) == 0;
                }
            }
            return false; // Không thể lưu được
        }

        private bool btgNhomLenh_CanDelete(object sender, ButtonGroupEventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            m_MsTacGia = dsTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString().Trim();
            String SQL = "select count(*) from SachTacGia where MSTacGia='" + m_MsTacGia.Trim() + "'";
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
