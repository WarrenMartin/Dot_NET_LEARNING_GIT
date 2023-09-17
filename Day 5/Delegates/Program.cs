namespace Delegates


{
    //Step 1: Create a delegate class having the same signature as the function to call 
    public delegate void Disp1();

    public delegate int  DelAdd(int a, int b);
    internal class Program
    {
        static void Main1()
        {
            //step 2 : declare a delegate reference. and a delegate object. 
            // the delegate object has the function name as a parameter.

            Disp1 dsp1=new Disp1(Display);
            //dsp1(); // at this point it is calling display

            dsp1 += Show;
            dsp1();  //at this point it is calling show




            //Display();
        }

        static void Main()
        {
            //DelAdd del1Add = new DelAdd(Display);
            //or
            DelAdd Objdeladd = Add;
            Objdeladd = Subtract;

            int ans = Objdeladd(15, 30);

            Console.WriteLine(ans);

        }

        static void Display() 
        {
            Console.WriteLine("Display called");
        }

        static void Show()
        {
            Console.WriteLine("Show called");
        }

        static int Add(int a, int b)
        {
            return a + b; 
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}