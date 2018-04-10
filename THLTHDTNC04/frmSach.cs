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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        #region Khai báo biến
        private SqlConnection conn = new SqlConnection(MainForm.ConnStr);
        private String m_Table = "Sach"; // Tên table không có dấu tiếng Việt
        private DataSet dsSach; // Không gán giá trị đầu ở đây
        private int m_CurrColumn = 0;
        private String m_MsSach;
        private String[] OldSach;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            String SQL =
            "select MSSach,NhanDeSach,MSNXB,NamXB,SoTrang,HinhBia from Sach order by MSSach";
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsSach = new DataSet(); // Tạo thể hiện mới của dsSach
            da.Fill(dsSach, m_Table); // Từ data adapter da điền dữ liệu vào dsSach, 
                                      // và đặt tên datatable là Sach
            dgvSach.DataSource = dsSach.Tables[m_Table];
            btgNhomLenh.Reccount = dsSach.Tables[m_Table].Rows.Count;
            btgNhomLenh.ds = dsSach;
        }

        private void DinhViLai(String MSTacGia)
        {
            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dsSach.Tables[m_Table].Rows[i]["MSSach"].ToString().Trim() == m_MsSach.Trim())
                {
                    btgNhomLenh.Position = i;
                    dgvSach.CurrentCell = dgvSach.Rows[i].Cells[0];
                    return; // Đi về sớm
                }
        }
        #endregion

        private void frmSach_Load(object sender, EventArgs e)
        {
            this.btgNhomLenh.CanSave += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanSave);
            this.btgNhomLenh.CanDelete += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanDelete);
            LoadData();
            btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvSach;
            btgNhomLenh.TableName = m_Table;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btgNhomLenh.Mode != 0)
            {
                if (dgvSach.CurrentRow.Index != btgNhomLenh.Position)
                    dgvSach.CurrentCell = dgvSach.Rows[btgNhomLenh.Position].Cells[0];
            }
            if (dgvSach.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvSach.CurrentCell.RowIndex; // dgvNhaXuatBan.CurrentRow.Index;
                m_CurrColumn = dgvSach.CurrentCell.ColumnIndex;
            }
            m_MsSach = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSSach"].ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
                dgvSach.CurrentCell = dgvSach.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            dsSach.Tables[m_Table].Rows.Add("", "", "", "0", "0", null); // Có 6 cột 
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            dgvSach.CurrentCell = dgvSach.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void NumericColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgvSach_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSach.CurrentCell.ColumnIndex == 3 || dgvSach.CurrentCell.ColumnIndex == 4)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumericColumn_KeyPress);
                }
            }
            else
            {
                TextBox tb = e.Control as TextBox;
                tb.KeyPress -= new KeyPressEventHandler(NumericColumn_KeyPress);
            }
        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            OldSach = new String[5]; // Dùng cho trường hợp phục hồi (không kể cột hình ảnh)
            for (int i = 0; i < 5; i++)
                OldSach[i] = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position][i].ToString();
        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1)
            { // Lưu lúc thêm
                String SQL = "Insert into Sach(MSSach,NhanDeSach,MSNXB,NamXB,SoTrang) values('" + m_MsSach
                + "',N'" + dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NhanDeSach"].ToString()
                + "','" + dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString()
                + "'," + dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NamXB"].ToString()
                + "," + dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["SoTrang"].ToString()
                + ")";
                // MessageBox.Show(SQL);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                LoadData();
                DinhViLai(m_MsSach);
            }else
            {
                String SQL = "update Sach set "
                + "NhanDeSach=N'" +
                dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NhanDeSach"].ToString()
                + "',MSNXB='" + dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString()
                + "',NamXB=" + dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NamXB"].ToString()
                + ",SoTrang=" + dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["SoTrang"].ToString()
                + " where MSSach='" + m_MsSach.Trim() + "'";
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
                // dgvSach.CurrentCell = dgvSach.Rows[btgNhomLenh.Reccount-1].Cells[0];
                // dsSach.Tables[m_Table].Rows.RemoveAt(btgNhomLenh.Reccount);
            }
            else
            {
                for (int i = 0; i < 5; i++) // Không kể cột HinhBia
                    dsSach.Tables[m_Table].Rows[btgNhomLenh.Position][i] = OldSach[i];
            }
        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_MsSach = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSSach"].ToString().Trim();
            if (MessageBox.Show(
            "Có chắc chắn hủy bỏ sách với mã số sách " + m_MsSach + " không?",
            "Sách", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String SQL = "delete from Sach where MSSach='" + m_MsSach + "'";
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
            m_MsSach = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSSach"].ToString().Trim();
            String NhanDeSach =
            dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NhanDeSach"].ToString().Trim();
            String MSNXB = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString().Trim();
            int NamXB =
            int.Parse(dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NamXB"].ToString().Trim());
            int SoTrang =
            int.Parse(dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["SoTrang"].ToString().Trim());
            if (btgNhomLenh.Mode == 1)
            {
                if (m_MsSach.Trim() != "" && NhanDeSach.Trim() != "" && MSNXB.Trim() != "" && NamXB > 0
&& SoTrang > 0)
                {
                    String SQL = "select count(*) from Sach where MSSach='" + m_MsSach.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    int So = (int)cmd.ExecuteScalar();
                    if (So == 0)
                    {
                        SQL = "select count(*) from NhaXuatBan where MSNXB='" + MSNXB.Trim() + "'";
                        cmd = new SqlCommand(SQL, conn);
                        int So1 = (int)cmd.ExecuteScalar();
                        return So1 > 0;
                    }
                }
            }
            else
            {
                if (NhanDeSach.Trim() != "" && MSNXB.Trim() != "" && NamXB > 0 && SoTrang > 0)
                {
                    String SQL = "select count(*) from NhaXuatBan where MSNXB='" + MSNXB.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    return ((int)cmd.ExecuteScalar()) > 0;
                }
            }
            return false;
        }

        private bool btgNhomLenh_CanDelete(object sender, ButtonGroupEventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            m_MsSach = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSSach"].ToString().Trim();
            String SQL = "select count(*) from SachTacGia where MSSach='" + m_MsSach.Trim() + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            int So = (int)cmd.ExecuteScalar();
            return (So == 0);
        }

        private void btgNhomLenh_PrintClick(object sender, ButtonGroupEventArgs e)
        {
            MessageBox.Show("Chưa viết chương trình in", this.Text);
        }

        private void btgNhomLenh_ExtraClick(object sender, ButtonGroupEventArgs e)
        {
            frmHinhBia frm = new frmHinhBia();
            if (conn.State == ConnectionState.Closed) conn.Open();
            frm.txtMSSach.Text = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSSach"].ToString().Trim();
            frm.txtNhanDeSach.Text =
            dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NhanDeSach"].ToString().Trim();
            frm.txtMSNXB.Text =
            dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString().Trim();
            frm.txtNamXB.Text = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NamXB"].ToString().Trim();
            frm.txtSoTrang.Text = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["SoTrang"].ToString();
            if (!dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["HinhBia"].Equals(System.DBNull.Value))
            {
                MemoryStream ms =
                new MemoryStream((byte[])(dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["HinhBia"]));
                frm.pbHinhBia.Image = Image.FromStream(ms);
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                DinhViLai(m_MsSach);
            }
        }

        private void btgNhomLenh_Extra2Click(object sender, ButtonGroupEventArgs e)
        {
            frmSachTacGia frm = new frmSachTacGia();
            if (conn.State == ConnectionState.Closed) conn.Open();
            frm.MSSach = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSSach"].ToString().Trim();
            frm.NhanDeSach =
            dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NhanDeSach"].ToString().Trim();
            frm.MSNXB = dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["MSNXB"].ToString().Trim();
            frm.NamXB = int.Parse(dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["NamXB"].ToString());
            frm.SoTrang = int.Parse(dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["SoTrang"].ToString());
            if (!dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["HinhBia"].Equals(System.DBNull.Value))
            {
                MemoryStream ms =
                new MemoryStream((byte[])(dsSach.Tables[m_Table].Rows[btgNhomLenh.Position]["HinhBia"]));
                frm.HinhBia = Image.FromStream(ms);
            }
            frm.ShowDialog();
        }
    }
}
