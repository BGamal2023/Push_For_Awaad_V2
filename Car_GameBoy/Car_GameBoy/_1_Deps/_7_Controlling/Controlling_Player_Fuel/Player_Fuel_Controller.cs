using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps._7_Controlling.Controlling_Player_Fuel
{
    internal class Player_Fuel_Controller
    {

        public double player_Fuel_Control(double timerTick)
        {

            Globals.player_Fuel -= timerTick / 1000;
            double result = Math.Floor(Globals.player_Fuel);
            if (Globals.food_Collision)
            {

                Globals.player_Fuel += 5;

            }
            Fuel_Indicator_Creator.fuel_Indic_TBox.Text = result.ToString();
            return result;
        }
       
       
    }
}
