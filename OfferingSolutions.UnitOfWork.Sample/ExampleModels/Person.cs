using System.Collections.Generic;

namespace OfferingSolutions.UoW.Sample.ExampleModels
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Thing> Things { get; set; }
    }
}