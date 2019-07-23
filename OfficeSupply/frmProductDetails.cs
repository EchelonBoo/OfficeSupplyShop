using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeSupply
{
    public partial class frmProductDetails : Form
    {
        private Product product = null;
        public frmProductDetails(Product p)
        {
            product = p;
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            
        }

        public Product GetUpdateProduct()
        {
            if(product != null)
            {
                txtProductName.Text = product.name;
                txtProductID.Text = product.productID.ToString();
                txtProductShortDescription.Text = product.shortDescription;
                txtProductLongDescription.Text = product.longDescription;
                txtProductSupplierID.Text = product.supplierID.ToString();
                txtProductUnitPrice.Text = product.unitPrice.ToString();
                txtProductReorderAmount.Text = product.reorderAmount.ToString();
                txtProductReorderLevel.Text = product.reorderLevel.ToString();
                txtProductMarkup.Text = product.markup.ToString();
            }
            
            
            this.ShowDialog();
            return product;
        }

        private bool IsValidData()
        {
            //code for validation to be added later
            return true;
        }

        private void btnUpdateProductDetails_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                product = new Product(
                                      txtProductName.Text, 
                                      txtProductShortDescription.Text,
                                      txtProductLongDescription.Text,
                                      Convert.ToInt16(txtProductSupplierID.Text),
                                      Convert.ToDouble(txtProductUnitPrice.Text),
                                      Convert.ToInt16(txtProductReorderAmount.Text),
                                      Convert.ToInt16(txtProductReorderLevel.Text),
                                      Convert.ToDouble(txtProductMarkup.Text)
                                      );
                this.Close();
            }
        }
    }
}
