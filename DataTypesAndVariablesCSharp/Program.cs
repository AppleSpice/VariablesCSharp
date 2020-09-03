using System;

namespace DataTypesAndVariablesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            part1();

            part2();

            part3();
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
            //part3.1
            string drink = "wine";
            string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" said the March Hare.";

            int storyLength = madTeaParty.Length;
            string toFind = "March Hare";

            string findLowerCase = toFind.ToLower();
            int findMarchHare = madTeaParty.IndexOf(toFind);

            Console.WriteLine(madTeaParty.Substring(findMarchHare));
            Console.WriteLine($"This scene is {storyLength} long.\n");
            Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}.");

            //part3.2
            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
            // Second string variable
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

            // Print variable and newline
            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine(firstSpeech);

            //part3.3
            //Declare the variables
            string beginning = "howdy";
            string middle = "Yall";
            string end = "lol";

            // Concatenate the string and the variables
            string story = beginning + middle + end;

            // Print the story to the console 
            Console.WriteLine(story);

            //part3.4
            // Declare the variables
            string beginning2 = "Once upon a time,";
            string middle2 = "The kid climbed a tree";
            string end2 = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story2 = $"{beginning2}{middle2}{end2}";

            // Print the story to the console 
            Console.WriteLine(story2);

            //part3.5
            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;

            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");

            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

            //part3.6
            // User Name
            string name = "Farhad Hesam Abbasi";

            // Get first letter
            int charPosition = name.IndexOf("F");
            char firstLetter = name[charPosition];

            // Get last name
            int charPosition2 = name.IndexOf("Abbasi");
            string lastName = name.Substring(charPosition2);

            // Print results
            Console.WriteLine($"{firstLetter} {lastName}");

            //part3.7
            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition3 = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition3, length);

            // Get scene description
            charPosition3 = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition3);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine($"{cameraDirections} {sceneDescription}");

            //test
        }



    }
}
