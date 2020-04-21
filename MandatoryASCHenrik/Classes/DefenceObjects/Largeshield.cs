using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.DefenceObjects
{
    public class Largeshield : IDefenceObject
    {
        public int Weight { get; set; } = 3;
        public Tile Tile { get; set; }
        public int BonusDefence { get; set; } = 6;
    }
}