using System;

namespace DPM225423_NguyenNgocHuy_Pattern01_Adapter
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
