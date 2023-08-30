namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o2=new Class1();
            o2.i = 1;

            Class1.static_i=240;

            Class1.static_Display();
        }
    }


    public class Class1 
    {
        public int i;

        public static int static_i;

        public void Display()
        {
            Console.WriteLine("Display");
        }

        // Static Construcot 

         static Class1()
        {
            Console.WriteLine(" static cons");
        }

        // Can call method without creating obj of that class. 
        public static void static_Display()
        {
            Console.WriteLine("Static Display");
        }

        // Static property : it is usd for validation and for common data 

        private static int p1;
        public static int P1
        {
            get { return p1; }
            set 
            {
                if (value < 100)
                    p1 = value;

                else
                    Console.WriteLine("Invalid i");
            }

    }



}