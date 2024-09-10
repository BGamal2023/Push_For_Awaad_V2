using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level_2 : I_Level_Runnable
    {
        public void Run()
        {
            //-----------
            ///MainWidow
            
            /// GameArea
            Globals.gameArea_Bkground_Color = Brushes.Yellow;
            //-----------
            Globals.timerTick = 400;
            //-----------
            /// Racing Area
            Globals.racing_Area_bGround_Color = Brushes.Gray;
            /// Racing Area Bkg Lines
            Globals.moving_Increment = 50;
            //------------------------------------
            /// Blocks  in sideway of racing area
            Globals.right_Sideway_Blocks_Height = 60;
            Globals.no_Of_The_Right_SideWay_Blocks = 7;
            Globals.right_Sideway_Blocks_Y_Pos = 40;
            Globals.left_Sideway_Blocks_Height = 60;
            Globals.no_Of_Left_SideWay_Blocks = 7;
            //-------------------------------------------------
            /// player container 
            Score_Box_Creator.obj_TextBlock.Text = 0.ToString();
            Globals.player_Continer_Color= Brushes.Gray;    
            //-------------------------------------------------
            ///Enemyies
            Globals.number_Of_Enemies = 4;
            Globals.vertical_Dis_Bet_Enemies = 300;
            //--------------------------------------------------------------
            /// Levels
            Globals.level_Score = 500;



        }
    }
}
