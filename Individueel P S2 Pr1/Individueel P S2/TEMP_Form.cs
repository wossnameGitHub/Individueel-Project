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
    public partial class TEMP_Form : Form
    {
        public TEMP_Form()
        {
            InitializeComponent();
        }

        private void GetVisuals(bool fullmap)
        {
            ListBox listBox = new ListBox(); // wordt zometeen gelijk overschreven
            Block[,] blocks = new Block[1, 1]; // wordt zometeen gelijk overschreven

            if (fullmap)
            {
                listBox = listBox1;
                blocks = DisplayHolder.FullMap.blocks;
            }
            else
            {
                listBox = listBox2;
                blocks = DisplayHolder.displayMap.blocks;
            }

            listBox.Items.Clear();

            for (int y = blocks.GetLength(1) - 1; y >= 0; y--)
            {
                string a = "";

                for (int x = 0; x < blocks.GetLength(0); x++)
                {
                    a += " ";
                    if (blocks[x, y].type != BlockType.HERO)
                    { a += blocks[x, y].ToString(); }
                    else
                    {
                        if (!DisplayHolder.heroStatus.Alive)
                        { a += "F"; }
                        else if (DisplayHolder.heroStatus.JustJumped)
                        { a += "#"; }
                        else
                        { a += "X"; }
                    }
                }

                listBox.Items.Add(a);
            }
        }

        private void GetAllVisuals()
        {
            GetVisuals(true);
            GetVisuals(false);
            labelTimer.Text = "Time: " + DisplayHolder.timePassed.ToString();
        }

        private void TIME_PASSES()
        {
            buttonLeft.BackColor = Color.LightGray;
            buttonRight.BackColor = Color.LightGray;
            buttonJump.BackColor = Color.LightGray;

            MainLogic.TimePasses();
            GetAllVisuals();

            if (!DisplayHolder.heroStatus.Alive)
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

        private void buttonpressed(InputType type)
        {
            MainLogic.InputRecieved(type);
            GetAllVisuals();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            buttonLeft.BackColor = Color.Yellow;
            buttonpressed(InputType.Left);
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            buttonRight.BackColor = Color.Yellow;
            buttonpressed(InputType.Right);
        }
        private void buttonJump_Click(object sender, EventArgs e)
        {
            buttonJump.BackColor = Color.Yellow;
            buttonpressed(InputType.Jump);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MainLogic.StartGame();
            
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



        // hieronder stuff dat te maken heeft met de real-life timer

        static Timer myTimer;
        static bool RealTimer = false;

        // This is the method to run when the timer is raised.
        private static void TimerEventProcessor(object sender, EventArgs e)
        {
            // Stops the timer
            myTimer.Stop();

            Program.OmdatTimer.TIME_PASSES();

            // Restarts the timer
            if (DisplayHolder.heroStatus.Alive)
            { myTimer.Enabled = true; }
        }

        private void buttonRealTime_Click(object sender, EventArgs e)
        {
            if (RealTimer)
            {
                RealTimer = false;
                myTimer.Stop();
                if (DisplayHolder.heroStatus.Alive)
                { buttonTimePasses.Show(); }
                buttonRealTime.Text = "Real-time: OFF";
                buttonRealTime.BackColor = Color.Tomato;
            }
            else
            {
                RealTimer = true;
                if (DisplayHolder.heroStatus.Alive)
                { myTimer.Enabled = true; }
                buttonTimePasses.Hide();
                buttonRealTime.Text = "Real-time: ON";
                buttonRealTime.BackColor = Color.LimeGreen;
            }
        }
    }
}
