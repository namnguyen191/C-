using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerClasses
{
    public class RegularBurger
    {
        private bool ketchup, lettuce, mustard, onions, pickels;
        private string condimentList;
        //public bool getKetchup()
        //{
        //    return ketchup;
        //}
        //public void setKetchup(bool ketchup)
        //{
        //    this.ketchup = ketchup;
        //}
        public string Condiments
        {
            set { condimentList = value; }
            get
            {
                if (Ketchup)
                {
                    condimentList += typeof(RegularBurger).GetProperties()[0].Name;
                }
                if (Lettuce)
                {
                    condimentList += typeof(RegularBurger).GetProperties()[1].Name;
                }
                if (Onions)
                {
                    condimentList += typeof(RegularBurger).GetProperties()[2].Name;
                }
                if (Mustard)
                {
                    condimentList += typeof(RegularBurger).GetProperties()[3].Name;
                }
                if (Pickels)
                {
                    condimentList += typeof(RegularBurger).GetProperties()[4].Name;
                }
                return condimentList;
            }
        }

        public bool Ketchup
        {
            get { return ketchup;}
            set { ketchup = value; }
        }
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        public bool Onions
        {
            get { return onions; }
            set { onions = value; }
        }
        public bool Pickels
        {
            get { return pickels; }
            set { pickels = value; }
        }
        //constructor: Instantiates class fields( giving them a value)
        public RegularBurger()
        {
            Ketchup = Lettuce = Mustard = Pickels = Onions = false;
        }
        public RegularBurger(bool k, bool l, bool m, bool o, bool p)
        {
            Ketchup = k;
            Lettuce = l;
            Mustard = m;
            Onions = o;
            Pickels = p;
        }
        public override string ToString()
        {
            return "Regular Burger with condiments: " + this.Condiments;
        }
    }
}
