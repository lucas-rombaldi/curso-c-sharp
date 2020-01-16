using Curso.Language.Core;
using System;
using System.Collections.Generic;

namespace Curso.Language.Samples
{
    public class CastingSample : AbstractSample
    {
        public override void PrintContent()
        {
            string teste = "abc";

            //Using IS
            if (teste is string)
                Console.WriteLine("TESTANDO TIPO DA VARIÁVEL: A variável teste é uma string.");

            //Using AS
            IEnumerable<int> numbers = new[] { 10, 20, 30 };
            IList<int> indexable = numbers as IList<int>;
            if (indexable != null)
            {
                Console.WriteLine($"CONVERTENDO COM AS: {indexable.Count}");
            }

            //Using Parse
            if (int.TryParse("abc", out int resultado))
                Console.WriteLine("TRYPARSE: O valor \"ABC\" é um inteiro válido.");
            else
                Console.WriteLine("TRYPARSE: O valor \"ABC\" NÃO é um inteiro válido.");

            int resultado2 = int.Parse("123");
            Console.WriteLine("PARSE: O valor \"123\" é um inteiro válido.");            

            Console.WriteLine($"SYSTEM.CONVERT: Convertendo NULL para inteiro: {Convert.ToInt32(null)}");
            Console.WriteLine($"SYSTEM.CONVERT: Convertendo \"456\" para inteiro: {Convert.ToInt32("456")}");
        }
    }
}
