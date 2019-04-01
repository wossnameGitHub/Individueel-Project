using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    class Map
    {
        public Block[,] blocks;
        public MapAmbiance ambiance;

        public Map(BlockType[,] given_map)
        {
            int size_x = given_map.GetLength(0);
            int size_y = given_map.GetLength(1);

            blocks = new Block[size_x, size_y];

            for (int x = 0; x < size_x; x++)
            {
                for (int y = 0; y < size_y; y++)
                {
                    blocks[x, y] = new Block(given_map[x, y]);
                }
            }
        }
    }
}
