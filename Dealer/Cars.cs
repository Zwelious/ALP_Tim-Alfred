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
using MySql.Data.MySqlClient;

namespace Dealer
{
    public partial class Cars : Form
    {
        string connection, directory;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtCars;
        PictureBox[] carPics;
        Label[] carName;
        Button[] buy;
        public static List<Car> cars;
        public static List<string> carNames;
        public static List<string> imagePaths;
        int x, y, i;
        public static int car;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Homepage home = new Homepage();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            this.Controls.Add(home);
            home.Show();
        }

        public Cars()
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            x = 20;
            y = 20;
            i = 0;
            int j = 0;
            this.panel_cars.Controls.Clear();
            foreach (string name in carNames)
            {
                if (name.Contains(txt_search.Text))
                {
                    carPics[i] = new PictureBox();
                    carPics[i].Size = new Size(150, 165);
                    carPics[i].Location = new Point(x, y);
                    carPics[i].SizeMode = PictureBoxSizeMode.Zoom;
                    carPics[i].BackColor = Color.LightSalmon;
                    string url = imagePaths[i];
                    string fullUrl = directory + url;
                    carPics[i].ImageLocation = fullUrl;
                    this.panel_cars.Controls.Add(carPics[i]);

                    carName[i] = new Label();
                    carName[i].Size = new Size(150, 24);
                    carName[i].Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold);
                    carName[i].Location = new Point(x, y + 175);
                    carName[i].TextAlign = ContentAlignment.TopCenter;
                    carName[i].Text = name;
                    this.panel_cars.Controls.Add(carName[i]);

                    buy[i] = new Button();
                    buy[i].Size = new Size(150, 31);
                    buy[i].Location = new Point(x, y + 200);
                    buy[i].Tag = i.ToString();
                    buy[i].Text = "Buy";
                    buy[i].ForeColor = Color.White;
                    buy[i].BackColor = Color.OrangeRed;
                    buy[i].Click += buy_Click;
                    this.panel_cars.Controls.Add((buy[i]));

                    if ((j + 1) % 4 == 0)
                    {
                        x = 20;
                        y += 240;
                    }
                    else
                    {
                        x += 170;
                    }
                    j++;
                }
                i++;
            }
            i = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.panel_cars.Controls.Clear();
            txt_search.Text = "";
            carListings();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cars_Load(object sender, EventArgs e)
        {
            dtCars = new DataTable();
            string command = "select * from cars";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtCars);
            
            cars = new List<Car>();

            for (int i = 0; i < dtCars.Rows.Count; i++)
            {
                string id = dtCars.Rows[i][0].ToString();
                string name = dtCars.Rows[i][1].ToString();
                string type = dtCars.Rows[i][2].ToString();
                string transmission = dtCars.Rows[i][3].ToString();
                long price = Convert.ToInt64(dtCars.Rows[i][4]);
                string color = dtCars.Rows[i][5].ToString();
                int stock = Convert.ToInt32(dtCars.Rows[i][6].ToString());
                Car car = new Car(id, name, type, transmission, price, color, stock);
                cars.Add(car);
            }
            carNames = new List<string>();
            foreach (Car car in cars)
            {
                if (!carNames.Contains(car.Name))
                {
                    carNames.Add(car.Name);
                }
            }
            carPics = new PictureBox[cars.Count];
            carName = new Label[cars.Count];
            buy = new Button[cars.Count];

            string file = "car pictures.txt";
            string[] lines = File.ReadAllLines(file);
            imagePaths = new List<string>();
            foreach (string line in lines)
            {
                imagePaths.AddRange(line.Split(','));
            }

            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            carListings();
        }
        private void buy_Click(object sender, EventArgs e)
        {
            if(Login.userEmail == null)
            {
                MessageBox.Show("Please login first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var send = sender as Button;
                car = Convert.ToInt32(send.Tag);
                this.Controls.Clear();

                CarBuy buycar = new CarBuy();
                buycar.TopLevel = false;
                buycar.Dock = DockStyle.Fill;
                this.Controls.Add(buycar);
                buycar.Show();
            }
        }

        private void carListings()
        {
            x = 20;
            y = 20;
            i = 0;
            foreach (string name in carNames)
            {
                carPics[i] = new PictureBox();
                carPics[i].Size = new Size(150, 165);
                carPics[i].Location = new Point(x, y);
                carPics[i].SizeMode = PictureBoxSizeMode.Zoom;
                carPics[i].BackColor = Color.LightSalmon;
                string url = imagePaths[i];
                string fullUrl = directory + url;
                carPics[i].ImageLocation = fullUrl;
                this.panel_cars.Controls.Add(carPics[i]);

                carName[i] = new Label();
                carName[i].Size = new Size(150, 24);
                carName[i].Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold);
                carName[i].Location = new Point(x, y + 175);
                carName[i].TextAlign = ContentAlignment.TopCenter;
                carName[i].Text = name;
                this.panel_cars.Controls.Add(carName[i]);

                buy[i] = new Button();
                buy[i].Size = new Size(150, 31);
                buy[i].Location = new Point(x, y + 200);
                buy[i].Tag = i.ToString();
                buy[i].Text = "Buy";
                buy[i].ForeColor = Color.White;
                buy[i].BackColor = Color.OrangeRed;
                buy[i].Click += buy_Click;
                this.panel_cars.Controls.Add((buy[i]));

                if ((i + 1) % 4 == 0)
                {
                    x = 20;
                    y += 240;
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
