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

            map[4, 4] = Blocktype.SpawnHero;

            return map;
        }
    }
}
