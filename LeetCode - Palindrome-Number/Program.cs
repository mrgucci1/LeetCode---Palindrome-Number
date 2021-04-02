using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Palindrome_Number
{
    class Program
    {
        //https://leetcode.com/problems/palindrome-number/
        static void Main(string[] args)
        {
            int x = 1534236469;
            bool solution = checkPalindrome(x);
            Console.WriteLine(solution);
            Console.ReadKey();
        }
        static public bool checkPalindrome(int x)
        {
            if (x > Int32.MinValue && x < Int32.MaxValue)
            {
                string output = "";
                //if negative, remove and add negative sign to output
                if (x.ToString().Contains("-"))
                {
                    x = Convert.ToInt32(x.ToString().Replace("-", ""));
                    output = "-";
                }
                //convert to char array
                char[] charArr = x.ToString().ToCharArray();
                //for loop that counts backwords, reversing int
                for (int i = charArr.Length - 1; i >= 0; i--)
                {
                    output += charArr[i];
                }
                if (x.ToString() == output)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
