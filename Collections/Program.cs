Console.WriteLine("Enter sentence");

string sentence = Console.ReadLine();
string sentenceToUpper = sentence.ToUpper();

string[] words = sentenceToUpper.Split(' ');

Dictionary<char, int> wordCounts = new Dictionary<char, int>();

foreach (string word in words)
{
    char[] charArr = word.ToCharArray();

    if (!wordCounts.ContainsKey(charArr[0]))
    {
        wordCounts[charArr[0]] = 0;
    }
    wordCounts[charArr[0]]++;
}


foreach (KeyValuePair<char,int> item in wordCounts.OrderBy(x => x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
