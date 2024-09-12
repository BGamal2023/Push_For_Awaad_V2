using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level_Common_Code
    {
        //------------------------------------------------------------------------------------------------
        public static void reset_The_Fuel_Counter()
        {
            Globals.player_Fuel = 100;
            Fuel_Indicator_Creator.fuel_Indic_TBox.Text = Globals.player_Fuel.ToString();
        }
        //------------------------------------------------------------------------------------------------
        public static void reset_The_Enemy_Position()
        {
            Globals.enemy_X_Pos = 328;
            Globals.enemy_Y_Pos = 0;
        }
        //------------------------------------------------------------------------------------------------
        public static void detect_New_Level(int current_Level_Nu)
        {
            if (current_Level_Nu == 2)
            {
                Level_2 obj_Level_2 = new Level_2();
                Globals.current_Level = obj_Level_2;
            }
            if (current_Level_Nu == 3)
            {
                Level_3 obj_Level_3 = new Level_3();
                Globals.current_Level = obj_Level_3;
            }
            Globals.current_Level.Run();
        }
        //------------------------------------------------------------------------------------------------
        public static  void update_Player_Score(TextBox tb)
        {
            tb.Text = Globals.player_Score.ToString();
        }
    }
}
