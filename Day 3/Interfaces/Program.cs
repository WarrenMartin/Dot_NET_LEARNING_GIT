namespace Interfaces
{
    internal class Program
    {
        static void Main1(string[] args)
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
            ((IDbFunctions)o).Insert();

            //method 4
           // (o as IDbFunctions).



        }

        static void Main(string[] args) {
            Class1 o = new Class1();
           
            (o as IFileFunctions).Close();
            (o as IFileFunctions).Delete();
            (o as IDbFunctions).Delete();
            o.Open();
            

           
        
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }


    public class Class1 : IDbFunctions, IFileFunctions
    {
        public void Display()
        {
            Console.WriteLine("display from class1");
        }
        

        public void Insert()
        {
            Console.WriteLine("insert from class1");
        }

        public void Update()
        {
            Console.WriteLine("update from class1");
        }

        //void IFileFunctions.Open()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFileFunctions.Close()
        //{
        //    throw new NotImplementedException();
        //}

        void IFileFunctions.Delete()
        {
           Console.WriteLine("delete of ifile function");
        }

        public void Open()
        {
            Console.WriteLine("ifile from open");
        }

        public void Close()
        {
            Console.WriteLine("ifile from close");
        }

        

        void IDbFunctions.Delete()
        {
            Console.WriteLine("Delete of idb function");
        }
    }

}