using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    public class Class1
    {
        List<Productos> listaProductos = new List<Productos>();

        public int CalcularIndexProducto(int codProducto)
        {
            int resultado=0;
            foreach (Productos producto in listaProductos)
            {
                Celulares celular = (Celulares) producto;
                AiresAcondicionados airesAcondicionados = (AiresAcondicionados) producto;
                Computadoras computadora = (Computadoras) producto;

                if (celular.CodigoProducto==codProducto&& celular.CalcularGarantia()>=2 && celular.SistemaOperativo=="Android")
                {
                    producto.PrecioLista -= producto.PrecioLista * 0.10;
                    resultado = 10;
                }
                else if (airesAcondicionados.CodigoProducto== codProducto && airesAcondicionados.CalcularGarantia()>=1 && airesAcondicionados.Frigorias>3200)
                {
                    producto.PrecioLista -= airesAcondicionados.PrecioLista * 0.08;
                    resultado = 8;
                }
                else if (computadora.CodigoProducto==codProducto&& computadora.Notebook==true)
                {
                    producto.PrecioLista -= producto.PrecioLista * 0.12;
                    resultado = 12;
                }
            }
            return resultado;
        }
    }
}
