using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTraining
{
    public class Devide
    {
        private bool isNumberZero = true;

        public Devide(float number)
        {
            if (number != 0)
                
                isNumberZero = false;

        }
        public bool GetIsNumberZero()
            { return isNumberZero; }


        public static float DevideNumbers(float number1, float number2)
        {
            return number1 / number2;
        }
    }
}
