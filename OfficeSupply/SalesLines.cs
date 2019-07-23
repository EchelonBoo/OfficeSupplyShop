using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSupply
{
    public class SalesLines
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShortDesc { get; set; }

        public SalesLines()
        {

        }
        public SalesLines(int prodID, int qty, decimal totalP, string shortDesc)
        {
            ProductID = prodID;
            Quantity = qty;
            TotalPrice = totalP;
            ShortDesc = shortDesc;
        }



    }
}
