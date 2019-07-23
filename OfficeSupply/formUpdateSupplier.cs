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
    public partial class formSupplierDetails : Form
    {
        private Suppliersdetails supplierss = null;
        public formSupplierDetails(/*Suppliersdetails p*/)
        {
            //supplierss = p;
            InitializeComponent();
        }

        private void formUpdateSupplier_Load(object sender, EventArgs e)
        {

        }
        //public Suppliersdetails GetUpdateSupplier()
        //{
        //    if (supplierss != null)
        //    {
        //        Name2txt.Text = supplierss.name;
        //        ID2txt.Text = supplierss.id.ToString();
        //        Email2txt.Text = supplierss.Email;
        //        Address2txt.Text = supplierss.address;
        //        company2txt.Text = supplierss.address;
        //        Address2txt.Text = supplierss.address;
        //        vatno2txt.Text = supplierss.vatNo.ToString();
               
        //    }
        //    this.ShowDialog();
        //    return supplierss;
        //}


       

        public void CUbtn_Click(object sender, EventArgs e)
        {
            
                supplierss = new Suppliersdetails(Name2txt.Text, phonenumber2txt.Text,Email2txt.Text,Address2txt.Text,status2txt.Text, company2txt.Text);
                this.Close();
            
        }
    }
}

