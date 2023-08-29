namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o=new Class1();
            o.I = 10; //your assigning a val so set is called
            Console.WriteLine(o.I);

           

        }
    }

    public class Class1
    {
        //private int i; // class level variable -field

        //public void SetI(int VALUE) {
        //    if (VALUE < 100)
        //    {
        //        i = VALUE;


        //    }
        //    else {
        //        Console.WriteLine("Invalid i");
        //        // throw new Exception("Invalid i");
        //    }
        //}

        //public int GetI() { return i; } 

        private int i;
        public int I { 
         
            
            set 
            { 
                if(value<100)
                    i = value;
                else
                    Console.WriteLine("Invalid i");
            }

            get { return i; }

        }

       
    }
}