using System;

namespace DPM225423_NguyenNgocHuy_Pattern01_Bridge
{
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
