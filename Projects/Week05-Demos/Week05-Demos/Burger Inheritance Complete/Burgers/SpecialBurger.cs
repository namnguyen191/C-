using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class SpecialBurger : RegularBurger
    {
        private int intNumOfCheeseSlices;
        private int intNumOfBaconSlices;

        public int NumOfCheeseSlices
        {
            get
            { return intNumOfCheeseSlices; }
            set
            {
                if (value > 0 && value <= 3)
                    intNumOfCheeseSlices = value;
            }
        }

        public int NumOfBaconSlices
        {
            get
            { return intNumOfBaconSlices; }
            set
            {
                if (value > 0 && value <= 4)
                {
                    intNumOfBaconSlices = value;
                }
                else
                {
                    intNumOfBaconSlices = 4;
                }
                
            }
        }

        public SpecialBurger(int cheeseSlices, int baconSlices)
            : base()
        {
            NumOfCheeseSlices = cheeseSlices;
            NumOfBaconSlices = baconSlices;
        }

        //overloaded constructor
        public SpecialBurger(bool ketchup, bool lettuce, bool mustard, bool onions, bool pickels, 
            int cheeseSlices, int baconSlices) : base(ketchup,lettuce,mustard,onions,pickels)
        {
            NumOfCheeseSlices = cheeseSlices;
            NumOfBaconSlices = baconSlices;
        }

        public override string ToString()
        {
            return base.ToString() + "and \n" + NumOfBaconSlices + " bacon slice(s) and " + NumOfCheeseSlices + 
                " cheese slice(s)";
        }

    }
}
