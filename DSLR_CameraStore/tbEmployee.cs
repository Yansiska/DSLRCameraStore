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
    public partial class tbEmployee : Form
    {
        public tbEmployee()
        {
            InitializeComponent();
        }

        private void btnAddE_Click(object sender, EventArgs e)
        {

            try
            {
                sqlConnect.Connect.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO TBEMPLOYEE VALUES (@ID_EMPLOYEE,@NAME,@ADDRESS,@POSITION,@GENDER,@PHONE_NUMBER,@EMAIL)", sqlConnect.Connect);
                sqlInsert.Parameters.AddWithValue("@ID_EMPLOYEE", txtIDEmployee.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@NAME", txtNameE.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@ADDRESS", txtAddresE.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@POSITION", cb_Position.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@GENDER", cb_gender.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@PHONE_NUMBER", txtPhoneE.Text.Trim());
                sqlInsert.Parameters.AddWithValue("@EMAIL", txtEmailE.Text.Trim());
                //eksekusi baris perintah T-SQL
                sqlInsert.ExecuteNonQuery();
                MessageBox.Show("Data saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDEmployee.Clear();
                txtNameE.Clear();
                txtAddresE.Clear();
                cb_Position.Text = "";
                cb_gender.Text = "";
                txtPhoneE.Clear();
                txtEmailE.Clear();

                sqlConnect.Connect.Close();
                Display();
                Auto();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
            }
        }

        public void Display()
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("SELECT * FROM TBEMPLOYEE", sqlConnect.Connect);
                DataTable dt = new DataTable();
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                sqlDisplay.Fill(dt);
                dgEmployee.DataSource = dt;
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

        private void btnUpdateE_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE TBEMPLOYEE SET Phone_Number = @Phone_Number WHERE ID_Employee=@ID_Employee", sqlConnect.Connect);

                cmdUpdate.Parameters.AddWithValue("@ID_Employee", txtIDEmployee.Text.Trim());
                cmdUpdate.Parameters.AddWithValue("@Phone_Number", txtPhoneE.Text.Trim());


                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Data Terupdate");
                txtIDEmployee.Clear();
                txtNameE.Clear();
                txtAddresE.Clear();
                cb_Position.Text = "";
                cb_gender.Text = "";
                txtPhoneE.Clear();
                txtEmailE.Clear();

                sqlConnect.Connect.Close();
                Display();
                Auto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM TBEMPLOYEE WHERE ID_Employee =@ID_Employee", sqlConnect.Connect);
                cmdDelete.Parameters.AddWithValue("@ID_Employee", txtIDEmployee.Text.Trim());


                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Data Terhapus");
                txtIDEmployee.Clear();
                txtNameE.Clear();
                txtAddresE.Clear();
                cb_Position.Text = "";
                cb_gender.Text = "";
                txtPhoneE.Clear();
                txtEmailE.Clear();

                sqlConnect.Connect.Close();
                Display();
                Auto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void tbEmployee_Load(object sender, EventArgs e)
        {
            Display();
            Auto();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MenuAdmin obj = new MenuAdmin();
            obj.Show();
            this.Hide();
        }

        private void dgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmployee.SelectedRows.Count > 0)
            {
                txtIDEmployee.Text = dgEmployee.Rows[e.RowIndex].Cells
                    [0].Value.ToString();
                txtNameE.Text = dgEmployee.Rows[e.RowIndex].Cells
                    [1].Value.ToString();
                txtAddresE.Text = dgEmployee.Rows[e.RowIndex].Cells
                    [2].Value.ToString();
                cb_Position.Text = dgEmployee.Rows[e.RowIndex].Cells
                    [3].Value.ToString();
                cb_gender.Text = dgEmployee.Rows[e.RowIndex].Cells
                    [4].Value.ToString();
                txtPhoneE.Text = dgEmployee.Rows[e.RowIndex].Cells
                    [5].Value.ToString();
                txtEmailE.Text = dgEmployee.Rows[e.RowIndex].Cells
                    [6].Value.ToString();
            }
        }
        
        public void Auto()
        {
            sqlConnect.Connect.Open();
            SqlCommand SC = new SqlCommand("Select Top 1 * from tbEmployee order by ID_Employee desc", sqlConnect.Connect);
            SqlDataReader SDR = SC.ExecuteReader();
            bool AdaData = SDR.Read();
            if (AdaData)
            {
                int idAngka = AutoGetID((string)SDR[0]);
                idAngka += 1;
                txtIDEmployee.Text = AutoGeneratedID(idAngka);
            }
            else
            {
                int idAngka = 1;
                txtIDEmployee.Text = AutoGeneratedID(idAngka);
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
            return 'E' + hasil;
        }

        private void cb_Position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
