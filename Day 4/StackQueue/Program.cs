using System.Collections;
namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack s = new Stack();
            s.Push(1);
            s.Push("ab");
            Console.WriteLine(s);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            

        }
    }
}