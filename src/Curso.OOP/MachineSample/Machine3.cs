using System;

namespace Curso.OOP.MachineSample
{
    public class Machine3 : AbstractMachine
    {
        public Machine3(IPrintStrategy printStrategy) 
            : base(printStrategy)
        { }

        public override void Desligar()
        {
            _printStrategy.Print($"Desligando {nameof(Machine3)}...");
        }

        public override void Ligar()
        {
            _printStrategy.Print($"Ligando {nameof(Machine3)}...");
        }

        public override void RealizarOperacao(string operacao)
        {
            base.RealizarOperacao(operacao);
            _printStrategy.Print("Enviando e-mail avisando que a máquina foi desligada...");
        }
    }
}
