using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    public static class MainLogic
    {
        private static Map map;
        private static Hero hero;
        private static List<Inputtype> inputs = new List<Inputtype>();

        private static int[] DeterminePartOfMap()
        {
            int[] partofmap = new int[4];

            if (hero.x_loc > 3 && hero.x_loc < Instellingen.mapsize[0] - 11)
            { partofmap[0] = hero.x_loc - 4; }
            else if (hero.x_loc <= 3)
            { partofmap[0] = 0; }
            else
            { partofmap[0] = Instellingen.mapsize[0] - 15; }

            if (hero.y_loc > 2 && hero.y_loc < Instellingen.mapsize[1] - 6)
            { partofmap[1] = hero.y_loc - 3; }
            else if (hero.y_loc <= 2)
            { partofmap[1] = 0; }
            else
            { partofmap[1] = Instellingen.mapsize[1] - 10; }//

            partofmap[2] = partofmap[0] + 15;
            partofmap[3] = partofmap[1] + 9;
            return partofmap;
        }

        private static void UpdateDisplayHolder()
        {
            DisplayHolder.heroLocation = new int[2] { hero.x_loc, hero.y_loc };

            DisplayHolder.map = map;
            DisplayHolder.partofmap = DeterminePartOfMap();
        }

        public static void StartGame()
        {
            map = new Map(Instellingen.mapsize, Instellingen.given_map);
            hero = new Hero();

            // determine the starting location for the Hero
            for (int x = 0; x < map.blocks.GetLength(0); x++)
            {
                for (int y = 0; y < map.blocks.GetLength(1); y++)
                {
                    if (map.blocks[x, y].type == Blocktype.SpawnHero)
                    {
                        hero.x_loc = x;
                        hero.y_loc = y;
                        map.blocks[x, y].type = Blocktype.EmptySpace;
                    }
                }
            }

            UpdateDisplayHolder();
        }

        private static bool ValidToJump()
        {
            return map.blocks[hero.x_loc, hero.y_loc - 1].type == Blocktype.WallFloor;
        }
        

        public static void TimePasses()
        {
            if (inputs.Contains(Inputtype.Get_Down))
            {
                inputs.Clear();
                hero.TryMoving(Dim.Y, -1, map);
            }

            if (inputs.Contains(Inputtype.Jump) && ValidToJump())
            {
                hero.TryMoving(Dim.Y, 1, map);
                hero.TryMoving(Dim.Y, 1, map);
            }

            if (inputs.Contains(Inputtype.Left) && inputs.Contains(Inputtype.Right))
            { inputs.Clear(); }

            if (inputs.Contains(Inputtype.Left))
            { hero.TryMoving(Dim.X, -1, map); }

            if (inputs.Contains(Inputtype.Right))
            { hero.TryMoving(Dim.X, 1, map); }

            hero.HitHisHead = false;

            inputs.Clear();
            UpdateDisplayHolder();
        }

        public static void InputRecieved(Inputtype type)
        {
            if (!inputs.Contains(type))
            { inputs.Add(type); }
        }
    }
}
