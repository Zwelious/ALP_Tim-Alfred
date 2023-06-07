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

namespace Dealer
{
    public partial class Payment : Form
    {
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtSales, dtAdmin;
        public Payment()
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

        private void Payment_Load(object sender, EventArgs e)
        {
            car_name.Text = CarBuy.name + " - " + CarBuy.color;
            car_no.Text = CarBuy.norangka;
            cust_email.Text = Login.userEmail;
            sub_total.Text = "Rp. " + CarBuy.harga.ToString();

            int pajak = Convert.ToInt32(CarBuy.harga) * 10 / 100;
            tax.Text = "Rp. " + pajak.ToString();

            int totall = Convert.ToInt32(CarBuy.harga) + pajak;
            total.Text = "Rp. " + totall.ToString();
            
            dtSales = new DataTable();
            string query = "select * from carsales";
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtSales);

            dtAdmin = new DataTable();
            string query2 = "select * from adminn";
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(query2, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtAdmin);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if(cmb_payment.Text == "")
            {
                MessageBox.Show("Please choose a payment method.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id = "P" + (dtSales.Rows.Count + 1).ToString("000");
                Random random = new Random();
                int count = random.Next(0, 6);

                string adminID = dtAdmin.Rows[count][0].ToString();

                int stock = Convert.ToInt32(CarBuy.dtChosenCar.Rows[0][3].ToString()) - 1;
                string command = $"update car_inventory set sold = 1 where no_rangka = '{CarBuy.norangka}'";
                string command2 = $"update cars set car_stock = '{stock}' where car_id = '{CarBuy.dtChosenCar.Rows[0][0].ToString()}'";
                string command_addSale = $"insert into carsales values ('{id}', '{cust_email.Text}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{car_no.Text}', '{adminID}')";
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }

                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(command2, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }

                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(command_addSale, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }

                this.Controls.Clear();

                Purchase_Success pay = new Purchase_Success();
                pay.TopLevel = false;
                pay.Dock = DockStyle.Fill;
                this.Controls.Add(pay);
                pay.Show();
            }
            
        }
    }
}
