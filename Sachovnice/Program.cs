using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachovnice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barvy = { "██", "  " };
            int barva = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(barvy[barva]);
                    if (barva == 0)
                        barva = 1;
                    else
                        barva = 0;
                    //lze použít:
                    /*if ((i + j) % 2 == 0)
                        Console.Write("██");
                    else
                        Console.Write("  ");*/
                }
                Console.WriteLine();
                barva = (barva == 0) ? 1 : 0;
            }
            Console.ReadKey();
        }
    }
}
