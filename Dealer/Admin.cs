using System;
using System.Collections;
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
    public partial class Admin : Form
    {
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtItem, dtCarInv;
        int stock, addedStock, harga;
        string id, nama, tipe, transmisi, color;

        private void Admin_Load(object sender, EventArgs e)
        {
            dtItem = new DataTable();
            dtCarInv = new DataTable();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu home = new Menu();
            home.Show();
        }

        public static bool isAdmin;

        private void btn_open_Click(object sender, EventArgs e)
        {
            isAdmin = true;
            this.Hide();
            History history = new History();
            history.Show();
        }

        public Admin()
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
        private void cmb_Menu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtItem.Clear();
            dtItem.Columns.Clear();
            if(cmb_Menu.Text == "Add Cars")
            {
                lbl_color.Visible = true;
                cmb_color.Visible = true;
                cmb_name.Items.Clear();
                lbl_name.Text = "Car Name";
                string command = "select * from cars";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtItem);
                for(int i = 0; i < dtItem.Rows.Count; i++)
                {
                    if (!cmb_name.Items.Contains(dtItem.Rows[i][1].ToString()))
                    {
                        cmb_name.Items.Add(dtItem.Rows[i][1].ToString());
                    }
                }
            }
            else if(cmb_Menu.Text == "Add Accessories")
            {
                lbl_color.Visible = false;
                cmb_color.Visible = false;
                cmb_name.Items.Clear();
                lbl_name.Text = "Accessory Name";
                string command = "select * from accessories_inventory";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtItem);
                for (int i = 0; i < dtItem.Rows.Count; i++)
                {
                    if (!cmb_name.Items.Contains(dtItem.Rows[i][1].ToString()))
                    {
                        cmb_name.Items.Add(dtItem.Rows[i][1].ToString());
                    }
                }

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Menu.Text == "" || cmb_name.Text == "" || cmb_color.Text == "" || numeric_stock.Value <= 0)
            {
                MessageBox.Show("Enter all fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmb_Menu.Text == "Add Cars")
                {
                    addedStock = Convert.ToInt32(numeric_stock.Value);
                    bool newColor = true;
                    for (int i = 0; i < dtItem.Rows.Count; i++)
                    {
                        if (dtItem.Rows[i][1].ToString() == cmb_name.Text)
                        {
                            id = dtItem.Rows[i][0].ToString();
                            nama = dtItem.Rows[i][1].ToString();
                            tipe = dtItem.Rows[i][2].ToString();
                            transmisi = dtItem.Rows[i][3].ToString();
                            harga = Convert.ToInt32(dtItem.Rows[i][4].ToString());
                            stock = Convert.ToInt32(dtItem.Rows[i][6].ToString());
                            color = cmb_color.Text;
                            if (color == dtItem.Rows[i][5].ToString())
                            {
                                newColor = false;
                                break;
                            }
                        }
                    }
                    if (newColor)
                    {
                        id = id.Substring(0, 6) + color[0];
                        string command = $"insert into cars values('{id}', '{nama}', '{tipe}', '{transmisi}', {harga}, '{color}', {addedStock})";
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
                    }
                    else
                    {
                        string command = $"update cars set stock = {stock + addedStock} where car_id = '{id}' and car_color = '{color}'";
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
                    }

                    dtCarInv.Clear();
                    dtCarInv.Columns.Clear();
                    string commandInv = "select * from car_inventory";
                    sqlCommand = new MySqlCommand(commandInv, sqlConnection);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtCarInv);
                    int counter = 0;
                    for (int i = 0; i < dtCarInv.Rows.Count; i++)
                    {
                        if(id == dtCarInv.Rows[i][1].ToString())
                        {
                            counter++;
                        }

                    }

                    for(int i = 1; i <= addedStock; i++)
                    {
                        string no_rangka = id + (counter + i).ToString("00");
                        string query = $"insert into car_inventory values('{no_rangka}', '{id}', 0)";
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
                        }
                    }
                    MessageBox.Show("Successfully added stock.");
                }
                else if (cmb_Menu.Text == "Add Accessories")
                {
                    int stock = 0;
                    for(int i = 0; i < dtItem.Rows.Count; i++)
                    {
                        if (dtItem.Rows[i][1].ToString() == cmb_Menu.Text)
                        {
                            stock = Convert.ToInt32(dtItem.Rows[i][2].ToString());
                        }
                    }
                    string command = $"update accessories_inventory set stock = {stock + Convert.ToInt32(numeric_stock.Value)} where accessories_name = '{cmb_name.Text}'";
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
                        MessageBox.Show("Successfully added stock.");
                    }
                }
            }
            
        }
    }
}
