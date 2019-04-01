using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    class Game
    {
        private Map map;
        private Hero hero;
        public int timePassed { get; private set; }
        //private ??? timeStarted;
        public List<bool[]> movesSaved { get; private set; }

        public Game(Map map)
        {
            this.map = map;
            hero = new Hero();
            timePassed = 0;
            //timeStarted = the_time_right_now
            movesSaved = new List<bool[]>();

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
        }

        private void DoTheFallingThing()
        {
            if (!hero.status.JustJumped)
            {
                hero.TryMoving(Dim.Y, -1, map);
            }
        }

        private bool ValidToJump()
        {
            return map.blocks[hero.x, hero.y - 1].type == BlockType.WallFloor;
        }

        public void TimePasses(List<InputType> inputs)
        {
            bool validjump = ValidToJump();
            movesSaved.Add(new bool[3] { false, false, false });

            DoTheFallingThing();
            hero.status.JustJumped = false;

            if (inputs.Contains(InputType.Jump) && validjump)
            {
                hero.TryMoving(Dim.Y, 1, map);
                hero.TryMoving(Dim.Y, 1, map);
                movesSaved[timePassed][(int)InputType.Jump] = true; // hoe ik het nu doe slaat hij sprongen die niet geldig waren ook niet op
            }

            if (inputs.Contains(InputType.Left)) 
            {
                hero.TryMoving(Dim.X, -1, map);
                movesSaved[timePassed][(int)InputType.Left] = true; // datzelfde geldt ook voor als je links en rrecht tegelijkertijd indrukt (geen van beide wordt opgeslagen)
            }

            if (inputs.Contains(InputType.Right))
            {
                hero.TryMoving(Dim.X, 1, map);
                movesSaved[timePassed][(int)InputType.Right] = true; // zie hierboven
            }

            hero.status.HitHisHead = false;
            timePassed += 1;
        }

        private int[] DeterminePartOfMap()
        {
            int[] partofmap = new int[4]; // lowx, lowy, highx, highy

            if (hero.x > 3 && hero.x < map.blocks.GetLength(0) - 11)
            { partofmap[0] = hero.x - 4; }
            else if (hero.x <= 3)
            { partofmap[0] = 0; }
            else
            { partofmap[0] = map.blocks.GetLength(0) - 15; }

            if (hero.y > 2 && hero.y < map.blocks.GetLength(1) - 6)
            { partofmap[1] = hero.y - 3; }
            else if (hero.y <= 2)
            { partofmap[1] = 0; }
            else
            { partofmap[1] = map.blocks.GetLength(1) - 10; }

            partofmap[2] = partofmap[0] + 15;
            partofmap[3] = partofmap[1] + 10;
            return partofmap;
        }

        public Map CreateDisplayMap()
        {
            int[] partofmap = DeterminePartOfMap();

            int x_total = partofmap[2] - partofmap[0];
            int y_total = partofmap[3] - partofmap[1];

            BlockType[,] given_map = new BlockType[x_total, y_total];
            for (int x = 0; x < x_total; x++)
            {
                for (int y = 0; y < y_total; y++)
                {
                    given_map[x, y] = BlockType.PENDING;
                }
            }

            Map D_map = new Map(given_map);
            D_map.ambiance = map.ambiance;

            for (int x = 0; x < x_total; x++)
            {
                for (int y = 0; y < y_total; y++)
                {
                    D_map.blocks[x, y] = map.blocks[x + partofmap[0], y + partofmap[1]].CopyBlock();
                    if (hero.x == x + partofmap[0] && hero.y == y + partofmap[1])
                    { D_map.blocks[x, y].type = BlockType.HERO; }
                }
            }

            return D_map;
        }

        public Map TEMP_CreateFullMap()
        {
            int x_total = map.blocks.GetLength(0);
            int y_total = map.blocks.GetLength(1);

            BlockType[,] given_map = new BlockType[x_total, y_total];
            for (int x = 0; x < x_total; x++)
            {
                for (int y = 0; y < y_total; y++)
                {
                    given_map[x, y] = BlockType.PENDING;
                }
            }

            Map D_map = new Map(given_map);
            D_map.ambiance = map.ambiance;

            for (int x = 0; x < x_total; x++)
            {
                for (int y = 0; y < y_total; y++)
                {
                    D_map.blocks[x, y] = map.blocks[x, y].CopyBlock();
                    if (hero.x == x && hero.y == y)
                    { D_map.blocks[x, y].type = BlockType.HERO; }
                }
            }

            return D_map;
        }

        public HeroStatus GetHeroStatus()
        {
            return hero.status;
        }
    }
}
