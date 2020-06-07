using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Cocinero: Personal
    {
        private string _pizza;

        public Cocinero(string pizza) : base()
        {
            Pizza = _pizza;

        }

        public string Pizza { get => _pizza; set => _pizza = value; }
    }
}
