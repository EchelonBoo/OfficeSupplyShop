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
    public partial class frmAddSalesLines : Form
    {

        private SalesLines saleslines = null;
        private List<Product> productList = new List<Product>();

        public frmAddSalesLines(List<Product> pList)
        {          
            InitializeComponent();
            this.productList = pList;

            foreach(Product p in productList)
            {
                productComboBox.Items.Add(p.productID);
            }
        }

        
       public SalesLines GetNew()
        {
            this.ShowDialog();
            return saleslines;
        }

        private void btnAddSalesLines_Click(object sender, EventArgs e)
        {
           
            saleslines = new SalesLines(Convert.ToInt16(productComboBox.Text), Convert.ToInt16(txtQty.Text), Convert.ToDecimal(txtTotal.Text), txtShortDesc.Text);
            this.Close();
        }

        private void AddSalesLines_Load(object sender, EventArgs e)
        {

        }

        public void updateTextBoxes(List<Product> productList)
        {
     
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
                if(productComboBox.SelectedIndex == p.productID)
                {
                    double unitPrice = p.unitPrice;
                }

                if(txtQty.Text != "")
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

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
