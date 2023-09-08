namespace ValueTypeRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            int j = 200;
           // Swap(ref i, ref j);
           Init(out i,out j);
            Console.WriteLine(i);
            Console.WriteLine(j);

        }

        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Init(out int a, out int b) 
        {
            a = 1000;
            b = 2000;
        }

    }

    
}