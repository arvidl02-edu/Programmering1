using System;

namespace Bögström
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string[int.Parse(Console.ReadLine())].Length);

            // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
            // You can modify the path if necessary.


            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            for(i = 0; i < 
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);




        }
    }
}
