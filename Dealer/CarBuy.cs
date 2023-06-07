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
    public partial class CarBuy : Form
    {
        int carNo;
        List<Car> cars;
        List<String> colors;
        Car car;
        Button[] colorPicks;
        int colorCount = 0, x, y;
        public static string name, color, norangka, harga;
        public static DataTable dtChosenCar;
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        public CarBuy()
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
       
        private void CarBuy_Load(object sender, EventArgs e)
        {
            btn_checkout.Enabled = true;
            carNo = Cars.car;
            cars = Cars.cars;
            colors = new List<string>();
            string directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            picture_car.ImageLocation = directory + Cars.imagePaths[carNo];
            lbl_carName.Text = Cars.carNames[carNo];

            foreach(Car mobil in cars)
            {
                if(mobil.Name == lbl_carName.Text)
                {
                    colors.Add(mobil.color);
                    car = mobil;
                }
            }

            colorPicks = new Button[colors.Count];

            x = 450;
            y = 230;
            foreach(string color in colors)
            {
                colorPicks[colorCount] = new Button();
                colorPicks[colorCount].Size = new Size(30, 30);
                colorPicks[colorCount].Location = new Point(x, y);
                colorPicks[colorCount].Tag = color;
                colorPicks[colorCount].BackColor = Color.FromName(color);
                colorPicks[colorCount].Click += color_Click;
                this.Controls.Add(colorPicks[colorCount]);
                x += 40;
            }
            lbl_color.Text = car.color;

            car_name.Text = car.Name;
            car_type.Text = car.Type;
            if(car.Transmission == "AT")
            {
                car_trans.Text = "Automatic";
            }
            else
            {
                car_trans.Text = "Manual";
            }
            car_price.Text = "Rp. " + car.price.ToString();

            if(car.stock == 0)
            {
                lbl_availability.Text = "Out of stock!";
                lbl_availability.ForeColor = Color.Red;
                btn_checkout.Enabled = false;
            }
            else
            {
                lbl_availability.Text = car.stock.ToString() + " unit(s) available!";
            }
            
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            name = lbl_carName.Text;
            color = lbl_color.Text;

            dtChosenCar = new DataTable();
            string command = $"select c.car_id, c.car_name, c.car_color, c.car_stock, ci.no_rangka, c.car_price from cars c, car_inventory ci where c.car_id = ci.car_id and c.car_name = '{name}' and c.car_color = '{color}' and ci.sold = 0";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtChosenCar);

            norangka = dtChosenCar.Rows[0][4].ToString();
            harga = dtChosenCar.Rows[0][5].ToString();

            this.Controls.Clear();

            Payment checkout = new Payment();
            checkout.TopLevel = false;
            checkout.Dock = DockStyle.Fill;
            this.Controls.Add(checkout);
            checkout.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Cars cars = new Cars();
            cars.TopLevel = false;
            cars.Dock = DockStyle.Fill;
            this.Controls.Add(cars);
            cars.Show();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            lbl_color.Text = send.Tag.ToString();
            foreach(Car carr in cars)
            {
                if(carr.Name == car_name.Text && carr.color == lbl_color.Text)
                {
                    lbl_availability.Text = carr.stock.ToString() + " unit(s) available!";
                }
            }
        }
    }
}
