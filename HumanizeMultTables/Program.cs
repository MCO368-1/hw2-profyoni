using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace HumanizeMultTables
{
    static class Program
    {
        static void Main(string[] args)
        {
            const int gridSize = 5;
            Console.WriteLine($"{"",13}" + MultTables.MultiplierRow(1, 1, gridSize, header: false));
            for (int i = 1; i <= gridSize; i++)
            {
                Console.WriteLine(new String('_', (gridSize + 1) * 13));
                Console.WriteLine(MultTables.MultiplierRow(i, 1, gridSize));
            }
            Console.ReadLine();
        }
    }
}
