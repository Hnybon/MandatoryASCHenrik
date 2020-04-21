using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.Objects
{
    public class BastardSword : IAttackObject
    {
        public int Weight { get; set; } = 4;
        public Tile Tile { get; set; }
        public int BonusAttack { get; set; } = 16;

    }
}