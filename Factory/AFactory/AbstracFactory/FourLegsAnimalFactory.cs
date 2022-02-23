using AFactory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.AbstracFactory
{
    internal class FourLegsAnimalFactory : AbstracAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Dog();
            }
            else
            {
                return new Cat();
            }
        }
    }
}
