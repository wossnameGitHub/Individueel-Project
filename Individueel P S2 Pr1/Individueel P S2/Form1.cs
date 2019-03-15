﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individueel_P_S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GetAllVisuals();
        }

        void GetVisualTotal()
        {
            listBox1.Items.Clear();
            for (int y = Instellingen.mapsize[1] - 1; y >= 0; y--)
            {
                string a = "";

                for (int x = 0; x < Instellingen.mapsize[0]; x++)
                {
                    if (!(Program.main.hero.x_loc == x && Program.main.hero.y_loc == y))
                    { a += " " + Program.main.map.blocks[x, y].ToString(); }
                    else
                    { a += " X"; }
                }

                listBox1.Items.Add(a);
            }
        }
        void GetVisualLimited()
        {
            int[] yeet = Program.main.partofmap;
            listBox2.Items.Clear();
            for (int y = Program.main.partofmap[3]; y >= Program.main.partofmap[1]; y--)
            {
                string a = "";

                for (int x = Program.main.partofmap[0]; x < Program.main.partofmap[2]; x++)
                {
                    if (!(Program.main.hero.x_loc == x && Program.main.hero.y_loc == y))
                    { a += " " + Program.main.map.blocks[x, y].ToString(); }
                    else
                    { a += " X"; }
                }

                listBox2.Items.Add(a);
            }
        }

        public void GetAllVisuals()
        {
            GetVisualTotal();
            GetVisualLimited();
        }

        private void buttonpressed(Inputtype type)
        {
            Program.main.InputRecieved(type);
            GetAllVisuals();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        { buttonpressed(Inputtype.Left); }
        private void buttonRight_Click(object sender, EventArgs e)
        { buttonpressed(Inputtype.Right); }
        private void buttonJump_Click(object sender, EventArgs e)
        { buttonpressed(Inputtype.Jump); }
        private void buttonGetDown_Click(object sender, EventArgs e)
        { buttonpressed(Inputtype.Get_Down); }
    }
}
