using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer
{
    public class Car
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Transmission { get; set; }
        public long price { get; set; }
        public string color { get; set; }
        public int stock { get; set; }
        public bool outOfStock { get; set; }

        public Car(string iD, string name, string type, string transmission, long price, string color, int stock)
        {
            this.ID = iD;
            this.Name = name;
            this.Type = type;
            this.Transmission = transmission;
            this.price = price;
            this.color = color;
            this.stock = stock;

            if(this.stock > 0)
            {
                this.outOfStock = true;
            }
            else
            {
                this.outOfStock = false;
            }
        }
    }
}
