namespace Delegates


{
    //Step 1: Create a delegate class having the same signature as the function to call 
    public delegate void Disp1();
    internal class Program
    {
        static void Main()
        {
            //step 2 : declare a delegate reference. and a delegate object. 
            // the delegate object has the function name as a parameter.

            Disp1 dsp1=new Disp1(Display);
            dsp1();

            Display();
        }

        static void Display() 
        {
            Console.WriteLine("Display called");
        }
    }
}