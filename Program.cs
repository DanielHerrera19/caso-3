using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NA;
            double PA;
            double TOT;

            Console.WriteLine("Numero de alumnos que realizan el viaje: ");
            NA = int.Parse(Console.ReadLine());

            if (NA >= 100)
            {
                PA = 65.0;
            }
            else if (NA >= 50)
            {
                PA = 70.0;
            }
            else if (NA >= 30)
            {
                PA = 95.0;
            }
            else
            {
                PA = 4000 / NA;
            }

            TOT = PA * NA;

            Console.WriteLine("El pago individual es de: " + PA);
            Console.WriteLine("El pago total es: " + TOT);  
        }
    }
}