using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class AiresAcondicionados : Productos
    {
        public string TipoAire { get; set; }
        public int Frigorias { get; set; }

        Productos producto = new Productos();

    }
}
