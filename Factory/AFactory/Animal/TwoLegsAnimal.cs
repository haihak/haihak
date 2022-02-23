using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.Animal
{
    abstract class TwoLegsAnimal : IAnimal
    {
        public abstract string GetName();
    }
}
