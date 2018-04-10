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
    public partial class frmHinhBia : Form
    {
        public frmHinhBia()
        {
            InitializeComponent();
        }

        #region Khai báo biến
        private String filename = "";

        #endregion

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            String DataPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString()).ToString();
            ofd.InitialDirectory = DataPath + "\\Hinh";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                pbHinhBia.Image = Bitmap.FromFile(filename);
                btnOK.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MainForm.ConnStr);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "UpdateImage",
                CommandType = CommandType.StoredProcedure
            })
            {
                cmd.Parameters.Add("@MSSach", SqlDbType.VarChar).Value = txtMSSach.Text;
                var fileBytes = System.IO.File.ReadAllBytes(filename);
                cmd.Parameters.Add("@HinhBia", SqlDbType.Image).Value = fileBytes;
                cmd.ExecuteScalar();
            }
            conn.Close();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
