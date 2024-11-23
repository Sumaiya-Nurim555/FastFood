using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int OrderHeaderId { get; set; }

        public OrderHeader OrderHeader { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Count { get; set; }  

        public string name { get; set; }    
        public string description { get; set; }
    
        public double price { get; set; }


    }
}
