using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachineWork
    {
        List<Coin> buyerInsert = new List<Coin>();
        List<Coin> returnCoins = new List<Coin>();
       public SodaMachine dispensery = new SodaMachine();

        public Quarter quarter = new Quarter(25, 10000);
        public Dime dime = new Dime(10, 10000);
        public Nickel nickel = new Nickel(5, 10000);
        public Penny penny = new Penny(1, 10000);

        public int insertCoins()
        {
            insertQuarters();
            totalPayment();
            Console.WriteLine("\n");
            insertDimes();
            totalPayment();
            Console.WriteLine("\n");
            insertNickles();
            totalPayment();
            Console.WriteLine("\n");
            insertPennies();
            int totalCoinValues = buyerInsert.Sum(x => Convert.ToInt32(x.value));
            Console.WriteLine("Total amount of money inserted into machine is: " + totalCoinValues + "cents");
            return totalCoinValues; 
        }
        
        
        public void insertQuarters()
        {
            Console.WriteLine("How many quarters would you like to insert");
            int amountQuarter = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= amountQuarter-1; i++)
            {
                buyerInsert.Add(quarter);
            }
            Console.WriteLine("You have inserted " + amountQuarter + " quarters.");
            int totalCostQuarter = quarter.value * amountQuarter;
            Console.WriteLine("For a value of " + totalCostQuarter + "cents");
        }
        public void insertDimes()
        {
            Console.WriteLine("How many dimes would you like to insert");
            int amountDimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= amountDimes - 1; i++)
            {
                buyerInsert.Add(dime);
            }
            Console.WriteLine("You have inserted " + amountDimes + " dimes.");
            int totalCostDimes = dime.value * amountDimes;
            Console.WriteLine("For a value of " + totalCostDimes + "cents");
        }
        public void insertNickles()
        {
            
            Console.WriteLine("How many nickels would you like to insert");
            int amountNickels = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= amountNickels -1; i++)
            {
                buyerInsert.Add(nickel);
            }
            Console.WriteLine("You have inserted " + amountNickels + " nickels.");
            int totalCostNickels = nickel.value * amountNickels;
            Console.WriteLine("For a value of " + totalCostNickels + "cents");
        }
        public void insertPennies()
        {
            Console.WriteLine("How many pennies would you like to insert");
            int amountPennies = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= amountPennies - 1; i++)
            {
                buyerInsert.Add(penny);
            }
            Console.WriteLine("You have inserted " + amountPennies + " pennies.");
            int totalCostPennies = penny.value * amountPennies;
            Console.WriteLine("For a value of " + totalCostPennies + "cents");
        }
        public int totalPayment()
        {
            int totalCoinValues = buyerInsert.Sum(x => Convert.ToInt32(x.value));
            Console.WriteLine("Total amount of money inserted into machine is: "+ totalCoinValues +"cents");
            return totalCoinValues;
        }

        public void machineLogic(int sodaCost, int moneyPaid)
        
        {
            

                if (moneyPaid < sodaCost)
                {
                    Console.WriteLine("Not enough money, here is your money back.");
                    buyerInsert.Clear();
                }
                if (moneyPaid == sodaCost)
                {
                    Console.WriteLine("Here is your soda");
                    buyerInsert.Clear();
                }
                if (moneyPaid > sodaCost)
                {
                    int remainder = moneyPaid - sodaCost;
                    while (remainder > 0)
                    {
                        if (remainder >= 25)
                        {
                            dispensery.quarters.quantity -= 1;
                            returnCoins.Add(quarter);
                            remainder -= 25;
                            
                        }

                        if (remainder >= 10)
                        {
                            dispensery.dimes.quantity -= 1;
                            returnCoins.Add(dime);
                            remainder -= 10;
                            
                        }
                        if (remainder >= 5)
                        {
                            dispensery.nickels.quantity -= 1;
                            returnCoins.Add(nickel);
                            remainder -= 5;
                            
                        }
                    if (remainder < 5 && remainder != 0)
                        {
                            dispensery.pennies.quantity -= 1;
                            returnCoins.Add(penny);
                            remainder -= 1;
                        }
                        
                    }
                if (dispensery.quarters.quantity <= 0 || dispensery.dimes.quantity <= 0 || dispensery.nickels.quantity <= 0 || dispensery.pennies.quantity <= 0)
                {
                    Console.WriteLine("Not enough coin in machine, here is your money back");
                    printChange();
                    buyerInsert.Clear();
                }
                else {
                    buyerInsert.Clear();
                    Console.WriteLine("Here is your soda!");
                    printChange();
                    returnCoins.Clear();
                }

            }
        }

        public void printChange()
        {
            foreach (Coin coin in returnCoins)
            {
                if (coin.value == 25)
                {
                    Console.WriteLine("return a quarter..");
                }
                if (coin.value == 10)
                {
                    Console.WriteLine("return a dime..");
                }
                if (coin.value == 5)
                {
                    Console.WriteLine("return a nickel..");
                }
                if (coin.value == 1)
                {
                    Console.WriteLine("return a penny..");
                }
            }
                int totalCoinValues = returnCoins.Sum(x => Convert.ToInt32(x.value));
                Console.WriteLine("-- current change total = " + totalCoinValues);
        }
        public int sodaSelection()
        {
            Console.WriteLine("Please select your choice of soda");
            Console.WriteLine("Input (1) for grape flavor: 60cents, input (2) for orange: 35cents, input (3) for meat flavored for 6 cents???");
            string sodaSelection = Console.ReadLine();
            switch (sodaSelection)
            {
                case "1":
                    if (dispensery.grapeDrink.quantity >= 1)
                    {
                        int priceGrape = 60;
                        return priceGrape;
                    }
                    else
                    {
                        Console.WriteLine("Not enough grapeDrink");
                        int priceGrape = 0;
                        return priceGrape;
                    }
                case "2":
                    if (dispensery.orangeDrink.quantity >=1)
                    {
                        int priceOrange = 35;
                        return priceOrange;
                    }
                    else
                    {
                        Console.WriteLine("Not enough orange drink");
                        int priceOrange = 0;
                        return priceOrange;
                    }
                case "3":
                    if (dispensery.meatDrink.quantity >= 1)
                    {
                        int priceMeat = 6;
                        return priceMeat;
                    }
                    else
                    {
                        Console.WriteLine("Not enough meat");
                        int priceMeat = 0;
                        return priceMeat;
                    }
                default:
                    int priceNull = 0;
                    return priceNull;
                    
            }
        }
    }
}









            
