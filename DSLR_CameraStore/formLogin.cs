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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtUsername.Text.Length == 0) || (txtPassword.Text.Length == 0))
                {
                    MessageBox.Show("Username Or Password cannot left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sqlConnect.Connect.Open();
                    SqlCommand sqlInsert = new SqlCommand("INSERT INTO TBLOGIN VALUES (@USERNAME,@PASSWORD)", sqlConnect.Connect);
                    sqlInsert.Parameters.AddWithValue("@USERNAME", txtUsername.Text.Trim());
                    sqlInsert.Parameters.AddWithValue("@PASSWORD", txtPassword.Text.Trim());
                    //eksekusi baris perintah T-SQL
                    sqlInsert.ExecuteNonQuery();
                    MessageBox.Show("Data saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    sqlConnect.Connect.Close();
                    Display();
                }

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
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("SELECT * FROM TBLOGIN", sqlConnect.Connect);
                DataTable dt = new DataTable();
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                sqlDisplay.Fill(dt);
                dg_Login.DataSource = dt;
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

        private void formLogin_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE TBLOGIN SET PASSWORD = @PASSWORD WHERE USERNAME=@USERNAME", sqlConnect.Connect);

                cmdUpdate.Parameters.AddWithValue("@USERNAME", txtUsername.Text.Trim());
                cmdUpdate.Parameters.AddWithValue("@PASSWORD", txtPassword.Text.Trim());


                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Data Terupdate");
                txtUsername.Clear();
                txtPassword.Clear();
                sqlConnect.Connect.Close();
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM TBLOGIN WHERE USERNAME =@USERNAME", sqlConnect.Connect);
                cmdDelete.Parameters.AddWithValue("@USERNAME", txtUsername.Text.Trim());


                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Data Terhapus");

                sqlConnect.Connect.Close();
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void dg_Login_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dg_Login_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_Login.SelectedRows.Count > 0)
            {
                txtUsername.Text = dg_Login.SelectedRows[0].Cells
                    [0].Value.ToString();

                txtPassword.Text = dg_Login.SelectedRows[0].Cells
                    [1].Value.ToString();
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }
    }
    
}
