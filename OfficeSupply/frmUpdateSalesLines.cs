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
    public partial class frmUpdateSalesLines : Form
    {
        private SalesLines saleslines = null;
        private List<SalesLines> salesLinesList = new List<SalesLines>();
        private List<Product> productList = new List<Product>();

        public frmUpdateSalesLines(List<Product> pList, List<SalesLines> slList)
        {
            this.productList = pList;
            this.salesLinesList = slList;
            InitializeComponent();

            foreach (Product p in productList)
            {
                productComboBox.Items.Add(p.productID);
            }
        }

        public SalesLines GetUpdate()
        {
            foreach (SalesLines sl in salesLinesList)
            {

                productComboBox.Text = sl.ProductID.ToString();
                txtQty.Text = sl.Quantity.ToString();
                txtShortDesc.Text = sl.ShortDesc;
                txtTotal.Text = sl.TotalPrice.ToString();

            }
            return saleslines;
        }


         private void btnUpdateSalesLines_Click(object sender, EventArgs e)
          {
                saleslines = new SalesLines(Convert.ToInt16(productComboBox.Text), Convert.ToInt16(txtQty.Text), Convert.ToDecimal(txtTotal.Text), txtShortDesc.Text);
                this.Close();
          }


        public void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Product p in productList)
            {
                if (Convert.ToInt16(productComboBox.Text) == p.productID)
                //if(productComboBox.Contains(Convert.ToInt16(p.productID)))
                {

                    int quantity = 0;
                    txtQty.Text = Convert.ToString(quantity);
                    txtShortDesc.Text = p.name;

                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            int quantity;
            foreach (Product p in productList)
            {
                if (productComboBox.SelectedIndex == p.productID)
                {
                    double unitPrice = p.unitPrice;
                }

                if (txtQty.Text != "")
                {
                    quantity = Convert.ToInt16(txtQty.Text);
                }
                else
                {
                    quantity = 0;
                }


                txtTotal.Text = (p.unitPrice * quantity).ToString();
            }
        }
    }
}
