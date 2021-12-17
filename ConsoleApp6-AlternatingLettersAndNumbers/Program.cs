using System;

namespace ConsoleApp6_AlternatingLettersAndNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string of letters and numbers.");
            string userInput = Console.ReadLine();

            //Function that makes a string out of the letters
            string letterString = MakeLetterString(userInput);
            //Function that makes a string out of the numbers
            string numberString = MakeNumberString(userInput);
            //Function that mixes the letter and number strings
            MakeMixedString(letterString, numberString);
        }

        private static string MakeLetterString(string userInput)
        {
            string letterString = "";

            foreach (char c in userInput)
            {
                if (Char.IsLetter(c))
                {
                    letterString = letterString + c;
                }
            }

            Console.WriteLine($"You input the letters: {letterString}");
            return letterString;
        }

        private static string MakeNumberString(string userInput)
        {
            string numberString = "";

            foreach (char c in userInput)
            {
                if (Char.IsNumber(c))
                {
                    numberString = numberString + c;
                }
            }

            Console.WriteLine($"You input the numbers: {numberString}");
            return numberString;
        }

        private static string MakeMixedString(string letterString, string numberString)
        {
            string mixedString = "";
            if (letterString.Length - numberString.Length == 0)
            {
                Console.WriteLine("Do you prefer a number first (type \"n\") or a letter first (type \"l\")?");
                string numOrLet = Console.ReadLine();

                if (numOrLet == "n")
                {
                    for (int i = 0; i < numberString.Length; i++)
                    {
                        mixedString = mixedString + numberString[i] + letterString[i];
                    }
                }

                else if (numOrLet == "l")
                {
                    for (int i = 0; i < letterString.Length; i++)
                    {
                        mixedString = mixedString + letterString[i] + numberString[i];
                    }
                }
            }
            else if (letterString.Length - numberString.Length == 1)
            {
                for (int i = 0; i < letterString.Length - 1; i++)
                {
                    mixedString = mixedString + letterString[i] + numberString[i];
                }

                mixedString = mixedString + letterString[letterString.Length - 1];
            }
            else if (numberString.Length - letterString.Length == 1)
            {
                for (int i = 0; i < numberString.Length - 1; i++)
                {
                    mixedString = mixedString + numberString[i] + letterString[i];
                }

                mixedString = mixedString + numberString[numberString.Length - 1];
            }
            else
            {
                Console.WriteLine($"These amounts of letters and numbers cannot be alternated: {mixedString}.\n" +
                                  $"Try entering an equal amount of letters and numbers or a difference of only 1 or 2.");
            }

            Console.WriteLine(mixedString);
            return mixedString;
        }
    }
}