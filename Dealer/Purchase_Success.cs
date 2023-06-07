using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer
{
    public partial class Purchase_Success : Form
    {
        public Purchase_Success()
        {
            InitializeComponent();
        }

        private void Purchase_Success_Load(object sender, EventArgs e)
        {

        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Homepage menu = new Homepage();
            menu.TopLevel = false;
            menu.Dock = DockStyle.Fill;
            this.Controls.Add(menu);
            menu.Show();
        }
    }
}
