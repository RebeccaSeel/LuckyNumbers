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
            string playAgain;
            do
            {
            Console.WriteLine("Thank your for playing Lucky Numbers!! \n");
            Console.WriteLine("By playing Lucky Numbers, you have a chance to win $3,000,000.00! \n");
            
            Console.WriteLine("You need to enter two numbers to get started! \n");
            //following is "a" in range (a,b)
            Console.WriteLine("Enter your lowest number (must be a whole number) for the number generator: \n");
            int startNum = int.Parse(Console.ReadLine()); 
            Console.WriteLine("");
            //following is "b" in range (a,b)
            Console.WriteLine("Enter your highest number (must be a whole number) for the number generator: \n");
            int endNum = int.Parse(Console.ReadLine()); 
            Console.WriteLine("");
            Console.WriteLine("Now enter your six Lucky Numbers which must be between these two numbers. \n");

            //get six numbers from user and check for validity (i.e number is within their range)
            
            int i;
            int[] userNumbers = new int[6];
                     
            for (i = 0; i < userNumbers.Length; i++)
            {
                Console.Write("Enter your number: \n");
                userNumbers[i] = int.Parse(Console.ReadLine());
                while (userNumbers[i] < startNum || userNumbers[i] > endNum)
                {
                    Console.WriteLine("Not a valid number within the range you set. Enter another number.");
                    userNumbers[i] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("");
            
            //PART 2
            //randomly generate 6 numbers using a loop and store in an array, display to console

            Console.WriteLine("Now let's get your randomly generated numbers for comparison. \n");

            Random luckyNum = new Random();
            int[] randomNums = new int[6];
       
            for (i = 0; i < 6; i++)
            {
                randomNums[i] = luckyNum.Next(startNum, endNum + 1);
            }

            foreach (int j in randomNums)
            {
                Console.WriteLine("Lucky Number:{0}", j);
            }
            Console.WriteLine("");
           
            //PART 3
            //identify the jackpot number and let the user know what it is as well as their earnings based
            //on the number of matches between their numbers and the randomly generated numbers

            int jackpot = 3000000; 
            int totalMatches = 0; 
           
            foreach (int k in userNumbers)
            {
                if (k == randomNums[0] || k == randomNums[1] || k == randomNums[2] || k == randomNums[3] || k == randomNums[4] || k == randomNums[5])
                {
                    totalMatches++;
                }
            }
            Console.WriteLine("You guessed " + totalMatches + " numbers correctly.");
            int totalWinnings = jackpot / totalMatches;
            Console.WriteLine("You won $" + totalWinnings);

            //PART4
            //ask user if they want to play again, continue if yes, stop if no
            Console.WriteLine("Would you like to play again? YES/NO");
            //do
            //{
                playAgain = Console.ReadLine();
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
