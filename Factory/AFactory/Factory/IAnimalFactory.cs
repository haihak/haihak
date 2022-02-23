using AFactory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.Factory
{
    interface IAnimalFactory
    {
        // Tạo tạo animal
        IAnimal createAnimal();
    }
}
