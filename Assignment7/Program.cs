using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayListLibrary;

namespace Assignment7
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("a) Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    arrayList.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--;
                }
            }

            // b) Print the ArrayList.
            Console.WriteLine("b) ArrayList: ");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // c) Find the element existing in the ArrayList and remove the element.
            Console.Write("c) Enter an element to remove: ");
            if (int.TryParse(Console.ReadLine(), out int elementToRemove))
            {
                if (arrayList.Contains(elementToRemove))
                {
                    arrayList.Remove(elementToRemove);
                    Console.WriteLine($"Removed {elementToRemove} from the ArrayList.");
                }
                else
                {
                    Console.WriteLine($"Element {elementToRemove} not found in the ArrayList.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }

            // d) Copy the elements of the ArrayList to an array.
            int[] array = arrayList.Cast<int>().ToArray();
            

            // e) Remove the elements which are not ints from the array.
            array = array.Where(item => item is int).Cast<int>().ToArray();

            // f) Once you have an int array, sort and reverse the array.
            Array.Sort(array);
            Array.Reverse(array);

            // Print the sorted and reversed array.
            Console.WriteLine("f) Sorted and Reversed Array: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); ;
            Console.ReadLine();
        }
    }
}
    

