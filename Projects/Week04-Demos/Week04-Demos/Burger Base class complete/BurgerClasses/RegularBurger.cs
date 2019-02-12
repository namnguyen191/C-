using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerClasses
{
    public class RegularBurger
    {
        //fields
        private bool blnKetchup, blnLettuce, blnMustard, blnOnions, blnPickles;
        private string strCondimentList;

        //properties
        public bool Ketchup
        {
            get { return blnKetchup; }
            set { blnKetchup = value; }
        }
        public bool Lettuce
        {
            get { return blnLettuce; }
            set { blnLettuce = value; }
        }
        public bool Mustard
        {
            get { return blnMustard; }
            set { blnMustard = value; }
        }
        public bool Onions
        {
            get { return blnOnions; }
            set { blnOnions = value; }
        }
        public bool Pickles
        {
            get { return blnPickles; }
            set { blnPickles = value; }
        }
        public string CondimentList
        {
            get
            {
                strCondimentList = ""; //refreshes to empty list
                if (blnKetchup)
                {
                    strCondimentList += typeof(RegularBurger).GetProperties()[0].Name + "\n";
                }
                if (blnLettuce)
                {
                    strCondimentList += typeof(RegularBurger).GetProperties()[1].Name + "\n";
                }
                if (blnMustard)
                {
                    strCondimentList += typeof(RegularBurger).GetProperties()[2].Name + "\n";
                }
                if (blnOnions)
                {
                    strCondimentList += typeof(RegularBurger).GetProperties()[3].Name + "\n";
                }
                if (blnPickles)
                {
                    strCondimentList += typeof(RegularBurger).GetProperties()[4].Name;
                }
                return strCondimentList;
            }
            set
            {
                if (value != null)
                strCondimentList = value;
            }
        }

        public RegularBurger()
        {
            Ketchup = Lettuce = Onions = Mustard = Pickles = false;
            CondimentList = "";
        }

        public RegularBurger(bool ketchup, bool lettuce, bool mustard, bool onions, bool pickles)
        {
            blnKetchup = ketchup;
            Lettuce = lettuce;
            Mustard = mustard;
            Onions = onions;
            Pickles = pickles;
        }

        public override String ToString()
        {
            return "I am " + this.GetType().Name + " with " + CondimentList;
        }
    }
}
