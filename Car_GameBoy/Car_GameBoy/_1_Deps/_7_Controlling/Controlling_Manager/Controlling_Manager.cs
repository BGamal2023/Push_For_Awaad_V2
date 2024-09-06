using Car_GameBoy._1_Deps._7_Controlling.Controlling_Player_Food;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Player_Fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._7_Controlling.Controlling_Manager
{
    internal class Controlling_Manager
    {
        private Player_Fuel_Controller obj_PFC=new Player_Fuel_Controller();
        private Player_Food_Controller obj_Player_Food_Controlling=new Player_Food_Controller();
        //---------------------------------------------------------------------------------------\
        public void control(double timerTick,Canvas gameArea)
        {
           double inTime_Fuel_Level= obj_PFC.player_Fuel_Control(timerTick);
            obj_Player_Food_Controlling.control_Player_Food(inTime_Fuel_Level, gameArea);
        }
    }
}
