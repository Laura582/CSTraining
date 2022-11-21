using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTraining
{
    public class Operator
    {
        private bool isOperator;

            public Operator(string initialValue)
        {
            if (initialValue == null)
                isOperator = false;

            else if
                (initialValue == "+"
                  || initialValue == "-"
                  || initialValue == "*"
                  || initialValue == "/")
            { isOperator = true; }

            else
                isOperator = false;
        }


        public bool GetIsOperator()
        {
            return isOperator;
        }
    }
}
