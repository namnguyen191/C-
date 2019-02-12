using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    public class Buyer
    {
        public string FName { set; get; }
        public string LName { set; get; }
        public Buyer()
        {
            FName= "";
            LName = "";
        }
        public Buyer(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }
    }
}
