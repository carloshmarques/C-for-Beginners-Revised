using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StudentApplication
{
    public class Student
    {
        int _stuId = 0;
        string _firstName = String.Empty;
        string _lastName = String.Empty;
        decimal _loanAmount = 0;
        char _gender = '\0';
        bool _isNew = false;

        // Constructor
        public Student(int stuId, string firstName, string lastName, decimal loanAmount, char gender, bool isNew)
        {
            
            // Property assignments go here:
            /// <INT32>
            /*
             * This integer data type is a 32 bit data type
             *  it is a signed data type which means it supports both positive and negative values
             *  This data type supports a range from; 
             *  -21487483648 to 2147483647
             * 
             *  The integer data type has an unsigned counter part named
             *  uInt(Unsigned);
             *  Unsigned means it only supports positive values.
             *   uInt supports a range of positive whole number values between
             *   0 to 4294967295.
             *
             */
            /// </INT32>           
            this._stuId = stuId;
            /// <String>
            /// .- String:
            /// .- Internally a string object stores a read-only sequence char objects.
            /// .- The data stored for a string object is immutable.
            /// .- A string is a reference type.
            /// </String>          
            this._firstName = firstName;
            this._lastName = lastName;
            /// <DECIMAL>
            /// A decimal is a precise fractional integral type that can represent
            /// decimal numbers with 29 significant digits.
            ///     It differs from the float and double data types because it
            /// supports less range but a much higher precision which makes the data type
            /// preferable for financial and monetary calculations.
            ///     The 'float' and 'double' are faster than the 'decimal'.
            ///     The 'Float'(Single data type) supports 32 bits of data.
            ///     The 'Double' data  type supports double the amount of bits(i.e. 64 bits of data).
            ///     The decimal supports 128 bits of data.
            ///     The decimal data type is a value type.
            /// </DECIMAL>
            this._loanAmount = loanAmount;

            /// <CHAR>
            ///  
            ///     The Char data type is a 16 bit unicode data type.
            ///     TIt supports character encodings i.e values that represent characters.
            ///     The char is a value type. 
            /// </CHAR>
            this._gender = gender;

            /// <Boolean>
            ///     The Boolean data type supports one of two values;
            ///     .- True
            ///     .- False
            /// 
            /// </Boolean>
            /// 
            this._isNew = isNew;

            _stuId = stuId;
            _firstName = firstName;
            _lastName = lastName;
            _loanAmount = loanAmount;
            _gender = gender;
            _isNew = isNew;
        }
        public void UpdateLoanAmount(decimal loanAmount)
        {
            // UpdateLoanAmount Method 
            // Updates _loanAmount member variables
            _loanAmount = loanAmount;
            /*
             * This method will be used to demonstrate the fundamental difference
             * between value types and reference types
             * */
        }
        public string StudentData()
        {

            string studentData = $"stuId:  {_stuId}, firstName: {_firstName}, loan Amount: {_loanAmount}";
            return studentData;
            //  StudentData Method: Returns student data as text
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {   // 
            /*
             * This application will simply accept input from the user
             * which will be stored in an object created from the 'student class';
             * Student 'student' = new Student(stuId, firstName, lastName, loanAmount, gender, isNew);
             * Student 'studentCopy = student' 
             * Student 'UpdateLoanAmount(20000)'
             * 
             *  and then initialize an new student object called 'studentCopy',
             *  to the student object that store's the student data,
             *  then using the update loan amount method to update the student object
             *  with the new loan amount, and then see if this action as affected
             *  the studentCopy object.
             *  
             */
            // Placeholder for future code
            int stuId = 0;
            string firstName = string.Empty;
            string lastName = string.Empty;
            decimal loanAmount = 0;
            char gender = '\0';
            bool isNew = false;
            Console.WriteLine("Please enter the student Id");

            stuId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the student's first name");

            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the student's last name");

            lastName = Console.ReadLine();

            Console.WriteLine("Please enter the student's loan amount");

            loanAmount = Decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

            /*
             * Using Regex for Flexible Input
             * Regular expressions to detect more complex patterns in the input. 
             * For example, you might want to match words that sound like "male" or "female" even with minor typos.
             */

            Console.WriteLine("Please enter the student's gender  ('f' = female, 'm' = male)");

            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The student is new (true/false)");

            isNew = Convert.ToBoolean(Console.ReadLine());

            Student student = new Student(stuId, firstName, lastName, loanAmount, gender, isNew);

            Console.Clear();

            Student studentCopy = student;

            if (Object.ReferenceEquals(student, studentCopy))
            {
                Console.WriteLine("Both student and studentCopy refer to the same object.");
            }
            else
            {
                Console.WriteLine("student and studentCopy are different objects.");
            }


            Console.WriteLine("Student data  " + student.StudentData());

            Console.WriteLine();

            Console.WriteLine("Student copy data  " + studentCopy.StudentData());

            Console.WriteLine();

            Console.WriteLine("Please update the student's loan amount");

            student.UpdateLoanAmount(Convert.ToDecimal(Console.ReadLine()));

            string dividerText = "After loan update";

            Console.WriteLine(new String('-', dividerText.Length));

            Console.WriteLine(dividerText);

            Console.WriteLine(new String('-', dividerText.Length));

            Console.WriteLine("Student data  " + student.StudentData());

            Console.WriteLine();

            Console.WriteLine("Student copy data  " + studentCopy.StudentData());

            Console.ReadKey();

            // link: https://youtu.be/rM9HostBLJ4?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=926



        }
    }
}
