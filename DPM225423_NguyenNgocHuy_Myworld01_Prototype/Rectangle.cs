using System;

namespace DPM225423_NguyenNgocHuy_Myworld01_PrototypeRealWorld
{
    /// <summary>
    /// The 'ConcretePrototype' class - Rectangle
    /// </summary>
    public class Rectangle : ShapePrototype
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override ShapePrototype Clone()
        {
            Console.WriteLine("Cloning Rectangle {0}x{1}", Width, Height);
            return this.MemberwiseClone() as ShapePrototype;
        }
    }
}
    