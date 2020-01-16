using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class IndexerSample : AbstractSample
    {
        public override void PrintContent()
        {
            var indexer = new MyIndexer();
            Console.WriteLine($"Meu índice na posição 3 é: {indexer[3]}.");
        }
    }

    public class MyIndexer
    {
        // Array of temperature values
        private int[] temps = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        // To enable client code to validate input 
        // when accessing your indexer.
        public int Length
        {
            get { return temps.Length; }
        }

        // Indexer declaration.
        // If index is out of range, the temps array will throw the exception.
        public int this[int index]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }
    }
}
