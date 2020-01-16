using Curso.Language.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Curso.Language.Samples
{
    public class JsonSerializeSample : AbstractSample
    {
        public override void PrintContent()
        {
            var objeto = new JsonClass()
            {
                ID = Guid.NewGuid().ToString(),
                Children = new List<ChildClass>()
                {
                    new ChildClass(){ ItemID = Guid.NewGuid().ToString(), ItemName = "CANETA" },
                    new ChildClass(){ ItemID = Guid.NewGuid().ToString(), ItemName = "BORRACHA" },
                    new ChildClass(){ ItemID = Guid.NewGuid().ToString(), ItemName = "LÁPIS" }
                }
            };

            Console.WriteLine("Serializando JsonClass...");
            var json = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            Console.WriteLine(json);

            Console.WriteLine("Deserializando JsonClass...");
            var objetoReverse = JsonConvert.DeserializeObject<JsonClass>(json);
            Console.WriteLine($"Objeto.ID = {objetoReverse.ID}");
        }
    }

    public class JsonClass
    {
        public string ID { get; set; }

        public List<ChildClass> Children { get; set; }
    }

    public class ChildClass
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
    }
}
