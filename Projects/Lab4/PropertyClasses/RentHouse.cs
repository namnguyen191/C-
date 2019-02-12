using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyClasses
{
    public class RentHouse
    {
        public int NumOfRooms { set; get; }
        public const int PRICE = 500;
        Person prs;
        
        public int CalculateRent()
        {
            return NumOfRooms * PRICE;
        }

        public RentHouse()
        {
            NumOfRooms = 1;
            prs = new Person();
        }

        public RentHouse(string fname, string lname){
            prs.FName = fname;
            prs.LName = lname;
        }

        public override string ToString()
        {
            return prs.ToString() +
                  "\nNumber of rooms rent: " + NumOfRooms +
                   "\nTotal cost: " + CalculateRent();
        }
    }
}
