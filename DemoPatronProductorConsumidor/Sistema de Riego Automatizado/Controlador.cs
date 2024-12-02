using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Sistema_de_Riego_Automatizado
{
    internal class Controlador
    {
        private Cola cola;

        public Controlador(Cola cola)
        {
            this.cola = cola;
        }

        public void AnalizarSensores()
        {
            Sensor sensor = cola.ObtenerSensor();
            if (sensor != null)
            {
                if (sensor.Tipo == "Humedad" && sensor.Valor < 50)
                {
                    ActivarRiego();
                }
                else if (sensor.Tipo == "Humedad" && sensor.Valor >= 50)
                {
                    DesactivarRiego();
                }
                else if (sensor.Tipo == "Temperatura" && sensor.Valor > 30)
                {
                    ActivarRiego();
                }
                else if (sensor.Tipo == "Presión de agua" && sensor.Valor < 10)
                {
                    GenerarAlerta();
                }
            }
        }

        private void ActivarRiego()
        {
            Console.WriteLine("Activando riego...");
        }

        private void DesactivarRiego()
        {
            Console.WriteLine("Desactivando riego...");
        }

        private void GenerarAlerta()
        {
            Console.WriteLine("Generando alerta...");
        }
    }
}
