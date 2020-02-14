using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Curso.OOP.MachineSample
{
    public class Sample
    {
        public void Execute()
        {
            var classes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(classe => classe.GetInterfaces().Contains(typeof(IMachine))
                                && !classe.IsAbstract);

            foreach (var classe in classes)
            {
                var machine = Activator.CreateInstance(classe, new object[] { new ConsolePrintStrategy() }) as IMachine;
                machine.RealizarOperacao("funcionar");
            }
        }
    }
}
