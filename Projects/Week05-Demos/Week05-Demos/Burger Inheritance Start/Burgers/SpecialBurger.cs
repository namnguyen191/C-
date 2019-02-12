using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class SpecialBurger : RegularBurger
    {
        public SpecialBurger() : base()
        {
            cheeseSlices = baconSlices = 1;
        }

        public SpecialBurger(bool ketchup, bool lettuce, bool mustard, bool onions, bool pickles, int cheese, int bacon) : base(ketchup,lettuce,mustard,onions,pickles)
        {
            cheeseSlices = cheese;
            baconSlices = bacon;
        }

        public SpecialBurger(int cheese, int bacon)
            : base()
        {
            CheeseSlices = cheese;
            baconSlices = bacon;
        }


        private int cheeseSlices, baconSlices;

        public int CheeseSlices
        {
            get
            {
                return cheeseSlices;
            }
            set
            {
                if (value > 0 && value < 5)
                    cheeseSlices = value;
                else
                    cheeseSlices = 1;
            }
        }

        public int BaconSlices
        {
            get
            {
                return baconSlices;
            }
            set
            {
                if (value > 0 && value < 7)
                    baconSlices = value;
                else
                    baconSlices = 1;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of cheese slices: " + CheeseSlices +
                                     "\nNumber of bacon slices: " + BaconSlices;
        }
    }
}
