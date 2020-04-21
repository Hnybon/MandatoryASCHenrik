using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using MandatoryASCHenrik.Classes.Creatures;
using MandatoryASCHenrik.Interfaces;
using MandatoryASCHenrik.States;

namespace MandatoryASCHenrik.World
{
    public class World
    {
        private char[,] _world;
        private readonly int maxWidth;
        private readonly int maxHeight;
        private readonly String horizontalLine = "";

        public List<ACreature> CreaturesList = new List<ACreature>();

        public static List<Tile> _usedTiles;

        // snake Head
        private int _headrow;
        private int _headcol;

        public World(int width, int height, int population)
        {
            _world = new char[width,height];
            maxWidth = width;
            maxHeight = height;
            for (int i = 0; i < width+2; i++)
            {
                horizontalLine += "-";
            }

            //kalder PopulateWorld() og sætter [population] Creatures ind i CreaturesList
            CreaturesList = PopulateWorld(width, height, population);

            //TODO Create Items/Objects in the world
        }

        public List<ACreature> PopulateWorld(int width, int height, int population)
        {
            //bør lave creatures
            //TODO Find a better way to put creatures into the world

            List<ACreature> _creatures = new List<ACreature>();

            for (int i = 0; i < population; i++)
            {
                _creatures.Add(CreateCreature(height, width));
            }

            return _creatures;
        }

        public ACreature CreateCreature(int height, int width)
        {
            //TODO Sikre at der ikke sker et uendeligt loop og at return null ikke laver ged i den

            var rand = new Random();
            int num = rand.Next(3);
            ACreature c;
            if (num == 0)
            {
                int row = rand.Next(width);
                int col = rand.Next(height);
                Tile _tile = new Tile(row, col);
                bool _tileOccupied = _usedTiles.Any(x => x.row == row && x.column == col);
                if (!_tileOccupied)
                {
                    c= new Goblin(_tile);
                    return c;
                }
                else
                {
                    //bør kalde metoden igen i tilfælde af at der allerede er et Creature i den Tile
                    CreateCreature(height, width);
                    //metoden beklager sig hvis jeg ikke sætter return null ind. hvad sker der når return null kører igennem?
                    return null;
                }
            }
            else if (num == 1)
            {
                int row = rand.Next(width);
                int col = rand.Next(height);
                Tile _tile = new Tile(row, col);
                bool _tileOccupied = _usedTiles.Any(x => x.row == row && x.column == col);
                if (!_tileOccupied)
                {
                    c = new Orc(_tile);
                    return c;
                }
                else
                {
                    //bør kalde metoden igen i tilfælde af at der allerede er et Creature i den Tile
                    CreateCreature(height, width);
                    return null;
                }
            }
            else
            {
                int row = rand.Next(width);
                int col = rand.Next(height);
                Tile _tile = new Tile(row, col);
                bool _tileOccupied = _usedTiles.Any(x => x.row == row && x.column == col);
                if (!_tileOccupied)
                {
                    c = new Human(_tile);
                    return c;
                }
                else
                {
                    //bør kalde metoden igen i tilfælde af at der allerede er et Creature i den Tile
                    CreateCreature(height, width);
                    return null;
                }
            }
        }

        public bool DoNextMove(StatesTypes move)
        {
            bool inside = true;

            switch (move)
            {
                //TODO Alter so it changes an ACreature objects Tile values instead

                case StatesTypes.NORTH:
                    _headrow--;
                    break;
                case StatesTypes.SOUTH:
                    _headrow++;
                    break;
                case StatesTypes.EAST:
                    _headcol++;
                    break;
                case StatesTypes.WEST:
                    _headcol--;
                    break;
            }

            //TODO Alter somehow
            // check if snake is moving outside playground
            if (_headrow == maxHeight || _headrow == -1 ||
                _headcol == maxWidth || _headcol == -1)
            {
                inside = false; // snake is outside playground
            }
            else
            {
                PrintPlayground(); // snake still inside
            }

            return inside;
        }

        private void PrintPlayground()
        {
            //TODO IDK
            Console.Clear();
            Console.WriteLine("Snake ");
            Console.WriteLine(horizontalLine);
            for (int r = 0; r < maxHeight; r++)
            {
                Console.WriteLine($"|{GetRowString(r)}|");
            }
            Console.WriteLine(horizontalLine);
        }
        private String GetRowString(int r)
        {
            StringBuilder sb = new StringBuilder();
            for (int c = 0; c < maxWidth; c++)
            {
                if (r == _headrow && c == _headcol)
                    sb.Append('H'); // head of snake
                else
                    sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}