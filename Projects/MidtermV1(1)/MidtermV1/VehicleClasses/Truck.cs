using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClasses
{
    public class Truck : Vehicles
    {
        public decimal CargoWeight { get; set; }
        public Truck()
        {
            CargoWeight = 0.00M;
        }
        public Truck(String custName, String mailList, decimal weight)
            : base()
        {
            CustomerName = custName;
            MailingList = mailList;
            CargoWeight = weight;
        }

        public override string ToString()
        {
            return base.ToString() + 
                   "\nTruck" + 
                   "\nMax. Cargo: " + CargoWeight + ".00 tons";
        }
    }
}
