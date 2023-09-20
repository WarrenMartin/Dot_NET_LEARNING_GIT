namespace ActionFuncPredicate
{


    public class Employee
    {
        public int EmpNo { get; set; }
        public String Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Action o1 = Display;
            o1();

            Action<String> o2 = Display;
            o2("Warre");

            

        }

        static void Main(string[] args)
        {
            Func<String> o1 = GetNow;
          //  Console.Write(o1());

            //Func<int, int> func = GetDouble;
            //func(10);

            Func<int, int, int> func2 = Add;
            Console.WriteLine(func2(2, 5));

            //calling boolean type
            Func<int, bool> boo1 = IsEven;
            Console.WriteLine(boo1(11));

            //you can do using another delegate called as Predicate
            // how action delegate takes a void as return type predicate takes boolean as a return type.

            Predicate<int> o2 = IsEven;
            o2(10);

            Employee obj = new Employee() { Basic = 2000 };
            // Now let us use predicate to pass it

            Predicate<Employee> boo2 = IsBasicGreaterThan1000;
            boo2(obj);

        }

        static bool IsBasicGreaterThan1000(Employee obj)
        {
            if(obj.Basic >10000)
                return true;
            return false;
        }



        static bool IsEven(int i)
        { 
            if (i % 2 == 0)
                return true;
            return false;
        }

        static String GetNow()
        {
            return DateTime.Now.ToLongTimeString();
        }

        static int GetDouble(int a)
        {
            return a * 2;
        }

        static void Display()
        {
            Console.WriteLine("Display Called");
        }

        static void Display(String s)
        {
            Console.WriteLine("Display Called",s);
        }

        static int Add(int a, int b) 
        {
            return a + b;
        }
    }
}