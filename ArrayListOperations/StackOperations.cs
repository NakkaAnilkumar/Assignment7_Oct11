using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperationsLibrary
{
    public class StackOperations
    {
        public static void PerformStackOperations()
        {
            Stack<int> originalStack = new Stack<int>();

            originalStack.Push(40);
            originalStack.Push(56);
            originalStack.Push(3);
            Console.WriteLine("Original Stack after Push:");
            PrintStack(originalStack);

            originalStack.Pop();
            Console.WriteLine("Original Stack after First Pop:");
            PrintStack(originalStack);
            originalStack.Pop();
            Console.WriteLine("Original Stack after Second Pop:");
            PrintStack(originalStack);

            Stack<int> copiedStack = new Stack<int>(originalStack);
            Console.WriteLine("Copied Stack:");
            PrintStack(copiedStack);

            originalStack.Clear();
            Console.WriteLine("Original Stack after Clear:");
            PrintStack(originalStack);
        }

        private static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }




}
    

