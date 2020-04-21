using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.DefenceObjects
{
    public class Buckler : IDefenceObject
    {
        public int Weight { get; set; } = 1;
        public Tile Tile { get; set; }
        public int BonusDefence { get; set; } = 2;
    }
}