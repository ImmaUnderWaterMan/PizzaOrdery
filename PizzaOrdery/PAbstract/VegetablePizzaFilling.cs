using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class VegetablePizzaFilling : IPizzaFilling
    {
        public string PizzaFilling()
        {
            return "Начинка: кабачок, шампиньоны";
        }
    }
}
