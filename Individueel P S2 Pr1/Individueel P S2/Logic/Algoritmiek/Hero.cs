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
        public bool HitHisHead = false;

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
        }

        public void TryMoving(Dim dim, int amount, Map map)
        {
            if (!HitHisHead)
            {
                switch (dim)
                {
                    case Dim.X:
                        if ((x_loc == 0 && amount < 0) || (x_loc == map.blocks.GetLength(0) - 1 && amount > 0))
                        { HitHisHead = true; }
                        else
                        { Move(dim, amount); }
                        break;
                    case Dim.Y:
                        if ((y_loc == 0 && amount < 0) || (y_loc == map.blocks.GetLength(1) - 1 && amount > 0))
                        { HitHisHead = true; }
                        else
                        { Move(dim, amount); }
                        break;
                }
            }
        }
    }
}
