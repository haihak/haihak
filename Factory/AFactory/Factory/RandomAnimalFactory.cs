using AFactory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.Factory
{
    internal class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal createAnimal()
        {
            Random random = new Random();
            int type = random.Next(0,4);
            if (type == 0)
            { 
                return new Dog();
            }
            else if (type == 1)
            {
                return new Cat();
            }
            else if (type == 2)
            {
                return new Duck();
            }
            else
            {
                return new Chicken();
            }    
        }
    }
}
