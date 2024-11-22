using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FP
{
    internal class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () =>
        {
            return new List<string>() {"rich.neat@boardgamer.com", "poppy.mcdonnell@irishdancer.com", "neil.hughes@walkingoncustard.com", "alice.yang@midfielder.com", "pippa.austin@musician.com" };
        };
        public static Action<string> GetUsername = username =>
        {
            Console.WriteLine(username.Split('@')[0]);
        };

        public static Action<List<string>> PrintCoolPeople = coolPeople =>
        {
            coolPeople.ForEach(Console.WriteLine);
        };

        public static Action<List<int>> SquaredNums = numbers =>
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= numbers[i];
            }
        };

        public static Action<List<int>> PrintNums = numbers =>
        {
            numbers.ForEach(Console.WriteLine);
        };

        public static Action<List<int>> PrintSquaredNums = numbers =>
        {
            SquaredNums(numbers);
            PrintNums(numbers);
        };




        public static Dictionary<string, List<string>> FilterEmails(List<string> inputList)
        {
            Predicate<string> dotCoDotUkChecker = input => Regex.IsMatch(input, @"\.co\.uk$");
            Predicate<string> dotComChecker = input => Regex.IsMatch(input, @"\.com$");

            var dict = new Dictionary<string, List<string>> {
            { ".co.uk", inputList.Where(email => dotCoDotUkChecker(email)).ToList() },
            { ".com", inputList.Where(email => dotComChecker(email)).ToList() },
            { "invalid", inputList.Where(email => !(dotCoDotUkChecker(email)) && !(dotComChecker(email)) ).ToList() } };

            return dict;


            //Filter the list of strings for .com, .uk, invalid etc, save to list - regex matching
            //

            // dictionary has fixed keys, make them with constructor. 
            // Dictionary would have fixed values, but Lists are mutable
            //Therefore, we build the dictionary with Key1 : new List, Key2: new List, Key3: List 
            // quicker way is .add {}
            //dict.Key(".com").V.add()

        }
    }
}
