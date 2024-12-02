using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor
{
    public class Productor
    {
        private Cola<Usuario> _cola;

        //ctor
        public Productor(Cola<Usuario> cola)
        {
            _cola = cola;
        }


        public void Producir(Usuario item)
        { 
            _cola.Agregar(item);
            Thread.Sleep(2000);
        }
    }
}
