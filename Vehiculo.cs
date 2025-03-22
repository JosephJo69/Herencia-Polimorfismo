using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Polimorfismo
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        public int velocidad = 0;



        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public bool encendido;
        public void encender()
        {
            encendido = true;
            Console.WriteLine("Se ha encendido el vehiculo");
        }
        public void apagar()
        {
            encendido = false;
            Console.WriteLine("Se ha apagado el vehiculo");
        }


        public virtual void acelerar()
        {
            if (encendido == true)
            {
                velocidad += 10;
                Console.WriteLine("Aceleraste, vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("El vehiculo esta apagado, no puedes acelerar");
            }
        }

        public virtual void frenar()
        {
            if (encendido == true)
            {
                velocidad -= 5;
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



