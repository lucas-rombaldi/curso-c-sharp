using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class ExtensionMethodsSample : AbstractSample
    {
        public override void PrintContent()
        {
            Console.WriteLine("STRING EXTENSION METHOD");
            string funcaoProduto = "Marketplace";
            Console.WriteLine($"Nomeando {funcaoProduto}... Equipe Trabalhando... (1 mês depois)... {funcaoProduto.NomearProduto()}");

            Console.WriteLine("OBJECT EXTENSION METHOD");
            var objeto = new MyOwnClass();
            objeto.Value = 10;
            Console.WriteLine($"O valor de objeto.Value é {objeto.Value}.");
            objeto.Add(35);
            Console.WriteLine($"O novo valor de objeto.Value é {objeto.Value}.");
        }
    }

    public static class MyExtensions
    {
        public static string NomearProduto(this string funcaoProduto)
        {
            return $"My{funcaoProduto}";
        }

        public static void Add(this MyOwnClass myOwnClass, int addValue)
        {
            myOwnClass.Value += addValue;
        }
    }

    public class MyOwnClass
    {
        public int Value { get; set; }
    }
}
