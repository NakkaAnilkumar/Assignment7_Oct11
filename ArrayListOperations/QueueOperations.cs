using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOperationsLibrary
{
    public class QueueOperations
    {
        public static void PerformQueueOperations()
        {
            Queue<int> originalQueue = new Queue<int>();

            originalQueue.Enqueue(1);
            originalQueue.Enqueue(2);
            originalQueue.Enqueue(3);
            Console.WriteLine("Original Queue after Enqueue:");
            PrintQueue(originalQueue);

            originalQueue.Dequeue();
            Console.WriteLine("Original Queue after First Dequeue:");
            PrintQueue(originalQueue);
            originalQueue.Dequeue();
            Console.WriteLine("Original Queue after Second Dequeue:");
            PrintQueue(originalQueue);

            Queue<int> copiedQueue = new Queue<int>(originalQueue);
            Console.WriteLine("Copied Queue:");
            PrintQueue(copiedQueue);

            originalQueue.Clear();
            Console.WriteLine("Original Queue after Clear:");
            PrintQueue(originalQueue);
        }

        private static void PrintQueue(Queue<int> queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }



}