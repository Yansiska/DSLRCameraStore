using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSLR_CameraStore
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            tbEmployee obj = new tbEmployee();
            obj.Show();
            this.Hide();
        }

        private void btnDProduct_Click(object sender, EventArgs e)
        {
            DetailProduct obj = new DetailProduct();
            obj.Show();
            this.Hide();
        }

        private void btnDTransaction_Click(object sender, EventArgs e)
        {
            DetailTransaction obj = new DetailTransaction();
            obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            formLogin obj = new formLogin();
            obj.Show();
            this.Hide();
        }
    }
}
