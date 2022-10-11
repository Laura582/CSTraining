Console.WriteLine("Choose operation: + - * /");
string chosenOperator = Console.ReadLine();
Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter first number");
int number2 = Convert.ToInt32(Console.ReadLine());

int answer;

switch(chosenOperator)
{
    case "+":
        answer = number1 + number2;
        Console.WriteLine("Answer is "+ answer);
        break;
    case "-":
        answer = number1 - number2;
        Console.WriteLine("Answer is " + answer);
        break;
    case "*":
        answer = number1 * number2;
        Console.WriteLine("Answer is " + answer);
        break;
    case "/":
        answer = number1 / number2;
        Console.WriteLine("Answer is " + answer);
        break;
    default:
        Console.WriteLine("WTF. Try again");
        break;
}