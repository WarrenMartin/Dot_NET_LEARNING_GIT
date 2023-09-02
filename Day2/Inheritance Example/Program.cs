namespace Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass o=new BaseClass();
            //o.PUBLIC=6;
            //o.PROTECTED_INTERNAL=9;
            //o.INTERNAL=10;

            // the not allowed once are
           // o.PRIVATE; Same class accessible 
            // o.PROTECTED; accessible in derived class
           // o.PRIVATE_PROTECTED; accessible in same class and derived class 


            DerivedCLass o2=new DerivedCLass();

            TestAccessSpecifiers.BaseClass o3=new TestAccessSpecifiers.BaseClass(); 

            
        }
    }
}




public class DerivedCLass : TestAccessSpecifiers.BaseClass
{ //BaseClass

    public void DoSomething() { }
}