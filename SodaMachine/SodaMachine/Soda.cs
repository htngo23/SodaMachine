using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Soda
    {
       public int quantity;
       public string flavor;
       public int value;

        public Soda(int Quantity, string Flavor, int Value)
        {
            quantity = Quantity;
            flavor = Flavor;
            value = Value;
        }
    }
}
