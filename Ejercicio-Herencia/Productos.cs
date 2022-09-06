using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    public class Productos
    {
        public int CodigoProducto { get; set; }
        public int CodigoMarca { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double PrecioLista { get; set; }
        public double DescuentoVigente { get; set; }

        Productos producto = new Productos();

        public int CalcularGarantia()
        {
            DateTime anoNuevo = new DateTime(2022, 01, 01);

            int anosGarantia = 0;
            if (PrecioLista <= 9000)
            {
                anosGarantia = 1;
            }
            if (PrecioLista >= 90000)
            {
                anosGarantia=2;
            }
            else if (PrecioLista >=9000 && FechaIngreso>= anoNuevo)
            {
                anosGarantia = 3;
            }
            return anosGarantia;
        }
        
    }
}
