using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class EnumSample : AbstractSample
    {
        public override void PrintContent()
        {
            Console.WriteLine($"ENUM DEFAULT");
            Console.WriteLine($"Ativo = {Situacao.Ativo}");
            Console.WriteLine($"Inativo = {Situacao.Inativo}");

            Console.WriteLine($"ENUM INT");
            Console.WriteLine($"Ativo = {CustomSituacao.Ativo}");
            Console.WriteLine($"Inativo = {CustomSituacao.Inativo}");

            Console.WriteLine($"ENUM CHAR");
            Console.WriteLine($"Ativo = {CustomCharSituacao.Ativo}");
            Console.WriteLine($"Inativo = {CustomCharSituacao.Inativo}");
        }
    }

    public enum Situacao
    {
        Ativo,
        Inativo
    }

    public enum CustomSituacao
    {
        Ativo = 1,
        Inativo = 0
    }

    public enum CustomCharSituacao
    {
        Ativo = 'A',
        Inativo = 'I'
    }
}
