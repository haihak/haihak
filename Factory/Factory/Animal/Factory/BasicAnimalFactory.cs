using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Animal.Factory
{
    class BasicAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            throw new NotImplementedException();
        }
    }
}
