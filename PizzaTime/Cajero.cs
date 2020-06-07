using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Cajero : Personal
    {
        private string _caja;
        public Cajero(string caja) : base()
        {
            Caja = _caja;

        }

        public string Caja { get => _caja; set => _caja = value; }
    }
}
