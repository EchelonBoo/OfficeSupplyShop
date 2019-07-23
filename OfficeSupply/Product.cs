using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OfficeSupply
{
    public class Product
    {
        public string name { get; set; }
        public int productID { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public int supplierID { get; set; }
        public double unitPrice { get; set; }
        public int reorderAmount { get; set; }
        public int reorderLevel { get; set; }
        public double markup { get; set; }

        public static int globalProductID; //global product id that products will get their ID from. Ensures all products have unique ID

        public Product(
                        string newName,
                        string newShortDescription,
                        string newLongDescription,
                        int newSupplierID,
                        double newUnitPrice,
                        int newReorderAmount,
                        int newReorderLevel,
                        double newMarkup
                        )
        {
            this.name = newName;
            this.productID = Interlocked.Increment(ref globalProductID); //Product ID is global product ID + 1
            this.shortDescription = newShortDescription;
            this.longDescription = newLongDescription;
            this.supplierID = newSupplierID;
            this.unitPrice = newUnitPrice;
            this.reorderAmount = newReorderAmount;
            this.reorderLevel = newReorderLevel;
            this.markup = newMarkup;
        }

        public void Update(Product newProduct)
        {
            this.name = newProduct.name;
            this.shortDescription = newProduct.shortDescription;
            this.longDescription = newProduct.longDescription;
            this.supplierID = newProduct.supplierID;
            this.unitPrice = newProduct.unitPrice;
            this.reorderAmount = newProduct.reorderAmount;
            this.reorderLevel = newProduct.reorderLevel;
            this.markup = newProduct.markup;
        }

    }
}
