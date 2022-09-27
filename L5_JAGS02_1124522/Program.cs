using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_JAGS0_1124522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DIA;

            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese un número para el día de la semana");

            DIA = Convert.ToInt32(Console.ReadLine());

            if (DIA == 1)
            {
                Console.WriteLine("El día es lunes");
            }
            if (DIA == 2)
            {
                Console.WriteLine("El día es martes");
            }
            if (DIA == 3)
            {
                Console.WriteLine("El día es miercoles");
            }
            if (DIA == 4)
            {
                Console.WriteLine("El día es jueves");
            }
            if (DIA == 5)
            {
                Console.WriteLine("El día es viernes");
            }
            if (DIA == 6)
            {
                Console.WriteLine("El día es sabado");
            }
            if (DIA == 7)
            {
                Console.WriteLine("El día es domingo");
            }
            if (DIA > 7)
            {
                Console.WriteLine("El numero ingresado no coincide");
            }
            Console.ReadKey();

        }
    }
}
