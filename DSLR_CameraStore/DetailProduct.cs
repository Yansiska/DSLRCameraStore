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
    public partial class DetailProduct : Form
    {
        public DetailProduct()
        {
            InitializeComponent();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO DETAILPRODUCT VALUES (@ID_Product,@Name_Product,@Stock,@Price,@Description)", sqlConnect.Connect);
                sqlInsert.Parameters.AddWithValue("@ID_Product", txtIdProductP.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Name_Product", txtNameP.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Stock", txtStockP.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Price", (Convert.ToDouble(txtPriceP.Text)));
                sqlInsert.Parameters.AddWithValue("@Description", txtDescriptionP.Text.Trim());
                
                //eksekusi baris perintah T-SQL
                sqlInsert.ExecuteNonQuery();
                MessageBox.Show("Data saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProductP.Clear();
                txtNameP.Clear();
                txtStockP.Clear();
                txtPriceP.Clear();
                txtDescriptionP.Clear();

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
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("SELECT * FROM DETAILPRODUCT", sqlConnect.Connect);
                DataTable dt = new DataTable();
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                sqlDisplay.Fill(dt);
                dgDetailProduct.DataSource = dt;
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

        private void btnUpdateP_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE DETAILPRODUCT SET Stock = @Stock WHERE ID_Product=@ID_Product", sqlConnect.Connect);

                cmdUpdate.Parameters.AddWithValue("@ID_Product", txtIdProductP.Text.Trim());
                cmdUpdate.Parameters.AddWithValue("@Stock", txtStockP.Text.Trim());


                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Data Terupdate");
                txtIdProductP.Clear();
                txtNameP.Clear();
                txtStockP.Clear();
                txtPriceP.Clear();
                txtDescriptionP.Clear();

                sqlConnect.Connect.Close();
                Display();
                Auto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM DETAILPRODUCT WHERE ID_Product =@ID_Product", sqlConnect.Connect);
                cmdDelete.Parameters.AddWithValue("@ID_Product", txtIdProductP.Text.Trim());


                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Data Terhapus");
                txtIdProductP.Clear();
                txtNameP.Clear();
                txtStockP.Clear();
                txtPriceP.Clear();
                txtDescriptionP.Clear();

                sqlConnect.Connect.Close();
                Display();
                Auto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void dgDetailProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDetailProduct.SelectedRows.Count > 0)
            {
                txtIdProductP.Text = dgDetailProduct.Rows[e.RowIndex].Cells
                    [0].Value.ToString();

                txtNameP.Text = dgDetailProduct.Rows[e.RowIndex].Cells
                    [1].Value.ToString();
                txtStockP.Text = dgDetailProduct.Rows[e.RowIndex].Cells
                    [2].Value.ToString();
                txtPriceP.Text = dgDetailProduct.Rows[e.RowIndex].Cells
                    [3].Value.ToString();
                txtDescriptionP.Text = dgDetailProduct.Rows[e.RowIndex].Cells
                    [4].Value.ToString();
            }
        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            Display();
            Auto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin obj = new MenuAdmin();
            obj.Show();
            this.Hide();
        }

        private void dgDetailProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void txtNameP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("SELECT * FROM DETAILPRODUCT2 WHERE NAME_PRODUCT LIKE '%' + '" + txtNameP.Text + "' + '%'", sqlConnect.Connect);
                DataTable dt = new DataTable();
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                sqlDisplay.Fill(dt);
                dgDetailProduct.DataSource = dt;
                sqlConnect.Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }*/
        public void Auto()
        {
            sqlConnect.Connect.Open();
            SqlCommand SC = new SqlCommand("Select Top 1 * from DetailProduct order by ID_Product desc", sqlConnect.Connect);
            SqlDataReader SDR = SC.ExecuteReader();
            bool AdaData = SDR.Read();
            if (AdaData)
            {
                int idAngka = AutoGetID((string)SDR[0]);
                idAngka += 1;
                txtIdProductP.Text = AutoGeneratedID(idAngka);
            }
            else
            {
                int idAngka = 1;
                txtIdProductP.Text = AutoGeneratedID(idAngka);
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
            return 'P' + hasil;
        }
    }
    
}
