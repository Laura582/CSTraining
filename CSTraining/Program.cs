namespace CSTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose operation: + - * /");
            string chosenOperator = Console.ReadLine();
            if (chosenOperator == "+"
                   || chosenOperator == "-"
                   || chosenOperator == "*"
                   || chosenOperator == "/")
            {
                Console.WriteLine("Enter first number");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int number2 = Convert.ToInt32(Console.ReadLine());

                string result = Calculator(number1, number2, chosenOperator);
                Console.WriteLine("Answer is " + result);
            }
            else
            {
                Console.WriteLine("WTF. Try again");
            }

        }
        public static string Calculator (int number1, int number2, string chosenOperator)
        {
            return chosenOperator switch
            {
                "+" => Convert.ToString(number1 + number2),
                "-" => Convert.ToString(number1 - number2),
                "*" => Convert.ToString(number1 * number2),
                "/" => Convert.ToString(number1 / number2),
                _ => "WTF. Try again",
            };
        }
    }
}