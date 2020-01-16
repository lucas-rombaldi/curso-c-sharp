using Curso.Language.Core;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Curso.Language.Samples
{
    public class ListsSample : AbstractSample
    {
        public override void PrintContent()
        {
            var listaArray = new string[10];
            listaArray[0] = "A";
            listaArray[2] = "B";
            ImprimeLista(listaArray);

            var listaBasica = new List<string>();
            listaBasica.Add("C");
            listaBasica.Add("D");
            ImprimeLista(listaBasica);

            var dicionario = new Dictionary<string, int>();
            dicionario.Add("A", 1);
            dicionario.Add("B", 2);
            foreach(var item in dicionario)
            {
                Console.WriteLine($"Imprimindo item do dicionário: {item.Key} = {item.Value}");
            }
            Console.WriteLine($"O valor do dicionário na chave A é: {dicionario["A"]}");

            var customList = new MyCustomList();
            ImprimeLista(customList);
        }

        private void ImprimeLista(IEnumerable lista)
        {
            foreach(var item in lista)
            {
                if (item != null)
                    Console.WriteLine($"Imprimindo item da lista do tipo {lista.GetType().Name}: {item.ToString()}");
            }
        }
    }

    public class MyCustomList : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "A";
            yield return "B";
            yield return "C";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyClass
    {
        public int MyProperty { get; set; }
    }
}
