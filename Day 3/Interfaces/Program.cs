namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            Class1 o = new Class1();
          //  o.Display();
            //o.Insert();
           // o.Update();
            //o.Delete();

            // Method 2
            IDbFunctions oIDb;
            oIDb = o;
            o.Insert();

            //Method 3
           // ((IDbFunctions)o).Insert();



        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("display from class1");
        }
        public void Delete()
        {
            Console.WriteLine("delete from class1");
        }

        public void Insert()
        {
            Console.WriteLine("insert from class1");
        }

        public void Update()
        {
            Console.WriteLine("update from class1");
        }
    }

}