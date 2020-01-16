using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class GenericsSample : AbstractSample
    {
        public override void PrintContent()
        {
            var objeto = new GenericClass<string>("Teste");

            var objeto2 = new GenericClass<MyCustomClass>(new MyCustomClass() { MyProperty = 10 });

            var objeto3 = new GenericConstrainedClass<MyCustomClass>(new MyCustomClass() { MyProperty = 20 });

            var objeto4 = new NormalClass();
            objeto4.GenericMethod<string>("Teste2");
        }

        public class GenericClass<T> 
        {
            public GenericClass(T value)
            {
                Value = value;
                Console.WriteLine($"GENERICS: O tipo de dado utilizado nesta classe é: {Value.GetType().FullName}");

                if (Value is ITestInterface)
                {
                    var test = Value as ITestInterface;
                    test.TestMethod();
                }                
            }

            private T Value { get; set; }
        }

        public class GenericConstrainedClass<T> where T : ITestInterface
        {
            public GenericConstrainedClass(T value)
            {
                Value = value;                
                Console.WriteLine($"CONSTRAINED GENERICS: O tipo de dado utilizado nesta classe é: {Value.GetType().FullName}");
                Value.TestMethod();
            }

            private T Value { get; set; }
        }

        public class NormalClass
        {
            public void GenericMethod<T>(T parm)
            {
                Console.WriteLine($"METHOD WITH GENERICS: O tipo de dado utilizado neste método é: {parm.GetType().FullName}");
            }
        }
    }

    public class MyCustomClass : ITestInterface
    {
        public int MyProperty { get; set; }

        public void TestMethod()
        {
            Console.WriteLine("TestMethod");
        }
    }

    public interface ITestInterface
    {
        void TestMethod();
    }
}
