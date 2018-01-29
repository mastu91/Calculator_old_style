using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_old_style
{
    class CalculatorService
    {
        private string sign;
        private string valueOne;

        public CalculatorService()
        {

        }

        public void SetOperator(string output, string sign)
        {
            this.sign = sign;
            valueOne = output;
        }

        public string Equalisation(string output)
        {
            double numOne = Convert.ToDouble(valueOne);
            double numTwo = Convert.ToDouble(output);
            switch (sign)
            {
                case "+":
                    output = (numOne + numTwo).ToString();
                    break;
                case "-":
                    output = (numOne - numTwo).ToString();
                    break;
                case "*":
                    output = (numOne * numTwo).ToString();
                    break;
                case "/":
                    output = (numOne / numTwo).ToString();
                    break;
            }
            return output;
        }

        public string Reset()
        {
            sign = null;
            valueOne = null;
            return "";
        }

        public string ChangeSign(string tbNumber)
        {
            double num = Convert.ToDouble(tbNumber);
            if(num < 0)
            {
                string[] number = tbNumber.Split('-');
                tbNumber = number[1];
            }
            if(num > 0)
            {
                tbNumber = "-" + Convert.ToString(num);
            }
            return tbNumber;
        }

        public string ResetNumber(string number)
        {
            return number.Substring(0, number.Length - 1);
        }
    }
}
