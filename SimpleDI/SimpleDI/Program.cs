using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDI.Interfaces;
using SimpleDI.FoodTypes;
namespace SimpleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinner dinner = new Dinner(new Pomidorowa(), new Pierogi(), new Herbata());
            dinner.Components();

            dinner.ChangeDinner(new Ogorkowa(), new Ryba(), new Woda());
            dinner.Components();

            Console.ReadLine();
        }
    }
}
