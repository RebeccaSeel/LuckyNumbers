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
            //explain app to user and get random generator range (a, b) from user
            Console.WriteLine("Thank your for playing Lucky Numbers!! \n");
            Console.WriteLine("By playing Lucky Numbers, you have a chance to win $3,000,000.00! \n");
            
            Console.WriteLine("You need to enter two numbers to get started! \n");
            Console.WriteLine("Enter your lowest number (must be a whole number) for the number generator: \n");
            int startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter your highest number (must be a whole number) for the number generator: \n");
            int endNum = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Your Lucky Numbers must be between these two numbers for you to win. \n");

            //get six numbers from user
            int[] userNumbers = new int[6];
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter your pick of six (whole) numbers between the numbers you just entered.");
            Console.ReadLine();
            do
            {
                if (userNum >= startNum && userNum <= endNum)
                {
                    Console.WriteLine(userNum);
                }
                if (userNum < startNum || userNum > endNum)
                {
                    Console.WriteLine("Not a valid number within the range you set. Enter another number");
                    Console.ReadLine();
                }
            } while (userNum % 2 == 0);


            //int userInput;
            //int[] userNumRange = new int[6];
            //int userNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Now enter your pick of six (whole) numbers between the numbers you just entered.");
            //Console.ReadLine();
            //userNum[0] = int.Parse(Console.ReadLine());
            //userNum[1] = int.Parse(Console.ReadLine());
            //userNum[2] = int.Parse(Console.ReadLine());
            //userNum[3] = int.Parse(Console.ReadLine());
            //userNum[4] = int.Parse(Console.ReadLine());
            //userNum[5] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 7; i++)
            //for (int i = 1; i <= userNum.Length; i++)
            //{
            //    if (i >= startNum && i <= endNum)
            //    {
            //        Console.WriteLine(userNum[i]);
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a valid number within the range you set. Enter another number");
            //        Console.ReadLine();
            //    }
            //}

            //PART 2
            //The program should randomly generate 6 numbers using a loop
            //The randomly generated numbers should be stored in an array
            //Numbers should be displayed to the console as such and using a loop 


            //randomly generate 6 numbers using a loop and store in an array, display to console
            int[] randomNums = new int[6];
            Random luckyNum = new Random();
            Console.WriteLine(luckyNum.Next(startNum, endNum + 1));

            for (int i = 0; i >= startNum && i <= endNum + 1; i++)
            {
                randomNums[i] = luckyNum.Next(startNum, endNum + 1);
            }

            foreach (int j in randomNums)
            {
                Console.WriteLine("Lucky Number:{i}", j);
            }
            Console.Read();

            for (int i = 0; i == randomNums.Length; i++)
            {
                if (userNumbers[i] == randomNums[i])
                {
                    continue;
                }
            }

            //Random luckyNumOne = new Random();
            //Console.WriteLine("Lucky Number: " + luckyNumOne);
            //Random luckyNumTwo = new Random();
            //Console.WriteLine("Lucky Number: " + luckyNumTwo);
            //Random luckyNumThree = new Random();
            //Console.WriteLine("Lucky Number: " + luckyNumThree);
            //Random luckyNumFour = new Random();
            //Console.WriteLine("Lucky Number: " + luckyNumFour);
            //Random luckyNumFive = new Random();
            //Console.WriteLine("Lucky Number: " + luckyNumFive);
            //Random luckyNumSix = new Random();
            //Console.WriteLine("Lucky Number: " + luckyNumSix);

            //PART 3
            //identify the jackpot number and let the user know what it is as well as their earnings based
            //on the number of matches between their numbers and the randomly generated numbers
            
            int jackpot = 3000000; 
            int totalMatches = 0; 
            int totalWinnings = jackpot / totalMatches;

            for (int i = 0; i < randomNums.Length; i++)
            {
                if (userNumbers.Contains(randomNums[i]))
                {
                    totalMatches++;
                }
                Console.WriteLine("Congratulations! You guessed {0}" + totalMatches + " numbers correctly.");
            }

            Console.WriteLine("You won $" + totalWinnings);


            //PART4
            //ask user if they want to play again, continue if yes, stop if no
            Console.WriteLine("Would you like to play again? YES/NO");
            do
            {
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
