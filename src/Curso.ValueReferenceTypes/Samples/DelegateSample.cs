using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class DelegateSample : AbstractSample
    {
        public delegate string MontaString(string resultado);

        public override void PrintContent()
        {
            //CUSTOM
            ImprimeResultado(RetornaString);
            MontaString montaString =
                (str) =>
                {
                    return string.Format($"CUSTOM DELEGATE: {str}.");
                };
            ImprimeResultado(montaString);

            //ACTION
            ImprimeResultado(Imprime);
            ImprimeResultado((str) => Console.WriteLine($"ACTION WITH CUSTOM METHOD: {str}"));

            //FUNC
            ImprimeResultado(Soma);
            ImprimeResultado((a, b) => a + b);

            //REAL-WORLD SAMPLE
            RealizaProcesso(10, 20, (resultado) => Console.WriteLine($"CALLBACK: Resultado {resultado}"));
        }

        private void ImprimeResultado(MontaString geraResultado)
        {
            Console.WriteLine(geraResultado("SUCESSO"));
        }

        private void ImprimeResultado(Action<string> impressao)
        {
            impressao("SUCESSO");
        }

        private void ImprimeResultado(Func<int, int, int> soma)
        {
            Console.WriteLine($"FUNC: O resultado da soma de 3 com 4 é:{soma(3, 4)}");
        }

        private string RetornaString(string result)
        {
            return string.Format($"CUSTOM DELEGATE WITH DEFAULT METHOD: {result}.");
        }

        private void Imprime(string parm)
        {
            Console.WriteLine($"ACTION WITH DEFAULT METHOD: {parm}");
        }

        private int Soma(int a, int b)
        {
            return a + b;
        }

        private void RealizaProcesso(int parm1, int parm2, Action<int> callback)
        {
            Console.WriteLine("REAL-WORLD SAMPLE");
            Console.WriteLine("INICIANDO PROCESSO...");
            Console.WriteLine($"REALIZANDO ETAPA 1 DO PROCESSO... ETAPA 1 REALIZADA, OBTIDO {parm1}.");
            Console.WriteLine($"REALIZANDO ETAPA 2 DO PROCESSO... ETAPA 2 REALIZADA, OBTIDO {parm2}.");
            var resultado = parm1 + parm2;
            Console.WriteLine($"REALIZANDO ÚLTIMA ETAPA DO PROCESSO... RESULTADO DA OPERAÇÃO FOI {resultado}.");

            callback(resultado);
        }
    }
}
