using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public double price { get; set; }

        public int CateoryId { get; set; }

        public Category Cateory { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

    }
}
