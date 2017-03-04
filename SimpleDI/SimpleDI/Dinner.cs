using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDI.Interfaces;
namespace SimpleDI
{
    class Dinner
    {
        private IDrink _drink;
        private IMainCourse _mainCourse;
        private ISoup _soup;

        public Dinner(ISoup soup, IMainCourse maainCourse, IDrink drink)
        {
            this._soup = soup;
            this._mainCourse = maainCourse;
            this._drink = drink;
        }

        public void Components()
        {
            _drink.DrinkType();
            _mainCourse.MainCourseType();
            _soup.SoupType();
        }
        public void ChangeDinner(ISoup soup, IMainCourse maainCourse, IDrink drink)
        {
            this._soup = soup;
            this._mainCourse = maainCourse;
            this._drink = drink;
        }
    }
}
