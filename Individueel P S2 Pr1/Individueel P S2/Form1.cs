using System;
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

            GetVisualTotal();
            GetVisualLimited();
        }

        void GetVisualTotal()
        {
            for (int y = Instellingen.mapsize[1] - 1; y >= 0; y--)
            {
                string a = "";

                a += Program.main.map.blocks[0, y].ToString();

                for (int x = 1; x < Instellingen.mapsize[0]; x++)
                {
                    a += " " + Program.main.map.blocks[x,y].ToString();
                }

                listBox1.Items.Add(a);
            }
        }
        void GetVisualLimited()
        {
            for (int y = Program.main.partofmap[3]; y >= Program.main.partofmap[1]; y--)
            {
                string a = "";

                for (int x = Program.main.partofmap[0]; x < Program.main.partofmap[2]; x++)
                {
                    a += " " + Program.main.map.blocks[x, y].ToString();
                }

                listBox2.Items.Add(a);
            }
        }
    }
}
