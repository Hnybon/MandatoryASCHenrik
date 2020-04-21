using System;
using System.Collections.Generic;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Interfaces
{
    public interface ICreature
    {
        int MaxHitPoints { get; set; }
        int Hitpoints { get; set; }
        int Speed { get; set; }
        int BaseAttack { get; set; }
        int BaseDefence { get; set; }
        int CarryWeight { get; set; }
        Tile Location { get; set; }
        IAttackObject Weapon { get; set; }
        IDefenceObject Shield { get; set; }

        void Hit(ACreature target);
        void TakeHit(int attack);
        void PickUpAttack(IAttackObject item);
        void PickUpDefence(IDefenceObject item);
        void Move();
    }
}