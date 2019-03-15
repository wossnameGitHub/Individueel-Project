using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2
{
    public class Map
    {
        public Block[,] blocks;

        public Map()
        {
            blocks = new Block[Instellingen.mapsize[0], Instellingen.mapsize[1]];

            for (int x = 0; x < blocks.GetLength(0); x++)
            {
                for (int y = 0; y < blocks.GetLength(1); y++)
                {
                    blocks[x, y] = new Block(Instellingen.given_map[x, y]);
                }
            }
        }
    }
}
