Console.WriteLine("Enter sentence");

string sentence = Console.ReadLine();

string[] words;

if (sentence != null)
{ 
    words = sentence.Split(' ');

    var numbers = words
    .Select(x => x).ToList()
    .Where(x => int.TryParse(x, out int n) == true)
    .Select(x => int.Parse(x))
    .Select(x => Math.Pow(x, 2))
    .OrderByDescending(x => x);
    PrintCollection(numbers);
}
else
{
    Console.WriteLine("You did not enter a sentence. Try again");
}

void PrintCollection(IEnumerable<double> doubles)
{
    foreach (var i in doubles)
    { 
        Console.WriteLine(i);
    }
}