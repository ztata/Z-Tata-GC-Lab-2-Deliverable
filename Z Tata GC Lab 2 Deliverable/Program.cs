using System;

namespace Z_Tata_GC_Lab_2_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Grand Circus room detail generator!");

            //will repeat the game based on user input 
            bool repeatGame = true;
            do
            {
                //gets user units
                Console.WriteLine("Please enter the units of measurement you would like to use: ");
                string userUnits = Console.ReadLine();
                
                //gets length of room 
                Console.WriteLine("Please enter a length value for your room:");
                string userInput = Console.ReadLine();
                double roomLength = double.Parse(userInput);

                //gets width of room 
                Console.WriteLine("Please enter a width value for your room:");
                userInput = Console.ReadLine();
                double roomWidth = double.Parse(userInput);

                //gets height of room
                Console.WriteLine("Please enter a height value for your room:");
                userInput = Console.ReadLine();
                double roomHeight = double.Parse(userInput);

                // creates variables for room parameters and performs calculations based on user inputs 
                double roomPerimeter = (roomLength * 2) + (roomWidth * 2);
                double roomArea = roomWidth * roomLength;
                double roomVolume = roomLength * roomHeight * roomWidth;

                //displays perimeter, area, and volume from dimensions specified
                Console.WriteLine($"The perimeter of your room is {roomPerimeter} {userUnits}.");
                Console.WriteLine($"The area of your room is {roomArea} square {userUnits}");
                Console.WriteLine($"The volume of your room is {roomVolume} cubic {userUnits}");

                //asks user if they would like to repeat the app again 
                Console.WriteLine("Would you like to repeat the program? Type yes to repeat or anything else for no.");
                userInput = Console.ReadLine();

                //if else statements either end of continue the loop to repeat the program 
                if (userInput.Trim().ToLower() == "yes")
                {
                    repeatGame = true;
                }

                else
                {
                    repeatGame = false;
                }

            } while (repeatGame == true);

            Console.WriteLine("Thank you! Please press any key to exit.");
            Console.ReadKey();

        }
    }
}
