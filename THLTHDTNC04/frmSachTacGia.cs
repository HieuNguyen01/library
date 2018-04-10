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
using System.IO;

namespace THLTHDTNC04
{
    public partial class frmSachTacGia : Form
    {
        public frmSachTacGia()
        {
            InitializeComponent();
        }

        #region Khai báo biến
        private SqlConnection conn = new SqlConnection(MainForm.ConnStr);
        private String m_Table = "SachTacGia"; // Tên table không có dấu tiếng Việt
        private String m_TableTacGia = "TacGia";
        private DataSet dsSachTacGia; // Không gán giá trị đầu ở đây
        private DataSet dsTacGia;
        private int m_CurrColumn = 0;
        private String m_MsSach;
        private String m_MsTacGia;
        private String[] OldSachTacGia;
        #endregion

        #region Các đặc trưng
        public String MSSach
        {
            set
            {
                txtMSSach.Text = m_MsSach = value;
            }
            get { return m_MsSach; }
        }
        public String NhanDeSach
        {
            set { txtNhanDeSach.Text = value; }
            get { return txtNhanDeSach.Text; }
        }
        public String MSNXB
        {
            set { txtMSNXB.Text = value; }
            get { return txtMSNXB.Text; }
        }
        public int NamXB
        {
            set { txtNamXB.Text = value.ToString(); }
            get { return int.Parse(txtNamXB.Text); }
        }
        public int SoTrang
        {
            set { txtSoTrang.Text = value.ToString(); }
            get { return int.Parse(txtSoTrang.Text); }
        }
        public Image HinhBia
        {
            set { pbHinhBia.Image = value; }
            get { return pbHinhBia.Image; }
        }
        #endregion

        #region Các phương thức
        private void LoadCboTacGia()
        {
            String SQL = "select MSTacGia,HocVi,HoTacGia,TenTacGia from TacGia order by MSTacGia";
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsTacGia = new DataSet();
            da.Fill(dsTacGia, m_TableTacGia);
            MSTacGia.DataSource = dsTacGia.Tables[m_TableTacGia];
            MSTacGia.DisplayMember = "MSTacGia";
            MSTacGia.ValueMember = "MSTacGia";
        }
        private void LoadData()
        {
            String SQL = "select SachTacGia.MSTacGia MSTacGia,HocVi,HoTacGia,TenTacGia from SachTacGia"
            + " inner join TacGia on SachTacGia.MSTacGia=TacGia.MSTacGia"
            + " where SachTacGia.MSSach='" + m_MsSach + "'"
            + " order by MSTacGia";
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsSachTacGia = new DataSet(); // Tạo thể hiện mới của dsSach
            da.Fill(dsSachTacGia, m_Table); // Từ data adapter da điền dữ liệu vào dsSach, 
                                            // và đặt tên datatable là Sach
            dgvSachTacGia.DataSource = dsSachTacGia.Tables[m_Table];
            btgNhomLenh.Reccount = dsSachTacGia.Tables[m_Table].Rows.Count;
            btgNhomLenh.ds = dsSachTacGia;
        }
        private void DinhViLai(String MSTacGia)
        {
            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dsSachTacGia.Tables[m_Table].Rows[i]["MSTacGia"].ToString().Trim() == m_MsTacGia.Trim())
                {
                    btgNhomLenh.Position = i;
                    dgvSachTacGia.CurrentCell = dgvSachTacGia.Rows[i].Cells[0];
                    return; // Đi về sớm
                }
        }

        #endregion

