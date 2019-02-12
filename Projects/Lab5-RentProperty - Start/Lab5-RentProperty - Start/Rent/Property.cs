using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    public class Property
    {
        private const int BEDROOMCOST = 500;
        private const int BATHROOMCOST = 100;
        Buyer prs;
        public Property(){
            NumOfBed = 0;
            NumOfBath = 0;
            PropertyId = "";
            Address = "";
        }
        public Property(string fname, string lname)
        {
            prs = new Buyer(fname, lname);
        }
        public int NumOfBed { set; get; }
        public double NumOfBath { set; get; }
        public string PropertyId { set; get; }
        public string Address { set; get; }
        public int CalRent()
        {
            return (int)((NumOfBath * BATHROOMCOST) + (NumOfBed * BEDROOMCOST));
        }
        public string toString()
        {
            return "Thank you " + prs.FName + " " + prs.LName +
                   "\n\nProperty Id: " + PropertyId + 
                   "\nAddress: " + Address + 
                   "\n\nYou have rented " + NumOfBed + " bedroom(s) and " + NumOfBath + " bathrooms for the monthly rent of " + CalRent() + "$";
        }

    }
}
