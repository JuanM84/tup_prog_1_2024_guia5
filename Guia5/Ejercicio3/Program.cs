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
                    nombreMenor = nombre;
                    libMenor = numL;
                    notaMenor = nota;
                    nombreMayor = nombre;
                    libMayor = numL;
                    notaMayor = nota;

                }
                else
                {
                    if(nota < notaMenor)
                    {
                        nombreMenor = nombre;
                        libMenor = numL;
                        notaMenor = nota;
                    }
                    if(nota > notaMayor)
                    {
                        nombreMayor = nombre;
                        libMayor = numL;
                        notaMayor = nota;
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
