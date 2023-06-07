using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer
{
    public class AccCart
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int harga { get; set; }

        public AccCart(string id, string name, int qty, int harga)
        {
            this.ID = id;
            this.Name = name;
            this.Qty = qty;
            this.harga = harga;
        }
    }
}
