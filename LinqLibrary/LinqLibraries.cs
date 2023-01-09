namespace LinqLibrary
{
    public class LinqLibraries
    {
        public static IOrderedEnumerable<double> CalculateNumbers(string[] sentence)
        {
            var calculatedNumbers = sentence
                .Where(x => int.TryParse(x, out int n))
                .Select(x => Math.Pow(int.Parse(x), 2))
                .OrderByDescending(x => x);

            return calculatedNumbers;
        }
    }
}