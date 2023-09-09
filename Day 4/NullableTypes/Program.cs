namespace NullableTypes
{
    internal class Program
    {
        static void Main()
        {
            int? i;
            i = null;
            //int j = (int)i;
            j=i.GetValueOrDefault();

            // or you can do it like this also
            i = i ?? 0; // ?? = null coalescing operator 

        }
    }
}