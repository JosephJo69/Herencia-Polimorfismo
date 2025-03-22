using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Polimorfismo
{
    class Camion : Vehiculo
    {
        private int combustible = 50;
        private string tipoCombustible = "Gasolina";
        private string transmision = "Manual";
        private int velmotocicleta = 0;
        public Camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            combustible = 50;
        }
        public override void frenar()
        {
            base.frenar();
            {
                if (encendido == true)
                {
                    velocidad -= 8;
                    if (velocidad <= 0)
                    {
                        velocidad = 0;
                        Console.WriteLine("Frenaste mucho, te detuviste");
                    }
                    else
                    {
                        Console.WriteLine("Frenaste, vas a {0} KMS / Hora", velocidad);
                    }
                }
                else
                {
                    Console.WriteLine("El vehiculo esta apagado, no puedes frenar");
                }
            }
        }
    }
}
