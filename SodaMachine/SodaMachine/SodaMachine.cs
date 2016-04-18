using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        public Quarter quarters;
        public Dime dimes;
        public Nickel nickels;
        public Penny pennies;
        public Soda grapeDrink;
        public Soda orangeDrink;
        public Soda meatDrink;

        public SodaMachine()
        {
            quarters = new Quarter(25, 20);
            dimes = new Dime(10, 10);
            nickels = new Nickel(5, 20);
            pennies = new Penny(1, 50);
            grapeDrink = new Soda(1000, "Grape", 60);
            orangeDrink = new Soda(1000, "Orange", 35);
            meatDrink = new Soda(1000, "Meat", 6); 
        }
    }
}
