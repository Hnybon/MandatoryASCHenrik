using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.World;
using MandatoryASCHenrik.States;

namespace MandatoryASCHenrik.Game
{
    internal class Worker
    {
        public List<ACreature> Creatures;
        public List<IAttackObject> AttackObjects;
        public List<IDefenceObject> DefenceObjects;

        public void Start()
        {
            World.World w = new World.World(30,30, 10);

            //TODO Gameplay loop
            //alle creatures har en tur, dem med højest Speed går først (flere Creatures har samme Speed. skal finde en måde at give en tilfældig første tur osv.))

            // 1. prioritet: hvis der er et Creature i en Tile lige ved siden af mig, Hit()
            // 2. prioritet: hvis jeg ikke har et våben og jeg står ved siden af et, PickupAttack(). Hvis jeg ikke står ved siden af, bevæg mig imod det nærmeste våben.
            // 3. prioritet: hvis jeg ikke har et skjold og jeg står ved siden af et, PickupDefence(). Hvis jeg ikke står ved siden af, bevæg mig imod det nærmeste Skjold.
            // 4. prioritet: bevæg mig imod nærmeste fjende

            // using table state machine
            //IState stateMachine = new TableStateMachine();

            // using state machine pattern
            //IState stateMachine = new StateMachinePattern();

            //bool gameContinue = true;
            //while (gameContinue)
            //{
            //    foreach (var v in Creatures)
            //    {

            //    }
            //    StatesTypes nextMove = stateMachine.NextMove();

            //    gameContinue = w.DoNextMove(nextMove);

            //}

            //Console.WriteLine("You loose :-( ");
        }


        //private InputType ReadNextEvent()
        //{
        //    InputType ev = InputType.FORWARD;

        //    Console.Write("Type next movement 'a,w,d' : ");
        //    bool ok = false;
        //    while (!ok)
        //    {
        //        ConsoleKeyInfo info = Console.ReadKey();
        //        char c = info.KeyChar;
        //        switch (c)
        //        {
        //            case 'a':
        //                ev = InputType.LEFT;
        //                ok = true;
        //                break;
        //            case 'd':
        //                ev = InputType.RIGHT;
        //                ok = true;
        //                break;
        //            case 'w':
        //                ev = InputType.FORWARD;
        //                ok = true;
        //                break;
        //        }
        //    }

        //    return ev;
        //}
    }
}