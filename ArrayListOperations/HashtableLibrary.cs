using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableManagerLibrary
{
    public class HashTableManager
    {
        private Hashtable hashtable = new Hashtable();

        public void AddElement(string key, string value)
        {
            hashtable.Add(key, value);
        }

        public void RemoveElement(string key)
        {
            hashtable.Remove(key);
        }

        public Hashtable GetHashTable()
        {
            return hashtable;
        }
    }
}
