using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2
{
    static class TEMP_Instellingen
    {
        private static int[] mapsize = new int[2] { 35, 15 };

        public static BlockType[,] given_map = GivenMap(mapsize[0], mapsize[1]);

        static BlockType[,] GivenMap(int x, int y)
        {
            BlockType[,] map = new BlockType[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 0 || j == 0 || j == 1 || j == 2 || j == y - 1)
                    { map[i, j] = BlockType.WallFloor; }
                    else if (i == x - 1)
                    { map[i, j] = BlockType.Death; }
                    else
                    { map[i, j] = BlockType.EmptySpace; }
                }
            }

            map[4, 3] = BlockType.SpawnHero;

            map[1, 3] = BlockType.WallFloor;
            map[1, 4] = BlockType.WallFloor;
            map[2, 3] = BlockType.WallFloor;
            map[2, 4] = BlockType.WallFloor;

            map[4, 6] = BlockType.WallFloor;
            map[6, 8] = BlockType.WallFloor;
            map[10, 8] = BlockType.WallFloor;

            map[8, 0] = BlockType.Death;
            map[8, 1] = BlockType.EmptySpace;
            map[8, 2] = BlockType.EmptySpace;
            map[9, 0] = BlockType.Death;
            map[9, 1] = BlockType.EmptySpace;
            map[9, 2] = BlockType.EmptySpace;

            map[12, 0] = BlockType.Death;
            map[12, 1] = BlockType.EmptySpace;
            map[12, 2] = BlockType.EmptySpace;
            map[13, 0] = BlockType.Death;
            map[13, 1] = BlockType.EmptySpace;
            map[13, 2] = BlockType.EmptySpace;
            map[14, 0] = BlockType.Death;
            map[14, 1] = BlockType.EmptySpace;
            map[14, 2] = BlockType.EmptySpace;

            map[19, 3] = BlockType.Death;

            return map;
        }
    }
}
