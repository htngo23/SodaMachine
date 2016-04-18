using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Nickel:Coin
    {
        public Nickel(int Value, int Quantity)
        {
            value = Value;
            quantity = Quantity;
        }
    }
}
