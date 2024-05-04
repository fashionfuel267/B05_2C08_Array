using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05_2C08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");

            int[] lab;
            lab= new int[4] ;
            lab[0] =int.Parse( Console.ReadLine());
            Console.WriteLine("enter first number");
            lab[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            lab[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            lab[3] = int.Parse(Console.ReadLine());
            for (int i = 0 ; i < lab.Length ; i++)
            {
                Console.WriteLine($"{i+1}. {lab[i]}");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
