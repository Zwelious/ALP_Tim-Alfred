using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dealer.Properties;
using MySql.Data.MySqlClient;

namespace Dealer
{
    public partial class Accessories : Form
    {
        public Accessories()
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
        int x, y, i;
        string connection, directory;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtAcc;
        PictureBox[] accPics;
        Label[] accLabel, labelHarga;
        List<string> accNames, accHarga, imagePaths;
        Button[] buy;
        Panel[] produk;
        public static List<AccCart> cart;
        public static List<string> cartPics;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Homepage home = new Homepage();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            this.Controls.Add(home);
            home.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            x = 20;
            y = 20;
            i = 0;
            int j = 0;
            this.panel_acc.Controls.Clear();
            foreach (string name in accNames)
            {
                if (name.Contains(txt_search.Text))
                {
                    produk[i] = new Panel();
                    produk[i].Size = new Size(150, 250);
                    produk[i].Location = new Point(x, y);
                    produk[i].BackColor = Color.LightSalmon;
                    this.panel_acc.Controls.Add(produk[i]);

                    accPics[i] = new PictureBox();
                    accPics[i].Size = new Size(150, 160);
                    accPics[i].Location = new Point(0, 0);
                    accPics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    accPics[i].BackColor = Color.LightSalmon;
                    string url = imagePaths[i];
                    string fullUrl = directory + url;
                    accPics[i].ImageLocation = fullUrl;
                    produk[i].Controls.Add(accPics[i]);

                    accLabel[i] = new Label();
                    accLabel[i].Size = new Size(150, 24);
                    accLabel[i].Font = new Font("Bahnschrift", 10F, FontStyle.Bold | FontStyle.Underline);
                    accLabel[i].Location = new Point(0, 168);
                    accLabel[i].TextAlign = ContentAlignment.TopCenter;
                    accLabel[i].Text = name;
                    produk[i].Controls.Add(accLabel[i]);

                    labelHarga[i] = new Label();
                    labelHarga[i].Size = new Size(150, 24);
                    labelHarga[i].Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold);
                    labelHarga[i].Location = new Point(0, 190);
                    labelHarga[i].TextAlign = ContentAlignment.TopCenter;
                    labelHarga[i].Text = accHarga[i];
                    produk[i].Controls.Add(labelHarga[i]);

                    buy[i] = new Button();
                    buy[i].Size = new Size(150, 31);
                    buy[i].Location = new Point(0, 213);
                    buy[i].Tag = i.ToString();
                    buy[i].Text = "Add to cart";
                    buy[i].ForeColor = Color.White;
                    buy[i].BackColor = Color.OrangeRed;
                    buy[i].Click += buy_Click;
                    produk[i].Controls.Add((buy[i]));

                    if ((j + 1) % 4 == 0)
                    {
                        x = 20;
                        y += 300;
                    }
                    else
                    {
                        x += 170;
                    }
                    j++;
                }
                i++;
                
            }
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            if (Login.userEmail == null)
            {
                MessageBox.Show("Please login first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cart.Count == 0)
            {
                MessageBox.Show("Cart is empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Controls.Clear();

                Cart shoppingCart = new Cart();
                shoppingCart.TopLevel = false;
                shoppingCart.Dock = DockStyle.Fill;
                this.Controls.Add(shoppingCart);
                shoppingCart.Show();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.panel_acc.Controls.Clear();
            txt_search.Text = "";
            accListings();
        }
        
        private void Accessories_Load(object sender, EventArgs e)
        {
            btn_cart.FlatStyle = FlatStyle.Flat;
            btn_cart.FlatAppearance.BorderSize = 0;
            dtAcc = new DataTable();
            string command = "select * from accessories_inventory";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtAcc);

            accNames = new List<string>();
            accHarga = new List<string>();
            accPics = new PictureBox[dtAcc.Rows.Count];
            accLabel = new Label[dtAcc.Rows.Count];
            labelHarga = new Label[dtAcc.Rows.Count];
            produk = new Panel[dtAcc.Rows.Count];
            buy = new Button[dtAcc.Rows.Count];

            cart = new List<AccCart>();
            cartPics = new List<string>();

            if (Cart.cart != null)
            {
                foreach (AccCart aksesoris in Cart.cart)
                {
                    cart.Add(aksesoris);
                }
                foreach(string gambar in Cart.pictures)
                {
                    cartPics.Add(gambar);
                }
            }

            for(int i = 0; i < dtAcc.Rows.Count; i++)
            {
                accNames.Add(dtAcc.Rows[i][1].ToString());
                accHarga.Add("Rp. " + dtAcc.Rows[i][3].ToString());
            }

            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            string file = "acc pictures.txt";
            string[] lines = File.ReadAllLines(file);
            imagePaths = new List<string>();
            foreach (string line in lines)
            {
                imagePaths.AddRange(line.Split(','));
            }

            accListings();
        }
        private void buy_Click(object sender, EventArgs e)
        {
            if (Login.userEmail == null)
            {
                MessageBox.Show("Please login first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool notInCart = true;

                var send = sender as Button;
                int pilihan = Convert.ToInt32(send.Tag);
                string id = dtAcc.Rows[pilihan][0].ToString();
                string name = dtAcc.Rows[pilihan][1].ToString();
                int qty = 1;
                int harga = Convert.ToInt32(dtAcc.Rows[pilihan][3].ToString());
                AccCart item = new AccCart(id, name, qty, harga);
                foreach (AccCart accessory in cart)
                {
                    if (accessory.Name == item.Name)
                    {
                        MessageBox.Show("Item already in cart, open shopping cart if you want to change the amount of the item(s).", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        notInCart = false;
                    }
                }
                if (notInCart)
                {
                    MessageBox.Show("Successfully added to cart.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    cart.Add(item);
                    cartPics.Add(imagePaths[pilihan]);
                }
            }
        }

        private void accListings()
        {
            x = 20;
            y = 20;
            i = 0;
            foreach (string name in accNames)
            {
                produk[i] = new Panel();
                produk[i].Size = new Size(150, 250);
                produk[i].Location = new Point(x, y);
                produk[i].BackColor = Color.LightSalmon;
                this.panel_acc.Controls.Add(produk[i]);

                accPics[i] = new PictureBox();
                accPics[i].Size = new Size(150, 160);
                accPics[i].Location = new Point(0, 0);
                accPics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                accPics[i].BackColor = Color.LightSalmon;
                string url = imagePaths[i];
                string fullUrl = directory + url;
                accPics[i].ImageLocation = fullUrl;
                produk[i].Controls.Add(accPics[i]);

                accLabel[i] = new Label();
                accLabel[i].Size = new Size(150, 24);
                accLabel[i].Font = new Font("Bahnschrift", 10F, FontStyle.Bold | FontStyle.Underline);
                accLabel[i].Location = new Point(0, 168);
                accLabel[i].TextAlign = ContentAlignment.TopCenter;
                accLabel[i].Text = name;
                produk[i].Controls.Add(accLabel[i]);

                labelHarga[i] = new Label();
                labelHarga[i].Size = new Size(150, 24);
                labelHarga[i].Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold);
                labelHarga[i].Location = new Point(0, 190);
                labelHarga[i].TextAlign = ContentAlignment.TopCenter;
                labelHarga[i].Text = accHarga[i];
                produk[i].Controls.Add(labelHarga[i]);

                buy[i] = new Button();
                buy[i].Size = new Size(150, 31);
                buy[i].Location = new Point(0, 213);
                buy[i].Tag = i.ToString();
                buy[i].Text = "Add to cart";
                buy[i].ForeColor = Color.White;
                buy[i].BackColor = Color.OrangeRed;
                buy[i].Click += buy_Click;
                produk[i].Controls.Add((buy[i]));

                if ((i + 1) % 4 == 0)
                {
                    x = 20;
                    y += 300;
                }
                else
                {
                    x += 170;
                }
                i++;
            }
        }
    }
}

