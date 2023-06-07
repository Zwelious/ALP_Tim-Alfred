using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dealer
{
    public partial class History : Form
    {
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtHistory, dtDetails;
        string menu;
        public History()
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

        private void History_Load(object sender, EventArgs e)
        {
            txt_search.Enabled = false;
            btn_search.Enabled = false;
            btn_reset.Enabled = false;
            dtHistory = new DataTable();
            dgv_history.DataSource = dtHistory;
            dtDetails = new DataTable();
            clearData();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(Admin.isAdmin == true)
            {
                this.Hide();
                Admin home = new Admin();
                home.Show();
            }
            else
            {
                this.Controls.Clear();
                Homepage home = new Homepage();
                home.TopLevel = false;
                home.Dock = DockStyle.Fill;
                this.Controls.Add(home);
                home.Show();
            }
            
        }

        private void btn_carsales_Click(object sender, EventArgs e)
        {
            clearData();
            menu = "car";
            btn_carsales.Enabled = false;
            btn_accsales.Enabled = true;
            txt_search.Enabled = true;
            btn_search.Enabled = true;
            btn_reset.Enabled = true;
            string command = "";
            if(Admin.isAdmin == true)
            {
                command = $"select cs.email as Email, cs.carsales_id as `ID`, c.car_name as Mobil, cs.buy_date as `Date`, cs.no_rangka as `Nomor Rangka`, c.car_color as Warna from carsales cs, cars c, car_inventory i where c.car_id = i.car_id and i.no_rangka = cs.no_rangka";
            }
            else
            {
                command = $"select cs.carsales_id as `ID`, c.car_name as Mobil, cs.buy_date as `Date`, cs.no_rangka as `Nomor Rangka`, c.car_color as Warna from carsales cs, cars c, car_inventory i where c.car_id = i.car_id and i.no_rangka = cs.no_rangka and email = '{Login.userEmail}'";
            }
            
            fillDGV(command, dtHistory);
        }

        private void btn_accsales_Click(object sender, EventArgs e)
        {
            clearData();
            menu = "acc";
            btn_accsales.Enabled = false;
            btn_carsales.Enabled = true;
            txt_search.Enabled = true;
            btn_search.Enabled = true;
            btn_reset.Enabled = true;
            string command = "";
            if (Admin.isAdmin == true)
            {
                command = $"select s.email as Email, s.accsales_id as `ID`, a.accessories_name as Barang, s.total_buying as Jumlah from accessories_sales s, accessories_inventory a where s.accessories_id = a.accessories_id";
            }
            else
            {
                command = $"select s.accsales_id as `ID`, a.accessories_name as Barang, s.total_buying as Jumlah from accessories_sales s, accessories_inventory a where s.accessories_id = a.accessories_id and email = '{Login.userEmail}'";
            }
                
            fillDGV(command, dtHistory);
        }
        
        private void fillDGV(string query, DataTable dthistory)
        {
            dthistory.Rows.Clear();
            dthistory.Columns.Clear();
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dthistory);
        }

        private void dgv_history_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            trans_id.Text = dgv_history.CurrentRow.Cells[0].Value.ToString();
            if(menu == "car")
            {
                string command;
                if(Admin.isAdmin == true)
                {
                    command = $"select cs.carsales_id, cs.no_rangka, c.car_name, c.car_transmission, c.car_color, c.car_price, a.adminn_name from carsales cs, cars c, car_inventory ci, adminn a where cs.carsales_id = '{trans_id.Text}' and cs.no_rangka = ci.no_rangka and ci.car_id = c.car_id and cs.adminn_id = a.adminn_id";
                }
                else
                {
                    command = $"select cs.carsales_id, cs.no_rangka, c.car_name, c.car_transmission, c.car_color, c.car_price, a.adminn_name from carsales cs, cars c, car_inventory ci, adminn a where cs.carsales_id = '{trans_id.Text}' and cs.no_rangka = ci.no_rangka and ci.car_id = c.car_id and cs.adminn_id = a.adminn_id and cs.email = '{Login.userEmail}'";
                }
                
                fillDGV(command, dtDetails);
                string no = dtDetails.Rows[0][1].ToString();
                string name = dtDetails.Rows[0][2].ToString();
                string trans = dtDetails.Rows[0][3].ToString();
                string color = dtDetails.Rows[0][4].ToString();
                double price = Convert.ToInt32(dtDetails.Rows[0][5].ToString()) * 1.1;
                string admin = dtDetails.Rows[0][6].ToString();
                item_details.Text = no + "\n" + name + "\n" + trans + "\n" + color;
                total_paid.Text = "Rp. " + price.ToString();
                admin_name.Text = admin;
            }
            else if(menu == "acc")
            {
                string command;
                if(Admin.isAdmin == true)
                {
                    command = $"select a.accsales_id, ai.accessories_id, ai.accessories_name, ai.accessories_price, a.total_buying from accessories_sales a, accessories_inventory ai where a.accsales_id = '{trans_id.Text}' and ai.accessories_id = a.accessories_id";
                }
                else
                {
                    command = $"select a.accsales_id, ai.accessories_id, ai.accessories_name, ai.accessories_price, a.total_buying from accessories_sales a, accessories_inventory ai where a.accsales_id = '{trans_id.Text}' and ai.accessories_id = a.accessories_id and a.email = '{Login.userEmail}'";
                }
                fillDGV(command, dtDetails);
                string item = "";
                double total = 0;
                for(int i = 0; i < dtDetails.Rows.Count; i++)
                {
                    string accID = dtDetails.Rows[i][1].ToString();
                    string name = dtDetails.Rows[i][2].ToString();
                    total += (Convert.ToInt32(dtDetails.Rows[i][3].ToString()) * Convert.ToInt32(dtDetails.Rows[i][4].ToString()));
                    item += accID + " - " + name + "\n";
                }
                total = total * 1.1;
                item_details.Text = item;
                total_paid.Text = "Rp. " + total.ToString();
                admin_name.Text = "-";

            }
            
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if(menu == "car")
            {
                string command = $"select cs.carsales_id as `ID`, c.car_name as Mobil, cs.buy_date as `Date`, cs.no_rangka as `Nomor Rangka`, c.car_color as Warna from carsales cs, cars c, car_inventory i where c.car_id = i.car_id and i.no_rangka = cs.no_rangka and cs.email = '{Login.userEmail}' and c.car_name like '%{txt_search.Text}%'";
                fillDGV(command, dtHistory);
            }
            else if(menu == "acc")
            {
                string command = $"select s.accsales_id as `ID`, a.accessories_name as Barang, s.total_buying as Jumlah from accessories_sales s, accessories_inventory a where s.accessories_id = a.accessories_id and s.email = '{Login.userEmail}' and a.accessories_name like '%{txt_search.Text}%'";
                fillDGV(command, dtHistory);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dtHistory.Clear();
            dtHistory.Columns.Clear();
            txt_search.Enabled = false;
            btn_search.Enabled = false;
            btn_reset.Enabled = false;
            clearData();
            btn_carsales.Enabled = true;
            btn_accsales.Enabled = true;
        }

        private void clearData()
        {
            trans_id.Text = "";
            item_details.Text = "";
            total_paid.Text = "";
            admin_name.Text = "";
        }
    }
}
