using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, nombreMenor="", nombreMayor="", jug;
            float promedio, menor=0, mayor=0;
            
            Console.WriteLine("Ingrese el Nombre del Jugador: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Promedio de {0}:", nombre);
            promedio = Convert.ToSingle(Console.ReadLine());
            menor = promedio;
            nombreMenor = nombre;
            mayor = promedio;
            nombreMayor = nombre;
            Console.WriteLine("Desea ingresar otro jugador? (S/N)");
            jug = Console.ReadLine();
            while (jug == "S" || jug == "s")
            {
                Console.WriteLine("Ingrese el Nombre del Jugador: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Promedio de {0}:", nombre);
                promedio = Convert.ToSingle(Console.ReadLine());
                //Es menor promedio?
                if (promedio < menor)
                {
                    menor = promedio;
                    nombreMenor = nombre;
                }
                //Es mayor promedio?
                if (promedio > mayor)
                {
                    mayor = promedio;
                    nombreMayor = nombre;
                }
                Console.WriteLine("Desea ingresar otro jugador? (S/N)");
                jug = Console.ReadLine();

            }
            
            Console.WriteLine("---------------");
            Console.WriteLine("El Jugador con mayor promedio es {0} con ${1}", nombreMayor, mayor);
            Console.WriteLine("El Jugador con menor promedio es {0} con ${1}", nombreMenor, menor);
            Console.ReadKey();
        }
    }
}
