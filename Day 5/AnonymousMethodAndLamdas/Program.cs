namespace AnonymousMethodAndLamdas
{
    internal class Program
    {
        static void Main()
        {
            // Anonomous example for action 
            Action o = delegate()
            {
                Console.WriteLine("Display Called");
            };
            o();

            // anonomous example for func
            Func<int, int, int> o2 = delegate (int a, int b)
            {
                return a + b;
            };
            o2(1, 2);

            // anonomous example for predicate
            Predicate<int> o3 = delegate (int i)
            {
                if (i % 2 == 0)
                    return true;
                  return false;
            };
            o3(10);
             

        }

        // this is only for your reference for your code you dont require it
        static void Display()
        {
            Console.WriteLine("Display Called");
        }

        // this is only for your reference for your code you dont require it
        static int Add(int a, int b) 
        { 
            return a + b;
        }

        // this is only for your reference for your code you dont require it
        static bool IsEven(int i)
        { 
            if(i%2 == 0)
                return true;
            return false;
        }

    }
}