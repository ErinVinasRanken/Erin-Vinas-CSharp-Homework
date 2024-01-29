using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*	#7.  Write a console application that tracks
 *		the home sales of three salespeople
 *		Danielle, Edward, Francis):
 *		●	The program prompts the user for a 
 *			salesperson initial (d, e, or f) and 
 *			the sales amount, then updates the 
 *			total sales.
 *		●	Any user can have multiple sales.
 *		●	If the user enters "z" for the initial
 *			then the program should display the total
 *			sales for each salesperson, the grand
 *			total for all sales, and the name of the
 *			salesperson with the highest total.
 *		●	If the user enters an initial other than
 *			"d", "e", "f" or "z" then the program 
 *			should display an error and prompt the 
 *			user for a new initial.
 *		●	All initials should be treated in a 
 *			case-insensitive manner.
 */

namespace HomeSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int sum = 0, sumD = 0, sumE = 0, sumF = 0, value;
            int highestSale = 0;
            string highestSalesPerson = "";

            while (true)
            {
                WriteLine("Enter the initial for Salesperson D, E, F and Z to terminate:");

                // Read the initial as a string and convert it to uppercase
                string input = Console.ReadLine()?.ToUpper();

                if (string.IsNullOrEmpty(input))
                {
                    WriteLine("Please enter a valid initial.");
                    continue;
                }

                ch = input[0];

                if (ch == 'D')
                {
                    WriteLine("Please enter the sale amount:");
                    value = Convert.ToInt32(Console.ReadLine());
                    sum += value;
                    sumD += value;
                }
                else if (ch == 'E')
                {
                    WriteLine("Please enter the sale amount:");
                    value = Convert.ToInt32(Console.ReadLine());
                    sum += value;
                    sumE += value;
                }
                else if (ch == 'F')
                {
                    WriteLine("Please enter the sale amount:");
                    value = Convert.ToInt32(Console.ReadLine());
                    sum += value;
                    sumF += value;
                }
                else if (ch == 'Z')
                {
                    break;
                }
                else
                {
                    WriteLine("Please enter a valid initial.");
                    continue;
                }

                // Update highest salesperson
                if (sumD > sumE && sumD > sumF)
                {
                    highestSalesPerson = "Danielle";
                    highestSale = sumD;
                }
                else if (sumE > sumF)
                {
                    highestSalesPerson = "Edward";
                    highestSale = sumE;
                }
                else
                {
                    highestSalesPerson = "Francis";
                    highestSale = sumF;
                }
            }

            WriteLine("\nTotal Sale Of Danielle Is: {0:c}", sumD);
            WriteLine("\nTotal Sale Of Edward Is: {0:c}", sumE);
            WriteLine("\nTotal Sale Of Francis Is: {0:c}", sumF);
            WriteLine("\nTotal Sale Is: {0:c}", sum);
            WriteLine("\nHighest Sales Person is {0}\nHighest Sale Is {1:c}", highestSalesPerson, highestSale);

            ReadLine();
        }
    }
}
