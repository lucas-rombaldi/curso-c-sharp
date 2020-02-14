using Curso.Language.Core;
using System;
using System.Threading.Tasks;

namespace Curso.Language.Samples
{
    public class PureTaskSample : AbstractSample
    {
        private Object lockObject = new Object();

        public override void PrintContent()
        {
            var task = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Print($"* INSIDE NEW THREAD: {i}...");
                }
            })
            .ContinueWith((result) =>
            {
                Print($"* THREAD ENDED: {result}!");
            });

            for (int i = 0; i < 100; i++)
            {
                Print($"/ MAIN THREAD: {i}...");
            }
            Print($"/ MAIN THREAD ENDED!");

            task.Wait();
        }

        private void Print(string str)
        {
            //Thread-safe (garante que apenas uma thread irá acessar este recurso).
            lock (lockObject)
            {
                Console.WriteLine(str);
            }            
        }
    }
}
