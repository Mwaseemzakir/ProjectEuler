using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solution.Problem11_20
{
    public static class Problem17
    {
        public static void Solution()
        {
            string sentence = "";
            for (int i = 1; i < 1001; i++)
            {
                sentence = sentence + GetLetterOfNumber(i);
            }
            Console.WriteLine("Max Length : " + sentence.Length);
        }

        public static string GetLetterOfNumber(int input)
        {
            if (input >= 1 && input < 20)
            {
                return GetLetter(input); // 1-9 Solved
            }
            else if (input >= 10 && input < 100)
            {
                string let = GetLetter(10 * (int)(input / 10)); // 10-99 Solved
                int remainder = input % 10;
                if (remainder != 0)
                {
                    let = let + GetLetter(remainder);
                }
                return let;
            }
            else if (input >= 100 && input < 1000)
            {
                string let = GetLetter(((int)input / 100)) + "hundred"; //101 - 999
                int firstremainder = input % 100;
                if (firstremainder != 0)
                {
                    let = let + "and";
                    if (firstremainder >= 1 && firstremainder < 20)
                    {
                        let = let + GetLetter(firstremainder);
                    }
                    else
                    {
                        let = let + GetLetter(10 * (int)(firstremainder / 10));
                        int secondRemainder = input % 10;
                        if (secondRemainder != 0)
                        {
                            let = let + GetLetter(secondRemainder);
                        }
                    }

                }
                return let;
            }
            else if (input == 1000)
            {
                string let = GetLetter(input);
                return let;
            }
            return "";
        }
        public static string GetLetter(int input)
        {
            if (input >= 1 && input < 20)
            {
                switch (input)
                {
                    case 1: return "one";
                    case 2: return "two";
                    case 3: return "three";
                    case 4: return "four";
                    case 5: return "five";
                    case 6: return "six";
                    case 7: return "seven";
                    case 8: return "eight";
                    case 9: return "nine";
                    case 10: return "ten";
                    case 11: return "eleven";
                    case 12: return "twelve";
                    case 13: return "thirteen";
                    case 14: return "fourteen";
                    case 15: return "fifteen";
                    case 16: return "sixteen";
                    case 17: return "seventeen";
                    case 18: return "eighteen";
                    case 19: return "nineteen";
                }
            }
            else if (input >= 20 && input < 100)
            {
                switch (input)
                {
                    case 10: return "ten";
                    case 20: return "twenty";
                    case 30: return "thirty";
                    case 40: return "forty";
                    case 50: return "fifty";
                    case 60: return "sixty";
                    case 70: return "seventy";
                    case 80: return "eighty";
                    case 90: return "ninety";
                }
            }
            else if (input == 1000)
            {
                return "onethousand";
            }
            return "";
        }
    }
}
