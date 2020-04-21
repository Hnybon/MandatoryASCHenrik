using System;
using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Interfaces
{
    public abstract class ACreature : ICreature
    {
        public int MaxHitPoints { get; set; }
        public int Hitpoints { get; set; }
        public int Speed { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefence { get; set; }
        public int CarryWeight { get; set; }
        public Tile Location { get; set; }
        public IAttackObject Weapon { get; set; }
        public IDefenceObject Shield { get; set; }

        protected ACreature()
        {
        }

        protected ACreature(Tile location)
        {
            Location = location;
        }


        public void Hit(ACreature target)
        {
            int Attack = BaseAttack + Weapon.BonusAttack;

            target.TakeHit(Attack);
        }

        public void TakeHit(int attack)
        {
            int Damage = attack - BaseDefence - Shield.BonusDefence;

            if (Damage > 0)
            {
                Hitpoints = Hitpoints - Damage;
                if (Hitpoints <= 0)
                {
                    //TODO Kill creature/remove from world/delete from list
                }
            }
            else
            {
                Hitpoints = Hitpoints;
            }

        }

        public void PickUpAttack(IAttackObject item)
        {
            //TODO Fix pickup system
            if (item.BonusAttack > Weapon.BonusAttack && CarryWeight + Weapon.Weight >= item.Weight)
            {
                CarryWeight = CarryWeight + Weapon.Weight - item.Weight;
                Weapon = item;
                //TODO Destroy item
            }
            else
            {
                
            }

        }

        public void PickUpDefence(IDefenceObject item)
        {
            //TODO Fix pickup system
            if (item.BonusDefence > Shield.BonusDefence && CarryWeight + Shield.Weight >= item.Weight)
            {
                CarryWeight = CarryWeight + Shield.Weight - item.Weight;
                Shield = item;
                //TODO Destroy item
            }
            else
            {
                //??
            }
        }
        public void Move()
        {
            //TODO Move from one tile to the next (only horizontal/vertical)
        }
    }
}