using System.Numerics;

namespace ServiceForCalculator.Classes
{
    public class CalcService: ICalcService
    {
        //чи потрібен конструктор?
        //чи треба оголошувати зміні в класі?

        //double? firstNumber;
        //double? secondNumber;
        //double result = 0;

        public double? Multiplay(double? number1, double? number2)
        {
            if (number1 == null || number2 == null)
            {
                return null; //???що тут правильно прописати?
            }

            return (number1.Value * number2.Value);
        }

        public double? Divide(double? aaa, double? bbb)
        {

            if (aaa == null || bbb == null || bbb == 0)
            {
                return null;
            }
            return (aaa.Value / bbb.Value);
        }

        public double? Plus(double? number1, double? number2)
        {
            if (number1 == null || number2 == null)
            {
                return null;
            }

            return (number1.Value + number2.Value);
        }

        public double? Subtract(double? number1, double? number2)
        {
            if (number1 == null || number2 == null)
            {
                return null;
            }

            return (number1.Value - number2.Value);
        }

    }
}
