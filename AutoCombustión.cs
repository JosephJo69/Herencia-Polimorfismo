using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Polimorfismo
{
    internal class AutoCombustión : Vehiculo
    {
        private int combustible = 50;
        private string tipoCombustible = "Diesel";
        private string transmision = "Manual";

        public AutoCombustión (int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
          
            combustible = 50;
        }
        public override void acelerar()
        {
            base.acelerar();
            combustible = combustible - 2;
        }

        public int nivelCombustible() { return combustible; }
        public void cargarCombustible()
        {
            combustible+=3;
        }
    }
}
