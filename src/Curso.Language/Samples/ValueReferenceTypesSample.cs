using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class ValueReferenceTypesSample : AbstractSample
    {
        public override void PrintContent()
        {
            ShowValueTypeSample();
            Console.WriteLine();
            ShowReferenceTypeSample();
            Console.WriteLine();
        }

        private static void ShowValueTypeSample()
        {
            int a = 10;

            //Por ser um value type, o valor é copiado entre as duas variáveis
            int b = a;

            b = 30;

            Console.WriteLine($"Value Types");
            Console.WriteLine($"a = {a} / b = {b}");
        }

        private static void ShowReferenceTypeSample()
        {
            MyClass a = new MyClass() { Value = 10 };

            //A referência "b" no STACK passa a apontar para o conteúdo de "a" no HEAP, ou seja, serão mantidas duas referências para o mesmo conteúdo.
            MyClass b = a;

            b.Value = 30;

            Console.WriteLine($"Reference Types");
            Console.WriteLine($"a = {a.Value} / b = {b.Value}");
        }

        public class MyClass
        {
            public int Value { get; set; }
        }
    }
}
