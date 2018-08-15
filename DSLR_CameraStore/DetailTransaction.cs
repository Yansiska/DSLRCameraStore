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
    public partial class DetailTransaction : Form
    {
        public DetailTransaction()
        {
            InitializeComponent();
        }

        private void btnAddT_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO DETAILTRANSACTION VALUES (@ID_Transaction,@Name,@Address,@ID_Product,@Name_Product,@Stock,@Qty,@Price,@Total_Price,@Date)", sqlConnect.Connect);
                sqlInsert.Parameters.AddWithValue("@ID_Transaction", txtIDT.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Name", txtNameT.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Address", txtAddresT.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@ID_Product", txtIDP.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Name_Product", txtNameP.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Stock", txtStockP.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Qty", txtQtyT.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Price", txtPriceT.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Total_Price", txtPriceT.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Date", txtDateT.Text.Trim());
                //eksekusi baris perintah T-SQL
                sqlInsert.ExecuteNonQuery();
                MessageBox.Show("Data saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDT.Clear();
                txtNameT.Clear();
                txtAddresT.Clear();
                txtIDP.Clear();
                txtNameP.Clear();
                txtStockP.Clear();
                txtQtyT.Clear();
                txtPriceT.Clear();
                txtTotalPrice.Clear();
                txtDateT.Text = DateTime.Now.ToString();

                sqlConnect.Connect.Close();
                Display();
                Auto();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Display()
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("SELECT * FROM DetailTransaction", sqlConnect.Connect);
                DataTable dt = new DataTable();
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                sqlDisplay.Fill(dt);
                dgDetailTransaction.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                sqlConnect.Connect.Close();
            }
        }

        private void dgDetailTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDetailTransaction.SelectedRows.Count > 0)
            {
                txtIDT.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [0].Value.ToString();

                txtNameT.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [1].Value.ToString();
                txtAddresT.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [2].Value.ToString();
                txtIDP.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [3].Value.ToString();
                txtNameP.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [4].Value.ToString();
                txtStockP.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [5].Value.ToString();
                txtQtyT.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [6].Value.ToString();
                txtPriceT.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [7].Value.ToString();
                txtTotalPrice.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [8].Value.ToString();
                txtDateT.Text = dgDetailTransaction.Rows[e.RowIndex].Cells
                    [9].Value.ToString();
            }
        }

        private void DetailTransaction_Load(object sender, EventArgs e)
        {
            Display();
            Auto();
            txtDateT.Text = DateTime.Now.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM DETAILTRANSACTION WHERE ID_Transaction =@ID_Transaction", sqlConnect.Connect);
                cmdDelete.Parameters.AddWithValue("@ID_Transaction", txtIDT.Text.Trim());


                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Data Terhapus");
                txtIDT.Clear();
                txtNameT.Clear();
                txtAddresT.Clear();
                txtIDP.Clear();
                txtNameP.Clear();
                txtStockP.Clear();
                txtQtyT.Clear();
                txtPriceT.Clear();
                txtTotalPrice.Clear();
                txtDateT.Text = DateTime.Now.ToString();

                sqlConnect.Connect.Close();
                Display();
                Auto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MenuAdmin obj = new MenuAdmin();
            obj.Show();
            this.Hide();
        }
        public void Auto()
        {
            sqlConnect.Connect.Open();
            SqlCommand SC = new SqlCommand("Select Top 1 * from DetailTransaction order by ID_Transaction desc", sqlConnect.Connect);
            SqlDataReader SDR = SC.ExecuteReader();
            bool AdaData = SDR.Read();
            if (AdaData)
            {
                int idAngka = AutoGetID((string)SDR[0]);
                idAngka += 1;
                txtIDT.Text = AutoGeneratedID(idAngka);
            }
            else
            {
                int idAngka = 1;
                txtIDT.Text = AutoGeneratedID(idAngka);
            }
            SDR.Close();

            sqlConnect.Connect.Close();
        }

        public bool ketemuSelainNol = false;
        public string angkaKodeLama = "";


        public int AutoGetID(string kodeLama)
        {
            bool ketemuSelainNol = false;
            string angkaKodeLama = "";
            for (int i = 0; i < kodeLama.Length; i++)
            {
                if (Char.IsNumber(kodeLama[i]))
                {
                    if (!ketemuSelainNol)
                    {
                        if (kodeLama[i] != '0')
                        {
                            ketemuSelainNol = true;
                            angkaKodeLama += kodeLama[i];
                        }
                    }
                    else
                    {
                        angkaKodeLama += kodeLama[i]; //angkaKodeLama = angkaKodeLama + kodeLama[i]
                    }
                }
            }
            return int.Parse(angkaKodeLama); //untuk mengembalikan nilai dari variabel\
        }

        public string AutoGeneratedID(int id)
        {
            string hasil = "";
            string idString = id.ToString();
            int digit = 3;
            int a = 0;
            int indexMulaiDigit = digit - idString.Length - 1;
            for (int i = 0; i < digit; i++)
            {
                if (i > indexMulaiDigit)
                {
                    hasil += idString[a];
                    a += 1;
                }
                else
                {
                    hasil += '0';
                }
            }
            return 'T' + hasil;
        }
    }
}
