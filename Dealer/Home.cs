using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dealer
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(Login.userEmail != null)
            {
                lbl_userEmail.Text = Login.userEmail;
                lbl_userEmail.Location = new Point(500, 35);
                lbl_login.Text = "Log out";
            }

            Homepage home = new Homepage();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            this.panel_menu.Controls.Add(home);
            home.Show();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            if(lbl_login.Text == "Log out")
            {
                Login.userEmail = null;
                if(Accessories.cart != null)
                {
                    Accessories.cart.Clear();
                }
                else if(Cart.cart != null)
                {
                    Cart.cart.Clear();
                }
                this.Hide();
                new Menu().Show();
            }
            else
            {
                this.Hide();
                new Login().Show();
            }
        }

        private void lbl_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminLogin().Show();
        }

        private void lbl_login_MouseHover(object sender, EventArgs e)
        {
            lbl_login.ForeColor = Color.LightBlue;
        }

        private void lbl_login_MouseLeave(object sender, EventArgs e)
        {
            lbl_login.ForeColor = Color.Cyan;
        }
        private void lbl_admin_MouseEnter(object sender, EventArgs e)
        {
            lbl_admin.ForeColor = Color.Cyan;
        }

        private void lbl_admin_MouseHover(object sender, EventArgs e)
        {
            lbl_admin.ForeColor = Color.LightBlue;
        }
    }
}
