using System;
using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Classes.Creatures
{
    public class Human : ACreature
    {
        public new int MaxHitPoints { get; set; } = 60;
        public new int Speed { get; set; } = 5;
        public new int BaseAttack { get; set; } = 10;
        public new int BaseDefence { get; set; } = 5;
        public new int CarryWeight { get; set; } = 6;

        public Human(Tile location) : base(location)
        {
            Location = location;
        }
    }
}