using Ejercicio2NumCuadrado.Servicios;

namespace Ejercicio2NumCuadrado.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            PedirNumeroInterfaz pn = new PedirNumeroImplementacion();
            double numPedido,raiz;
           

            numPedido = pn.pedirNumero();
            raiz = Math.Sqrt(numPedido);

            if (raiz*raiz==numPedido)
                Console.WriteLine("El numero es entero");
            else
                Console.WriteLine("El numero no es entero");

        }

    }

}