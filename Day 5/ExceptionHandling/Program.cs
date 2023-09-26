namespace ExceptionHandling
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1 obj = new Class1();
            obj = null;
            int x=Convert.ToInt32(Console.ReadLine());
            obj.P1 = 100 / x;
            Console.WriteLine(obj.P1);
            Console.ReadLine();
        }

        static void Main()
        {
            Class1 obj=new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");

            }
            catch 
            {
                Console.WriteLine("Exception Occured");
            }
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get { return  p1; } 
            set { p1 = value;}
        }
    }
}