using System;
using System.Collections.Generic;

namespace Capacity_Count
{
    class Program
    {
        static void Main()
        {
            // Create a List of integers
            List<int> numbers = new List<int>();

            // Add some elements to the list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            // Get the count and capacity of the list
            int count = numbers.Count;
            int capacity = numbers.Capacity;

            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Capacity: {capacity}");
        }
    }
}