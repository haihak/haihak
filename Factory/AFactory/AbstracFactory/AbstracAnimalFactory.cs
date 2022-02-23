using AFactory.Animal;
using AFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.AbstracFactory
{
    abstract class AbstracAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal createAnimal();
    }
}
