using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program2
    {
        static void Main()
        {
            Class2 o=new Class2();
            o.i = 1;    
            Console.WriteLine(o.i);
        }
    }

    public class Class2
    {
        public int i { get; set; }
    }
}
