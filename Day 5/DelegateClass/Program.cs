namespace DelegateClass

    /*
     * Remeber the heria chy 
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
           Del1 objDel=(Del1) Delegate.Combine(new Del1(Display), new Del1(Show));
            objDel();


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