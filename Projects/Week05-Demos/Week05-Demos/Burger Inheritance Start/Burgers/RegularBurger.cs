using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class RegularBurger
    {
        //fields
        private bool blnKetchup;
        private bool blnLettuce;
        private bool blnOnions;
        private bool blnMustard;
        private bool blnPickels;
        private string strCondimentList;

        //properties

        public bool Ketchup
        {
            get
            {
                return blnKetchup;
            }
            set
            {
                blnKetchup = value;
            }
        }

        public bool Lettuce
        {
            get
            {
                return blnLettuce;
            }
            set
            {
                blnLettuce = value;
            }
        }

        public bool Mustard
        {
            get
            {
                return blnMustard;
            }
            set
            {
                blnMustard = value;
            }
        }

        public bool Onions
        {
            get
            {
                return blnOnions;
            }
            set
            {
                blnOnions = value;
            }
        }

        public bool Pickels
        {
            get
            {
                return blnPickels;
            }
            set
            {
                blnPickels = value;
            }
        }

        public string CondimentList
        {
            get
            {
                strCondimentList = "";  //refreshes to empty list
                if (Ketchup)
                {
                    strCondimentList += "Ketchup\n";
                }
                if (Lettuce)
                {
                    strCondimentList += "Lettuce\n";
                }
                if (Mustard)
                {
                    strCondimentList += "Mustard" + Environment.NewLine;
                }
                if (Onions)
                {
                    strCondimentList += "Onions\n";
                }
                if (Pickels)
                {
                    strCondimentList += "Pickels\n";
                }
                               
                return strCondimentList;
            }
            set
            {
                if (value != null)
                    strCondimentList += value;
            }
        }

        public RegularBurger()
        {
            Onions = false;
            Lettuce = false;
            Mustard = false;
            Pickels = false;
            Ketchup = false;
            CondimentList = "";
        }

        public RegularBurger(bool ketchup, bool lettuce, bool mustard, bool onions, bool pickles)
        {
            Ketchup = ketchup;
            Onions = onions;
            Lettuce = lettuce;
            Pickels = pickles;
            Mustard = mustard;
        }

        public override String ToString()
        {
            return GetType().Name + " with" + Environment.NewLine + CondimentList;
        }
    }
}
