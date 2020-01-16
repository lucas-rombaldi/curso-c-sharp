using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class OperatorSample : AbstractSample
    {
        public override void PrintContent()
        {
            var objeto1 = new NormalClass() { MyProperty = 10 };
            var objeto2 = new NormalClass() { MyProperty = 10 };

            if (objeto1 == objeto2)
                Console.WriteLine("OBJETO 1 é igual ao OBJETO 2 (sem OPERATOR)");
            else
                Console.WriteLine("OBJETO 1 é diferente do OBJETO 2 (sem OPERATOR)");

            var objeto1op = new MyOperatorClass() { MyProperty = 10 };
            var objeto2op = new MyOperatorClass() { MyProperty = 10 };

            if (objeto1op == objeto2op)
                Console.WriteLine("OBJETO 1 é igual ao OBJETO 2 (com OPERATOR)");
            else
                Console.WriteLine("OBJETO 1 é diferente do OBJETO 2 (com OPERATOR)");
        }
    }

    public class NormalClass
    {
        public int MyProperty { get; set; }
    }

    public class MyOperatorClass
    {
        public int MyProperty { get; set; }

        public static bool operator ==(MyOperatorClass one, MyOperatorClass another)
        {
            return one.MyProperty == another.MyProperty;
        }

        public static bool operator !=(MyOperatorClass one, MyOperatorClass another)
        {
            return one.MyProperty != another.MyProperty;
        }
    }
}
