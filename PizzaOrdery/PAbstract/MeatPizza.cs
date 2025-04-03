using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class MeatPizza : IPizza
    {
        public string PizzaDescription()
        {
            return "Мясная пицца";
        }
    }
}
