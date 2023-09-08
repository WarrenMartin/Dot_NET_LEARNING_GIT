namespace ValueTypes
{
    internal class Program
    {
        static void Main()
        {
            MyStruct st=new MyStruct();
            Console.WriteLine(st.MyCustomProperty = 1);
            Console.WriteLine(st.MyAutoProperty);

        }
    }
    public struct MyStruct
    {
        // Field
        private int myField;

        // Auto-implemented property
        public int MyAutoProperty { get; set; }

        // Custom property
        public int MyCustomProperty
        {
            get
            {
                return myField;
            }
            set
            {
                myField = value;
            }
        }
    }


}