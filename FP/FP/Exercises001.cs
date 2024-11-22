﻿using System;
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
    }
}
