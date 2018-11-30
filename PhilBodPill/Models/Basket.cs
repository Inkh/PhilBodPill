using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models
{
    public class Basket
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        //Nav props
        public Product Product { get; set; }
    }
}