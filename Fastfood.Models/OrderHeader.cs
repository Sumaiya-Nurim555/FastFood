using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class OrderHeader
    {
        public int ID {  get; set; }
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime TimeofPick { get; set; }

        public DateTime DateOfPick { get; set; }

        public double Total {  get; set; }

        public double OrderTotal { get; set; }

        public double SubTotal { get; set; }

        public string CuponCode { get; set; }

        public double CuponDis {  get; set; }

        public string TransId { get; set; }

        public string OrderStatus { get; set; }

        public string PaymentStatus { get;   set; }

        public string Name { get; set; }
        public string Phone { get; set; } 

    }

}
