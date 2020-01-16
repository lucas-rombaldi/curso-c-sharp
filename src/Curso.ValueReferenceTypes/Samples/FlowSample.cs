using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class FlowControlSample : AbstractSample
    {
        public override void PrintContent()
        {
            IfSample(25);
            SwitchCaseSample(10);
            ForSample();
            ForEachSample();
            WhileSample();
            NullableSample();

            Console.ReadKey();
        }

        private static void NullableSample()
        {
            //int notAllowedNullable = null;
            int? allowedNullable = null;

            int resultado = allowedNullable ?? 0;
        }

        private static void WhileSample()
        {
            int cont = 1;
            while (cont <= 10)
            {
                Console.WriteLine($"Loop while cont = {cont}");
                cont++;
            }
        }

        private static void ForEachSample()
        {
            var objList = new string[2] { "A", "B" };
            foreach (var obj in objList)
            {
                Console.WriteLine($"Loop obj = {obj}");
            }
        }

        private static void ForSample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Loop i = {i}");
            }
        }

        private static void SwitchCaseSample(int checkValue)
        {
            switch (checkValue)
            {
                case 10:
                    Console.WriteLine("Case 10");
                    break;
                case 20:
                    Console.WriteLine("Case 20");
                    break;
                default:
                    break;
            }
        }

        private static void IfSample(int checkValue)
        {
            if (checkValue > 20)
            {
                Console.WriteLine("O valor é maior que 20.");
            }
            else if (checkValue > 30)
            {
                Console.WriteLine("O valor é maior que 30.");
            }
            else
            {
                Console.WriteLine("Outro valor.");
            }

            bool IsPositive = checkValue > 0;
            var negativeValue = checkValue <= 0 ?
                checkValue : checkValue * -1;
        }
    }    
}
