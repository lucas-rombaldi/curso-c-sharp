using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class DisposableSample : AbstractSample
    {
        public override void PrintContent()
        {
            Console.WriteLine("OBJETO 1 (sem USING)");
            var processo1 = new MyDisposable();
            processo1.Processa();

            Console.WriteLine("OBJETO 1 (com USING)");
            MyDisposable processo2;
            using (processo2 = new MyDisposable())
            {
                processo2.Processa();
            }

            processo1.VerificaStatusProcesso(nameof(processo1));
            processo2.VerificaStatusProcesso(nameof(processo2));
        }
    }

    public class MyDisposable : IDisposable
    {
        private bool processoAberto = true;

        public void Processa()
        {
            Console.WriteLine("Realiza processo...");
        }

        public void Dispose()
        {
            Console.WriteLine("Finaliza processo...");
            processoAberto = false;
        }

        public void VerificaStatusProcesso(string name)
        {
            if (processoAberto)
                Console.WriteLine($"O processo {name} está aberto.");
            else
                Console.WriteLine($"O processo {name} está finalizado.");
        }
    }
}
