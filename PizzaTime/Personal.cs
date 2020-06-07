using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Personal
    {
        private Cocinero _cocinero;
        private Cajero _cajero;
        private Repartidor _repartidor;
        

        public Personal()
        {
        }

        public Personal(string pizza,string caja, string despacho, string pedido, string envio, string funcionamiento)
        {
            _cocinero = new Cocinero(pizza);
            _cajero = new Cajero(caja);
            _repartidor = new Repartidor(despacho);
            

              

        }

        internal Cocinero Cocinero { get => _cocinero; set => _cocinero = value; }
        internal Cajero Cajero { get => _cajero; set => _cajero = value; }
        internal Repartidor Repartidor { get => _repartidor; set => _repartidor = value; }
       
    }
}
