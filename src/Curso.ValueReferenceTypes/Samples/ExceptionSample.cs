using Curso.Language.Core;
using System;

namespace Curso.Language.Samples
{
    public class ExceptionSample : AbstractSample
    {
        public override void PrintContent()
        {
            try
            {
                int x = int.Parse("abc");
            }
            catch(Exception e)
            {
                Console.WriteLine($"EXCEPTION: \"abc\" não consegue ser convertido. {e.Message}");
            }

            try
            {
                throw new CustomException("Teste");
            }
            catch (CustomException e)
            {
                Console.WriteLine($"CustomException gerada: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception gerada: {e.Message}");
            }
            finally
            {
                Console.WriteLine($"Bloco executado, independente se gerou ou não exceção.");
            }
        }
    }
}
