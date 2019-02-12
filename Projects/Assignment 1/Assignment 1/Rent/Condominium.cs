using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    public class Condominium :  Property
    {
        
        private const int basePrice = 700;
        private const int amenities = 300;
        public bool Amenities { set; get; }
        public Condominium() : base()
        {
            Amenities = false;
        }
        public Condominium(string add, string id) : base(add,id)
        {
            Amenities = false;
        }
        public int CalRent()
        {
            int rent;
            if (Amenities == true)
            {
                rent = basePrice + amenities;
            }
            else { rent = basePrice; }
            return rent; 
        }
        public override string ToString()
        {
            string amen;
            if (Amenities == true) amen = "with amenities"; else amen = "";
            return base.ToString() + 
                   "\n\nYou have rented 1 bedroom condominium " + amen + " for the monthly rent of " + CalRent();
        }
    }
}
