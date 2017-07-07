using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1
            //DONE = Ask the user for a starting number for the lowest number in the number range.
            //DONE = Ask the user for an ending number for the highest number in the number range.
            //DONE = Ask the user to guess the 6 numbers the user thinks will be the lucky numbers generated within the number range.
            //DONE = --Numbers must be stored in an array
            //DONE = --Array must be populated using a loop
            //DONE = If the user enters a number that is outside of the range set, prompt the user to give you a valid number. 
            //DONE = Do this until the user enters a valid number.
            Console.WriteLine("Thank your for playing Lucky Numbers!! \n");
            Console.WriteLine("You need to enter two numbers to get started! \n");
            Console.WriteLine("Enter your lowest number (must be a whole number) for the number generator: \n");
            int startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your highest number (must be a whole number) for the number generator: \n");
            int endNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Now you will be prompted to enter your picks of six numbers between the numbers you just entered.\n");
            Console.WriteLine("Your first number: ");
            Console.ReadLine();
            Console.WriteLine("Your second number: ");
            Console.ReadLine();
            Console.WriteLine("Your third number: ");
            Console.ReadLine();
            Console.WriteLine("Your fourth number: ");
            Console.ReadLine();
            Console.WriteLine("Your fifth number: ");
            Console.ReadLine();
            Console.WriteLine("Your sixth number: ");
            Console.ReadLine();

            int[] userNums = new int[6];
            for(int i = 0; i < 7; i++)
            {
                userNums[i] = int.Parse(Console.ReadLine());
            }     

            for (int i = 0; i >= startNum && i <= endNum; i++)
            {
                continue;
            }
            else
            {
                Console.WriteLine("I'm sorry. Please provide a valid whole number: ");
            }



            //Random luckyNum = new Random();
            //Console.WriteLine([luckyNum.Next(startNum, endNum + 1)]);

            //PART 2
            //The program should randomly generate 6 numbers using a loop
            //The randomly generated numbers should be stored in an array
            //Numbers should be displayed to the console as such and using a loop 
            //DONE = (Numbers below are for example only. Format must be exact):
            //DONE = Lucky Number: 12
            //DONE = Lucky Number: 47
            //DONE = Lucky Number: 28
            //DONE = Lucky Number: 3
            //DONE = Lucky Number: 19
            //DONE = Lucky Number: 35

            int[] randomNums = new int[6];
            for (int i = 0; i < 7; i++)
            {
                Random ranGenNums = new Random{ };
                int randomNumbers = ranGenNums.Next(1,7);


            }

            Random luckyNumOne = new Random();
            Console.WriteLine("Lucky Number: " + luckyNumOne);
            Random luckyNumTwo = new Random();
            Console.WriteLine("Lucky Number: " + luckyNumTwo);
            Random luckyNumThree = new Random();
            Console.WriteLine("Lucky Number: " + luckyNumThree);
            Random luckyNumFour = new Random();
            Console.WriteLine("Lucky Number: " + luckyNumFour);
            Random luckyNumFive = new Random();
            Console.WriteLine("Lucky Number: " + luckyNumFive);
            Random luckyNumSix = new Random();
            Console.WriteLine("Lucky Number: " + luckyNumSix);




            //PART 3
            //DONE = Hard-code a value for the jackpot amount 
            //DONE = and let the user know what the jackpot amount is at some point you decide in the program.
            //The program should count the number of correctly guessed numbers and output to the console to notify the user. 
            //Example: You guessed 3 numbers correctly!
            //The program should calculate the user's winnings based on the number of numbers guessed correctly.
            //The user's winnings should be output to the console.
            //Example: You won $256,877.23!
            
            Console.WriteLine("By playing Lucky Numbers, you have a chance to win $3,000,000.00!");

            int luckyNumMatches; //this will be the number of guesses that match the random numbers
            int userWinnings; //this calculates the winngs by jackpot/luckyNumMatches 

            Console.WriteLine("Congratulations! You guessed " + luckyNumMatches + " numbers correctly.");
            Console.WriteLine("You won " + userWinnings);




            //PART4
            //DONE = Ask the user if the user would like to play again.
            //DONE = If the user says yes, then the program should run again from the beginning.
            //DONE = If the user says no, then the program should say "Thanks for playing!" (Must be exact statement).
            Console.WriteLine("Would you like to play again? YES/NO");
            do
            {
                //Console.WriteLine("Would you like to play again? YES/NO");
                string playAgain = Console.ReadLine();
                if (playAgain == "NO")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
                else
                {
                    continue;
                }
            } while (true);

            //STRETCH
            //Make your program ensure none of the generated numbers are repeated. 
            //If there is a repeated number, replace it with a new number. Do this until there are no repeated numbers.
            







        }
    }
}
