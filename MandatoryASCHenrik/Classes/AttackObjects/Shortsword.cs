using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.Objects
{
    public class Shortsword : IAttackObject
    {
        public int Weight { get; set; } = 2;
        public Tile Tile { get; set; }
        public int BonusAttack { get; set; } = 8;
    }
}