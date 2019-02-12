using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FridgeClasses
{
    public class FullSize : Refrigerator
    {
        public string Feature { get; set; }

        public FullSize(string makeModel, double capacity, bool energyStarRated, string feature)
            : base(makeModel, capacity, energyStarRated)
        {
            Feature = feature;
        }

       

        public override string ToString()
        {
            string result = base.ToString();
            result += "Full Size" + Environment.NewLine;
            if (Feature != "")
            {
                result += "Feature: " + Feature + Environment.NewLine;
            }
           
            return result;
        }
    }

}