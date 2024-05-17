using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();

            int anterior = 0, anterior_anterior = 0, actual=0, hasta;

            Console.WriteLine("Ingresar cuantos números desea mostrar la serie de Fibonacci: ");
            hasta = Convert.ToInt32(Console.ReadLine());


            for(int num=0; num <= hasta; num++)   
            {
                //if( num == 0 ) actual = 0;
                //if (num == 1) actual = 1;
                anterior_anterior = anterior;
                anterior = actual;
                switch (num)
                {
                    case 0:
                        actual = 0;
                        break;
                    case 1:
                        actual = 1; 
                        break;
                    default:
                        actual = anterior + anterior_anterior; 
                        break;
                }
                Console.WriteLine(actual);
            }

            Console.ReadKey();
        }
    }
}
