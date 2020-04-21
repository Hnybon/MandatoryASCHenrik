using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.Objects
{
    public class Dagger : IAttackObject
    {
        public int Weight { get; set; } = 1;
        public Tile Tile { get; set; }
        public int BonusAttack { get; set; } = 4;
    }
}