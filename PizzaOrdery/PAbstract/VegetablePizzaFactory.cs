using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class VegetablePizzaFactory : IPizzaFactory
    {
        public IPizza CookPizza()
        {
        return new VegetablePizza(); 
        }
        public IPizzaFilling AddFilling()
        {
            return new VegetablePizzaFilling();
        }
    }
}
