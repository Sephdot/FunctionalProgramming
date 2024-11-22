using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FP
{
    internal class Exercises001
    {
        public static Func<int, int> AddOne = num => num + 1;

        public static Func<int, int> SquareIt = num => num * num;

        public static Func<int, int> AddTen = num => num + 10;

        public static Predicate<string> GrammarCheck =
            input =>
            {
                return Regex.IsMatch(input, @"^A.*!$");
            };

        public static Func<string, string, int> SumIndices = (string1, string2) =>
        string1.IndexOf('a')
        + string2.IndexOf('e');


        public static string CheckValidEmail(string input)
        {
            Predicate<string> domainChecker = input => Regex.IsMatch(input, @"@northcoders\.co\.uk$");
            Predicate<string> userNameChecker = input => Regex.IsMatch(input, @"\w{5,}@");
            if (domainChecker(input) && userNameChecker(input))
            {
                return "Email domain and user valid, please continue";
            }
            else
            {
                return "Email domain and user name invalid, please check your input";
            }
        }

        
    }
}
