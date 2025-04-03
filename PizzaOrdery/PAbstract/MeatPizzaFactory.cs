using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class MeatPizzaFactory : IPizzaFactory
    {
        public IPizza CookPizza()
        {
        return new MeatPizza();
        }
        public IPizzaFilling AddFilling()
        {
            return new MeatPizzaFilling();
        }
    }
}
