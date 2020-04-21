using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.DefenceObjects
{
    public class Smallshield : IDefenceObject
    {
        public int Weight { get; set; } = 2;
        public Tile Tile { get; set; }
        public int BonusDefence { get; set; } = 4;
    }
}