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
    public partial class Login : Form
    {
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtCustomers;
        public static string userEmail;
        public Login()
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
        private void lbl_clearFields_Click(object sender, EventArgs e)
        {
            txt_email.Clear();
            txt_password.Clear();
            txt_email.Focus();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool loginSuccess = false;
            if(txt_email.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please input all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dtCustomers.Rows.Count; i++)
                {
                    if (dtCustomers.Rows[i][0].ToString() == txt_email.Text)
                    {
                        if (dtCustomers.Rows[i][1].ToString() == txt_password.Text)
                        {
                            loginSuccess = true;
                        }
                    }
                }
                if (loginSuccess)
                {
                    userEmail = txt_email.Text;
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    new Home().Show();
                }
                else
                {
                    MessageBox.Show("The email or password you entered is incorrect, please try again.");
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
                dtCustomers = new DataTable();
                string command = "select * from customer";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtCustomers);
        }

        private void lbl_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminLogin().Show();
        }
    }
}
