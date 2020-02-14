using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OOP
{
    public class ConsolePrintStrategy : IPrintStrategy
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
