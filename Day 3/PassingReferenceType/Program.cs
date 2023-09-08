namespace PassingReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o = new class1();
            o.i = 100;
            DoSomething1(o);
          
            static void DoSomething1(class1 obj)
            {
                obj.i = 200;
                Console.WriteLine(obj.i);
            }

        }
    }

    public class class1
    {
        public int i;
    }
}
