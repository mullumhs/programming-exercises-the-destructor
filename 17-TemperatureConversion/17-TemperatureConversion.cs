using System;
using System.Runtime.Remoting.Services;
using System.Xml.Serialization;

/*
===============================================================================
PROJECT 17: TEMPERATURE CONVERSION
===============================================================================
Objective:
- Utilise functions to create a program that converts temperatures between Celsius and Fahrenheit based on user input.

Example Output:
- This is how your program should behave:

    What would you like to do?
    1. Celsius to Fahrenheit
    2. Fahrenheit to Celsius
    1
    Enter temperature in Celsius: 0
    That is 32 Fahrenheit

Pseudocode:
    BEGIN Main
        choice = MainMenu()
        IF choice = 1 THEN
            result = CelsiusToFahrenheit()
            PRINT result
        ELSE IF choice = 2 THEN
            result = FahrenheitToCelsius()
            PRINT result
        ELSE
            PRINT "Invalid Choice!"
        END IF
    END Main

    BEGIN CelsiusToFahrenheit
        c = GetTemperature("Celsius")
        f = (c * 9/5) + 32
        RETURN f
    END CelsiusToFahrenheit 

    BEGIN FahrenheitToCelsius
        f = GetTemperature("Fahrenheit")
        c = (f - 32) * 5/9
        RETURN c
    END FahrenheitToCelsius

    BEGIN GetTemperature(unit)
        PRINT "Enter temperature in " + unit
        INPUT temp
        RETURN temp
    END GetTemperature

Main Tasks:
1. Write a function to convert Celsius to Fahrenheit.
2. Write a function to convert Fahrenheit to Celsius.
3. Implement a menu for the user to choose which conversion they want to perform.
4. Display the result of the conversion based on the user's choice.

Questions:
1. What did you find challenging about implementing an entire program yourself?

Extension Tasks:
1. Add an option in the menu for the user to exit the program.
2. Enhance the program to handle invalid input gracefully without crashing.
3. Research and implement a function to convert temperature to and from Kelvin.
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_17_TemperatureConversion
    {
        static void Main(string[] args)
        {
            // Write your code here
            question();
            string Choice = Console.ReadLine();
            if (Choice == "1")
            {
                Choice1();
            }
            else if (Choice == "2")
            {
                Choice2();
            }
            else
            {
                Console.WriteLine("Nice one bud");
            }
            Exit();
        }

        // functions
        static void question()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" What would you like to do?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.WriteLine();
        }
        static double CtoF(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static double FtoC(double f)
        {
            return (f - 32) * 5 / 9;
        }
        static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to exit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        static void Choice1()
        {
            Console.WriteLine("Enter temperature in Celsius");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{CtoF(c)} degrees Fahrenheit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        static void Choice2()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter temperature in Fahrenheit");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{FtoC(f)} degrees Celsius");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
