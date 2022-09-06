using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class Computadoras:Productos
    {
        public int VelocidadRam { get; set; }
        public int VelocidadProcesador { get; set; }
        public int Almacenamiento { get; set; }
        public bool Notebook { get; set; }

        Productos producto = new Productos();

    }
}
