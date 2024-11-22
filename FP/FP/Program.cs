namespace FP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            numbers.Select(x => Exercises001.AddTen(x)).ToList().ForEach(Console.WriteLine);

            numbers.ForEach(x => Console.WriteLine(Exercises001.AddTen(x)));

            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };

            words.ForEach(word => Console.WriteLine(Exercises001.GrammarCheck(word)));

            Console.WriteLine(Exercises001.SumIndices("start", "pale"));
            Console.WriteLine(Exercises001.CheckValidEmail("david@northcoders.co.uk"));

            Exercises002.GetCoolPeople().ForEach(Exercises002.GetUsername);

            Exercises002.PrintCoolPeople(Exercises002.GetCoolPeople());

            List<int> numList = new List<int> { 5, 8, 3, 6, 67 };
            Exercises002.PrintSquaredNums(numList);*/

            List<string> emailList = new List<string>
            {
                "alice.yang@northcoders.com",
                "richard.neat@northcoders.com",
                "mario@plumbing.it",
                "link@hyrule.co.uk",
                "shrek@duloc.com",
                "neil.hughes@walkingoncustard.com",
                "csharp@microsoft.cs",
                "ziggy@spidersfrommars.co.uk",
                "lemmy@motorhead.co,uk",
                "me@myhouse.sleep"
            };

            var filteredEmails = Exercises002.FilterEmails(emailList);

            foreach (var item in filteredEmails)
            {
                Console.WriteLine(item.Key);
                item.Value.ForEach(Console.WriteLine);
            }
        }
    }
}
