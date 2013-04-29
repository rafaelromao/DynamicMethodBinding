using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicMethodBinding
{
    public interface IAnimal
    {
        string GenusName { get; }
    }

    public class Lion : IAnimal 
    {
        public string GenusName { get { return "Panthera"; } }
    }

    public class Zebra : IAnimal 
    {
        public string GenusName { get { return "Equus"; } }
    }

    public class Elephant : IAnimal 
    {
        public string GenusName { get { return "Loxodonta"; } }
    }

    public class Taxonomy
    {
        #region This is the only public method!

        public string GenusFor(IAnimal animal)  
        {
            // Which version of GenusFor will be called? It depends on the concrete type of 'animal'.
            return ((dynamic)this).GenusFor((dynamic)animal);
        }

        #endregion

        #region These are private methods!

        private string GenusFor(Lion lion)
        {
            return "Lion genus is " + lion.GenusName;
        }

        private string GenusFor(Zebra zebra)
        {
            return "Zebra genus is " + zebra.GenusName;
        }

        private string GenusFor(Elephant elephant)
        {
            return "Elephant genus is " + elephant.GenusName;
        }

        #endregion
    }
}
