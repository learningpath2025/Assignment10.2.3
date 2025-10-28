namespace Assignment10._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>{ "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.WriteLine("The cities are :");
            list.ForEach(city => Console.Write($"{city}, "));
            Console.WriteLine();

            var result = from city in list
                         where city.StartsWith('A') && city.EndsWith('M')
                         select city;

            Console.WriteLine($"\nThe cities that start with 'A' and end with 'M' are :");
            result.ToList().ForEach(city => Console.Write($"{city} "));
            Console.ReadLine();
        }
    }
}
