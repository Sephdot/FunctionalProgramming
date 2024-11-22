namespace FP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            numbers.Select(x => Exercises001.AddTen(x)).ToList().ForEach(Console.WriteLine);

            /*numbers.ForEach(x => Console.WriteLine(Exercises001.AddTen(x)));*/

            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };

            words.ForEach(word => Console.WriteLine(Exercises001.GrammarCheck(word)));
        }
    }
}
