using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public int totalPrice { get; set; }
        public DateTime date { get; set; }

        public List<Basket> Baskets { get; set; }
    }
}
