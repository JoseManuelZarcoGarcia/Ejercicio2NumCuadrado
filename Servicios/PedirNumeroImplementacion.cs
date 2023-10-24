using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2NumCuadrado.Servicios
{
    internal class PedirNumeroImplementacion : PedirNumeroInterfaz
    {

        public double pedirNumero()
        {
            double numeroPedido;
            Console.WriteLine("Escriba un nuemro entero ");
            numeroPedido = Convert.ToDouble(Console.ReadLine()); 

            return numeroPedido;
        }

    }
}
