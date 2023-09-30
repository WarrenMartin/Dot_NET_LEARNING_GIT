namespace EventHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Writing this code
            Class1 objClass1=new Class1();
            //make invalid p1 delegate reference(Event) defined in class1 refer to our function objClass1_InvalidP1;
            objClass1.InvalidP1 += objClass1_InvalidP1;
            objClass1.P1 = 1;


        }

        static void objClass1_InvalidP1()
        {
            Console.WriteLine("Invalid Event raised -event handling code here");
        }
    }

    // Step 1: Create a delegate class having the same signature as the event handling function


    public delegate void InvalidP1EventHandler();

    

    public class Class1
    {
        // Step 2: declare the event of the delegate type
        // event is a delegate reference

        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get 
            {
                return p1;
            }
            set
            {
                if (value < 0)
                {
                    p1 = value;
                }
                else 
                {
                    //Raising an Event
                    //step 3-raise the event whenever required
                    //to raise the event call the delegate reference

                    if (InvalidP1 != null)
                    {
                        InvalidP1();
                    }
                    // Now we need to put an additional check  saying if INvalidP1() not eqaul to null then call it else you will get an null pointer exception
                }
            }
        }
    }
}