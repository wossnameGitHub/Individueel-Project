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
        {
            InitializeComponent();
        }

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
                    {
                        if (DisplayHolder.heroAlive)
                        { a += "X"; }
                        else
                        { a += "F"; }
                    }
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
                    {
                        if (DisplayHolder.heroAlive)
                        { a += "X"; }
                        else
                        { a += "F"; }
                    }
                }

                listBox2.Items.Add(a);
            }
        }

        private void GetAllVisuals()
        {
            GetVisualTotal();
            GetVisualLimited();
            labelTimer.Text = "Time: " + time.ToString();
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MainLogic.StartGame();
            time = 0;
            GetAllVisuals();

            buttonLeft.Show();
            buttonRight.Show();
            buttonJump.Show();
            buttonLeft.BackColor = Color.LightGray;
            buttonRight.BackColor = Color.LightGray;
            buttonJump.BackColor = Color.LightGray;

            buttonRealTime.Show();
            buttonTimePasses.Show();
            buttonStart.Text = "Restart Game";
            labelTimer.Show();
            

            /* Adds the event and the event handler for the method that will 
               process the timer event to the timer. */
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            myTimer.Interval = 1000;
            myTimer.Start();
            if (!RealTimer)
            { myTimer.Stop(); }
        }

        private void TIME_PASSES()
        {
            buttonLeft.BackColor = Color.LightGray;
            buttonRight.BackColor = Color.LightGray;
            buttonJump.BackColor = Color.LightGray;

            time += 1;

            MainLogic.TimePasses();
            GetAllVisuals();

            if (!DisplayHolder.heroAlive)
            {
                buttonTimePasses.Hide();
                buttonLeft.Hide();
                buttonRight.Hide();
                buttonJump.Hide();

                myTimer.Stop();
            }
        }

        private void buttonTimePasses_Click(object sender, EventArgs e)
        { TIME_PASSES(); }




        static int time;

        // hieronder stuff dat te maken heeft met de real-life timer

        static Timer myTimer;
        static bool RealTimer = false;

        // This is the method to run when the timer is raised.
        private static void TimerEventProcessor(object sender, EventArgs e)
        {
            // Stops the timer
            myTimer.Stop();

            Program.moetmaar.TIME_PASSES();

            // Restarts the timer
            if (DisplayHolder.heroAlive)
            { myTimer.Enabled = true; }
        }

        private void buttonRealTime_Click(object sender, EventArgs e)
        {
            if (RealTimer)
            {
                RealTimer = false;
                myTimer.Stop();
                if (DisplayHolder.heroAlive)
                { buttonTimePasses.Show(); }
                buttonRealTime.Text = "Real-time: OFF";
                buttonRealTime.BackColor = Color.Tomato;
            }
            else
            {
                RealTimer = true;
                if (DisplayHolder.heroAlive)
                { myTimer.Enabled = true; }
                buttonTimePasses.Hide();
                buttonRealTime.Text = "Real-time: ON";
                buttonRealTime.BackColor = Color.LimeGreen;
            }
        }
    }
}
