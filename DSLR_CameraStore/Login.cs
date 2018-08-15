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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Connect.Open();
                SqlCommand cmdDisplay = new SqlCommand("SELECT * FROM TBLOGIN WHERE USERNAME =@USERNAME AND PASSWORD =@PASSWORD", sqlConnect.Connect);
                cmdDisplay.Parameters.AddWithValue("@USERNAME", txtUsername.Text.Trim());
                cmdDisplay.Parameters.AddWithValue("@PASSWORD", txtPassword.Text.Trim());
                SqlDataReader dr;
                dr = cmdDisplay.ExecuteReader();
                if (dr.Read())
                {
                    //jika valid
                    MessageBox.Show("Welcome, " + txtUsername.Text);
                    MenuAdmin obj = new MenuAdmin();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    //jika invalid
                    MessageBox.Show(" Invalid Username or Password");
                }
                sqlConnect.Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
