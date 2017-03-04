using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDI.Interfaces;
namespace SimpleDI.FoodTypes
{
    class Ryba : IMainCourse
    {
        public void MainCourseType()
        {
            Console.WriteLine("Drugie danie: Ryba");
        }
    }
}
