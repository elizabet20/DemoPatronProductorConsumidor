using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor
{
   //ctor
    public class Cola <T>
    {
        private int capacidadMaxima;
        private Queue<T> cola = new Queue<T>();
        private object lockObjeto = new object();
        public Cola(int capacidad)
        {
            capacidadMaxima = capacidad;   
        }


        public void Agregar(T item)
        {
            lock (lockObjeto)
            {
                while (cola.Count >= capacidadMaxima)
                { 
                Monitor.Wait(lockObjeto);
                }
                cola.Enqueue(item);
                Monitor.Pulse(lockObjeto);
            }
        
        }
        public T Extraer()
        {
            lock (lockObjeto)
            {
                while (cola.Count == 0)
                {
                    Monitor.Wait(lockObjeto);
                }
                T item = cola.Dequeue();
                Monitor.Pulse(lockObjeto);
                return item;
            }
            cola.Dequeue();
        }
    }
}
