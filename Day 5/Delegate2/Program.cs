namespace Delegate2
{
    public delegate int DelAdd(int a, int b);
    internal class Program
    {
        static void Main()
        {
            int ans= CallMathOperation(Add);
             Console.WriteLine(ans);

            int sub = CallMathOperation(Subtract);
            Console.WriteLine(sub);

        }

        static int CallMathOperation(DelAdd objDelAdd)
        {
            return objDelAdd(10, 11);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a , int b)
        {
            return a - b;
        }
    }
}