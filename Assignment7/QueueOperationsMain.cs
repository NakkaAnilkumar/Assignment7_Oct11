
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueOperationsLibrary; 

namespace Assignment7
{
    public class QueueOperationsMain
    {
        static void Main(string[] args)
        {
            QueueOperations.PerformQueueOperations();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
