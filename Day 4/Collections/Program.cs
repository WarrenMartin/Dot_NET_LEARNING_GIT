using System.Collections;
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(10);
            objArrayList.Add("vikram");
            objArrayList.Add(true);
            objArrayList.Add(4.234);

            objArrayList.Remove("vikram"); // remove vikram out from here
            objArrayList.RemoveAt(0); // removeat removes the 0th element 

            Console.WriteLine(objArrayList.Count);

            foreach (object i in objArrayList) 
            {
                Console.WriteLine(i);
            }
        }
    }
}