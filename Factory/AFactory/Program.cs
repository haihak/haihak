using AFactory.AbstracFactory;
using AFactory.Animal;
using AFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IAnimalFactory factory;
            // tạo hàm random
            Random random = new Random();

            int type = random.Next(0, 2);
            // nếu type = 0
            if(type == 0)
            {
                //gọi hàm ForLegsAnimalFactory
                factory = new FourLegsAnimalFactory();
            }
            // nếu type = 1
            else
            {
                //gọi hàm TwoLegsAnimalFactory
                factory = new TwoLegsAnimalFactory();
            }

            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());

            Console.ReadLine();
        }
    }
}
