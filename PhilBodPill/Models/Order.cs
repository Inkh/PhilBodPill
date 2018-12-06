using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public List<Basket> Baskets { get; set; }
    }
}
