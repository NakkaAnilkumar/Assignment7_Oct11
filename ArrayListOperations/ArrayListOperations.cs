using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLibrary
{
    public class ArrayListOperations
    {
        private ArrayList arrayList = new ArrayList();

        public void AddElements()
        {
            for (int i = 1; i <= 10; i++)
            {
                arrayList.Add(i);
            }
        }

        public void PrintArrayList()
        {
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void RemoveElement(int element)
        {
            if (arrayList.Contains(element))
            {
                arrayList.Remove(element);
            }
        }

        public int[] CopyArrayListToArray()
        {
            return arrayList.Cast<int>().ToArray();
        }

        public void RemoveNonIntsFromArray(ref int[] array)
        {
            array = array.Where(item => item is int).Cast<int>().ToArray();
        }

        public void SortAndReverseArray(ref int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
    }
}