using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    public class Property
    {
        public Property()
        {

        }
        public Property(string add, string id){
            PropertyId = id;
            Address = add;
        }
        public string PropertyId { set; get; }
        public string Address { set; get; }
        public override string ToString()
        {
            return "\nProperty ID: " + PropertyId +
                   "\nAddress: " + Address;
        }

    }
}
