using Curso.Language.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Curso.Language.Samples
{
    public class RegexSample : AbstractSample
    {
        public override void PrintContent()
        {
            Console.WriteLine("Informe a string a ser validada...");
            string teste = Console.ReadLine();

            Console.WriteLine("Informe o padrão a ser utilizado na validação a ser validada...");
            string regexPattern = Console.ReadLine();

            var regex = new Regex(regexPattern);
            if (regex.Match(teste).Success)
                Console.WriteLine($"A string {teste} é compatível com a expressão regular {regexPattern}");
            else
                Console.WriteLine($"A string {teste} NÃO é compatível com a expressão regular {regexPattern}");
        }
    }
}
