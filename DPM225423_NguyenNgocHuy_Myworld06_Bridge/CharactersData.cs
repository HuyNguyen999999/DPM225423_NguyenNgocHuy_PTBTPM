using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Myworld06_Bridge
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class CharactersData : DataSource
    {
        private readonly List<string> characters = new List<string>();
        private int current = 0;
        private string world;

        public CharactersData(string world)
        {
            this.world = world;

            // Sample characters in the world
            characters.Add("Aric Stormblade");
            characters.Add("Elara Moonshadow");
            characters.Add("Thane Ironheart");
            characters.Add("Sylvara Windwhisper");
            characters.Add("Grok Lightseeker");
        }

        public override void NextRecord()
        {
            if (current <= characters.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void AddRecord(string character)
        {
            characters.Add(character);
        }

        public override void DeleteRecord(string character)
        {
            characters.Remove(character);
        }

        public override string GetCurrentRecord()
        {
            return characters[current];
        }

        public override void ShowRecord()
        {
            Console.WriteLine(characters[current]);
        }

        public override void ShowAllRecords()
        {
            Console.WriteLine("World: " + world);
            foreach (string character in characters)
            {
                Console.WriteLine(" " + character);
            }
        }
    }
}