using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    class Hero
    {
        public int x;
        public int y;
        public HeroStatus status;

        public Hero()
        {
            status = new HeroStatus
            {
                HitHisHead = false,
                JustJumped = false,
                Alive = true
            };
        }

        private void Move(Dim dim, int amount)
        {
            switch (dim)
            {
                case Dim.X:
                    x += amount;
                    break;
                case Dim.Y:
                    y += amount;
                    break;
            }

            if (dim == Dim.Y && amount > 0)     // dit kan niet in een keer, want als dit false is kan JustJumped nog steeds true zijn
            { status.JustJumped = true; }
        }

        public void TryMoving(Dim dim, int amount, Block[,] blocks) // blocks hier meegeven is niet echt cool
        {
            if (!status.HitHisHead)
            {
                switch (dim)
                {
                    case Dim.X:
                        if (blocks[x + amount, y].type == BlockType.WallFloor)
                        { status.HitHisHead = true; }
                        else if (blocks[x + amount, y].type == BlockType.Death)
                        { status.Alive = false; }
                        else
                        { Move(dim, amount); }
                        break;
                    case Dim.Y:
                        if (blocks[x, y + amount].type == BlockType.WallFloor)
                        {
                            if (amount > 0)
                            { status.HitHisHead = true; }
                        }
                        else if (blocks[x, y + amount].type == BlockType.Death)
                        { status.Alive = false; }
                        else
                        { Move(dim, amount); }
                        break;
                }
            }
        }
    }
}
