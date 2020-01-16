using Curso.Language.Core;
using System;
using System.Threading.Tasks;

namespace Curso.Language.Samples
{
    public class AsynchronousSample : AbstractSample
    {
        public override void PrintContent()
        {
            var demo = new Demo();
            var task = demo.DoStuff();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Working on the main thread...");
            }

            task.Wait();
        }
    }

    public class Demo
    {
        public async Task DoStuff()
        {
            await Task.Run(() =>
            {
                CountToFifty();
            });

            //Não irá executar até que CountToFifty for finalizado.
            Console.WriteLine("Counting to 50 is completed...");
        }

        private static async Task<string> CountToFifty()
        {
            int counter;
            for (counter = 0; counter <= 50; counter++)
            {
                Console.WriteLine($"BG THREAD: {counter}...");
            }

            return ("Counter = " + counter);
        }
    }
}
