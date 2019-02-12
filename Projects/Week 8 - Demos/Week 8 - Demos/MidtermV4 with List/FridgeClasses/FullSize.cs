using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FridgeClasses
{
    public class FullSize : Refrigerator
    {
        public string Feature { get; set; }
       
        //public FullSize(string makeModel, double capacity, bool energyStarRated, string feature)
        //    : base(makeModel, capacity, energyStarRated)
        //{
        //    Feature = feature;
        //}

        public FullSize(string makeModel, double capacity, bool energyStarRated, ListBox lstBox)
            : base(makeModel, capacity, energyStarRated)
        {
            Feature = "";
            for (int i = 0; i < lstBox.SelectedItems.Count; i++)
            {
                AddFeature(lstBox.SelectedItems[i].ToString());
            }
        }

        public void AddFeature(string feature)
        {
            if (feature != null)
            {
                Feature += feature + "\n";
            }
        }

       

       public override string ToString()
        {
            string result = base.ToString();
            result += "Full Size" + Environment.NewLine;
            result += (Feature != "" ? "Features: " + Feature + "\n" : "");
            return result;
        }
    }

}