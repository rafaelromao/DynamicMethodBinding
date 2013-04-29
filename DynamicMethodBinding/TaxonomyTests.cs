using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DynamicMethodBinding
{
    [TestFixture]
    public class TaxonomyTests
    {
        [Test]
        public void TestGenusForDynamicBinding()
        {
            var taxonomy = new Taxonomy(); 
            
            var lion = new Lion();
            Assert.AreEqual("Lion genus is Panthera", taxonomy.GenusFor(lion));

            var zebra = new Zebra();
            Assert.AreEqual("Zebra genus is Equus", taxonomy.GenusFor(zebra));

            var elephant = new Elephant();
            Assert.AreEqual("Elephant genus is Loxodonta", taxonomy.GenusFor(elephant));

            // The public Taxonomy.GenusFor method delegates to the best version of the private Taxonomy.GenusFor methods
            // the responsibility to tell the genus for the given IAnimal.
            // This shows how dynamic method binding works.
        }
    }
}
