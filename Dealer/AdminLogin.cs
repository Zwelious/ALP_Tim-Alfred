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
    public partial class AdminLogin : Form
    {
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtAdmin;
        public AdminLogin()
        {
            connection = "server=localhost;user=root;pwd=;database=db_dealership";
            try
            {
                sqlConnection = new MySqlConnection(connection);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            dtAdmin = new DataTable();
            string command = "select * from adminn";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtAdmin);
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            bool loginSuccess = false;
            if (txt_adminID.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please input all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dtAdmin.Rows.Count; i++)
                {
                    if (dtAdmin.Rows[i][0].ToString() == txt_adminID.Text)
                    {
                        if (dtAdmin.Rows[i][1].ToString() == txt_password.Text)
                        {
                            loginSuccess = true;
                        }
                    }
                }
                if (loginSuccess)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    new Admin().Show();
                }
                else
                {
                    MessageBox.Show("The admin ID or password you entered is incorrect, please try again.");
                }
            }
        }
    }
}
