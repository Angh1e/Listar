using System;
using System.Collections.Generic;

namespace Listar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            var diasSemana = new List<string>();
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(5);
            numeros.Add(30);
            numeros.Add(50);
            numeros.Add(60);

            diasSemana.Add("Lunes");
            diasSemana.Add("Martes");
            diasSemana.Add("Miercoles");
            diasSemana.Add("Jueves");
            diasSemana.Add("Viernes");
            Console.WriteLine("Esta lista es de los dias de la semana");

            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Esta lista es de los numeros");
           foreach (var sem in diasSemana)
           {
             Console.WriteLine(sem);

           }
            Console.WriteLine("Eliminar el 60 de la lista de numero");
            numeros.Remove(60);

            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }


        }
    }
}
