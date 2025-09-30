using System;

namespace DPM225423_NguyenNgocHuy_Myworld06_Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class Characters : CharactersBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            base.ShowAll();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}