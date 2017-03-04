using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDI.Interfaces;
namespace SimpleDI.FoodTypes
{
    class Ogorkowa :ISoup
    {
        public void SoupType()
        {
            Console.WriteLine("Rodzaj zupy: Ogórkowa");
        }
    }
}
