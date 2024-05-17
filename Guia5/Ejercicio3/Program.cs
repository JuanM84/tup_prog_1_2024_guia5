using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant = 0, numL, nota, libMenor=0, libMayor=0, notaMenor = 0, notaMayor = 0;
            string nombre, nombreMenor="", nombreMayor="";

            void esMenor(string nom, int lib, int n)
            {
                nombreMenor = nom;
                libMenor = lib;
                notaMenor = n;
            }
            void esMayor(string nom, int lib, int n)
            {
                nombreMayor = nom;
                libMayor = lib;
                notaMayor = n;
            }

            Console.WriteLine("Ingrese la cantidad de alumnos inscriptos:");
            cant = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;i<= cant; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno nº{0}:",i);
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número de libreta");
                numL = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la nota de {0}:", nombre);
                nota = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    esMenor(nombre, numL, nota);
                    esMayor(nombre, numL, nota);

                }
                else
                {
                    if(nota < notaMenor)
                    {
                        esMenor(nombre, numL, nota);
                    }
                    if(nota > notaMayor)
                    {
                        esMayor(nombre, numL, nota);
                    }
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Alumno con Mayor nota---");
            Console.WriteLine("Nombre: {0}", nombreMayor);
            Console.WriteLine("Libreta: {0}", libMayor);
            Console.WriteLine("Nota: {0}", notaMayor);
            Console.WriteLine("Alumno con Menor nota---");
            Console.WriteLine("Nombre: {0}", nombreMenor);
            Console.WriteLine("Libreta: {0}", libMenor);
            Console.WriteLine("Nota: {0}", notaMenor);
            Console.ReadKey();
        }
    }
}
