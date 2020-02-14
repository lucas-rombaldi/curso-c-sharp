using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OOP.MachineSample
{
    public interface IMachine
    {
        void Ligar();
        void RealizarOperacao(string operacao);
        void Desligar();
    }
}
