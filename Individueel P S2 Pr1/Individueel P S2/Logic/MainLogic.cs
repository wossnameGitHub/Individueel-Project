using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    static class MainLogic
    {
        // new shit
        public static Game currentGame;



        // old shit
        private static Map map;
        private static Hero hero;
        private static List<InputType> inputs = new List<InputType>();

        private static int[] DeterminePartOfMap()
        {
            int[] partofmap = new int[4];

            if (hero.x > 3 && hero.x < TEMP_Instellingen.mapsize[0] - 11)
            { partofmap[0] = hero.x - 4; }
            else if (hero.x <= 3)
            { partofmap[0] = 0; }
            else
            { partofmap[0] = TEMP_Instellingen.mapsize[0] - 15; }

            if (hero.y > 2 && hero.y < TEMP_Instellingen.mapsize[1] - 6)
            { partofmap[1] = hero.y - 3; }
            else if (hero.y <= 2)
            { partofmap[1] = 0; }
            else
            { partofmap[1] = TEMP_Instellingen.mapsize[1] - 10; }//

            partofmap[2] = partofmap[0] + 15;
            partofmap[3] = partofmap[1] + 9;
            return partofmap;
        }

        private static void UpdateDisplayHolder()
        {
            DisplayHolder.hero = hero;
            DisplayHolder.map = map;
            DisplayHolder.partofmap = DeterminePartOfMap();
        }

        public static void StartGame()
        {
            map = new Map(TEMP_Instellingen.mapsize, TEMP_Instellingen.given_map);
            hero = new Hero();

            // determine the starting location for the Hero
            for (int x = 0; x < map.blocks.GetLength(0); x++)
            {
                for (int y = 0; y < map.blocks.GetLength(1); y++)
                {
                    if (map.blocks[x, y].type == BlockType.SpawnHero)
                    {
                        hero.x = x;
                        hero.y = y;
                        map.blocks[x, y].type = BlockType.EmptySpace;
                    }
                }
            }

            UpdateDisplayHolder();
        }

        private static void DoTheFallingThing()
        {
            if (!hero.status.JustJumped)
            {
                hero.TryMoving(Dim.Y, -1, map);
            }
        }

        private static bool ValidToJump()
        {
            return map.blocks[hero.x, hero.y - 1].type == BlockType.WallFloor;
        }

        public static void TimePasses()
        {
            bool validjump = ValidToJump();

            DoTheFallingThing();
            hero.status.JustJumped = false;

            if (inputs.Contains(InputType.Jump) && validjump)
            {
                hero.TryMoving(Dim.Y, 1, map);
                hero.TryMoving(Dim.Y, 1, map);
            }

            if (inputs.Contains(InputType.Left) && inputs.Contains(InputType.Right))
            { inputs.Clear(); }

            if (inputs.Contains(InputType.Left))
            { hero.TryMoving(Dim.X, -1, map); }

            if (inputs.Contains(InputType.Right))
            { hero.TryMoving(Dim.X, 1, map); }

            hero.status.HitHisHead = false;

            inputs.Clear();
            UpdateDisplayHolder();
        }

        public static void InputRecieved(InputType type)
        {
            if (!inputs.Contains(type))
            { inputs.Add(type); }
        }
    }
}