        private void frmSachTacGia_Load(object sender, EventArgs e)
        {
            this.btgNhomLenh.CanSave += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanSave);
            this.btgNhomLenh.CanDelete += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanDelete);
            LoadCboTacGia();
            LoadData();
            btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvSachTacGia;
            btgNhomLenh.TableName = m_Table;
        }

        private void dgvSachTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btgNhomLenh.Mode != 0)
            {
                if (dgvSachTacGia.CurrentRow.Index != btgNhomLenh.Position)
                    dgvSachTacGia.CurrentCell = dgvSachTacGia.Rows[btgNhomLenh.Position].Cells[0];
            }
            if (dgvSachTacGia.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvSachTacGia.CurrentCell.RowIndex; // dgvNhaXuatBan.CurrentRow.Index;
                m_CurrColumn = dgvSachTacGia.CurrentCell.ColumnIndex;
            }
            m_MsTacGia = dsSachTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
                dgvSachTacGia.CurrentCell = dgvSachTacGia.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            dsSachTacGia.Tables[m_Table].Rows.Add("", "", "", ""); // Có 4 cột (không kể cột MSSach) 
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            dgvSachTacGia.CurrentCell = dgvSachTacGia.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void cboTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = dgvSachTacGia.CurrentCell.RowIndex;
            ComboBox cboTacGia = sender as DataGridViewComboBoxEditingControl;
            dgvSachTacGia.Rows[rowIndex].Cells["HocVi"].Value =
            dsTacGia.Tables[m_TableTacGia].Rows[cboTacGia.SelectedIndex]["HocVi"].ToString();
            dgvSachTacGia.Rows[rowIndex].Cells["HoTacGia"].Value =
            dsTacGia.Tables[m_TableTacGia].Rows[cboTacGia.SelectedIndex]["HoTacGia"].ToString();
            dgvSachTacGia.Rows[rowIndex].Cells["TenTacGia"].Value =
            dsTacGia.Tables[m_TableTacGia].Rows[cboTacGia.SelectedIndex]["TenTacGia"].ToString();
        }

        private void dgvSachTacGia_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSachTacGia.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox cboTacGia = (ComboBox)e.Control;
                if (cboTacGia != null)
                {
                    cboTacGia.SelectedIndexChanged -= cboTacGia_SelectedIndexChanged;
                    cboTacGia.SelectedIndexChanged += cboTacGia_SelectedIndexChanged;
                }
            }
        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            OldSachTacGia = new String[4]; // Dùng cho trường hợp phục hồi (không kể cột MSSach)
            for (int i = 0; i < 4; i++)
                OldSachTacGia[i] = dsSachTacGia.Tables[m_Table].Rows[btgNhomLenh.Position][i].ToString();
        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1)
            {
                m_MsTacGia = dsSachTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString();
                String SQL = "Insert into SachTacGia(MSSach,MSTacGia) values('" + m_MsSach + "','" + m_MsTacGia + "')";
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                LoadData();
                DinhViLai(m_MsTacGia);
            }
            else
            {
                String SQL = "delete SachTacGia where "
                + "MSSach='" + m_MsSach + "' and MSTacGia='" + OldSachTacGia[0] + "'";
                // MessageBox.Show(SQL);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                m_MsTacGia = dsSachTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString();
                SQL = "Insert into SachTacGia(MSSach,MSTacGia) values('" + m_MsSach + "','" + m_MsTacGia + "')";
                // MessageBox.Show(SQL);
                cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                LoadData();
                DinhViLai(m_MsTacGia);
            }
        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1)
            {
                // dgvSachTacGia.CurrentCell = dgvTacGia.Rows[btgNhomLenh.Reccount-1].Cells[0];
                // dsSachTacGia.Tables[m_Table].Rows.RemoveAt(btgNhomLenh.Reccount);
            }
            else
            {
                for (int i = 0; i < 4; i++) // Không kể cột MSSach
                    dsSachTacGia.Tables[m_Table].Rows[btgNhomLenh.Position][i] = OldSachTacGia[i];
            }
        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_MsTacGia = dsSachTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString().Trim();
            if (MessageBox.Show(
            "Có chắc chắn hủy bỏ sách với mã số tác giả " + m_MsTacGia
            + " của sách có mã số " + m_MsSach + " không?",
            "Sách", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String SQL = "delete from SachTacGia where MSSach='" + m_MsSach + "' and MSTacGia='"
                + m_MsTacGia + "'";
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
            m_MsTacGia =
            dsSachTacGia.Tables[m_Table].Rows[btgNhomLenh.Position]["MSTacGia"].ToString().Trim();
            if (btgNhomLenh.Mode == 1)
            {
                if (m_MsSach.Trim() != "" && m_MsTacGia.Trim() != "")
                {
                    String SQL = "select count(*) from SachTacGia where MSSach='" + m_MsSach.Trim()
                    + "' and MSTacGia='" + m_MsTacGia.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    int So = (int)cmd.ExecuteScalar();
                    return (So == 0);
                }
            }
            else
            {
                if (m_MsSach.Trim() != "" && m_MsTacGia.Trim() != "")
                {
                    String SQL = "select count(*) from SachTacGia where MSSach='" + m_MsSach.Trim()
                    + "' and MSTacGia='" + m_MsTacGia.Trim() + "' and MSTacGia<>'" + OldSachTacGia[0] + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    return ((int)cmd.ExecuteScalar()) == 0;
                }
            }
            return false; // Không thể lưu được
        }

        private bool btgNhomLenh_CanDelete(object sender, ButtonGroupEventArgs e)
        {
            return true;
        }

        private void btgNhomLenh_PrintClick(object sender, ButtonGroupEventArgs e)
        {
            MessageBox.Show("Chưa viết chương trình in", this.Text);
        }


        private void dgvSachTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvSachTacGia.ReadOnly)
                if (dgvSachTacGia.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    MessageBox.Show("Chưa viết phần tìm tác giả", this.Text);
                }
        }
    }
}
