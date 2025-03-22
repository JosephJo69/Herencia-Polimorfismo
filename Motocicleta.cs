using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Polimorfismo
{
    class Motocicleta : Vehiculo
    {
        private int combustible = 50;
        private string tipoCombustible = "Gasolina";
        private string transmision = "Manual";
        private int velmotocicleta = 0;
        public Motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            combustible = 50;
        }
        public override void acelerar()
        {
            if (encendido == true)
            {
                velocidad += 15; 
                Console.WriteLine("Aceleraste, vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("El vehiculo esta apagado, no puedes acelerar");
            }
            combustible -= 2;
        }

        public int nivelCombustible() { return combustible; }
        public void cargarCombustible()
        {
            combustible += 4;
        }
    }
}
