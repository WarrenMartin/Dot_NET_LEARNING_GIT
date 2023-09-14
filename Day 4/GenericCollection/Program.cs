namespace GenericCollection
{
    internal class Program
    {
        //List
        static void Main1(string[] args)
        {
           List<int> list = new List<int>();

            list.Add(10);    
            list.Add(20);
            list.Add(30);
        }

        //sortedList
        static void Main(string[] args)
        {
           SortedList<int,String> obj = new SortedList<int,String>();

            obj.Add(3, "c");
            obj.Add(4, "d");
            obj.Add(5, "e");
            obj.Add(6, "f");
            obj.Add(7, "g");

            //Now to loop through this we use a dictionary entry but now it has changed 

            foreach(KeyValuePair<int,String> kvp in obj)
            {
                Console.
            }


        }
    }
}