using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        /// <summary>
        /// Taking my functions and calling them using specified parameters
        /// </summary>
        /// <param name="args">defined in the assignemnt</param>
        public static void Main(string[] args)
        {
            //for loop for number 1-20
            for (int i = 0; i <= 20; i++)
            {
                //writing it to the console
                Console.WriteLine(FizzBuzz(i));
            }
            //way #1 to call the funtion and input the specified parameters
            string inString = "I love biscuits and gravy. It’s the best breakfast ever.";
            char letter = 'i';
            LetterCounter(letter, inString);
            
            //way #2 to call the function and input the specific parameters
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");

            Console.ReadKey();

        }


        /// <summary>
        /// FizzBuzz Program, taking any number and seeing if it is equally divisable by 3 and 5
        /// </summary>
        /// <param name="number">any number</param>
        /// <returns>Fizz, FizzBuzz, or Buzz</returns>
        public static string FizzBuzz(int number)
        {
           //if statement to compare the int number to the % of 5 and 3
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            //if the first one is not met then it continues to the next part of the function % 5
            else if (number % 5 == 0)
            {
                return "Fizz";
            }
            //if the last else if was not met then if continues to the next part of the function % 3
            else if (number % 3 == 0)
            {
                return "Buzz";
            }
            //if the number does not meet any of the parameters of the if statemnt it prints the number
            return number.ToString();

        }


        /// <summary>
        /// LetterCounter takes any string and compares it a specific letter.  Gives input as to the 
        /// times it is in UpperCase, LowerCase, and how many times the letter appears Total. 
        /// </summary>
        /// <param name="letter">any letter</param>
        /// <param name="inString">any string</param>
        public static void LetterCounter(char letter, string inString)
        {

            //defining my int's to hold my counts
            int numberOfUppercase = 0;
            int numberOfLowercase = 0;
            int numberOfTotalLetter = 0;

            //for loop to go through the entire string letter by letter to compare to char letter
            for (int i = 0; i < inString.Length; i++)
            {
                //taking my string and the varriable i (that I have to make a string to compare) and seeing if it 
                //matches the letter in uppercase form
                if (inString[i].ToString() == letter.ToString().ToUpper())
                {
                    //counting the number of times it is
                    numberOfUppercase++;
                }
                //taking the same string and comapring toLower
                if (inString[i].ToString() == letter.ToString().ToLower())
                {
                    //counting the number of times
                    numberOfLowercase++;
                }

            }

            //taking hte total number of upper and lower will give me the total of times it shows up
            numberOfTotalLetter = numberOfUppercase + numberOfLowercase;

            //writing to the console when it is called in the main function 
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of UPPERCASE "+ letter + "'s found: " + numberOfUppercase);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + numberOfLowercase);
            Console.WriteLine("Total Number of " + letter + "'s found: " + numberOfTotalLetter );
        }

    }

}

