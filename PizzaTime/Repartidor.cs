using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Repartidor : Personal
    {
        private string _despacho;
        public Repartidor(string despacho) : base()
        {
            Despacho = _despacho;
        }

        public string Despacho { get => _despacho; set => _despacho = value; }
    }
}
