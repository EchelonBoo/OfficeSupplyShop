using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeSupply
{

    public partial class frmOfficeSupply : Form
    {
        #region Bethany
        List<Sales> sales = new List<Sales>(); //list to store sales

        List<SalesLines> salesLinesList = new List<SalesLines>();//list to store saleslines, whihc make up sales

        List<Product> productList = new List<Product>(); // list to store products for use in saleslines

        List<Sales> Tempsales = new List<Sales>(); //used for the business operation

        public frmOfficeSupply()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 0;
            tabControl2.SelectedIndex = 0;

            #region Products
          //  Product p0 = new Product("Pencil", 1, "sharp", "very sharp", 1, 1.5, 50, 45, 50);
          //  Product p1 = new Product("Pen", 2, "red", "bic pen", 2, 5, 50, 45, 50);
          //  Product p2 = new Product("Pencil", 3, "sharp", "very sharp", 1, 1.5, 50, 45, 50);
          //productList.Add(p0);
          //productList.Add(p1);
          //productList.Add(p2);

            #endregion

            tabControl3.SelectedIndex = 0;
            tabProducts1();

            rBtnCash.Checked = true;
            tab0(); // this is for tabControl2 - call the first tab function on starting.
        }

        private void DisplayTabInfo() //calls the tab function depedning on which tab has been selected
        {
             switch (tabControl2.SelectedIndex)
             {
                 case 0:
                     tab0();
                     break;
                 case 1:
                     tab1();
                     break;
                 case 2:
                     tab2();
                     break;
                 default:
                     tab0();
                     break;
             }
        }

        public void AddSalesLines_Sales() //Function for hard coded data for both sales and saleslines
        {

            #region SalesLines
            salesLinesList.Add(new SalesLines(1, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(2, 7, 10, "Pencil"));
            salesLinesList.Add(new SalesLines(3, 10, 26, "Desk"));
            salesLinesList.Add(new SalesLines(4, 25, 47, "Tape"));
            salesLinesList.Add(new SalesLines(5, 78, 136, "Chair"));
            salesLinesList.Add(new SalesLines(6, 18, 69, "Hole Punch"));
            salesLinesList.Add(new SalesLines(7, 96, 203, "Stapler"));
            salesLinesList.Add(new SalesLines(8, 3, 132, "Scissors"));
            salesLinesList.Add(new SalesLines(9, 14, 29, "Laminator"));
            salesLinesList.Add(new SalesLines(10, 2, 123, "Guillotine"));
            salesLinesList.Add(new SalesLines(11, 1, 78, "Marker"));
            #endregion

            #region Sales
            sales.Add(new Sales(10, "Cash", Convert.ToDateTime("01 / 04 / 19 12:00:00"), new List<SalesLines>() { salesLinesList.ElementAt(2), salesLinesList.ElementAt(0) }));
            sales.Add(new Sales(80, "Cash", Convert.ToDateTime("02 / 04 / 19 17:26:12"), new List<SalesLines>() { salesLinesList.ElementAt(1) }));
            sales.Add(new Sales(10, "Cash", Convert.ToDateTime("01 / 04 / 19 12:15:13"), new List<SalesLines>() { salesLinesList.ElementAt(2), salesLinesList.ElementAt(0) }));
            sales.Add(new Sales(60, "Cash", Convert.ToDateTime("02 / 04 / 19 03:09:23"), new List<SalesLines>() { salesLinesList.ElementAt(1) }));
            sales.Add(new Sales(60, "Cash", Convert.ToDateTime("01 / 04 / 19 19:36:18"), new List<SalesLines>() { salesLinesList.ElementAt(1), salesLinesList.ElementAt(10), salesLinesList.ElementAt(8) }));
            sales.Add(new Sales(60, "Cash", Convert.ToDateTime("01 / 04 / 19 12:59:07"), new List<SalesLines>() { salesLinesList.ElementAt(9), salesLinesList.ElementAt(0) }));
            sales.Add(new Sales(60, "Cash", Convert.ToDateTime("02 / 04 / 19 23:48:58"), new List<SalesLines>() { salesLinesList.ElementAt(1) }));
            sales.Add(new Sales(60, "Card", Convert.ToDateTime("02 / 04 / 19 14:06:36"), new List<SalesLines>() { salesLinesList.ElementAt(1) }));
            sales.Add(new Sales(60, "Card", Convert.ToDateTime("01 / 04 / 19 15:07:34"), new List<SalesLines>() { salesLinesList.ElementAt(2), salesLinesList.ElementAt(0), salesLinesList.ElementAt(0), salesLinesList.ElementAt(0) }));
            sales.Add(new Sales(60, "Card", Convert.ToDateTime("01 / 04 / 19 12:36:21"), new List<SalesLines>() { salesLinesList.ElementAt(9) }));
            sales.Add(new Sales(60, "Card", Convert.ToDateTime("01 / 04 / 19 11:14:58"), new List<SalesLines>() { salesLinesList.ElementAt(5), salesLinesList.ElementAt(8) }));
            sales.Add(new Sales(60, "Card", Convert.ToDateTime("02 / 04 / 19 05:58:12"), new List<SalesLines>() { salesLinesList.ElementAt(6), salesLinesList.ElementAt(3) }));
            sales.Add(new Sales(60, "Card", Convert.ToDateTime("02 / 04 / 19 03:15:26"), new List<SalesLines>() { salesLinesList.ElementAt(1), salesLinesList.ElementAt(4), salesLinesList.ElementAt(9) }));
            #endregion
        }

        public void tab0()
        {
            listUpdate(listView1); // calls list update and add data to listview
        }

        public void tab1()
        {
           // listView2Refresh(listView2);
            
        }

        public void tab2()
        {

        }


       /* private void btnLoadSales_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"loadSales.txt");
            string type;
            int SalesID;
            decimal amount;
            List <SalesLines>  sl = new List<SalesLines>();
            string[] splitDetails;
            

            foreach (string s in lines)
            {
                splitDetails = s.Split(',');
                //SalesID = Convert.ToInt16(splitDetails[0]);
                amount = Convert.ToDecimal(splitDetails[1]);
                type = splitDetails[2];
                


                List<SalesLines> sLine = new List<SalesLines>();

                int count = 3;
                foreach(SalesLines salel in salesLinesList)
                {
                    if(salel.ShortDesc == splitDetails[count])
                    {
                        sLine.Add(salel);
                    }
                }

                Sales newChild = new Sales(Convert.ToInt32(splitDetails[0]), amount, type, DateTime.Parse(splitDetails[3]), sLine);
                sales.Add(newChild);
            }
            tab1();
        }*/

        private void listUpdate(ListView l) // adds to listView
        {
           l.Items.Clear(); // empties the list

            foreach (SalesLines sl in salesLinesList) // adds data to the listview
            {
                ListViewItem rows = new ListViewItem(sl.ProductID.ToString());

                rows.SubItems.Add(sl.Quantity.ToString());
                rows.SubItems.Add(sl.TotalPrice.ToString());
                rows.SubItems.Add(sl.ShortDesc);
                l.Items.Add(rows);
            }
        }

        private void listView2Refresh(ListView l)
        {
            l.Items.Clear();

            foreach(Sales sale in sales)
            {
                ListViewItem rows = new ListViewItem(sale.SalesID.ToString());

                rows.SubItems.Add(sale.DateTimeofSale.ToString());
                rows.SubItems.Add(sale.Type);
                rows.SubItems.Add(sale.Amount.ToString());
                l.Items.Add(rows);
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)//Working
        {
            AddSalesLines_Sales();
            listUpdate(listView1);
        }

        private void btnExit_Click(object sender, EventArgs e)//done
        {
            this.Close();
        }  

        private void btnExit2_Click_1(object sender, EventArgs e)//done
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)//Working
        {
            frmAddSalesLines frmAddSalesLines = new frmAddSalesLines(productList);

            SalesLines saleslines = frmAddSalesLines.GetNew();

            if(saleslines != null)
            {
                salesLinesList.Add(saleslines);
            }
            listUpdate(listView1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)//broken
        {

            ListView.CheckedIndexCollection checkedItem = listView1.CheckedIndices;
            while (checkedItem.Count > 0)
            {
                frmUpdateSalesLines updateSalesLinesForm = new frmUpdateSalesLines(productList, salesLinesList);
                SalesLines saleslines = updateSalesLinesForm.GetUpdate();
            
                if (saleslines != null)
                {
                    salesLinesList.Add(saleslines);
                }
                listUpdate(listView1);
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)//Working
        {
            var confirmResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            ListView.CheckedIndexCollection checkedItem = listView1.CheckedIndices;

            if (confirmResult == DialogResult.Yes)
            {
                while (checkedItem.Count > 0)
                {
                    listView1.Items.RemoveAt(checkedItem[0]);
                }

                salesLinesList.Clear();
                int count = 0;

                foreach (ListViewItem i in listView1.Items)
                {
                    int ID = Convert.ToInt16(listView1.Items[count].SubItems[0].Text);
                    int Qty = Convert.ToInt16(listView1.Items[count].SubItems[1].Text);
                    decimal TPrice = Convert.ToDecimal(listView1.Items[count].SubItems[2].Text);
                    string shrtDesc = listView1.Items[count].SubItems[3].Text;

                    SalesLines new_sl = new SalesLines(ID, Qty, TPrice, shrtDesc);
                    salesLinesList.Add(new_sl);
                    count++;

                }
            }
        } 

        private void btnFinish_Click(object sender, EventArgs e)//Working
        {
            decimal amount = 0;
            string type = "";
            DateTime DT = DateTime.Now;
            List<SalesLines> salesLines = new List<SalesLines>();

            if (rBtnCard.Checked)
            {
                type = rBtnCard.Text;
            }
            else
                type = rBtnCash.Text;

 
            amount = Convert.ToDecimal(txtTotal.Text);
            DT = DateTime.Now;
            salesLines = salesLinesList;

            Sales sale = new Sales(Convert.ToInt16(amount), type, DT, salesLines);
            sales.Add(sale);

            
            sale.Amount = amount;
            sale.Type = type;
            sale.DateTimeofSale = DT;
            sale.salesLines = salesLines;


            listView1.Items.Clear();
        }

        private void btnRecalc_Click(object sender, EventArgs e)//Working
        {
            decimal runningTot = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                runningTot += decimal.Parse(item.SubItems[2].Text.ToString());
            }
            txtTotal.Text = Convert.ToString(runningTot);
        }//working

        private void tabControl2_SelectedIndexChanged_1(object sender, EventArgs e)//done
        {
            DisplayTabInfo();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)//working
        {
            string search = txtSearch.Text;
            if(search != "")
            {
                foreach(ListViewItem i in listView1.Items)
                {
                    if (i.Text.ToLower().Contains(search.ToLower()))
                    {
                        i.Selected = true;
                    }
                    else
                        listView1.Items.Remove(i);
                }
            }
            else
                tab0();
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)//Come back to
        {
            string search = txtSearch2.Text;
            if (search != "")
            {
                foreach (ListViewItem i in listView2.Items)
                {
                    if (i.Text.ToLower().Contains(search.ToLower()))
                    {
                        i.Selected = true;
                    }
                    else
                        listView2.Items.Remove(i);
                }
            }
            else
                tab1();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//Working
        {
            Tempsales.Clear();
            txtCard.Text = "";
            txtCash.Text = "";

            foreach (Sales s in sales)
            {
                if (dateTimePicker1.Value.Date == s.DateTimeofSale.Date)
                {
                    
                    Tempsales.Add(s);
                }
                TemplistUpdate(listView2);
            }
            
        }

        private void TemplistUpdate(ListView l) //working // adds to listView
        {
            l.Items.Clear(); // empties the list
            foreach (Sales sl in Tempsales) // adds data to the listview
            {
              
                ListViewItem rows = new ListViewItem(sl.SalesID.ToString());

                rows.SubItems.Add(sl.DateTimeofSale.ToLongTimeString());
                rows.SubItems.Add(sl.Type);
                rows.SubItems.Add(sl.Amount.ToString());
                l.Items.Add(rows);
            }
            
            getCash_CardTotal();
            
        }

        private void getCash_CardTotal()//working //sums the total cash and card sales
        {
           
            decimal total = 0;
            decimal cardTotal = 0;

            foreach (ListViewItem item in listView2.Items)
            {
                if (item.SubItems[2].Text.ToString() == "Card")
                {
                    cardTotal += decimal.Parse(item.SubItems[3].Text.ToString());
                    txtCard.Text = Convert.ToString(cardTotal);
                }
                else
                {
                    total += decimal.Parse(item.SubItems[3].Text.ToString());
                    txtCash.Text = Convert.ToString(total);
                }
            }

        }

        private void btnFinish2_Click(object sender, EventArgs e)//working
        {
            listView2.Items.Clear();
            txtCard.Text = "";
            txtCash.Text = "";
            txtRichNote.Text = "";

            checkBoxYes.Checked = false;
            checkBoxNo.Checked = false;

            // create the output stream for a text file
            StreamWriter textOut = new StreamWriter(new FileStream(@"savedSales.txt", FileMode.Create, FileAccess.Write));

            // write each child
            foreach (Sales s in sales)
            {
                textOut.Write(s.Amount + ",");
                textOut.Write(s.Type + ",");
                textOut.Write(s.DateTimeofSale + ",");


                foreach (SalesLines sl in s.salesLines)
                {
                    textOut.Write(sl.ShortDesc + "-");

                }
                textOut.WriteLine();
            }
            MessageBox.Show("Sales have been saved", "Confirmation");
            // write the end of the document
            textOut.Close();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
 
            DateTime endDate = dateTimePickerEnd.Value;
            DateTime CardDay = startDate;
     

            
            decimal cardTotal = 0;
            decimal Cashtotal = 0;


          do
            {
                foreach (Sales s in sales)
                {
                    if (s.Type == "Card")
                    {
                        chart1.Series["Card"].Points.AddXY(startDate.Day.ToString(), cardTotal += s.Amount);
                        startDate = startDate.AddDays(1);
                        //startDate = startDate.AddDays(-1);
                    }
                    else
                    {
                        
                        chart1.Series["Cash"].Points.AddXY(startDate.Day.ToString(), Cashtotal += s.Amount);
                        startDate = startDate.AddDays(1);
                      // startDate = startDate.AddDays(-1);
                    }
                }
            } while (startDate <= endDate);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            chart1.Series["Card"].Points.Clear();
            chart1.Series["Cash"].Points.Clear();
            dateTimePickerStart.ResetText();
            dateTimePickerEnd.ResetText();
            


        }

        #endregion

        #region Jamie

        private void DisplayTabInfo2() //calls the tab function depedning on which tab has been selected
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    tab0();
                    break;
                case 1:
                    tab1();
                    break;
               
                default:
                    tab0();
                    break;
            }
        }

        IDictionary<int, double> productProfitList = new Dictionary<int, double>();

        private void DisplayTabInformation()
        {
            if (tabControl3.SelectedIndex == 0)
            {
                tabProducts1();
            }
            if (tabControl3.SelectedIndex == 1)
            {
                tabProducts2();
            }
            if (tabControl3.SelectedIndex == 2)
            {
                tabProducts3();
            }
        }

        private void tabProducts1()
        {
            txtProductSearch.Text = "";
            RefreshProductList(productList);
        }

        private void tabProducts2()
        {
            {
                fillProductBuisOpChart();
            }
        }

        private void tabProducts3()
        {
            fillProductReportChart();
        }

        private void fillProductBuisOpChart()
        {
            DateTime startDate = dtpProductOperationStartDate.Value;
            DateTime endDate = dtpProductOperationEndDate.Value;
            DateTime currentDate = startDate;

            //while(currentDate >= endDate)
            //{
            //    //Find most profitable product
            //    //Add it 
            //    //increment current Date
            //}

            //chartProductBuisOp.Series["Profit"].Points.AddXY("Ajay", "10000");
            //chartProductBuisOp.Series["Profit"].Points.AddXY("Ramesh", "8000");
            //chartProductBuisOp.Series["Profit"].Points.AddXY("Ankit", "7000");
            //chartProductBuisOp.Series["Profit"].Points.AddXY("Gurmeet", "10000");
            //chartProductBuisOp.Series["Profit"].Points.AddXY("Suresh", "8500");
            //chartProductBuisOp.Titles.Add("Profit Chart");
        }

        private void fillProductReportChart()
        {
            DateTime startDate = dtpProductReportStartDate.Value;
            DateTime endDate = dtpProductReportEndDate.Value;
            DateTime currentDate = startDate;

            //while(currentDate >= endDate)
            //{
            //    //Find most profitable product
            //    //Add it 
            //    //increment current Date
            //}

            chartProductReport.Series["Profit"].Points.AddXY("Ajay", "10000");
            chartProductReport.Series["Profit"].Points.AddXY("Ramesh", "8000");
            chartProductReport.Series["Profit"].Points.AddXY("Ankit", "7000");
            chartProductReport.Series["Profit"].Points.AddXY("Gurmeet", "10000");
            chartProductReport.Series["Profit"].Points.AddXY("Suresh", "8500");
            chartProductReport.Titles.Add("Profit Chart");
        }




        private void RefreshProductList(List<Product> productList)
        {
            lsvProductList.Items.Clear();
            foreach (Product p in productList)
            {
                ListViewItem lv1 = new ListViewItem(p.productID.ToString());
                lv1.SubItems.Add(p.name);
                lv1.SubItems.Add(p.shortDescription);
                lv1.SubItems.Add(p.unitPrice.ToString());
                lsvProductList.Items.Add(lv1);
            }
        }

        private void tabControlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTabInformation();
        }



        private void HardcodeProducts()
        {
            //Randomize products from list of products in text file
            List<string> prodNames = new List<string>();
            string line = File.ReadAllText(@"productNames.txt");
            string[] lines = line.Split(',');
            foreach (string l in lines)
                prodNames.Add(l);

            //Randomize product Short Descriptions from list of descriptions in text file
            List<string> prodShortDescs = new List<string>();
            string line1 = File.ReadAllText(@"productDescriptions.txt");
            string[] lines1 = line1.Split(',');
            foreach (string l1 in lines1)
                prodShortDescs.Add(l1);
            Random random = new Random();


            //Add randomized products to product list
            Product p0 = new Product(prodNames[random.Next(prodNames.Count - 1)], prodShortDescs[random.Next(prodShortDescs.Count - 1)],
                (prodShortDescs[random.Next(prodShortDescs.Count - 1)] + ' ' + prodShortDescs[random.Next(prodShortDescs.Count - 1)]), random.Next(10), random.Next(100),
                random.Next(50), random.Next(75), random.Next(200));

            productList.Add(p0);
            RefreshProductList(productList);

            //SalesLine list
            salesLinesList.Add(new SalesLines(1, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(4, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(15, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(23, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(18, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(7, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(9, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(8, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(9, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(11, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(17, 12, 5, "Pen"));
            salesLinesList.Add(new SalesLines(29, 7, 10, "Pencil"));
            salesLinesList.Add(new SalesLines(35, 10, 26, "Desk"));
            salesLinesList.Add(new SalesLines(49, 1, 10, "Chair"));


            //Sales list
            sales.Add(new Sales(10, "Cash", Convert.ToDateTime("01 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(2), salesLinesList.ElementAt(0) }));
            sales.Add(new Sales(80, "Cash", Convert.ToDateTime("02 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(1) }));
            sales.Add(new Sales(10, "Card", Convert.ToDateTime("01 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(2), salesLinesList.ElementAt(0) }));
            sales.Add(new Sales(60, "Card", Convert.ToDateTime("02 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(1) }));
            sales.Add(new Sales(10, "Cash", Convert.ToDateTime("03 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(4) }));
            sales.Add(new Sales(10, "Card", Convert.ToDateTime("03 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(5) }));
            sales.Add(new Sales(10, "Cash", Convert.ToDateTime("03 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(6) }));
            sales.Add(new Sales(10, "Card", Convert.ToDateTime("03 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(7) }));
            sales.Add(new Sales(10, "Card", Convert.ToDateTime("03 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(8) }));
            sales.Add(new Sales(10, "Cash", Convert.ToDateTime("03 / 04 / 19"), new List<SalesLines>() { salesLinesList.ElementAt(9) }));


        }

        private void RefreshProductBusinessOperationList()
        {
            lsvProductBusinessOperation.Items.Clear();
            IDictionary<Product, double> ProductsByProfit = new Dictionary<Product, double>();
            foreach (KeyValuePair<int, double> kvp in productProfitList)
            {
                foreach (Product p in productList)
                {
                    if (p.productID == kvp.Key)
                    {
                        ProductsByProfit.Add(p, kvp.Value);
                    }
                }
            }

            foreach (KeyValuePair<Product, double> kvp in ProductsByProfit)
            {
                ListViewItem lv1 = new ListViewItem(kvp.Key.productID.ToString());
                lv1.SubItems.Add(kvp.Key.name);
                lv1.SubItems.Add(kvp.Key.shortDescription);
                lv1.SubItems.Add(kvp.Key.markup.ToString());
                lv1.SubItems.Add(kvp.Value.ToString());
                lsvProductBusinessOperation.Items.Add(lv1);
            }
        }

        private void btnAutoCreateProducts_Click_1(object sender, EventArgs e)
        {
            HardcodeProducts();
        }

        private void btnCreateProduct_Click_1(object sender, EventArgs e)
        {
            Product p = null;
            frmProductDetails frmProductDetails = new frmProductDetails(p);
            p = frmProductDetails.GetUpdateProduct();
            if (p != null) //need to check if product is null or exception occurs
                productList.Add(p);
            RefreshProductList(productList);
        }

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {
            if (lsvProductList.CheckedItems.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    List<int> productIDsToBeDeleted = new List<int>();      //Store product IDs for deletion
                    ListView.CheckedListViewItemCollection checkedItemIDs = lsvProductList.CheckedItems;    //CheckedItem collection to retrieve product ID
                    ListView.CheckedIndexCollection checkedItems = lsvProductList.CheckedIndices;       //CheckedIndex collection to remove item from listview

                    //Add IDs to be removed into list
                    foreach (ListViewItem item in checkedItemIDs)
                    {
                        productIDsToBeDeleted.Add(Convert.ToInt32(item.SubItems[0].Text));
                    }
                    //Remove checked items from listview
                    while (checkedItems.Count > 0)
                    {
                        lsvProductList.Items.RemoveAt(checkedItems[0]);
                    }
                    //Get Items to be removed from product List
                    List<Product> itemsToRemove = new List<Product>();
                    foreach (Product product in productList)
                    {
                        foreach (int productToBeDeleted in productIDsToBeDeleted)
                        {
                            if (product.productID == productToBeDeleted)
                            {
                                itemsToRemove.Add(product);
                            }
                        }

                    }
                    //Remove items from product list
                    foreach (Product item in itemsToRemove)
                    {
                        productList.Remove(item);
                    }
                }
            }
            else
                MessageBox.Show("No Item Seleted", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

            string searchValue = txtProductSearch.Text;
            if (searchValue != "")
            {
                foreach (ListViewItem item in lsvProductList.Items)
                {
                    if (item.SubItems[1].Text.ToLower().Contains(searchValue.ToLower()))
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        lsvProductList.Items.Remove(item);
                    }

                }
            }
            else
                tabProducts1();
        }

        private void btnLoadProducts_Click_1(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"productDetails.txt");
            string name, shortDescription, longDescription;
            int productID, supplierID, reorderAmount, reorderLevel;
            double unitPrice, markup;
            string[] splitDetails;

            foreach (string s in lines)
            {
                splitDetails = s.Split(',');
                name = splitDetails[0];
                productID = Convert.ToInt16(splitDetails[1]);
                shortDescription = splitDetails[2];
                longDescription = splitDetails[3];
                supplierID = Convert.ToInt16(splitDetails[4]);
                unitPrice = Convert.ToDouble(splitDetails[5]);
                reorderAmount = Convert.ToInt16(splitDetails[6]);
                reorderLevel = Convert.ToInt16(splitDetails[7]);
                markup = Convert.ToDouble(splitDetails[8]);
                Product newChild = new Product(name, shortDescription, longDescription, supplierID, unitPrice
                   , reorderAmount, reorderLevel, markup);
                productList.Add(newChild);
            }
            tabProducts1();
        }

        private void btnSaveProducts_Click_1(object sender, EventArgs e)
        {
            // create the output stream for a text file
            StreamWriter textOut = new StreamWriter(new FileStream(@"productDetails.txt", FileMode.Create, FileAccess.Write));

            // write each child
            foreach (Product p in productList)
            {
                textOut.Write(p.name + ",");
                textOut.Write(p.productID + ",");
                textOut.Write(p.shortDescription + ",");
                textOut.Write(p.longDescription + ",");
                textOut.Write(p.supplierID + ",");
                textOut.Write(p.unitPrice + ",");
                textOut.Write(p.reorderAmount + ",");
                textOut.Write(p.reorderLevel + ",");
                textOut.WriteLine(p.markup + ",");
            }

            // write the end of the document
            textOut.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpProductOperationStartDate.Value;
            DateTime endDate = dtpProductOperationEndDate.Value;

            //do
            //{
                foreach (Product p in productList)//iterate through all products
                {
                    foreach (Sales s in sales)//iterate through all sales
                    {
                        //if (s.DateTimeofSale <= endDate && s.DateTimeofSale >= startDate)
                        //{
                            foreach (SalesLines sale in s.salesLines)//iterate through list of sales lines contained in each sale. saleslines contain prod IDs.
                            {
                                if (p.productID == sale.ProductID) //finding matching product IDs.
                                {
                                    if (productProfitList.ContainsKey(sale.ProductID))
                                    {                                           //profit calculated by (price with markup-price)*quantity sold
                                        productProfitList[sale.ProductID] += (((p.unitPrice * ((p.markup / 100) + 1)) - p.unitPrice) * sale.Quantity);
                                    }
                                    else
                                    {
                                        productProfitList.Add(sale.ProductID, (((p.unitPrice * ((p.markup / 100) + 1)) - p.unitPrice) * sale.Quantity));
                                    }
                                }
                            }
                        //}
                    }
                    //startDate = startDate.AddDays(1);
                }
            //} while (startDate <= endDate);

            //dictionary now contains product IDs and profit.
            RefreshProductBusinessOperationList();
        }

       



        private void lsvProductList_DoubleClick_1(object sender, EventArgs e)
        {
            //get the id of selected product
            int productID = Convert.ToInt32(lsvProductList.SelectedItems[0].SubItems[0].Text);

            //search for id in product list and call update function
            Product updatedProduct = null;
            foreach (Product p in productList)
            {
                if (p.productID == productID)
                {
                    frmProductDetails frmProductDetails = new frmProductDetails(p);
                    updatedProduct = frmProductDetails.GetUpdateProduct();
                    p.Update(updatedProduct);
                }
            }
            RefreshProductList(productList);
        }
        #endregion

        #region zaki

        List<Suppliersdetails> suppliers = new List<Suppliersdetails>();
        
        

        private void Hardcodesuppliers(List<Suppliersdetails> suppliers)
        {

            Suppliersdetails c1 = new Suppliersdetails("Bodk", "0894545444", "J street", "J company", "J@gmail.com", "approved");


            suppliers.Add(c1);
            RefreshsupplierList(suppliers);
        }

        private void RefreshsupplierList(List<Suppliersdetails> suppliers)
        {
            listView1.Items.Clear();
            foreach (Suppliersdetails p in suppliers)
            {
                ListViewItem lv1 = new ListViewItem(p.id.ToString());
                lv1.SubItems.Add(p.name);
                lv1.SubItems.Add(p.company);
                lv1.SubItems.Add(p.Email);
                listView1.Items.Add(lv1);
            }


        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                List<int> supplierIDsToBeDeleted = new List<int>();      //Store product IDs for deletion
                ListView.CheckedListViewItemCollection checkedItemIDs = listView1.CheckedItems;    //CheckedItem collection to retrieve product ID
                ListView.CheckedIndexCollection checkedItems = listView1.CheckedIndices;       //CheckedIndex collection to remove item from listview

                //Add IDs to be removed into list
                foreach (ListViewItem item in checkedItemIDs)
                {
                    supplierIDsToBeDeleted.Add(Convert.ToInt32(item.SubItems[0].Text));
                }

                //Remove checked items from listview
                while (checkedItems.Count > 0)
                {
                    listView1.Items.RemoveAt(checkedItems[0]);
                }

                //Get Items to be removed from product List
                List<Suppliersdetails> itemsToRemove = new List<Suppliersdetails>();
                foreach (Suppliersdetails supplier in suppliers)
                {
                    foreach (int supplierToBeDeleted in supplierIDsToBeDeleted)
                    {
                        if (supplier.id == supplierToBeDeleted)
                        {
                            itemsToRemove.Add(supplier);
                        }
                    }

                }
                

            }
            
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            
            Suppliersdetails p = null;
            //formSupplierDetails formUpdateSupplier = new formSupplierDetails(p);
            //p = formUpdateSupplier.GetUpdateSupplier();
            if (p != null) //need to check if product is null or exception occurs
                suppliers.Add(p);
            RefreshsupplierList(suppliers);



            listView1.Items.Clear();
            foreach (Suppliersdetails c in suppliers)
            {

                ListViewItem lv1 = new ListViewItem(c.name);

                listView1.Items.Add(lv1);
            }

            //Clear text boxes
            Nametxt.Text = "";
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //if txtboxsearch.text == subitems[0].text => found
                //otherwise not found. 
                if (searchtxt.Text == listView1.Items[i].SubItems[0].Text)
                    MessageBox.Show("found");
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDtxt.Text) || string.IsNullOrEmpty(Nametxt.Text) || string.IsNullOrEmpty(Emailtxt.Text) || string.IsNullOrEmpty(Phonenumbertxt.Text) || string.IsNullOrEmpty(Addresstxt.Text) || string.IsNullOrEmpty(Companytxt.Text) || string.IsNullOrEmpty(VatNotxt.Text))
                return;
            ListViewItem item = new ListViewItem(IDtxt.Text);
            item.SubItems.Add(Nametxt.Text);
            item.SubItems.Add(Emailtxt.Text);
            item.SubItems.Add(Phonenumbertxt.Text);
            item.SubItems.Add(Addresstxt.Text);
            item.SubItems.Add(Companytxt.Text);
            item.SubItems.Add(VatNotxt.Text);
            item.SubItems.Add(Statustxt.Text);
            listView1.Items.Add(item);
            IDtxt.Clear();
            Nametxt.Clear();
            Emailtxt.Clear();
            Phonenumbertxt.Clear();
            Addresstxt.Clear();
            Companytxt.Clear();
            VatNotxt.Clear();
            IDtxt.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            DateTime currentDay = startDate;
            chrtSupplierReport.Series["Report"].Points.AddXY(currentDay.Day.ToString(), "100000");
            chrtSupplierReport.Series["Report"].Points.AddXY("Pencil", "10000");
            chrtSupplierReport.Series["Report"].Points.AddXY("Stapler", "8000");
            chrtSupplierReport.Series["Report"].Points.AddXY("Ballpoint", "7000");
            chrtSupplierReport.Series["Report"].Points.AddXY("Printer", "10000");
            chrtSupplierReport.Series["Report"].Points.AddXY("Printer", "8500");
            //chart title   
            chrtSupplierReport.Titles.Add("Salary Chart");

            DateTime newDate = startDate.AddDays(1);
            chrtSupplierReport.Series["Report"].Points.AddXY(newDate.Day.ToString(), "200000");
            DateTime newDate1 = newDate.AddDays(1);
            chrtSupplierReport.Series["Report"].Points.AddXY(newDate1.Day.ToString(), "300000");
            DateTime newDate2 = newDate1.AddDays(1);
            chrtSupplierReport.Series["Report"].Points.AddXY(newDate2.Day.ToString(), "100000");
            chrtSupplierReport.Titles.Add("Salary Chart");

        }

        private void Autocreate_Click_1(object sender, EventArgs e)
        {
            Hardcodesuppliers(suppliers);
        }

        #endregion
    }
    

}
