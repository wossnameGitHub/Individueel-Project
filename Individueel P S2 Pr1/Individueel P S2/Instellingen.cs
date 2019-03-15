using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2
{
    static class Instellingen
    {
        public static int[] mapsize = new int[2] { 35, 15 };

        public static Blocktype[,] given_map = GivenMap(mapsize[0], mapsize[1]);

        static Blocktype[,] GivenMap(int x, int y)
        {
            Blocktype[,] map = new Blocktype[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 0 || j == 0 || j == 1 || j == 2 || j == y - 1)
                    { map[i, j] = Blocktype.WallFloor; }
                    else if (i == x - 1)
                    { map[i, j] = Blocktype.Death; }
                    else
                    { map[i, j] = Blocktype.EmptySpace; }
                }
            }

            map[4, 3] = Blocktype.SpawnHero;

            map[1, 3] = Blocktype.WallFloor;
            map[1, 4] = Blocktype.WallFloor;
            map[2, 3] = Blocktype.WallFloor;
            map[2, 4] = Blocktype.WallFloor;

            map[4, 6] = Blocktype.WallFloor;
            map[6, 8] = Blocktype.WallFloor;
            map[10, 8] = Blocktype.WallFloor;

            map[8, 0] = Blocktype.Death;
            map[8, 1] = Blocktype.EmptySpace;
            map[8, 2] = Blocktype.EmptySpace;
            map[9, 0] = Blocktype.Death;
            map[9, 1] = Blocktype.EmptySpace;
            map[9, 2] = Blocktype.EmptySpace;

            map[12, 0] = Blocktype.Death;
            map[12, 1] = Blocktype.EmptySpace;
            map[12, 2] = Blocktype.EmptySpace;
            map[13, 0] = Blocktype.Death;
            map[13, 1] = Blocktype.EmptySpace;
            map[13, 2] = Blocktype.EmptySpace;
            map[14, 0] = Blocktype.Death;
            map[14, 1] = Blocktype.EmptySpace;
            map[14, 2] = Blocktype.EmptySpace;

            map[19, 3] = Blocktype.Death;

            return map;
        }
    }
}
