using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTraining
{
    public class Calculation
    {
        public static float ResultCalculation(int countLenth, List<float> numbers, List<string> operators)
        {
            float result = numbers[0];

            for (int i = 0; i < countLenth - 1; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        result = Add.AddNumbers(result, numbers[i + 1]);
                        break;
                    case "-":
                        result = Subtract.SubtractNumbers(result, numbers[i + 1]);
                        break;
                    case "/":
                        Devide devide = new Devide(numbers[i + 1]);
                        if (devide.GetIsNumberZero() == false)
                        {
                            result = Devide.DevideNumbers(result, numbers[i + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                            result = 0;
                            break;
                        }
                        break;
                    case "*":
                        result = Multiply.MultiplyNumbers(result, numbers[i + 1]);
                        break;
                    default:
                        Console.WriteLine("Selected operator does not exist");
                        break;
                }
            }
            return result;
        }
    }
}
