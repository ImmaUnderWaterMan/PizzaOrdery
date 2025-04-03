using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class SeaPizza : IPizza
    {
        public string PizzaDescription()
        {
            return "Пицца с морепродуктами";
        }
    }
}
