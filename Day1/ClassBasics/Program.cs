using System.Security.Cryptography.X509Certificates;

namespace ClassBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o; // o is the reference of type Class1
            o=new Class1(); // object of the class
            //o refers to the object created

            Class1 o1=new Class1();
            o1.Display();
            
        }          
      
        
    }

    public class Class1 
    {
        public void Display()
        {
            int i = 100;
            Console.WriteLine("Displayed Called");


            //Local Function
            // Now local function is implicity private and therefore it cannot have a access specifier
            void DoSomething()
            {
                Console.WriteLine(i);
                i++;
            }
            DoSomething();
            Console.WriteLine(i);

        }

    }
}

