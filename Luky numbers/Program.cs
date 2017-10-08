using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luky_numbers
{
    class Program
    {
        private static string playagain;

        static void Main(string[] args)
        {

            do
            {
                int userLowNum = 0;
                int userHighNum = 0;







                Console.WriteLine("what would you like your low number to be in number range");
                userLowNum = int.Parse(Console.ReadLine());

                Console.WriteLine("what would you like your high number to be in number range");
                userHighNum = int.Parse(Console.ReadLine());






                int[] userNumbers = new int[6];
                Console.WriteLine("pick 6 numbers with in the two numbers you chose,\n that you think will be generated in Lucky Number generator");
                //taking users input and storing it in array

                for (int i = 0; i < 6; i++)
                {


                    userNumbers[i] = int.Parse(Console.ReadLine());
                    //this is here incase user is outside of range
                    while (userNumbers[i] < userLowNum || userNumbers[i] > userHighNum)
                    {
                        Console.WriteLine("please pick again");
                        Console.WriteLine("pick a number in range of the two you picked!");
                        userNumbers[i] = int.Parse(Console.ReadLine());
                    }

                }





                decimal  correct = 0;
                Random luckyNumber = new Random();
                int[] luckyData = new int[6];
                for (int number = 0; number < 6; number++)
                {


                    int randomNumber = luckyNumber.Next(userLowNum, userHighNum);
                    luckyData[number] = randomNumber;
                    Console.WriteLine("Lucky Numbers :" + randomNumber);
                        
                    
                }
                foreach (int i in userNumbers)
                {
                    foreach (int a in luckyData)
                    {
                        if (i == a)
                        {
                            correct++;
                        }
                    }

                }


                decimal jackpot = 48000.00m;



                Console.WriteLine("you have " + correct);
               
                decimal winnings = (correct/6) * jackpot;
                Console.WriteLine("Your prize winnings are $" + winnings);
                Console.WriteLine("play Again");
                playagain = Console.ReadLine();

            } while (playagain == "yes");

            Console.WriteLine("Thanks for plaing!");



        }

        }

    }


