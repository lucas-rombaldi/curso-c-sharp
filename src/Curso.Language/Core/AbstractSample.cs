using System;

namespace Curso.Language.Core
{
    public abstract class AbstractSample : ISample
    {
        public virtual void PrintTitle()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine(ToString());
            Console.WriteLine("----------------------------------");
        }

        public abstract void PrintContent();

        public virtual void Print()
        {
            PrintTitle();
            PrintContent();
        }

        public override string ToString()
        {
            return GetType().Name.Replace("Sample", string.Empty);
        }
    }
}
