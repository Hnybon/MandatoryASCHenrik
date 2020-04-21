using System;
using MandatoryASCHenrik.Classes.DefenceObjects;
using MandatoryASCHenrik.Classes.Objects;
using MandatoryASCHenrik.Interfaces;

namespace MandatoryASCHenrik.Factory
{
    public class ItemFactory
    {
        public static IObject GetClass(FactoryType type)
        {
            var r = new Random();
            int rnum = r.Next(3);
            if (rnum == 0)
            {
                switch (type)
                {
                    case FactoryType.IAttackObject: return new Dagger();

                    case FactoryType.IDefenceObject: return new Buckler();
                }
            }
            else if (rnum == 1)
            {
                switch (type)
                {
                    case FactoryType.IAttackObject: return new Shortsword();

                    case FactoryType.IDefenceObject: return new Smallshield();
                }
            }
            else if (rnum == 2)
            {
                switch (type)
                {
                    case FactoryType.IAttackObject: return new Longsword();

                    case FactoryType.IDefenceObject: return new Largeshield();
                }
            }
            else
            {
                switch (type)
                {
                    case FactoryType.IAttackObject: return new BastardSword();

                    case FactoryType.IDefenceObject: return new Towershield();
                }
            }
            return new Dagger();
        }
    }
}