namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)


        {

            int[] arr3 = (int[])Array.CreateInstance(typeof(int), 5);

            int[] arr=new int[3];

          
            for (int i = 0; i < arr.Length; i++)
            {
                //To Read Values from the users
                //Console.WriteLine("enter Value for arr[" +i + "]:"); //Method is called String concatenation
                //Console.WriteLine("enter value for arr[{0}]:",i); //placeholders
                //Console.WriteLine($"Enter value for arr[{i}]:") //String interpolation

                //arr[i] = int.Parse(Console.ReadLine());
                arr[i] =Convert.ToInt32(Console.ReadLine());

            }
            foreach (int item in arr)
            { 
                Console.WriteLine(item);
            }

        }
    }
}