using System;

namespace DPM225423_NguyenNgocHuy_Myworld06_Bridge
{
    /// <summary>
    /// Bridge Design Pattern - Myworld Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create RefinedAbstraction
            var characters = new Characters();

            // Set ConcreteImplementor
            characters.Data = new CharactersData("Eldoria");

            // Exercise the bridge
            characters.Show();
            characters.Next();
            characters.Show();
            characters.Next();
            characters.Show();
            characters.Add("Luna Starlight");

            characters.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}