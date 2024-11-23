using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class Cupon
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Type { get; set; }

        public double Disount { get; set; }

        public double MinimumAmount { get; set; }

    }
}
