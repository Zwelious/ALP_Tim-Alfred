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
using System.IO;

namespace Dealer
{
    public partial class Menu : Form
    {
        string connection;

        public Menu()
        {
            InitializeComponent();
        }

        private void btn_loginUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void lbl_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void lbl_login_MouseHover(object sender, EventArgs e)
        {
            lbl_login.ForeColor = Color.FromArgb(255, 192, 128);
        }

        private void lbl_start_MouseHover(object sender, EventArgs e)
        {
            lbl_start.ForeColor = Color.FromArgb(255, 192, 128);
        }

        private void lbl_login_MouseLeave(object sender, EventArgs e)
        {
            lbl_login.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void lbl_start_MouseLeave(object sender, EventArgs e)
        {
            lbl_start.ForeColor = Color.FromArgb(255, 128, 0);
        }
    }
}
