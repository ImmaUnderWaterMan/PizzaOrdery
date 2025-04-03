using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class VegetablePizza : IPizza
    {
        public string PizzaDescription()
        {
            return "Вегатарианская пицца";
        }
    }
}
