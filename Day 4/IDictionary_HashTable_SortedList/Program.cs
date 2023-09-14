using System.Collections;
using System.Collections.Generic;


namespace IDictionary_HashTable_SortedList
{
    internal class Program
    {
        static void Main()
        {
           Hashtable objDictionary=new Hashtable();

            objDictionary.Add(3,"c");
            objDictionary.Add(2,"b");
            objDictionary.Add(1,"c");


            objDictionary[5] = "new value";

            objDictionary.Remove(5);

            foreach(DictionaryEntry item in  objDictionary)
            {
                Console.WriteLine(item);
            }

        }
    }
}