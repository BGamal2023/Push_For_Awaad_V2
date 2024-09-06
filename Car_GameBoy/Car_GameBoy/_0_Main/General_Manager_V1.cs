using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._0_MainWindow_Handler;
using Car_GameBoy._1_Deps._1_GameArea_Handler;
using Car_GameBoy._1_Deps._2_Creating.Creating_Collision_Text;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using Car_GameBoy._1_Deps._2_Creating.Creating_Manager;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager;
using Car_GameBoy._1_Deps._4_Moving.Moving_Manager;
using Car_GameBoy._1_Deps._5_Buttons.Buttons_Manager;
using Car_GameBoy._1_Deps._6_Collision;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Manager;
using Car_GameBoy._1_Deps.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Car_GameBoy._0_Main
{
    internal class General_Manager_V1
    {
       
        private Canvas gameArea = new Canvas();
        private Moving_Manager obj_Moving_Manager=new Moving_Manager();
        private level obj_Level=new level();
        //------------------------------------------------------------------------------------------------
        public void start_And_Handle_The_App(MainWindow mW)
        {
            obj_Level.start_The_Level(mW, gameArea);
        }
       
       
        //------------------------------------------------------------------------------------------------
        public void onclick_Keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {

                obj_Moving_Manager.move_The_Player_Right(gameArea);
            }
            else if (e.Key == Key.Left)
            {
                obj_Moving_Manager.move_The_Player_Left(gameArea);

            }
        }
        //------------------------------------------------------------------------------------------------
        internal void onClick_Keyup(object sender, KeyEventArgs e)
        {

        }
     
    }
}
