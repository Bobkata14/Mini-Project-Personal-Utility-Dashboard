using System;
using System.Numerics;

namespace PersonalDashboard
{
    class PersonalUtilityDashboard
    {
        static void Main(string[] args)
        {
            // Personal Utility Dashboard


            // Personal Profile
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your city: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter letter of the group: ");
            char groupLetter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Is a fulltime?: ");
            bool isFullTime = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Favorite technology: ");
            string favoriteTechnology = Console.ReadLine();

            Console.WriteLine(" ");

            // Budget Calculator

            Console.WriteLine("Enter your monthly budget: ");
            decimal monthlyBudget = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter your ragular expenses: ");
            decimal regularExpenses = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter your extra expenses: ");
            decimal extraExpenses = Convert.ToDecimal(Console.ReadLine());

            decimal totalExpenses = regularExpenses;
            totalExpenses += extraExpenses;

            decimal budgetWithBonus = monthlyBudget;
            budgetWithBonus += 100m;

            decimal remainingBudgetWithBonus = 
                budgetWithBonus - totalExpenses;

            bool isBudgetEnough = monthlyBudget >= totalExpenses;
            Console.WriteLine($"Is budget enouht {isBudgetEnough}\n");

            // Advanced Caulculator
            Console.WriteLine("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            bool firstLarger = number1 > number2;
            Console.WriteLine($"Is first number larger? {firstLarger}");

            bool equals = number1 == number2;
            Console.WriteLine($"Is numbers are equals? {equals}");

            bool firstSmaller = number1 <= number2;
            Console.WriteLine($"Is first number is smaller or equal? {firstSmaller}");

            bool isAdultFullTimeStudent = age >= 18 && isFullTime;
            Console.WriteLine($"Adult full-time student: {isAdultFullTimeStudent}");

            int myInt = (int)number1;
            Console.WriteLine(myInt);

            Console.WriteLine(" ");

            //Math Operations

            Console.WriteLine("Enter a circle radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"Area: {Math.Round(area, 2)}");
            Console.WriteLine($"Circumference: {Math.Round(circumference, 2)}\n");

            // Text Analyzer

            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter a word to search: ");
            string searchWord = Console.ReadLine();
            int searchIndex = sentence.IndexOf(searchWord);

            Console.WriteLine("Enter replacement word: ");
            string replacementWord = Console.ReadLine();
            string updateSentence = sentence.Replace(searchWord, replacementWord);

            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.ToUpper());

            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence.Contains("programming"));

            Console.WriteLine(sentence.Trim());

            Console.WriteLine(sentence.Substring(0, 4));
            Console.WriteLine(sentence.StartsWith("I"));
            Console.WriteLine(sentence.EndsWith("."));

            Console.WriteLine(" \n");

            Console.WriteLine("====================================");
            Console.WriteLine("    personal utility dashboard".ToUpper());
            Console.WriteLine("====================================\n");

            Console.WriteLine("--- personal profile ---".ToUpper());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Group: {groupLetter}");
            Console.WriteLine($"Full time student: {isFullTime}");
            Console.WriteLine($"Favorite technology: {favoriteTechnology}\n");
            Console.WriteLine($"Adult full-time student {isAdultFullTimeStudent}");

            Console.WriteLine("--- budget calculator ---".ToUpper());
            Console.WriteLine($"Monthly budget: {monthlyBudget}");
            Console.WriteLine($"Regular expenses: {regularExpenses}");
            Console.WriteLine($"Extra expenses: {extraExpenses}");
            Console.WriteLine($"Total expenses: {totalExpenses}");
            Console.WriteLine($"Remaining budget: {monthlyBudget - totalExpenses}");
            Console.WriteLine($"Budget with bonus: {budgetWithBonus}");
            Console.WriteLine($"Remaining budget with bonus: {remainingBudgetWithBonus}");
            Console.WriteLine($"Is budget enough: {isBudgetEnough}\n");

            Console.WriteLine("--- advanced calculator ---".ToUpper());
            Console.WriteLine($"First number: {number1}");
            Console.WriteLine($"Second number: {number2}");
            Console.WriteLine($"Sum: {number1 + number2}");
            Console.WriteLine($"Difference: {number1 - number2}");
            Console.WriteLine($"Product: {number1 * number2}");
            Console.WriteLine($"Division: {number1 / number2}");
            Console.WriteLine($"Remainder: {number1 % number2}");
            Console.WriteLine($"First number is graeter: {firstLarger}");
            Console.WriteLine($"First number as integer: {myInt}");
            Console.WriteLine($"Numbers are equals: {equals}\n");

            Console.WriteLine($"--- math operations ---".ToUpper());
            Console.WriteLine($"Squre root: {Math.Sqrt(Math.Abs(number1))}");
            Console.WriteLine($"Absolute value: {Math.Abs(number1)}");
            Console.WriteLine($"Round: {Math.Round(number1)}");
            Console.WriteLine($"Ceiling: {Math.Ceiling(number1)}");
            Console.WriteLine($"Floor: {Math.Floor(number1)}");
            Console.WriteLine($"Power of 2: { Math.Pow(number1, 2)}");

            Console.WriteLine($"Maximum: {Math.Max(number1, number2)}");
            Console.WriteLine($"Minimum: {Math.Min(number1, number2)}");

            Console.WriteLine(" ");

            Console.WriteLine("--- circle calculator ---".ToUpper());
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {area, 2}");
            Console.WriteLine($"Circumference: {circumference, 2}\n");

            Console.WriteLine("--- text analyzer ---".ToUpper());
            Console.WriteLine($"Original text: {sentence}");
            Console.WriteLine($"Uppercase: {sentence.ToUpper()}");
            Console.WriteLine($"Lowercase: {sentence.ToLower()}");
            Console.WriteLine($"Trimed text: {sentence.Trim()}");
            Console.WriteLine($"Length: {sentence.Length}");
            Console.WriteLine($"Contains: '{searchWord}' : {sentence.Contains(searchWord)}");
            Console.WriteLine($"Index of: {searchWord} : {searchIndex}");
            Console.WriteLine($"Replace text: {updateSentence}");
            Console.WriteLine($"First 4 characters: {sentence.Substring(0, 4)}\n");

            Console.WriteLine("=============================================");
        }
    }
}