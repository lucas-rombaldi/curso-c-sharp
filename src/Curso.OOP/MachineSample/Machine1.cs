using System;

namespace Curso.OOP.MachineSample
{
    public class Machine1 : AbstractMachine
    {
        public Machine1(IPrintStrategy printStrategy) 
            : base(printStrategy)
        { }

        public override void Desligar()
        {
            _printStrategy.Print($"Desligando {nameof(Machine1)}...");
        }

        public override void Ligar()
        {
            _printStrategy.Print($"Ligando {nameof(Machine1)}...");
        }
    }
}
