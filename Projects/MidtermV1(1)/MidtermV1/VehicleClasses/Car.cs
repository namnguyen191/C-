using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClasses
{
    public class Car : Vehicles
    {
        public bool HatchBack { get; set; }
        public Car()
        {
            HatchBack = false;
        }
        public Car(String custName, String mailList, bool hatch)
            : base()
        {
            CustomerName = custName;
            MailingList = mailList;
            HatchBack = hatch;
        }

        public override string ToString()
        {
            String hatchCheck = "";
            if (HatchBack == true) hatchCheck = " with a Hatchback";
            return base.ToString() +
                   "\nCar" + hatchCheck;
        }
    }
}
