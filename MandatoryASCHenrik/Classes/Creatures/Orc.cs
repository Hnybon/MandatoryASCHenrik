using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.Creatures
{
    public class Orc : ACreature
    {
        public new int MaxHitPoints { get; set; } = 80;
        public new int Speed { get; set; } = 5;
        public new int BaseAttack { get; set; } = 15;
        public new int BaseDefence { get; set; } = 0;
        public new int CarryWeight { get; set; } = 8;

        public Orc(Tile location) : base(location)
        {
            Location = location;
        }
    }
}