namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyClass<int> myClass = new MyClass<int>();
            MyClass<String> myString = new MyClass<String>();

            int n1 = 10;
            int n2 = 20;
            Console.WriteLine($"{n1} {n2}");

            myClass.Swap(ref n1, ref n2);
            Console.WriteLine($"{n1}  {n2}");
        }
    }


     public class MyClass<T>
    {
        public void Swap(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }
    }

}