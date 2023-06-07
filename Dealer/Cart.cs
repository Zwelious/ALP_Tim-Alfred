using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dealer
{
    public partial class Cart : Form
    {
        public Cart()
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
        string connection, directory;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        PictureBox[] pics;
        Label[] names, price, stock, quantity;
        Button[] minus, plus;
        int i, x, y, subtotal, taxAmount, totalPrice;
        DataTable accDetails, accSales;
        public static List<AccCart> cart;

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (cmb_payment.Text == "")
            {
                MessageBox.Show("Please choose a payment method.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = 0;
                int productCount = 1;
                foreach(AccCart acc in Accessories.cart)
                {
                    string id = "ACC" + (accSales.Rows.Count + productCount).ToString("0000");
                    int stock = Convert.ToInt32(accDetails.Rows[x][2].ToString()) - acc.Qty;
                    string command = $"update accessories_inventory set accessories_stock = '{stock}' where accessories_id = '{acc.ID}'";
                    string command2 = $"insert into accessories_sales values ('{id}', '{acc.ID}', '{acc.Qty}', '{Login.userEmail}')";
                    productCount++;
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
                }
                this.Controls.Clear();

                Purchase_Success pay = new Purchase_Success();
                pay.TopLevel = false;
                pay.Dock = DockStyle.Fill;
                this.Controls.Add(pay);
                pay.Show();
            }
        }

        public static List<string> pictures;
        private void btn_back_Click(object sender, EventArgs e)
        {
            cart = Accessories.cart;
            pictures = Accessories.cartPics;
            this.Controls.Clear();

            Accessories acc = new Accessories();
            acc.TopLevel = false;
            acc.Dock = DockStyle.Fill;
            this.Controls.Add(acc);
            acc.Show();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            pics = new PictureBox[Accessories.cart.Count];
            names = new Label[Accessories.cart.Count];
            price = new Label[Accessories.cart.Count];
            stock = new Label[Accessories.cart.Count];
            minus = new Button[Accessories.cart.Count];
            plus = new Button[Accessories.cart.Count];
            quantity = new Label[Accessories.cart.Count];
            accDetails = new DataTable();
            updateCart();
            updateTotal();

            accSales = new DataTable();
            string command = $"select * from accessories_sales";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(accSales);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            int itemNo = Convert.ToInt32(send.Tag);
            if (quantity[itemNo].Text == "1")
            {
                MessageBox.Show("Item successfully removed from cart.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                Accessories.cart.Remove(Accessories.cart[itemNo]);
                Accessories.cartPics.Remove(Accessories.cartPics[itemNo]);
                updateCart();
            }
            else
            {
                Accessories.cart[itemNo].Qty -= 1;
                quantity[itemNo].Text = Accessories.cart[itemNo].Qty.ToString();
            }
            updateTotal();
            if (Accessories.cart.Count == 0)
            {
                this.Controls.Clear();

                Accessories acc = new Accessories();
                acc.TopLevel = false;
                acc.Dock = DockStyle.Fill;
                this.Controls.Add(acc);
                acc.Show();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            int itemNo = Convert.ToInt32(send.Tag);
            int row = 0;
            for(int i = 0; i < accDetails.Rows.Count; i++)
            {
                if (Accessories.cart[itemNo].ID == accDetails.Rows[i][0].ToString())
                {
                    row = i;
                    break;
                }
            }

            if(Accessories.cart[itemNo].Qty == Convert.ToInt32(accDetails.Rows[row][2].ToString()))
            {
                MessageBox.Show("Not enough stock.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Accessories.cart[itemNo].Qty += 1;
                quantity[itemNo].Text = Accessories.cart[itemNo].Qty.ToString();
            }
            updateTotal();
        }
        private void updateCart()
        {
            accDetails.Clear();
            panel_products.Controls.Clear();
            foreach (AccCart acc in Accessories.cart)
            {
                string command = $"select * from accessories_inventory where accessories_id = '{acc.ID}'";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(accDetails);
            }

            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            i = 0;
            x = 20;
            y = 20;
            for (int i = 0; i < Accessories.cart.Count; i++)
            {
                pics[i] = new PictureBox();
                pics[i].Size = new Size(150, 160);
                pics[i].Location = new Point(x, y);
                pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pics[i].BackColor = Color.LightSalmon;
                string url = Accessories.cartPics[i];
                string fullUrl = directory + url;
                pics[i].ImageLocation = fullUrl;
                panel_products.Controls.Add(pics[i]);

                names[i] = new Label();
                names[i].Size = new Size(150, 24);
                names[i].Location = new Point(x + 170, y);
                names[i].Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
                names[i].Text = Accessories.cart[i].Name;
                panel_products.Controls.Add(names[i]);

                price[i] = new Label();
                price[i].Size = new Size(150, 24);
                price[i].Location = new Point(x + 170, y + 25);
                price[i].Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
                price[i].Text = "Rp. " + Accessories.cart[i].harga.ToString();
                panel_products.Controls.Add(price[i]);

                string stockAvailable = accDetails.Rows[i][2].ToString();
                stock[i] = new Label();
                stock[i].Size = new Size(150, 24);
                stock[i].Location = new Point(x + 170, y + 50);
                stock[i].Font = new Font("Bahnschrift", 9F);
                stock[i].Text = stockAvailable + " in stock.";
                panel_products.Controls.Add(stock[i]);

                minus[i] = new Button();
                minus[i].Size = new Size(30, 30);
                minus[i].Location = new Point(x + 170, y + 85);
                minus[i].Tag = i.ToString();
                minus[i].Text = "-";
                minus[i].ForeColor = Color.White;
                minus[i].BackColor = Color.OrangeRed;
                minus[i].Click += minus_Click;
                panel_products.Controls.Add((minus[i]));

                plus[i] = new Button();
                plus[i].Size = new Size(30, 30);
                plus[i].Location = new Point(x + 240, y + 85);
                plus[i].Tag = i.ToString();
                plus[i].Text = "+";
                plus[i].ForeColor = Color.White;
                plus[i].BackColor = Color.OrangeRed;
                plus[i].Click += plus_Click;
                panel_products.Controls.Add((plus[i]));

                quantity[i] = new Label();
                quantity[i].Size = new Size(30, 24);
                quantity[i].Location = new Point(x + 210, y + 90);
                quantity[i].Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
                quantity[i].Text = Accessories.cart[i].Qty.ToString();
                panel_products.Controls.Add(quantity[i]);

                y += 180;
            }
        }

        private void updateTotal()
        {
            subtotal = 0;
            foreach(AccCart item in Accessories.cart)
            {
                subtotal += item.Qty * item.harga;
            }
            taxAmount = subtotal * 10 / 100;
            totalPrice = subtotal + taxAmount;

            sub_total.Text = "Rp. " + subtotal.ToString();
            tax.Text = "Rp. " + taxAmount.ToString();
            total.Text = "Rp. " + totalPrice.ToString();
        }
    }
}
