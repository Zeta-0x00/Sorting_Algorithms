using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            List<int> numberList = new List<int>();
            Random number = new Random();
            List<List<int>> Matrix = new List<List<int>>();
            int cont = 100;
            TESTS unitTEST = new TESTS();
            for (int i = 0; i < 20; i++)
            {
                numberList = unitTEST.CreateList(numberList, cont, number);
                unitTEST.setMatrix(numberList, Matrix);
                unitTEST.Excecute(sort, Matrix[0], Matrix[1], Matrix[2], Matrix[3], Matrix[4], Matrix[5], i + 1, cont);
                cont += 50000;
            }
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();

            
        }
       

    }

}
