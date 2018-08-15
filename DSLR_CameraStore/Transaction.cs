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
    public partial class Transaction : Form
    {
        private string idTrans;
        public Transaction()
        { 
            InitializeComponent();
            idTrans = tbTransaction.Text;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            Auto();
            
            //Display();
            DisplayProduct();
            txtDate.Text = DateTime.Now.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
            obj.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO DetailTransaction VALUES (@ID_Transaction,@Name,@Address,@ID_Product,@Name_Product,@Stock,@Qty,@Price,@Total_Price,@Date)", sqlConnect.Connect);
                sqlInsert.Parameters.AddWithValue("@ID_Transaction", tbTransaction.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Name", tbName.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Address", tbAddress.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@ID_Product", tbIdProduct.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Name_Product", txtNameProduct.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Stock", txtStockP.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Qty", tbQty.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Price", (Convert.ToDouble(tbPrice.Text.Trim())));
                sqlInsert.Parameters.AddWithValue("@Total_Price", txtTotalPrice.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@Date", txtDate.Text.Trim());

                //eksekusi baris perintah T-SQL
                sqlInsert.ExecuteNonQuery();
                MessageBox.Show("Data saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                CreportTransaction crt = new CreportTransaction(tbTransaction.Text);
                crt.Show();

                tbTransaction.Clear();
                tbName.Clear();
                tbAddress.Clear();
                tbIdProduct.Clear();
                txtNameProduct.Clear();
                txtStockP.Clear();
                tbQty.Clear();
                tbPrice.Clear();
                txtTotalPrice.Clear();
                txtDate.Text = DateTime.Now.ToString();

                sqlConnect.Connect.Close();
                DisplayProduct();
                Auto();


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*public void Display()
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("SELECT * FROM DetailTransaction", sqlConnect.Connect);
                DataTable dt = new DataTable();
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                sqlDisplay.Fill(dt);
                datagTransaction.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                sqlConnect.Connect.Close();
            }
        }*/

        

        public void DisplayProduct()
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("SELECT * FROM DETAILPRODUCT", sqlConnect.Connect);
                DataTable dt = new DataTable();
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                sqlDisplay.Fill(dt);
                dgProduct.DataSource = dt;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
            obj.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdProduct.Text = dgProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameProduct.Text = dgProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStockP.Text = dgProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPrice.Text = dgProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        public void OtomatisQTY()
        {
            if ((tbPrice.Text == "") || (tbQty.Text == ""))
            {
                txtTotalPrice.Text = "";
            }
            else if ((Convert.ToDouble(tbPrice.Text) <= 0) || (int.Parse(tbQty.Text) <= 0))
            {
                txtTotalPrice.Text = "Invalid Input !";
            }


            else
            {
                txtTotalPrice.Text = Convert.ToString(Convert.ToDouble(tbPrice.Text) * int.Parse(tbQty.Text));
            }
        }
        public void remaining_stock()
        {
            if ((txtStockP.Text == "") || (tbQty.Text == ""))
            {
                txtStockP.Text = "";
            }

            else if ((int.Parse(txtStockP.Text) < 0) || (int.Parse(tbQty.Text) < 0))
            {
                txtStockP.Text = "0";
            }

            else if (int.Parse(tbQty.Text) > int.Parse(txtStockP.Text))
            {
                txtStockP.Text = "Invalid Input !";
            }

            else
            {
                txtStockP.Text = Convert.ToString(int.Parse(txtStockP.Text) - int.Parse(tbQty.Text));
            }
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            remaining_stock();
            OtomatisQTY();
        }

        private void txtStockP_TextChanged(object sender, EventArgs e)
        {
            //remaining_stock();
        }

        private void txtSisa_TextChanged(object sender, EventArgs e)
        {
            //remaining_stock();
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
                tbTransaction.Text = AutoGeneratedID(idAngka);
            }
            else
            {
                int idAngka = 1;
                tbTransaction.Text = AutoGeneratedID(idAngka);
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

        private void tbTransaction_TextChanged(object sender, EventArgs e)
        {
            //Auto();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            /*CreportTransaction obj = new CreportTransaction();
            obj.Show();
            this.Hide();*/
        }
    }
}
