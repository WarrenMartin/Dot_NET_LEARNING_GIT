using System;

class Program
{
    static void Main()
    {
        // Multidimensional Array
        int[,] matrix = new int[3, 3];

        // Initializing the matrix
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                matrix[row, col] = row * 3 + col + 1;
            }
        }

        // Displaying the matrix
        Console.WriteLine("Multidimensional Array (Matrix):");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        // Jagged Array
        int[][] jaggedArray = new int[3][];

        // Initializing the jagged array with subarrays of different lengths
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Displaying the jagged array
        Console.WriteLine("\nJagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        // Accessing elements
        int element1 = matrix[1, 2]; // Accessing the element at row 1, column 2 of the matrix (should be 6)
        int element2 = jaggedArray[0][1]; // Accessing the element at the first position of the first subarray (should be 2)

        Console.WriteLine("\nAccessed Elements:");
        Console.WriteLine("Element in Matrix: " + element1);
        Console.WriteLine("Element in Jagged Array: " + element2);

        // Wait for user input before exiting
        Console.ReadLine();

        // warren Martin
    }
}