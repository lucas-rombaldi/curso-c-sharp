using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class BoxingUnboxingSample : AbstractSample
    {
        public override void PrintContent()
        {
            //Boxing (do mais específico para o mais abrangente)
            int inteiro = 10;
            object objeto = inteiro;
            Console.WriteLine($"Boxing do int 10 para object = {objeto}");

            //Unboxing (do mais abrangente para o mais específico)
            object objeto2 = 20;
            int inteiro2 = (int)objeto2;
            Console.WriteLine($"Unboxing do object 20 para int = {inteiro2}");

            object meuObjeto = new MinhaClasse(10);
            MinhaClasse minhaClasse = (MinhaClasse)meuObjeto;
            MinhaClasse minhaClasse2 = meuObjeto as MinhaClasse;

            MinhaSegundaClasse minhaClasse4 = meuObjeto as MinhaSegundaClasse;
            MinhaSegundaClasse minhaClasse3 = (MinhaSegundaClasse)meuObjeto;            
        }
    }

    public class MinhaClasse
    {
        public MinhaClasse(int codigo)
        {
            Codigo = codigo;
        }

        public int Codigo { get; set; }

        public void TesteMetodo()
        { }
    }

    public class MinhaSegundaClasse
    {
        public MinhaSegundaClasse(int codigo)
        {
            Codigo = codigo;
        }

        public int Codigo { get; set; }

        public void TesteMetodo()
        { }
    }
}
