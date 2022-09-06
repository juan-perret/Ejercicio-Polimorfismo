using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class Ventas
    {
        public int CodigoFactura { get; set; }
        public int Cuit { get; set; }
        public List<Productos> ProductosVendidos { get; set; }
        public DateTime FechaVenta { get; set; }
        public double ImporteVenta { get; set; }
        public double ImporteFinal { get; set; }

        public double DescuentoFormasPago()
        {
            FormasPagos formaDePago =  new FormasPagos();
            if (formaDePago.ToString()=="efectivo")
            {
                ImporteFinal= ImporteVenta - (ImporteVenta * 0.10);
            }
            else if(formaDePago.ToString()== "creditoEnTasa")
            {
                ImporteFinal = ImporteVenta + (ImporteVenta * 0.10);
            }
            else
            {
                ImporteFinal = ImporteVenta + (ImporteVenta * 0.05);
            }
            return ImporteFinal;
        }
    }
}
