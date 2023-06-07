using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.WebRequestMethods;

namespace Dealer
{
    public partial class Register : Form
    {
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtCustomers;
        public Register()
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

        private void lbl_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private async void btn_register_Click(object sender, EventArgs e)
        {
            bool emailUnavailable = false;
            if (txt_email.Text == "" || txt_name.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please input all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radio_L.Checked == false && radio_P.Checked == false)
            {
                MessageBox.Show("Please state your gender.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cek format email
            else if (!txt_email.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email not in correct format.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cek password lebih dari atau kurang dari 6
            else if (txt_password.Text.Length > 6 || txt_password.Text.Length < 6)
            {
                MessageBox.Show("Password must be 6 digits long.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cek password apakah angka saja, atau ada huruf atau simbol
            else if (!isDigitsOnly(txt_password.Text)) 
            {
                MessageBox.Show("Password must consist of numbers only.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cek password dan confirm password sama atau tidak
            else if (txt_password.Text != txt_confirm.Text)
            {
                MessageBox.Show("Passwords don't match.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < dtCustomers.Rows.Count; i++)
                {
                    if (dtCustomers.Rows[i][0].ToString() == txt_email.Text)
                    {
                        MessageBox.Show("Email already registered, please try another email.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailUnavailable = true;
                        break;
                    }
                }
                if (!emailUnavailable)
                {
                    string gender = "";
                    if(radio_L.Checked == true)
                    {
                        gender = "L";
                    }
                    else
                    {
                        gender = "P";
                    }
                    string query = $"insert into customer values('{txt_email.Text}', '{txt_password.Text}', '{txt_name.Text}', '{cust_borndate.Value.ToString("yyyy-MM-dd")}', '{gender}')";
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand = new MySqlCommand(query, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                        updateCustomers();
                        MessageBox.Show("Register successful! You can now login.", "", MessageBoxButtons.OK);
                        this.Hide();
                        new Login().Show();
                    }
                }
            }
        }

        public static bool isDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dtCustomers = new DataTable();
            updateCustomers();
        }

        private void updateCustomers()
        {
            dtCustomers.Clear();
            string command = "select * from customer";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtCustomers);
        }
    }
}
