using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MultiplicationTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Multiplication Table Generator");

            // Prompt user for number of rows
            Write("Enter The Number Of Rows: ");
            if (!int.TryParse(Console.ReadLine(), out int numRows) || numRows <= 0)
            {
                WriteLine("Please Enter A Valid Positive Integer For The Number Of Rows.");
                return;
            }

            // Prompt user for number of columns 
            Write("Enter The Number Of Columns:");
            if (!int.TryParse(Console.ReadLine(), out int numCols) || numCols <= 0)
            {
                WriteLine("Please Enter A Valid Positive Integer For The Number Of Columns");
                return;
            }

            // Display the multiplication table
            WriteLine("\nMultiplication Table:");
            for (int i = 1; i <= numRows; i++) 
            {
                for (int j = 1; j <= numCols; j++)
                {
                    Write($"{i * j,5}");
                }
                WriteLine();
            }

            ReadLine();
        }
    }
}
