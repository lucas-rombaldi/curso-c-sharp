using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class MethodParametersSample : AbstractSample
    {
        public override void PrintContent()
        {
            Calculate(10, 20, out int result);
            Console.WriteLine($"OUT PARAMETER: Ao somar 10 com 20, o resultado é {result}");

            int result2 = 0;
            CalculateRef(10, 20, ref result2);
            Console.WriteLine($"REF PARAMETER: Ao somar 10 com 20, o resultado é {result2}");

            int result3 = 0;
            CalculateWithoutRefOrOut(10, 20, result3);
            Console.WriteLine($"COMMOM PARAMETER: Ao somar 10 com 20, o resultado é {result3}");
        }

        private void Calculate(int a, int b, out int result)
        {
            result = a + b;
        }

        private void CalculateRef(int a, int b, ref int result)
        {
            result = a + b;
        }

        private void CalculateWithoutRefOrOut(int a, int b, int result)
        {
            result = a + b;
        }
    }
}
