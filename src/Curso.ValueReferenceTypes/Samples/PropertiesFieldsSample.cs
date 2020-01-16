using Curso.Language.Core;

namespace Curso.Language.Samples
{
    public class PropertiesFieldsSample : AbstractSample
    {
        public override void PrintContent()
        { }

        public class PropertiesFields
        {
            public int MyProperty { get; set; }

            private int _teste;

            public int Teste 
            {
                get
                {
                    return _teste;
                }
                set
                {
                    _teste = value;
                }
            }
        }
    }
}
