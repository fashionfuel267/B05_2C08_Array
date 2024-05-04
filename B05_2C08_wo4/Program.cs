using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05_2C08_wo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedarr = new int[5][];
            jaggedarr[0] = new int[] { 15, 45, 56 };
            jaggedarr[1] = new int[] { 65, 75, 5, 88, 89 };
            for (int i = 0; i < jaggedarr.Length; i++)
            {
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    Console.Write($"{jaggedarr[i][j]}\t");
                }
                Console.WriteLine(  );
            }
            Console.ReadKey();
        }
    }
}
