using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Assignment1
    {
    }

    public class Student 
    {
        // Only for name
        private String name;
        public String Name
        {
            get { return name; }

            set 
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Invalid name");

            }
        }

        private int empno;
        public int Empno
        {
            get { return empno; }
            set
            {
                if (value > 0)
                    empno = value;
                else Console.WriteLine("Invalid empno");
            }
        }

        private float basic;
        public float Basic
        {
            get { return basic; }
            set
            {
                if ((basic = value) > 0) ;
            }
        }
    }
   
}
