using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    class Block
    {
        public BlockType type;
        public BlockVersion version;

        public Block(BlockType t)
        {
            type = t;
        }

        /// <summary>
        /// Deze methode is tijdelijk, aangezien dit niet relevant gaat zijn als ik verder kom dan ASCII art
        /// </summary>
        public override string ToString()
        {
            if (type != BlockType.EmptySpace)
            { return type.ToString()[0].ToString(); }
            else
            { return " "; }
        }
    }
}
