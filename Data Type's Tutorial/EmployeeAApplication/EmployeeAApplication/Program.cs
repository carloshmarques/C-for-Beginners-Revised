using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAApplication
{
    internal class Program
    {       // link: https://youtu.be/sW-fsSJaFA0?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di
        static void Main(string[] args)
        {
            /*
              * Aproperly define a group of variables for a employee record, such as;
              * - employeeid
              * - firstName
              * - last Name
              * - annualSalary
              * - gender
              * _ isManager
              * - narrative
              * _ The function of this is to accept data from the user input from which variables
              *   and output a narrative to the Console like so:
              *   
              *   
              *  'Employee with and id of 1, who's full name is Sarah Johnson,
              *   is a female and is part of the manegement team.
              *   This employee currently earns an annual salary of 60000.1345632178 pounds'
              *   
              */
            //console title
            Console.Title = "Employee Application";
            // set the output encoding to european encoding
            // Comment the line bellow if not needed
            Console.OutputEncoding = Encoding.UTF8;
            // Declare a variable for the employee id with an int value
            int employeeiD = 0;
            // Declare a variable for the employee first and last name from an empty string
            string firstName = string.Empty;
            string lastName = string.Empty;
            // Declare a variable as a Decimal type to store the employee annual salary
            decimal annualSalary = 0;
            // Declare a char variable to store employee gender
            char gender = '\0';
            // Declare a boolean variable that denote's if employee is a manager or not
            bool isManager = false;
            // Prompt the user for a value
            Console.WriteLine("Please enter a unique ID for this employee!");
            // wait for user input
            employeeiD = Convert.ToInt32(Console.ReadLine());
            // prompt for employee first name
            Console.WriteLine("Enter the employee first name: ");
            firstName = Console.ReadLine();
            // prompt for employee last name
            Console.WriteLine("Enter the employee last name: ");
            // wait for user input
            lastName = Console.ReadLine();
            // prompt for employee Salary
            Console.WriteLine("Please enter employee annual salary:");
            // wait for user input
            annualSalary = Convert.ToDecimal(Console.ReadLine());
            // prompt for employee gender
            Console.WriteLine("Please enter employee gender; (f) for female, (m) for male!");
            // wait for user input
            gender = Convert.ToChar(Console.ReadLine());
            // prompt to see if employee is a manager or not(true/false)
            Console.WriteLine("Is the employee a manager?, please reply in this format only:(true/false)");
            isManager = Convert.ToBoolean(Console.ReadLine());
            // prep the planned concatened text as above by declaring a string variable: genderTerm
            string genderTerm = (gender == 'f') ? "female" : "male";
            // make the narrative more managable
            string managerNarrative = (isManager) ? "is part of management team!" : "is currently not part of the management!";
            // Set the variable for the narrative
            string narrative = $"Employee with an Id of: {employeeiD}!{Environment.NewLine}";
            narrative += $"Who's full name is: {firstName} {lastName}!{Environment.NewLine}";
            narrative += $"{firstName}, is a {genderTerm} gender employee, and his a {managerNarrative}{Environment.NewLine}";
            narrative += $"this employee currently earns a annual salary of {annualSalary} pounds!";
            // Clear the console
            Console.Clear();
            // display the text
            Console.WriteLine(narrative);
            Console.ReadKey();
            //Continue here on: https://youtu.be/sW-fsSJaFA0?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=1345
        }
    }
}
