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

namespace DSLR_CameraStore
{
    public partial class formLoginn : Form
    {
        public formLoginn()
        {
            InitializeComponent();
        }

        private void txtPrint_Click(object sender, EventArgs e)
        {
           txtPrint.Clear();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlDataAdapter sqlSearch = new SqlDataAdapter("SELECT * FROM TBLOGIN WHERE USERNAME = '" + txtPrint.Text.Trim() + "'", sqlConnect.Connect);
                DataSet ds = new DataSet();
                sqlSearch.SelectCommand.ExecuteNonQuery();
                sqlSearch.Fill(ds, "my_data");
                ReportLogin rpt = new ReportLogin();
                rpt.SetDataSource(ds);
                crystalReport.ReportSource = ds;

                sqlConnect.Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
