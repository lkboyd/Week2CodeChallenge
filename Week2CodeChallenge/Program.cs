using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }

            string inString = "I love biscuits and gravy. It’s the best breakfast ever.";
            char letter = 'i';
            LetterCounter(letter, inString);
            

            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");

            Console.ReadKey();

        }

        public static string FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }

            else if (number % 5 == 0)
            {
                return "Fizz";
            }
            else if (number % 3 == 0)
            {
                return "Buzz";
            }
            return number.ToString();

        }



        public static void LetterCounter(char letter, string inString)
        {
            int numberOfUppercase = 0;
            int numberOfLowercase = 0;
            int numberOfTotalLetter = 0;

            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == letter.ToString().ToUpper())
                {
                    numberOfUppercase++;
                }
                if (inString[i].ToString() == letter.ToString().ToLower())
                {
                    numberOfLowercase++;
                }

            }

            numberOfTotalLetter = numberOfUppercase + numberOfLowercase;
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of UPPERCASE "+ letter + "'s found: " + numberOfUppercase);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + numberOfLowercase);
            Console.WriteLine("Total Number of " + letter + "'s found: " + numberOfTotalLetter );
        }

    }

}

