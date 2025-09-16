using System;

namespace DPM225423_NguyenNgocHuy_Pattern01_AbstractFactory.Products
{
    internal class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }
}
    