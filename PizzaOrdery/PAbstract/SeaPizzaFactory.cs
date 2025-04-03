using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class SeaPizzaFactory : IPizzaFactory
    {
        public IPizza CookPizza()
        { 
            return new SeaPizza(); 
        }
        public IPizzaFilling AddFilling()
        { 
            return new SeaPizzaFilling(); 
        }
    }
}
