using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class SubCategory
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public int  CategoryId { get; set; }

        public Category  Category{ get; set; }
    }
}
