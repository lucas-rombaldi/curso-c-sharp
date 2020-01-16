using Curso.Language.Core;
using System;
using System.Dynamic;

namespace Curso.Language.Samples
{
    public class DynamicTypesSample : AbstractSample
    {
        public override void PrintContent()
        {
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.MyKey = 1;
            dynamicObject.MyValue = "A";
            Console.WriteLine($"Dynamically setted type: {dynamicObject.MyKey} = {dynamicObject.MyValue}");

            var anonymousObject = new { MyAnonymousKey = 2, MyAnonymousValue = "B" };
            Console.WriteLine($"Anonymously setted type: {anonymousObject.MyAnonymousKey} = {anonymousObject.MyAnonymousValue}");
        }
    }
}
