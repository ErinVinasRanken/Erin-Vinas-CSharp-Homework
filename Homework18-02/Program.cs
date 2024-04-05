using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Homework18_02
{
    internal class Program
    {
        // Decalre and initialize global cnstsant
        const string NOTHINGINPUTTED = "No Value Inputted For Search Criteria";
        const string NOLASTNAMEFOUND = "No Matching Employee Last Name Found";
        const string NOADDRESSFOUND = "No Matching Employee Address Found";
        const string NOCITYFOUND = "No Matching Employee City Found";

        // Declare and initialize lobal variable
        static List<Employee> employees = EmployeeManager.LoadData();
        static void Main(string[] args)
        {
            int option;
            bool runAgain = true;

            while (runAgain)
            {
                option = ShowMenu();
                CallCorrectFunction(option);
                runAgain = AnotherTime();
            }
        }

        static int ShowMenu()
        {
            Clear();

            string o;
            int optionChosen = 0;
            bool result;

            // Build the mneu
            string menuStr = "Choose One Of The Following Options\n";
            menuStr += "Enter A 1 To Show All Employees Last Name Ascending\n";
            menuStr += "Enter A 2 To Show All Employees By Address Ascending\n";
            menuStr += "Enter A 3 To Show All Employees By City Ascending\n";
            menuStr += "Enter A 4 To Show All Employees By State Ascending\n";
            menuStr += "Enter A 5 To Show All Employees By Zip Code Ascending\n";
            menuStr += "Enter A 6 To Show One Or More Employees By Last Name Ascending\n";
            menuStr += "Enter A 7 To Show One Or More Employees By Address Ascending\n";
            menuStr += "Enter A 8 To Show one Or More Employees By City Ascending\n";
            menuStr += "Enter A 9 To Exit Program Now\n\n";
            menuStr += "Please Enter A 1, 2, 3, 4, 5, 6, 7, 8, Or 9 Now:";

            Write(menuStr);
            o = ReadLine();

            // Vlaidate that the entry was valid (# 1 - 9)
            result = int.TryParse(o, out optionChosen);

            // If parse failed
            if (!result)
            {
                Write("You Must Enter a Number! Please Try Again: ");
                ReadLine();
                ShowMenu();
            }
            else if (optionChosen < 1 || optionChosen > 9)
            {
                Write("You Must Enter a Number Between 1 And 9! Please Try Again: ");
                ReadLine();
                ShowMenu();
            }

            return optionChosen;
        }

        static void CallCorrectFunction(int o)
        {
            switch (o)
            {
                case 1:
                    ShowEmployeesByLastNameAscending();
                    break;
                case 2:
                    ShowEmployeesByAddressAscending();
                    break;
                case 3:
                    ShowEmployeesByCityAscending();
                    break;
                case 4:
                    ShowEmployeesByStateAscending();
                    break;
                case 5:
                    ShowEmployeesByZipCodeAscending();
                    break;
                case 6:
                    ShowEmployeesByLastNameCriteria();
                    break;
                case 7:
                    ShowEmployeesByAddressCriteria();
                    break;
                case 8:
                    ShowEmployeesByCityCriteria();
                    break;
                case 9:
                    ExitProgramNow();
                    break;
                default:
                    break;
            }
        }

        static void ShowEmployeesByLastNameAscending()
        {
            Clear();

            var lastNameAscending =
                from e in employees
                orderby e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By Last Name In Ascending Order:\n");
            foreach (var e in lastNameAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByAddressAscending()
        {
            Clear();

            var addressAscending =
                from e in employees
                orderby e.Address ascending, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By Address In Ascending Order:\n");
            foreach (var e in addressAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByCityAscending()
        {
            Clear();

            var cityAscending =
                from e in employees
                orderby e.City, e.Address ascending, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By City In Ascending Order:\n");
            foreach (var e in cityAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByStateAscending()
        {
            Clear();

            var stateAscending =
                from e in employees
                orderby e.State, e.City, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By State In Ascending Order:\n");
            foreach (var e in stateAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByZipCodeAscending()
        {
            Clear();

            var zipCodeAscending =
                from e in employees
                orderby e.ZipCode ascending, e.State, e.City, e.LastName ascending, e.FirstName ascending
                select e;

            WriteLine("All Employees By Zip Code In Ascending Order:\n");
            foreach (var e in zipCodeAscending)
            {
                WriteLine(e);
            }

            ReadLine();
        }

        static void ShowEmployeesByLastNameCriteria()
        {
            Clear();

            string lastName;

            Write("Enter An Employee Last Name To Search For (Full Or Partial):");
            lastName = ReadLine();

            if (lastName.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
                ReadLine();
            }
            else
            {
                var lastNames =
                    from e in employees
                    orderby e.LastName ascending
                    where e.LastName.ToUpper().Contains(lastName.ToUpper())
                    select e;

                WriteLine("\nLast Names Matching Inputted Criteria: ");
                if (lastNames.Count() < 1)
                {
                    WriteLine(NOLASTNAMEFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in lastNames)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }

        static void ShowEmployeesByAddressCriteria()
        {
            Clear();

            string address;

            Write("Enter An Employee Address To Search For (Full Or Partial):");
            address = ReadLine();

            if (address.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
                ReadLine();
            }
            else
            {
                var addresses =
                    from e in employees
                    orderby e.LastName ascending
                    where e.Address.ToUpper().Contains(address.ToUpper())
                    select e;

                WriteLine("\nAddresses Matching Inputted Criteria: ");
                if (addresses.Count() < 1)
                {
                    WriteLine(NOADDRESSFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in addresses)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }

        static void ShowEmployeesByCityCriteria()
        {
            Clear();

            string city;

            Write("Enter An Employee City To Search For (Full Or Partial):");
            city = ReadLine();

            if (city.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
                ReadLine();
            }
            else
            {
                var cities =
                    from e in employees
                    orderby e.LastName ascending
                    where e.City.ToUpper().Contains(city.ToUpper())
                    select e;

                WriteLine("\nCities Matching Inputted Criteria: ");
                if (cities.Count() < 1)
                {
                    WriteLine(NOCITYFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in cities)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }


        static void ExitProgramNow()
        {
            Clear();

            WriteLine("Program Terminating Normally. Bye For Now.");
            ReadLine();
            Environment.Exit(0);
        }

        static bool AnotherTime()
        {
            bool retVal = true;

            string again = "";
            char firstChar = ' ';

            Write("Run Program Again?!? (Y/N)");
            again = ReadLine().ToUpper();

            if (again == "")
            {
                return false;
            }

            firstChar = again[0];
            
            if (firstChar != 'Y')
            {
                retVal = false;
            }

            return retVal;
        }
    }
}
