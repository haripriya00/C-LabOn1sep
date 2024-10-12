using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment_on_oct1
{
    internal class Program
    {
        static void Main(string[] args)
     // Lab 35: Salary and Tax Calculation
     //Assignment: 
     //Write a program that calculates the tax to be paid based on the annual salary of an employee.The
     //tax rules are as follows: 
     //1. If the salary is less than $10,000, no tax is applied.
     //2. If the salary is between $10,000 and $50,000, a 10% tax is applied.
     //3. If the salary is above $50,000, a 20% tax is applied.
     //4. If the employee is a senior citizen (aged 60 or above), they get an additional tax
     //exemption of $5,000 from their taxable income.
     //5. Your program should
     // Prompt the user to enter their annual salary and age. 
     // Use nested if statements to calculate the appropriate tax based on the salary and age. 
     // Print the tax amount to be paid.

        //{
        //    Console.Write("Enter your annual salary: ");
        //    double salary = double.Parse(Console.ReadLine());

        //    Console.Write("Enter your age: ");
        //    int age = int.Parse(Console.ReadLine());

        //    double taxableIncome = salary;
        //    double tax = 0;
        //    if (age >= 60)
        //    {
        //        taxableIncome -= 5000; 
        //    }

        //    if (taxableIncome < 10000)
        //    {
        //        tax = 0;
        //    }
        //    else if (taxableIncome >= 10000 && taxableIncome <= 50000)
        //    {
        //        tax = taxableIncome * 0.10; 
        //    }
        //    else
        //    {
        //        tax = taxableIncome * 0.20; 
        //    }

        //    Console.WriteLine($"The tax amount to be paid is: ${tax:F2}");
        //}





        // Lab 34: Calculate student grade
        //Assignment: 
        //Write a program that accepts the grades(marks) of a student in three subjects.The program
        //should determine the following: 
        //1. If the student has passed in all subjects (passing mark is 40 in each subject). 
        //2. If the student has passed, check if the average grade is 70 or above.If so, print
        //"Distinction". 
        //3. If the student has not passed in any subject, print the number of subjects failed. 

        //{
        //    Console.Write("Enter the marks for Subject 1: ");
        //    int subject1 = int.Parse(Console.ReadLine());

        //    Console.Write("Enter the marks for Subject 2: ");
        //    int subject2 = int.Parse(Console.ReadLine());

        //    Console.Write("Enter the marks for Subject 3: ");
        //    int subject3 = int.Parse(Console.ReadLine());

        //    int passingMark = 40;
        //    int totalSubjects = 3;
        //    int failedSubjects = 0;

        //    // Check for passed subjects
        //    if (subject1 < passingMark)
        //        failedSubjects++;
        //    if (subject2 < passingMark)
        //        failedSubjects++;
        //    if (subject3 < passingMark)
        //        failedSubjects++;

        //    // Determine if student has passed all subjects
        //    if (failedSubjects == 0)
        //    {
        //        // Calculate average
        //        double average = (subject1 + subject2 + subject3) / (double)totalSubjects;
        //        Console.WriteLine("The student has passed in all subjects.");

        //        // Check for distinction
        //        if (average >= 70)
        //        {
        //            Console.WriteLine("Distinction.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The student has failed in {failedSubjects} subject(s).");
        //    }
        //}





        //  Lab 33: Check whether a number is positive, even and greater than 50 
        //Assignment: 
        //Write a program that checks whether an input number is positive, even, and greater than 50 using 
        //nested if statements.

        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    if (number > 0)
        //    {
        //        if (number % 2 == 0) 
        //        {
        //            if (number > 50) 
        //            {
        //                Console.WriteLine($"{number} is positive, even, and greater than 50.");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{number} is positive and even but not greater than 50.");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{number} is positive but not even.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not positive.");
        //    }
        //}





        //  Lab 32: Check whether a given year is leap year
        //Assignment: 
        //Write a program to check whether a year is a leap year or not using an if-else statement.

        //{
        //    Console.Write("Enter a year: ");
        //    int year = int.Parse(Console.ReadLine());

        //    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //    {
        //        Console.WriteLine($"{year} is a leap year.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{year} is not a leap year.");
        //    }
        //}





        // Lab 31: Check a number is divisible by 3 & 5 
        //Assignment: 
        //Write a program to check whether a number is divisible by both 3 and 5 using an if statement.

        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    if (number % 3 == 0 && number % 5 == 0)
        //    {
        //        Console.WriteLine($"{number} is divisible by both 3 and 5.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not divisible by both 3 and 5.");
        //    }
        //}





        //  Lab 30: Input is within a range
        //Assignment: 
        //Write a program that checks if the input number is within a certain range(e.g., between 1 and
        //100) and also checks if it is even or odd using relational and logical operators.

        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    if (number >= 1 && number <= 100)
        //    {
        //        Console.WriteLine($"{number} is within the range of 1 to 100.");

        //        if (number % 2 == 0)
        //        {
        //            Console.WriteLine($"{number} is even.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{number} is odd.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not within the range of 1 to 100.");
        //    }
        //}





        //   Lab 29: Currency Conversion
        //Assignment: 
        //Write a C# program to convert a given amount of money from USD to another currency (e.g., 
        //EUR). Assume a conversion rate, for example, 1 USD = 0.85 EUR.The program should take the
        //amount in USD as input and display the equivalent amount in EUR.

        //{
        //    const double conversionRate = 0.85; 
        //    Console.Write("Enter the amount in USD: ");
        //    double amountInUSD = double.Parse(Console.ReadLine());

        //    double amountInEUR = amountInUSD * conversionRate;

        //    Console.WriteLine($"{amountInUSD} USD is equivalent to {amountInEUR:F2} EUR.");
        //}





        //  Lab 28: Find the Average of Three Numbers
        //Assignment:
        //Write a C# program that takes three numbers as input from the user and calculates the average of 
        //those numbers.The result should be displayed with two decimal places

        //{
        //    Console.Write("Enter the first number: ");
        //    double num1 = double.Parse(Console.ReadLine());

        //    Console.Write("Enter the second number: ");
        //    double num2 = double.Parse(Console.ReadLine());

        //    Console.Write("Enter the third number: ");
        //    double num3 = double.Parse(Console.ReadLine());

        //    double average = (num1 + num2 + num3) / 3;

        //    Console.WriteLine($"The average of the three numbers is: {average:F2}");
        //}





        //  Lab 27: Arithmetic Operations
        //Assignment: 
        //Write a program that takes two numbers as input and performs all arithmetic operations on them
        //(addition, subtraction, multiplication, division, modulus, increment, and decrement). 

        //{
        //    Console.Write("Enter the first number: ");
        //    int num1 = int.Parse(Console.ReadLine());

        //    Console.Write("Enter the second number: ");
        //    int num2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
        //    Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
        //    Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");

        //    if (num2 != 0)
        //    {
        //        Console.WriteLine($"Division: {num1} / {num2} = {(double)num1 / num2}");
        //        Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Division and modulus by zero are not allowed.");
        //    }

        //    Console.WriteLine($"Increment first number: {num1} + 1 = {++num1}");
        //    Console.WriteLine($"Decrement second number: {num2} - 1 = {--num2}");
        //}





        //   Lab 26: Swap two values
        //Assignment: 
        //Write a program that swaps the values of two variables using a third variable and without using a 
        //third variable.

        //{
        //    int a, b;

        //    Console.Write("Enter the value of a: ");
        //    a = int.Parse(Console.ReadLine());

        //    Console.Write("Enter the value of b: ");
        //    b = int.Parse(Console.ReadLine());

        //    // Swapping without using a third variable
        //    a = a + b;
        //    b = a - b;
        //    a = a - b;

        //    Console.WriteLine($"After swapping (without third variable): a = {a}, b = {b}");
        //}





        //  Lab 25: Grading System
        //Assignment: 
        //Write a C# program that accepts the marks of a student in a subject and assigns a grade based on 
        //the following criteria: 
        //1. If the marks are greater than or equal to 90, the grade is 'A'. 
        //2. If the marks are between 80 and 89, the grade is 'B'. 
        //3. If the marks are between 70 and 79, the grade is 'C'. 
        //4. If the marks are between 60 and 69, the grade is 'D'. 
        //5. If the marks are below 60, the grade is 'F'. 
        //Your program should: 
        //     Prompt the user to enter the marks(out of 100). 
        //     Use nested if statements to determine and print the grade based on the marks entered.

        //{
        //    Console.Write("Enter the marks (out of 100): ");
        //    int marks = int.Parse(Console.ReadLine());

        //    if (marks >= 90)
        //    {
        //        Console.WriteLine("Grade: A");
        //    }
        //    else if (marks >= 80 && marks <= 89)
        //    {
        //        Console.WriteLine("Grade: B");
        //    }
        //    else if (marks >= 70 && marks <= 79)
        //    {
        //        Console.WriteLine("Grade: C");
        //    }
        //    else if (marks >= 60 && marks <= 69)
        //    {
        //        Console.WriteLine("Grade: D");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Grade: F");
        //}
        //}





        //  Lab 24: Simple Calculator
        //Assignment:
        //Write a C# program that takes two numbers and an operator (+, -, *, /) as input, and performs the 
        //corresponding operation.Use an if-else statement to determine which operation to perform
        //{
        //    Console.Write("Enter the first number: ");
        //    double num1 = double.Parse(Console.ReadLine());

        //    Console.Write("Enter the second number: ");
        //    double num2 = double.Parse(Console.ReadLine());

        //    Console.Write("Enter an operator (+, -, *, /): ");
        //    char op = Console.ReadKey().KeyChar;
        //    Console.WriteLine();

        //    if (op == '+')
        //    {
        //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        //    }
        //    else if (op == '-')
        //    {
        //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        //    }
        //    else if (op == '*')
        //    {
        //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        //    }
        //    else if (op == '/')
        //    {
        //        if (num2 != 0)
        //        {
        //            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Division by zero is not allowed.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid operator.");
        //    }
        //}






        //  Lab 23: Check if a Number is Divisible by 5 and 11 
        //Assignment:
        //Write a C# program that checks if a number is divisible by both 5 and 11. 

        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    if (number % 5 == 0 && number % 11 == 0)
        //    {
        //        Console.WriteLine("The number is divisible by both 5 and 11.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number is not divisible by both 5 and 11.");
        //    }
        //}





        // Lab 22: Check If a Number is Positive, Negative, or Zero
        //Assignment:
        //Write a C# program that takes a number as input and checks whether the number is positive, 
        //negative, or zero using relational and logical operators.


        //{
        //    Console.Write("Enter a number: ");
        //    double number = double.Parse(Console.ReadLine());

        //    if (number > 0)
        //    {
        //        Console.WriteLine("The number is positive.");
        //    }
        //    else if (number < 0)
        //    {
        //        Console.WriteLine("The number is negative.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number is zero.");
        //    }
        //}





        //Lab 21: Check if a Character is a Vowel or Consonant
        //Assignment:
        //Write a C# program that takes a character as input and checks if the character is a vowel or 
        //consonant using relational and logical operators.

        //{
        //    Console.Write("Enter a character: ");
        //    char ch = char.ToLower(Console.ReadKey().KeyChar);
        //    Console.WriteLine();

        //    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        //    {
        //        Console.WriteLine($"{ch} is a vowel.");
        //    }
        //    else if ((ch >= 'a' && ch <= 'z'))
        //    {
        //        Console.WriteLine($"{ch} is a consonant.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{ch} is not a valid letter.");
        // }
        //}





        //Lab 20: Eligibility Check
        //Assignment: 
        //Write a C# program that checks whether a person is eligible to apply for a job based on the 
        //following criteria: 
        //1. The person must be between 18 and 35 years old.
        //2. The person must have at least 2 years of work experience. 
        //3. The person must either have a college degree or 5 years of work experience. 
        //Your program should: 
        // Prompt the user to enter their age, work experience (in years), and whether they have a
        //college degree(yes/no). 
        // Use relational operators(>, <, >=, <=, ==) and logical operators(&&, ||) to evaluate
        //these conditions.
        // Print whether the person is eligible to apply for the job or not. 

        //{
        //    Console.Write("Enter your age: ");
        //    int age = int.Parse(Console.ReadLine());

        //    Console.Write("Enter your work experience (in years): ");
        //    int experience = int.Parse(Console.ReadLine());

        //    Console.Write("Do you have a college degree? (yes/no): ");
        //    string hasDegree = Console.ReadLine().ToLower();

        //    if (age >= 18 && age <= 35 && experience >= 2 && (hasDegree == "yes" || experience >= 5))
        //    {
        //        Console.WriteLine("You are eligible to apply for the job.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You are not eligible to apply for the job.");
        //    }
        //}





        //Lab 19: Determine if a Person is Eligible for a Loan
        // Assignment:
        // Write a C# program to check if a person is eligible for a loan. The eligibility criteria are: 
        // The person must be at least 21 years old.
        // The person must earn at least $30,000 per year. 
        // The person must not have any outstanding loans. 
        //The program should take the age, income, and loan status (yes/no) as input.

        //    {
        //        Console.Write("Enter your age: ");
        //    int age = int.Parse(Console.ReadLine());
        //    Console.Write("Enter your annual income (in dollars): ");
        //    double income = double.Parse(Console.ReadLine());
        //    Console.Write("Do you have any outstanding loans? (yes/no): ");
        //    string hasOutstandingLoan = Console.ReadLine().ToLower();
        //    if (age >= 21 && income >= 30000 && hasOutstandingLoan == "no")
        //    {
        //        Console.WriteLine("You are eligible for a loan.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You are not eligible for a loan.");
        //}
        //}





        //   Lab 18: Check Voting Eligibility
        //   Assignment:

        //   Write a C# program that checks if a person is eligible to vote. The eligibility criteria are: 
        // The person must be at least 18 years old.
        // The person must be a citizen. 

        //   The program should take the age and citizenship status as input from the user. 
        //       {
        //           Console.Write("Enter your age: ");
        //           int age = int.Parse(Console.ReadLine());
        //           Console.Write("Are you a citizen? (yes/no): ");
        //           string isCitizen = Console.ReadLine().ToLower();
        //           if (age >= 18 && isCitizen == "yes")
        //           {
        //               Console.WriteLine("You are eligible to vote.");
        //           }
        //           else
        //           {
        //               Console.WriteLine("You are not eligible to vote.");
        //           }
        //}





        // Lab 17: Find the Power of a Number
        //Assignment: 
        //Write a C# program that calculates the power of a number using the Math.Pow() method. The 
        //program should take the base and exponent as input from the user.

        //        {
        //        Console.WriteLine("Enter the base number:");
        //     double baseNumber = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Enter the exponent:");
        //     double exponent = Convert.ToDouble(Console.ReadLine());
        //        double result = Math.Pow(baseNumber, exponent);
        //        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");
        //     Console.ReadLine();

        //}




        //  Lab 16: Assignment Operator
        //   Assignment: 
        //   Write a program demonstrating the use of the assignment operator = to assign values to variables.

        //       {
        //        int a = 5;
        //   Console.WriteLine("The value of a is: " + a);
        //Console.ReadLine();

        // }




    //Lab 15: C# Coding Standards 
        //Assignment: 
        //Refactor a provided C# program to follow proper coding standards (naming conventions, 
        //comments, etc.). 
        //Provided Code: 
        //class program
               // {
                 //static void main()
                 //{
                       // int num1 = 5;
                        //int num2 = 3;
                       // Console.WriteLine(num1 + num2);
                 //}
              //}

        //{
        //    Console.WriteLine("Enter the first number:");
        //    int number1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the second number:");
        //    int number2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("The sum is: " + (number1 + number2));
        //    Console.ReadLine();
        //}





        //Lab 14: C# Coding Standards 
        //Assignment: 
        //Write a simple C# program to accept an employee’s name, age and monthly salary and display 
        //them on the screen.The code should be written following the coding standards, including proper
        //naming conventions, indentation, comments, and meaningful variable names. 
        //{
        //    string employeeName;
        //    int employeeAge;
        //    decimal monthlySalary;
        //    Console.WriteLine("Enter Employee Name:");
        //    employeeName = Console.ReadLine();
        //    Console.WriteLine("Enter Employee Age:");
        //    employeeAge = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Employee Monthly Salary:");
        //    monthlySalary = Convert.ToDecimal(Console.ReadLine());
        //    Console.WriteLine("\n--- Employee Details ---");
        //    Console.WriteLine("Name: " + employeeName);
        //    Console.WriteLine("Age: " + employeeAge);
        //    Console.WriteLine("Monthly Salary: $" + monthlySalary);
        //    Console.ReadLine();

        //}





        // Lab 13: Calculating Area of Rectangle
        //Assignment
        //Declare two variables width and height for the dimensions of a rectangle.Calculate the area
        //using the formula Area = width * height.Use constants to define conversion factors, for 
        //example, inches to centimeters.Print the area in both square inches and square centimeters.

        //{
        //    Console.WriteLine("Enter the length of the rectangle: ");
        //    double length = Double.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the breadth of the rectangle: ");
        //    double breadth = Double.Parse(Console.ReadLine());
        //    double arearectangle = length * breadth;
        //    double areaininches = arearectangle * 39.3701;
        //    double areaincentimetres = arearectangle * 100;
        //    Console.WriteLine("Area in Inches: " + areaininches);
        //    Console.WriteLine("Area in Centimeters: " + areaincentimetres);
        //    Console.ReadLine();
        //}




        //Lab 12: Using Constants
        //Assignment
        // Declare two constants: const double PI = 3.14159; and const int DAYS_IN_WEEK = 7.Write a
        //program that calculates the circumference of a circle using the formula C = 2 * PI * radius.Print
        //the result along with the number of days in a week.
        //{
        //    const double PI = 3.14159;
        //    const int DAYS_IN_WEEK = 7;
        //    Console.Write("Enter the radius of the circle: ");
        //    double radius = Convert.ToDouble(Console.ReadLine());
        //    double circumference = 2 * PI * radius;
        //    Console.WriteLine("The circumference of the circle is: " + circumference);
        //    Console.WriteLine("Number of days in a week: " + DAYS_IN_WEEK);
        //    Console.ReadLine();
        //}




        //Lab 11: Variables and Constants
        //Assignment: 
        // Write a program to calculate the area of a circle and a rectangle using variables and constants.
        // Prompt the user to input values
        //{

        //    Console.WriteLine("Enter the radius of the circle: ");
        //    int radius = Convert.ToInt32(Console.ReadLine());
        //    const double pivalue = 3.14159;
        //    double areacircle, arearectangle;
        //    areacircle = radius * radius * pivalue;
        //    Console.WriteLine("Area of the circle is " + areacircle);
        //    Console.WriteLine("Enter the lenght of the rectangle: ");
        //    int length = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the breadth of the rectangle: ");
        //    int breadth = Convert.ToInt32(Console.ReadLine());
        //    arearectangle = length * breadth;
        //    Console.WriteLine("Area of the rectangle is " + arearectangle);
        //    Console.ReadLine();
        //}




        //Lab 10: Variables and Constants
        //Assignment:
        //Declare variables of the following types: int, float, double, char, string, and bool. Initialize each variable with a value.
        // Print the values of each variable along with its type using  Console.WriteLine(). 
        //{
        //    int a = 5;
        //    float b = 6.8f;
        //    double c = 4.90;
        //    char d = 'c';
        //    string e = " hai";
        //    bool f = true;
        //    Console.WriteLine(a + " is an integer ");
        //    Console.WriteLine(b + " is floating value");
        //    Console.WriteLine(c + " is a double value ");
        //    Console.WriteLine(d + " is a character");
        //    Console.WriteLine(e + " is a  string");
        //    Console.WriteLine(f + " is a boolean value");
        //    Console.ReadLine();

        //}




        //Lab 9: Body Mass Index(BMI) Calculator
        //Assignment: 
        //Write a program to calculate BMI using the formula: 
        //BMI = weight / (height* height) where weight is in kilograms and height is in meters.Declare variables weight and height, then calculate and print the BMI.

        //{
        //    double weight, height;
        //    Console.WriteLine("Enter the weight: ");
        //    weight = Double.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the height: ");
        //    height = Double.Parse(Console.ReadLine());
        //    double temp = height * height;
        //    double bmi = temp / weight;
        //    Console.WriteLine(" BMI is " + bmi);
        //    Console.ReadLine();
        //}




        //Lab 8: String Length and Character Count
        //Assignment: 
        //Write a program that takes a string as input and prints the number of characters in the string, excluding spaces.

        //{
        //    Console.WriteLine("Enter the string: ");
        //    string input = Console.ReadLine();
        //    string secinput = input.Replace(" ", "");
        //    int length = secinput.Length;
        //    Console.WriteLine(" length is " + length);
        //    Console.ReadLine();

        //}





        //Lab 7: Input/output with Time Calculation
        //Assignment: 
        //Write a program that asks the user to input a number of seconds and converts it into hours, minutes, and seconds.
        //{
        //    Console.WriteLine("Enter the number of seconds: ");
        //    int totalSeconds = Convert.ToInt32(Console.ReadLine());
        //    int hours = totalSeconds / 3600;
        //    int minutes = (totalSeconds % 3600) / 60;
        //    int seconds = totalSeconds % 60;
        //    Console.WriteLine("Time is: {0} hours, {1} minutes, {2} seconds", hours, minutes, seconds);
        //    Console.ReadLine();

        //}




        //Lab 6: Calculating the Area of a Circle
        //Assignment: 
        //Write a program that takes the radius of a circle as input and calculates its area using the 
        //formula: Area=π* r * r Where r is the radius, and π is approximately 3.14159. 
        //{
        //    Console.WriteLine("Enter the radius");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    const double q = 3.14159;
        //    double area;
        //    area = a * a * q;
        //    Console.WriteLine("radius " + area);
        //    Console.ReadLine();
        //}





        // Lab 5: Simple Interest Calculation
        //Assignment: 
        // Write a program that calculates the simple interest using the formula: Simple Interest = (P * R * T) / 100, 
        //Where P is the principal amount, R is the rate of interest, and T is the time in years.
        //{
        //    Console.WriteLine("Enter the pricopal amount");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the rate");
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the time");
        //    int c = Convert.ToInt32(Console.ReadLine());
        //    int i = (a * b * c) / 100;
        //    Console.WriteLine("simple interest is " + i);
        //    Console.ReadLine();

        //}




        //Lab 4: Temperature Conversion
        //Assignment: 
        //1. Write a program that takes a temperature in Celsius from the user and converts it to Fahrenheit.
        //2. The formula is: Fahrenheit= (Celsius× 9/5) + 32. 
        //{
        //    Console.WriteLine("Enter the temperature in Celsius:");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    int b = ((a * 9) / 5) + 32; // Removed the extra closing parenthesis
        //    Console.WriteLine("The temperature in Fahrenheit is " + b);
        //    Console.ReadLine();
        //}




        //Lab 3: Input/output with Arithmetic Operations
        //Assignment: 
        //1. Write a program that asks the user to input two numbers and prints the result of their sum,
        ///difference, multiplication, and division.
        // 2. Modify the program to display a message if the division by zero is attempted.
        //{
        //    Console.WriteLine("enter the numbers");
        //    float a = Convert.ToInt32(Console.ReadLine());
        //    float b = Convert.ToInt32(Console.ReadLine());
        //    float mul = a * b;
        //    float add = a + b;
        //    float sub = a - b;
        //    float div = 0;
        //    if (b != 0)
        //    {
        //        div = a / b;
        //        Console.WriteLine("Division is " + div);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Division by zero is not allowed.");
        //    }
        //    Console.WriteLine("sum is " + add + ", difference is " + sub + ", product is " + mul);
        //    Console.ReadLine();
        // }



        // Lab 2: Input/output with Strings
        //  Assignment: 
        //1. Write a program that asks the user for their full name and age, then prints a message like 
        //"Hello, [Name]! You are [Age] years old.”. 
        //2. Modify the program to ask for the user's favorite color and include it in the greeting.

        //    {
        //        Console.WriteLine("Enter your full name and your age");
        //        string uname = Console.ReadLine();
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Hai  " + uname + " Your age is " + age);
        //        Console.WriteLine("Enter your favourite color");
        //        string color = Console.ReadLine();
        //Console.WriteLine("Hai  " + uname + " Your age is " + age + " Your favourite color is " + color);
        //        Console.ReadLine();
        //    }



        //Lab 1: Hello, World! and Basic Input/output
        //Assignment: 
        // 1. Write a program that prints "Hello, World!" to the screen.
        //2. Modify the program to ask the user for their name and greet them with a personalized message.

        //{
        //    Console.WriteLine("Enter your name");
        //    string uname = Console.ReadLine();
        //    Console.WriteLine("Hai  " + uname);
        //    Console.ReadLine();
        //}
    }
}
