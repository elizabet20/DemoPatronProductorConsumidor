using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Sistema_de_Riego_Automatizado
{
    internal class Cola
    {
        private List<Sensor> cola = new List<Sensor>();

        public void AgregarSensor(Sensor sensor)
        {
            cola.Add(sensor);
        }

        public Sensor ObtenerSensor()
        {
            if (cola.Count > 0)
            {
                Sensor sensor = cola[0];
                cola.RemoveAt(0);
                return sensor;
            }
            return null;
        }
    }
}

