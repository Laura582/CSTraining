Console.WriteLine("Enter sentence");

string sentence = Console.ReadLine();

string[] words;

if (sentence != null)
{ 
    words = sentence.Split(' ');

    var numbers = words
        .Where(x => int.TryParse(x, out int n))
        .Select(x => Math.Pow(int.Parse(x), 2))
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