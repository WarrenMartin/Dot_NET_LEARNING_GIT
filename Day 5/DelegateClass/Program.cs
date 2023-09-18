namespace DelegateClass

    /*
     * Remeber the heriachy 
     * Object
     * Delegate
     * MulticastDelegate
     * Del1 
     */
{
    public delegate void Del1();
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is an Equivanent of +=
           Delegate objDel= Delegate.Combine(new Del1(Display), new Del1(Show)); 
           //Delegate.remove // This is the Equvalent of ==


        }

        static void Display() {
            Console.WriteLine("Hello Display");
        }

        static void Show() { 
            Console.WriteLine("Hello Show");
        }

        static int Add(int a, int b) 
        { 
            return a + b;
        }
        static int Subtract(int a, int b)
        { return a - b; }
    }
}