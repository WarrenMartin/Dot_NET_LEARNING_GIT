namespace ConstructorsAndObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Class1   obj1 = new Class1();
            obj1.p1 = 10;
            obj1.p2 = 20;
            obj1.p3 = 30;

            // We can also do this as 

            Class1 obj2 = new Class1() { p1 = 10, p2 = 20, p3 = 30 };
            
            
        }
    }

    public class Class1
    {
        public int p1 { get; set; }
        public int p2 { get; set; }
        public int p3 { get; set; }

        public Class1()
        {
            Console.WriteLine("No param Constructor is called ");
            p1 = 1;     
            p2 = 2;
            p3 = 3;
        }
        public Class1(int p1=1,int p2 = 2,int p3 = 3)
        {
            this.p1 = p1;
            this.p2 = p2;   
            this.p3 = p3;
        }

    }
}