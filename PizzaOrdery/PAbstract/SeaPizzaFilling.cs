using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdery.PAbstract
{
    public class SeaPizzaFilling : IPizzaFilling
    {
        public string PizzaFilling()
        {
            return "Начинка: креветки, мидии";
        }
    }
}
