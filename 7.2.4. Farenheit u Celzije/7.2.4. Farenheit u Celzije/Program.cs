using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4.Farenheit_u_Celzije
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi stupnjeve Farenheit");
            double Farenheit = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} F = {1} C", Farenheit FtoC(Farenheit));
            Console.ReadKey();
        }
        static double FtoC(double Farenheit);
        {
          return(double) 5/9* (Farenheit-32);
        }
        

    }
}
