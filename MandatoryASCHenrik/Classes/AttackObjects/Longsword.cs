using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.Objects
{
    public class Longsword : IAttackObject
    {
        public int Weight { get; set; } = 3;
        public Tile Tile { get; set; }
        public int BonusAttack { get; set; } = 12;
    }
}