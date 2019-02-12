using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    public class House: Property
    {
       
        private const int BEDROOMCOST = 500;
        private const int BATHROOMCOST = 100;
        public int NumOfBed { set; get; }
        public double NumOfBath { set; get; }
        public House(): base()
        {
            NumOfBed = 0;
            NumOfBath = 0;
        }
        public House(string add, string id): base(add,id)
        {
            NumOfBed = 0;
            NumOfBath = 0;
        }
        public int CalRent()
        {
            return (int)((NumOfBath * BATHROOMCOST) + (NumOfBed * BEDROOMCOST));
        }
        public override string ToString()
        {
            return base.ToString() + 
                   "\n\nYou have rented a house with " + NumOfBed + " bedroom(s) and " + NumOfBath + " bathroom(s) for the monthly rent of " + CalRent().ToString("c");
        }
    }
}
