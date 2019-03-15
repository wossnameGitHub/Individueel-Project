using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2
{
    public class MAIN
    {
        public Map map;
        public Hero hero;
        public int[] partofmap = new int[4]; // lowx lowy, highx, highy


        public MAIN()
        {
            map = new Map();
            hero = new Hero();

            for (int x = 0; x < map.blocks.GetLength(0); x++)
            {
                for (int y = 0; y < map.blocks.GetLength(1); y++)
                {
                    if (map.blocks[x,y].type == Blocktype.SpawnHero)
                    {
                        hero.x_loc = x;
                        hero.y_loc = y;
                    }
                }
            }

            partofmap = DeterminePartOfMapOld();
            partofmap = DeterminePartOfMap();
        }

        int[] DeterminePartOfMapOld()
        {
            int[] partofmap = new int[4];

            partofmap[0] = 0;
            partofmap[1] = 0;
            partofmap[2] = partofmap[0] + 16 - 1;
            partofmap[3] = partofmap[1] + 10 - 1;

            return partofmap;
        }

        int[] DeterminePartOfMap()
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
            { partofmap[1] = Instellingen.mapsize[1] - 9; }

            partofmap[2] = partofmap[0] + 15;
            partofmap[3] = partofmap[1] + 9;
            return partofmap;
        }
    }
}
