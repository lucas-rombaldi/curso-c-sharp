using Curso.Language.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Curso.Language
{
    public class Program
    {
        public static readonly string EXIT_OPTION = "S";

        public static void Main(string[] args)
        {
            RequestOption();
        }

        private static void RequestOption()
        {
            var sampleOptions = GetAvailableSamples();
            DrawMenu(sampleOptions);

            var option = Console.ReadLine();

            if (option == EXIT_OPTION)
                return;

            if (!sampleOptions.ContainsKey(option))
            {                
                Console.Clear();
                Console.WriteLine("Opção inválida. Tente novamente!");
                Console.WriteLine();
                RequestOption();
            }                
            else
            {
                Console.Clear();
                sampleOptions[option].Print();
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
                RequestOption();
            }
        }

        private static Dictionary<string, ISample> GetAvailableSamples()
        {
            var sampleOptions = new Dictionary<string, ISample>();

            //Extrai os exemplos do assembly (DLL) que implementam ISample
            var samples = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ISample)) && !t.IsAbstract)
                .OrderBy(s => s.Name);

            var cont = 0;
            foreach(var sample in samples)
            {
                sampleOptions.Add((++cont).ToString(), Activator.CreateInstance(sample) as ISample);
            }

            return sampleOptions;
        }

        private static void DrawMenu(Dictionary<string, ISample> sampleOptions)
        {
            Console.WriteLine("************** C# SAMPLES **************");
            foreach(var sample in sampleOptions)
            {
                Console.WriteLine($"{sample.Key} - {sample.Value.ToString()}");
            }
            Console.WriteLine("***************************************");
            Console.WriteLine($"Escolha uma opção... ou pressione \"{EXIT_OPTION}\" para SAIR.");
        }

    }
}
