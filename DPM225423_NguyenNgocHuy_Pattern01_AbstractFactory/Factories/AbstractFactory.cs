using DPM225423_NguyenNgocHuy_Pattern01_AbstractFactory.Products;

namespace DPM225423_NguyenNgocHuy_Pattern01_AbstractFactory.Factories
{
    internal abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
