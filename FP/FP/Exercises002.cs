using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
