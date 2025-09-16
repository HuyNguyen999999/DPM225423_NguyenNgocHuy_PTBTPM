using System;

namespace DPM225423_NguyenNgocHuy_Pattern01_Adapter
{
    /// <summary>
    /// Adapter Design Pattern - Program
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
