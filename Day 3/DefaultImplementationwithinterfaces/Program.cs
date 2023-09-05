namespace DefaultImplementationwithinterfaces
{
    internal class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            //o.Update();

            // (o as IDbFunctions).Select();
            Console.WriteLine(o);
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

        void Select()
        {
            Console.WriteLine("Default implementation code here");
        }
    }

    public class Class1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete of IDbFunctions");
        }

        public void Insert()
        {
            Console.WriteLine("Insert of IDbFunctions");
        }

        public void Update()
        {
            Console.WriteLine("Update of IDbFunctions");
        }
    }
}