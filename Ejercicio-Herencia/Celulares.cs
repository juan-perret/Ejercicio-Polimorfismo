using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class Celulares:Productos
    {
        public int VelocidadProcesador { get; set; }
        public int Almacenamiento { get; set; }
        public string SistemaOperativo { get; set; }

        Productos producto = new Productos();

    }
}
