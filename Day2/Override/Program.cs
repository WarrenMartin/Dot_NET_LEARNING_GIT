namespace Override
{
    internal class Program
    {
        static void Main1()
        {
            DerivedClass obj=new DerivedClass();
            //o.Display1();
            //obj.Display1("aaa");
            obj.Display2();


        }


        static void Main()
        {
            BaseClass o;
            o = new BaseClass();
            o.Display2(); // non virtual function - early bound 
            o.Display3(); // virtual function - late bound

            o = new DerivedClass();
            o.Display2(); // non virtual function - early bound 
            o.Display3(); // virtual function - late bound



        }
    }
}

public class BaseClass
{
    public void Display1()
    {
        Console.Write("base display1");
    }

    public void Display2()
    {
        Console.WriteLine("base display2");
    }

    public virtual void Display3()
    { 
        Console.WriteLine("base display3");
    }

}

public class DerivedClass : BaseClass
{
    // overload the base class method - same name, diff parameters
    public void Display1(String s)
    { 
        Console.WriteLine("derived display1 " + s);
    }
   // hide the base class method- same name , same parameters (same signature)
    public new  void Display2()
    {
         Console.WriteLine("derived display2");
    }


    //nw to override we do
    public override void Display3()
    {
        Console.WriteLine("derived display3");
    }

}