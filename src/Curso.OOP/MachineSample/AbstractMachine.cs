using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OOP.MachineSample
{
    public abstract class AbstractMachine : IMachine
    {
        protected readonly IPrintStrategy _printStrategy;
        public AbstractMachine(IPrintStrategy printStrategy)
        {
            _printStrategy = printStrategy;
        }

        public abstract void Desligar();

        public abstract void Ligar();

        public virtual void RealizarOperacao(string operacao)
        {
            Ligar();
            _printStrategy.Print($"Realizando operação: {operacao}");
            Desligar();
        }
    }
}
