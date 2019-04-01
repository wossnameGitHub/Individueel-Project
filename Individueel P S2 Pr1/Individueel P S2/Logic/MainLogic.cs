using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individueel_P_S2.Logic
{
    static class MainLogic
    {
        private static Game currentGame;
        private static List<InputType> inputs = new List<InputType>();

        private static void UpdateDisplayHolder()
        {
            DisplayHolder.displayMap = currentGame.CreateDisplayMap();
            DisplayHolder.heroStatus = currentGame.GetHeroStatus();
            DisplayHolder.timePassed = currentGame.timePassed;

            // for debugging purposes
            DisplayHolder.FullMap = currentGame.TEMP_CreateFullMap();
        }

        public static void StartGame()
        {
            Map map = new Map(TEMP_Instellingen.given_map);
            currentGame = new Game(map);
            UpdateDisplayHolder();
        }

        public static void InputRecieved(InputType type)
        {
            if (!inputs.Contains(type))
            { inputs.Add(type); }
        }

        public static void TimePasses()
        {
            if (inputs.Contains(InputType.Left) && inputs.Contains(InputType.Right))
            {
                inputs.Remove(InputType.Left);
                inputs.Remove(InputType.Right);
            }

            currentGame.TimePasses(inputs);

            inputs.Clear();
            UpdateDisplayHolder();
        }
    }
}
