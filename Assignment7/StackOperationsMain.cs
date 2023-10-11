using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackOperationsLibrary;


namespace Assignment7
{
    public class StackOperationsMain
    {
        static void Main()
        {
            Stack<int> originalStack = new Stack<int>();

            StackOperations.PerformStackOperations();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}

