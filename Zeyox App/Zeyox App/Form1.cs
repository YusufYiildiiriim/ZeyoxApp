using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeyox_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FavoriteButton_Click(object sender, EventArgs e)
        {
            FavoriteForm favoriteForm = new FavoriteForm();
            favoriteForm.ShowDialog();
        }

        private void BasketButton_Click(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm();  
            basketForm.ShowDialog();
        }

        private void Login_Registerbutton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void addressbutton_Click(object sender, EventArgs e)
        {
            AddressesForm addressForm = new AddressesForm();
            addressForm.ShowDialog();
        }
    }
}
