using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * comentario de multilinea
             */
            Console.WriteLine("Hola Mundito");
                Console.WriteLine("Ingrese nombre");
            //Esto es un scanner
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese edad");
            string edadTx = Console.ReadLine().Trim();
            //TrimStart = limpia al inicio
            //TrimEnd = limpia al final
            //Trim = limpia todo
            int edad = -1;
            bool esvalido = Int32.TryParse(edadTx, out edad);

            if (!esvalido) // if (esvalido == true)
            {
                Console.WriteLine("Ingrese bien la Edad");
            }
            else
            {
                Console.WriteLine("Su nombre es {0} y su edad es {1} ", nombre, edad);
            }

            
            Console.ReadKey();
        }
    }
}
