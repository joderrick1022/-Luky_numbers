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

                //asking user for numbers neede for game.
                Console.WriteLine(" \t \t \t welcome to lucky numbers!!");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(" \t What would you like your low number to be in number range");
                userLowNum = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("\t What would you like your high number to be in number range");
                userHighNum = int.Parse(Console.ReadLine());
                Console.WriteLine(  );
                Console.WriteLine();

                int[] userNumbers = new int[6];
                Console.WriteLine("\t pick 6 numbers with in (" + userLowNum + ", " + userHighNum + ") \n that you think will be generated in Lucky Number generator");
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

                float  correct = 0;
                Random luckyNumber = new Random();
                int[] luckyData = new int[6];
                for (int number = 0; number < 6; number++)
                {
                    

                    int randomNumber = luckyNumber.Next(userLowNum, userHighNum);
                    luckyData[number] = randomNumber;
                    Console.WriteLine("Lucky Numbers :" + randomNumber);
                }
                foreach (int i in userNumbers)//comparing user picks to random picks
                {
                    foreach (int a in luckyData)
                    {
                        if (i == a)
                        {
                            correct++;
                        }
                    }

                }


                float jackpot = 48000.00f;
                Console.WriteLine();
                Console.WriteLine();



                Console.WriteLine(" \t you have " + correct + " corrext.");
                Console.WriteLine();
                Console.WriteLine();

                 float winnings = (correct/6f) * jackpot;
                Console.WriteLine(" \t Your prize winnings are $" + winnings);
                Console.WriteLine(" \t play Again");
                playagain = Console.ReadLine().Trim().ToLower();

            } while (playagain == "yes");

            Console.WriteLine(" \t \t Thanks for plaing!");// this was the way the directions wanted me to end it



        }

        }

    }


