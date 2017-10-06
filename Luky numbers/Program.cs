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
            //Console.WriteLine("what would you like your low number to be in number range");
            //int userLowNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("what would you like your high number to be in number range");
            //int userHighNum = int.Parse(Console.ReadLine());

            Console.WriteLine("guess the 6 numbers you thinks will be the lucky numbers generated within the number range you chose.");
            int[] userNumbers = new int[6];
            for(int i = 0; i < userNumbers.Length; i++)
            {
                

                int six = int.Parse(Console.ReadLine());
                userNumbers[i] = six;

            }

            //Random rand = new Random();
            //int randNum = rand.Next(userLowNum, userHighNum);


            //int generatedNum = randNum;
            //int shuffle = generatedNum;
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(generatedNum);
            //}





            //Console.WriteLine("what would you like your low number to be in number range");
            //int userLowNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("what would you like your high number to be in number range");
            //int userHighNum = int.Parse(Console.ReadLine());


            //Random rand = new Random();
            //int randNum = rand.Next(userLowNum, userHighNum);


            //int generatedNum = randNum;
            //int shuffle = generatedNum;
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(generatedNum);
            //}





            //lucky_Numbers[0] = generatedNum;
            //lucky_Numbers[1] = generatedNum;
            //lucky_Numbers[2] = generatedNum;
            //lucky_Numbers[3] = generatedNum;
            //lucky_Numbers[4] = generatedNum;
            //lucky_Numbers[5] = generatedNum;

            //for (int i = 0; i < lucky_Numbers.Length; i++)
            //{
            //    Console.WriteLine(lucky_Numbers[i]);
            //}

            //for (int i = 0; i < 7; i++) 
            //{
            //    Console.WriteLine(lucky_Numbers[i]);
            //}

            //Random rand = new Random();
            //for (int number = 1; number <= 6; number++)
            //{
            //    int randomNumber = rand.Next(49) + 1;
            //    Console.Write("{0} ", randomNumber);






            //this is example of random number
            //int[] lucky_Numbers = new int[6];

            //Random rand = new Random();
            //for (int number = 0; number < 6; number++)
            //{
            //     lucky_Numbers[number] = rand.Next(userLowNum, userHighNum) ;
            //    Console.WriteLine("{0} ", lucky_Numbers[number]);

               

            }

        }

    }


