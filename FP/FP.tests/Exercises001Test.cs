using FluentAssertions;

namespace FP.Tests
{
    public class Exercises001Test
    {

        [Test]
        public void SquareItTest()
        {
            int input = 3;
            int expected = 9;

            int result = Exercises001.SquareIt(input);

            result.Should().Be(expected);
        }

        [Test]
        public void AddOneTest()
        {
            int input = 3;
            int expected = 4;

            int result = Exercises001.AddOne(input);

            result.Should().Be(expected);
        }

        [Test]
        public void Add10()
        {
            int input = 3;
            int expected = 13;

            int result = Exercises001.AddTen(input);

            result.Should().Be(expected);
        }


        [Test]
        public void GrammarCheckTest()
        {
            string input = "Amamazinfaasfjasbf!";
            bool expected = true;

            bool result = Exercises001.GrammarCheck(input);

            result.Should().Be(expected);
        }

        [Test]
        public void SumIndicesTest()
        {
            string input1 = "start";
            string input2 = "pale";
            int expected = 5;

            int result = Exercises001.SumIndices(input1,input2);

            result.Should().Be(expected);
        }

        [Test]
        public void CheckValidEmailTest()
        {
            string input1 = "lithuania@northcoders.co.uk";
            string expected = "Email domain and user valid, please continue";

            string result = Exercises001.CheckValidEmail(input1);

            result.Should().Be(expected);
        }
    }
}