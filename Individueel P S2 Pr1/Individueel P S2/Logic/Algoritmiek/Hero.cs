using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    public class Hero
    {
        public int x_loc;
        public int y_loc;
        public bool HitHisHead;
        public bool JustJumped;
        public bool Alive;

        public Hero()
        {
            HitHisHead = false;
            JustJumped = false;
            Alive = true;
        }

        private void Move(Dim dim, int amount)
        {
            switch (dim)
            {
                case Dim.X:
                    x_loc += amount;
                    break;
                case Dim.Y:
                    y_loc += amount;
                    break;
            }

            if (dim == Dim.Y && amount > 0)     // dit kan niet in een keer, want als dit false is kan JustJumped nog steeds true zijn
            { JustJumped = true; }
        }

        public void TryMoving(Dim dim, int amount, Map map)
        {
            if (!HitHisHead)
            {
                switch (dim)
                {
                    case Dim.X:
                        if (map.blocks[x_loc + amount, y_loc].type == Blocktype.WallFloor)
                        { HitHisHead = true; }
                        else if (map.blocks[x_loc + amount, y_loc].type == Blocktype.Death)
                        { Alive = false; }
                        else
                        { Move(dim, amount); }
                        break;
                    case Dim.Y:
                        if (map.blocks[x_loc, y_loc + amount].type == Blocktype.WallFloor)
                        {
                            if (amount > 0)
                            { HitHisHead = true; }
                        }
                        else if (map.blocks[x_loc, y_loc + amount].type == Blocktype.Death)
                        { Alive = false; }
                        else
                        { Move(dim, amount); }
                        break;
                }
            }
        }
    }
}
