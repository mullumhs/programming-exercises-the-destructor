using System;
using System.Diagnostics.Eventing.Reader;

/*
===============================================================================
PROJECT 09: PICK A DOOR
===============================================================================
Objective:
- Practice using selection statements with multiple conditions to control program flow based on user input.

Main Tasks:
1. Prompt the user to pick a door by entering a number (1, 2, or 3), and store the result in a string variable.
2. Use a selection statement (if...else if...else) to determine and output what is behind each door.
3. Print a warning message if the user picks something other than 1, 2, or 3.
4. Wait for input before ending the program.

Questions:
1. What is the purpose of the final ELSE statement in this program?
2. What is the difference between the = operator and the == operator?

Extension Tasks:
1. Use more else if statements to create more doors.
2. Customise the program to output a personalised message to the user (e.g., including their name).
3. Research online to learn how to generate a random number, and use this number to pick a door for the user.

Example:
- Below is an example of the program's output:

    Pick a Door: 1, 2 or 3
    2
    You win a Car!

Additional Resources:
- Selection Statements: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
- if-else Statement: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
- Random Numbers: https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_09_PickADoor
    {
        static void Main(string[] args)
        {
            // Ask the user to pick a door
            Console.WriteLine("Pick a Door: 1, 2 or 3");


            // Your code goes below here
            int door = Convert.ToInt32(Console.ReadLine());
            if (door == 1 || door == 2 || door == 3)
            {
                Console.WriteLine("Pick a Door: 1, 2 or 3");
                int door2 = Convert.ToInt32(Console.ReadLine());
                if (door2 == 1 || door2 == 2 || door2 == 3)
                {
                    if (door == 1)
                        if (door2 == 1)
                            Console.WriteLine("BAKER");
                    if (door == 1)
                        if (door2 == 2)
                            Console.WriteLine("MEOW MEOW MEOW MEOW MEOW");
                    if (door == 1)
                        if (door2 == 3)
                            Console.WriteLine("Linc's is a cutie patootie.");
                    if (door == 2)
                        if (door2 == 1)
                        {

                            Console.WriteLine("Domain Expansion: Infinite Void");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("");
                            Console.Beep(37, 100);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("");
                            Console.Beep(37, 100);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("");
                            Console.Beep(37, 100);
                            Console.Clear();

                            
                        }


                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("MEOW!");
            }
            Console.ReadLine();
            
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
