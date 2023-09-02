namespace Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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

    public virtual  void Display3()
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
    public new void Display2()
    {
        Console.WriteLine("derived display2");
    }


    //nw to override we do
    public override  sealed void Display3()
    {
        Console.WriteLine("derived display3");
    }

}