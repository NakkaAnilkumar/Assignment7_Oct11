using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashTableManagerLibrary;


namespace Assignment7
{
    public class HashTableManagerMain
    {
        static void Main()
        {
            HashTableManager hashTableManager = new HashTableManager();

            // Add elements
            hashTableManager.AddElement("Anil", "Value1");
            hashTableManager.AddElement("sunny", "Value2");
            hashTableManager.AddElement("Bunny", "Value3");

            // Get the hash table
            Hashtable hashtable = hashTableManager.GetHashTable();

            // Print the hash table
            Console.WriteLine("Contents of Hashtable:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Remove an element
            hashTableManager.RemoveElement("Bunny");

            // Print the hash table again
            Console.WriteLine("\nContents of Hashtable after removing 'Bunny':");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.ReadLine();


        }
    }
    
}
