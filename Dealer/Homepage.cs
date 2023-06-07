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

namespace Dealer
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        List<string> bannerPaths;
        int a, b;
        string directory;
        private void btn_acc_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Accessories acc = new Accessories();
            acc.TopLevel = false;
            acc.Dock = DockStyle.Fill;
            this.Controls.Add(acc);
            acc.Show();
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Cars cars = new Cars();
            cars.TopLevel = false;
            cars.Dock = DockStyle.Fill;
            this.Controls.Add(cars);
            cars.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            string file = "car banners.txt";
            string[] lines = File.ReadAllLines(file);
            bannerPaths = new List<string>();
            foreach (string line in lines)
            {
                bannerPaths.AddRange(line.Split(','));
            }
            a = 0;
            b = 4;
            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            changeBanner(a, b);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(a == 7)
            {
                a = 0;
            }
            else
            {
                a++;
            }

            if (b == 7)
            {
                b = 0;
            }
            else
            {
                b++;
            }

            changeBanner(a, b);
        }

        private void lbl_history_Click(object sender, EventArgs e)
        {
            if(Login.userEmail == null)
            {
                MessageBox.Show("Please login first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Controls.Clear();
                History history = new History();
                history.TopLevel = false;
                history.Dock = DockStyle.Fill;
                this.Controls.Add(history);
                history.Show();
            }
        }

        private void lbl_history_MouseHover(object sender, EventArgs e)
        {
            lbl_history.ForeColor = Color.FromArgb(255, 192, 128);
        }

        private void lbl_history_MouseLeave(object sender, EventArgs e)
        {
            lbl_history.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void changeBanner(int x, int y)
        {
            string url1 = bannerPaths[x];
            string fullUrl1 = directory + url1;
            picture_banner1.ImageLocation = fullUrl1;

            string url2 = bannerPaths[y];
            string fullUrl2 = directory + url2;
            picture_banner2.ImageLocation = fullUrl2;
        }
    }
}
