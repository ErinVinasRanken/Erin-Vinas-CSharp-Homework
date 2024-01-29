
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Homework01_03
{
    internal class Program
    {
        // Declare and initialize program constant
        const decimal PERCENT_RAISE = 0.04m;
        static void Main(string[] args)
        {
            string emp1Name = "";
            string emp2Name = "";
            string emp3Name = "";
            string emp1SalaryStr = "";
            string emp2SalaryStr = "";
            string emp3SalaryStr = "";
            
            decimal emp1Salary = 0m;
            decimal emp2Salary = 0m;
            decimal emp3Salary = 0m;

            string yearString = "";

            int year = 0;

            Write("Enter current year:\t");
            yearString = ReadLine();
            year = Convert.ToInt32(yearString);

            Write("\nEnter employee1 Name:\t");
            emp1Name = ReadLine();
            Write("Enter employee1 salary:\t");
            emp1SalaryStr = ReadLine();
            emp1Salary = Convert.ToDecimal(emp1SalaryStr);

            Write("\nEnter employee2 Name:\t");
            emp2Name = ReadLine();
            Write("Enter employee2 salary:\t");
            emp2SalaryStr = ReadLine();
            emp2Salary = Convert.ToDecimal(emp2SalaryStr);

            Write("\nEnter employee3 Name:\t");
            emp3Name = ReadLine();
            Write("Enter employee3 salary:\t");
            emp3SalaryStr = ReadLine();
            emp3Salary = Convert.ToDecimal(emp3SalaryStr);

            WriteLine("\nYear\t\t" + emp1Name + "\t\t\t" + emp2Name + "\t\t\t" + emp3Name + "\t\t\t");

            WriteLine(year + "\t\t" + emp1Salary.ToString("c") + "\t\t" + emp2Salary.ToString("c") + "\t\t" +
                                      emp3Salary.ToString("c") + "\t\t");

            ++year;

            emp1Salary += (emp1Salary * PERCENT_RAISE);
            emp2Salary += (emp2Salary * PERCENT_RAISE);
            emp3Salary += (emp3Salary * PERCENT_RAISE);

            WriteLine(year + "\t\t" + emp1Salary.ToString("c") + "\t\t" + emp2Salary.ToString("c") + "\t\t" +
                                      emp3Salary.ToString("c") + "\t\t");
            
            ++year;

            emp1Salary += (emp1Salary * PERCENT_RAISE);
            emp2Salary += (emp2Salary * PERCENT_RAISE);
            emp3Salary += (emp3Salary * PERCENT_RAISE);

            WriteLine(year + "\t\t" + emp1Salary.ToString("c") + "\t\t" + emp2Salary.ToString("c") + "\t\t" +
                                      emp3Salary.ToString("c") + "\t\t");

            ReadLine();
        }
    }
}
