using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.Creatures
{
    public class Goblin : ACreature
    {
        public new int MaxHitPoints { get; set; } = 20;
        public new int Speed { get; set; } = 10;
        public new int BaseAttack { get; set; } = 5;
        public new int BaseDefence { get; set; } = 6;
        public new int CarryWeight { get; set; } = 4;

        public Goblin(Tile location) : base(location)
        {
            Location = location;
        }
    }
}