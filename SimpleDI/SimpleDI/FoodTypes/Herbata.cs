using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDI.Interfaces;
namespace SimpleDI.FoodTypes
{
    class Herbata : IDrink
    {
        public void DrinkType()
        {
            Console.WriteLine("Rodzaj napoju: Herbata");
        }
    }
}
