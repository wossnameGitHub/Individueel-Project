using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2
{
    public class Block
    {
        public Blocktype type;

        public Block(Blocktype t)
        {
            type = t;
        }

        public override string ToString()
        {
            if (type != Blocktype.EmptySpace)
            { return type.ToString()[0].ToString(); }
            else
            { return " "; }
        }
    }
}
