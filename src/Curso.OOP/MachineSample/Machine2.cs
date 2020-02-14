using System;

namespace Curso.OOP.MachineSample
{
    public class Machine2 : AbstractMachine
    {
        public Machine2(IPrintStrategy printStrategy)
            : base(printStrategy)
        { }

        public override void Desligar()
        {
            _printStrategy.Print($"Desligando {nameof(Machine2)}...");
        }

        public override void Ligar()
        {
            _printStrategy.Print($"Ligando {nameof(Machine2)}...");
        }
    }
}
