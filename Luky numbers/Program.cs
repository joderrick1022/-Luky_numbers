using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luky_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what would you like your low number to be in number range");
            int userLowNum = int.Parse(Console.ReadLine());

            Console.WriteLine("what would you like your high number to be in number range");
            int userHighNum = int.Parse(Console.ReadLine());

            Console.WriteLine("guess the 6 numbers you thinks will be the lucky numbers generated within the number range you chose.");


            int[] userNumbers = new int[6];
            for (int i = 0; i < userNumbers.Length; i++)
            {


                int six = int.Parse(Console.ReadLine());
                userNumbers[i] = six;


            }


            //double jackpot = 100000000.00;

            Random luckyNumber = new Random();
            int[] luckyData = new int[6];
            for (int number = 0; number < 6; number++)
            {
                
                int randomNumber = luckyNumber.Next(userLowNum,userHighNum);
                luckyData[number] = randomNumber;
                Console.WriteLine("Lucky Numbers :" + randomNumber);

            }














        }

        }

    }


