using System.Drawing;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() => new Bison();
        public override Carnivore CreateCarnivore() => new Wolf();
    }
}
