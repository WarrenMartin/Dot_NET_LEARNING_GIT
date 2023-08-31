namespace Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass o=new BaseClass();
            o.PUBLIC=6;
            o.PROTECTED_INTERNAL=9;
            o.INTERNAL=10;

            // the not allowed once are
           // o.PRIVATE; Same class accessible 
            // o.PROTECTED; accessible in derived class
           // o.PRIVATE_PROTECTED; accessible in same class and derived class 


            DerivedCLass o2=new DerivedCLass();
            
        }
    }
}


public class BaseClass
{
    public int PUBLIC;
    private int PRIVATE;
    private int PROTECTED;
    internal int INTERNAL;
    protected internal int PROTECTED_INTERNAL;
    private protected int PRIVATE_PROTECTED;

}

public class DerivedCLass : BaseClass
{
    public void DoSomething() { }
}