using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OfficeSupply
{
    class Suppliersdetails
    {
        public int id { get; set; }
        public String name { get; set; }

        public String phonenumber { get; set; }

        public String address { get; set; }

        public String company { get; set; } 
        public String Status { get; set; }

        public String Email { get; set; }
        public int vatNo { get; set; }
        public static int supplierid;
        public static int supvatno;
        public Suppliersdetails(string newname, string newphonenumber, string newaddress, string newcompany, string newEmail, string newStatus)
        {

            this.name = newname;
            this.id = Interlocked.Increment(ref supplierid);
            this.Email = newEmail;
            this.address = newaddress;
            this.phonenumber = newphonenumber;
            this.company = newcompany;
            this.Status = newStatus;
            this.vatNo = Interlocked.Increment(ref supvatno);
        } 
        public void Update(Suppliersdetails newsuppliers)
        {
            this.name = newsuppliers.name;
            this.Email = newsuppliers.Email;
            this.phonenumber = newsuppliers.phonenumber;
            this.address = newsuppliers.address;
            this.company = newsuppliers.company;
            this.Status = newsuppliers.Status;


        }

        public String DisplayDetails()
        {
            String details =id + 0+ name + " " + phonenumber+ " "+ address+" "+company+" "+ Email+" "+vatNo+0;
            return details;
        }


    }
}
