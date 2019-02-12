using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyClasses
{
    public class Person
    {
        public string FName { set; get; }
        public string LName { set; get; }

        public Person()
        {
            FName = "";
            LName = "";
        }

        public override string ToString()
        {
            return FName + "\n" + LName;
        }
    }
}
