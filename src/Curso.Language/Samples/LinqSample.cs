using Curso.Language.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso.Language.Samples
{
    public class LinqSample : AbstractSample
    {
        public override void PrintContent()
        {
            var lista = new List<string>(){ "João", "Maria", "José", "Cleiton" };

            var nomesComJota = lista.Where(str => str.StartsWith("J"))
                .Take(2);
            Console.WriteLine("Nomes com J...");
            foreach (var nome in nomesComJota)
                Console.WriteLine($"- {nome}");

            var nomesComJota2 = from nome 
                                in lista
                                where nome.StartsWith("J")
                                select nome;
            Console.WriteLine("Nomes com J (segundo tipo)...");
            foreach (var nome in nomesComJota)
                Console.WriteLine($"- {nome}");

            var pessoas = new List<Pessoa>() { new Pessoa(10, "João"), new Pessoa(5, "Maria"), new Pessoa(7, "José"), new Pessoa(20, "Cleiton"), new Pessoa(30, "Jeferson") };

            var pessoasComJota2 =   from pessoa
                                    in pessoas
                                    where pessoa.Nome.StartsWith("J")
                                    select pessoa.Codigo;

            var pessoasComJota = pessoas.Where(str => str.Nome.StartsWith("J"))
                                        .OrderBy(o => o.Codigo);
            Console.WriteLine("Pessoas com J ordenadas pelo código...");
            foreach (var pessoa in pessoasComJota)
                Console.WriteLine($"- {pessoa.Codigo} {pessoa.Nome}");

            //Transformando objetos
            Console.WriteLine("Pessoas com estrutura modificada da classe para apenas o código...");
            var listaApenasCodigo = pessoas.Select(s => s.Codigo);
            foreach (var codigo in listaApenasCodigo)
                Console.WriteLine($"- {codigo}");

            var numeros = new List<int>() { 10, 20, 30 };
            Console.WriteLine($"A soma dos números da lista é de {numeros.Sum(s => s)}");
        }
    }

    public class Pessoa
    {
        public Pessoa(int codigo, string nome)
        {
            if (ID.Equals(Guid.Empty))
                ID = Guid.NewGuid();

            Codigo = codigo;
            Nome = nome;
        }

        public Guid ID { get; set; }

        public int Codigo { get; set; }

        public string Nome { get; set; }
    }
}
