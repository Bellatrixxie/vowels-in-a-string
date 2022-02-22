using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace VowelsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountVowels(string localString)
            {
                int count = 0;
                Regex reg = new Regex("[aeiou]");
                for (int i = 0; i < localString.Length; i++)
                {
                    string letter = localString[i].ToString();
                    if (reg.IsMatch(letter))
                    {
                        count++;
                    }
                }
                return count;
            }
            Console.WriteLine(CountVowels("aeiou"));
        }
    }
}
