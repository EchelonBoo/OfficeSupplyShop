using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OfficeSupply
{
    class Sales
    {
        public int SalesID { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public DateTime DateTimeofSale { get; set; }
        public static int globalSalesID;
        private DateTime dateTime;
        private List<SalesLines> sLine;

        public List<SalesLines> salesLines { get; set; }

        public Sales (decimal amount, string type, DateTime dateTimeSale, List<SalesLines> saleslines)
        {
            SalesID = Interlocked.Increment(ref globalSalesID);
            Amount = amount;
            Type = type;
            DateTimeofSale = dateTimeSale;
            salesLines = saleslines;
        }

        public Sales(int salesID, decimal amount, string type, DateTime dateTime, List<SalesLines> sLine)
        {
            SalesID = salesID;
            Amount = amount;
            Type = type;
            this.dateTime = dateTime;
            this.sLine = sLine;
        }
    }
}
