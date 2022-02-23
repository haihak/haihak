using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.Animal
{
    class Dog : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Dog";
        }
    }
}
