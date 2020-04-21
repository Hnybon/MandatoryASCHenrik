using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.DefenceObjects
{
    public class Towershield : IDefenceObject
    {
        public int Weight { get; set; } = 4;
        public Tile Tile { get; set; }
        public int BonusDefence { get; set; } = 8;
    }
}