using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class MeatPizzaFilling : IPizzaFilling
    {
        public string PizzaFilling()
        {
            return "Начинка: пепперони, ветчина";
        }
    }
}
