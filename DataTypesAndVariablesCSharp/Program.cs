using System;

namespace DataTypesAndVariablesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            part1();

            part2();

        }

        static void part1()
        {
            //part1.1
            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;
            // Print variables to the console
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);

            //part 1.2
            double number = 38498.3222;

            string dinosaur = "Barney";

            double locks = 293.000;

            bool isyes = true;

            string band = "The Low Anthem";

            //part 1.3
            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");

            // Turn that answer into an int

            // Attempt 1: use implicit conversion
            // int faveNumber = Console.ReadLine();

            // Attempt 2: use explicit conversion
            // int faveNumber = (int)Console.ReadLine();

            // Attempt 3: use Convert method
            int faveNumber = Convert.ToInt32(Console.ReadLine());
        }

        static void part2()
        {
            //part 2.1
            // Calculating Net Income 
            double revenue = 853023.45;
            double expenses = 438374.11;
            double netIncome = revenue - expenses;

            Console.WriteLine(netIncome);

            // Calculating a Break-Even Point
            double fixedCosts = 912849.30;
            double salesPrice = 29.99;
            double variableCostPerUnit = 17.65;

            double breakEvenVolume = fixedCosts / (salesPrice - variableCostPerUnit);
            Console.WriteLine(breakEvenVolume);

            //part 2.2
            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            decimal revenue2 = 390819.28m;

            // Log the values to the console:
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue2);

            //part 2.3
            // Your Age
            int userAge = 17;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

            //part 2.4
            // declare steps variable
            int steps = 0;

            // Two steps forward 
            steps += 2;

            // One step back 
            steps -= 1;

            // Print result to the console
            Console.WriteLine(steps);

            //part 2.5
            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;

            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);

            //part 2.6
            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

            //part 2.7
            double numberOne2 = 6.5;
            double numberTwo2 = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne2, numberTwo2));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne2));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne2, numberTwo2));
        }

        static void part3()
        {
            tring drink = "wine";
            string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" said the March Hare.";

            int storyLength = madTeaParty.Length;
            string toFind = "March Hare";

            string findLowerCase = toFind.ToLower();
            int findMarchHare = madTeaParty.IndexOf(toFind);

            Console.WriteLine(madTeaParty.Substring(findMarchHare));
            Console.WriteLine($"This scene is {storyLength} long.\n");
            Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}.");
        }



    }
}
