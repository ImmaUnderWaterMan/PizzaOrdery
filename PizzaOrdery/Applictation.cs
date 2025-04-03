using PizzaOrdery.PAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery
{
    public class Applictation
    {
        private IPizzaFactory _factory;
        private IPizza _pizza;
        private IPizzaFilling _filling;

        public Applictation(IPizzaFactory factory)
        {
            _factory = factory;
        }
        public void CookPizza()
        {
            _pizza = _factory.CookPizza();
            _filling = _factory.AddFilling();
        }
        

    }
}
