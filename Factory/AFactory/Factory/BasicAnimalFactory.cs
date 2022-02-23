using AFactory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.Factory
{
    class BasicAnimalFactory : IAnimalFactory
    {
        int index = 0;
        public IAnimal createAnimal()
        {
            if(index == 0)
            {
                index++;
                return new Dog();
            }
            if (index == 1)
            {
                index++;
                return new Cat();
            }
            if (index == 2)
            {
                index ++;
                return new Duck();
            }
            if (index == 3)
            {
                index = 0;
                return new Chicken();
            }    
            return null;
        }
    }
}
