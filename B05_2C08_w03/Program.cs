using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05_2C08_w03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] studnts = { {"Tasnim","Rahman" },{"Firoz","Aman" },{"Kalam" ,"Jamal"} };
            Console.WriteLine(studnts.GetLength(0));
            Console.WriteLine(studnts.GetLength(1));
            for (int i = 0;i<studnts.GetLength(0); i++)
            {
                for (int j = 0;j<studnts.GetLength(1); j++)
                {
                    Console.Write($"{studnts[i, j]}\t");
                }
                Console.WriteLine(  );
            }

            Console.ReadKey();
        }
    }
}
