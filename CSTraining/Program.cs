using CSTraining;

string chosenValue = "";

List<float> numbers = new List<float>();
List<string> operators = new List<string>();
//Enter values and Operators like this:
//1
//+
//1
//=
Console.WriteLine("Calculator");
Console.WriteLine("To calculate result, enter =");


while (chosenValue != "=")
{
    chosenValue = Console.ReadLine();


    if (float.TryParse(chosenValue, out var number))
    {
        numbers.Add(number);
    }
    else
    {
        Operator isOperator = new Operator(chosenValue);

        if (isOperator.GetIsOperator() == true)
            operators.Add(chosenValue);

        else
            break;
    }
}

Console.WriteLine(Calculation.ResultCalculation(numbers.Count, numbers, operators));