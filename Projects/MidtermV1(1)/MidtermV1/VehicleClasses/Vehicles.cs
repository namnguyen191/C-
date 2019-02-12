using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClasses
{
    public class Vehicles
    {
        private String customerName;
        public String MailingList { get; set; }
        public Vehicles()
        {
            customerName = "No Name";
            MailingList = "";
        }
        public Vehicles(String custName, String mailList)
        {
            customerName = custName;
            MailingList = mailList;
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                if (value != "") customerName = value;
            }
        }

        public override string ToString()
        {
            String mailCheck = "";
            if (MailingList != "") mailCheck = "\nCustomer will be added to the Events mailing list(s)";
            return "Name: " + CustomerName + 
                   mailCheck;
        }

    }
}
