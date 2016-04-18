using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class view
    {
        SodaMachineWork trial = new SodaMachineWork();

        public void menu()
        {
            bool onOff = true;
            while (onOff)
            {
                Console.WriteLine("Input 1 to select soda.  Input 2 to walk away");
                string sugar = Console.ReadLine();
                switch (sugar)
                {
                    case "1":
                        trial.machineLogic(trial.sodaSelection(), trial.insertCoins());
                        break;
                    case "2":
                        onOff = false;
                        break;
                    default:
                        onOff = false;
                        break;
                }
                
            }
        }
    }
}
