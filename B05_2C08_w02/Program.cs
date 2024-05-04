using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05_2C08_w02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lab;
            lab = new int[4];
            Console.WriteLine("enter number with coma");
           string data = (Console.ReadLine());
            var output= data.Split(',');
            for(int i = 0; i < output.Length; i++)
            {
                lab[i]= int.Parse(output[i]);
            }
            Console.WriteLine(  "ALl items of LAb");
            for (int i = 0; i < lab.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lab[i]}");
            }
            Array.Sort(lab);
            Console.WriteLine("ALl items of LAb after sorting");
            for (int i = 0; i < lab.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lab[i]}");
            }
            Array.Reverse(lab);
            Console.WriteLine("ALl items of LAb after Descending");
            for (int i = 0; i < lab.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lab[i]}");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
