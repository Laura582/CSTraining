namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");

            string sentence = Console.ReadLine();

            string[] words;

            if (sentence != null)
            {
                words = sentence.Split(' ');


                 PrintCollection(LinqLibrary.LinqLibraries.CalculateNumbers(words));
            }
            else
            {
                 Console.WriteLine("You did not enter a sentence. Try again");
            }
        }

        static void PrintCollection(IEnumerable<double> doubles)
        {
            foreach (var i in doubles)
            {
                Console.WriteLine(i);
            }
        }
    }
}
