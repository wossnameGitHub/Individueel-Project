using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Individueel_P_S2.Logic;

namespace Individueel_P_S2
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        private void GetVisualTotal()
        {
            listBox1.Items.Clear();

            Block[,] blocks = DisplayHolder.map.blocks;
            
            for (int y = blocks.GetLength(1) - 1; y >= 0; y--)
            {
                string a = "";

                for (int x = 0; x < blocks.GetLength(0); x++)
                {
                    a += " ";
                    if (!(DisplayHolder.heroLocation[0] == x && DisplayHolder.heroLocation[1] == y))
                    { a += blocks[x, y].ToString(); }
                    else
                    { a += "X"; }
                }

                listBox1.Items.Add(a);
            }
        }
        private void GetVisualLimited()
        {
            listBox2.Items.Clear();

            Block[,] blocks = DisplayHolder.map.blocks;
            int[] part = DisplayHolder.partofmap;

            for (int y = part[3]; y >= part[1]; y--)
            {
                string a = "";

                for (int x = part[0]; x < part[2]; x++)
                {
                    a += " ";
                    if (!(DisplayHolder.heroLocation[0] == x && DisplayHolder.heroLocation[1] == y))
                    { a += blocks[x, y].ToString(); }
                    else
                    { a += "X"; }
                }

                listBox2.Items.Add(a);
            }
        }

        private void GetAllVisuals()
        {
            GetVisualTotal();
            GetVisualLimited();
        }

        private void buttonpressed(Inputtype type)
        {
            MainLogic.InputRecieved(type);
            GetAllVisuals();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            buttonLeft.BackColor = Color.Yellow;
            buttonpressed(Inputtype.Left);
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            buttonRight.BackColor = Color.Yellow;
            buttonpressed(Inputtype.Right);
        }
        private void buttonJump_Click(object sender, EventArgs e)
        {
            buttonJump.BackColor = Color.Yellow;
            buttonpressed(Inputtype.Jump);
        }
        private void buttonGetDown_Click(object sender, EventArgs e)
        {
            buttonGetDown.BackColor = Color.Red;
            buttonpressed(Inputtype.Get_Down);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MainLogic.StartGame();
            GetAllVisuals();

            buttonLeft.Show();
            buttonRight.Show();
            buttonJump.Show();
            buttonGetDown.Show();

            buttonTimePasses.Show();
            buttonStart.Text = "Restart Game";
        }

        private void buttonTimePasses_Click(object sender, EventArgs e)
        {
            buttonLeft.BackColor = Color.LightGray;
            buttonRight.BackColor = Color.LightGray;
            buttonJump.BackColor = Color.LightGray;
            buttonGetDown.BackColor = Color.LightGray;

            MainLogic.TimePasses();
            GetAllVisuals();
        }
    }
}
