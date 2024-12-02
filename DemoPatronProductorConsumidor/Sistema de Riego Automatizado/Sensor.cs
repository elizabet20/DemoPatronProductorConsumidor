using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Sistema_de_Riego_Automatizado
{
    internal class Sensor
    {
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public Sensor(string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;
        }
    }
}

