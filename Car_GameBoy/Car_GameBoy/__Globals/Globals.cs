using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Car_GameBoy.__Globals
{
    internal class Globals
    {

        /// MainWindow
        public static int mWindow_Width = 700;
        public static int mWindow_Height = 750;

        //-----------
        /// GameArea
        public static int gameArea_Width = mWindow_Width;
        public static int gameArea_Height = 700;
        public static Brush gameArea_Bkground_Color = Brushes.DarkSlateGray;
        //-----------
        public static double timerTick = 700;
        //-----------
        /// Racing Area
        public static int racing_Area_X_Pos = 200;
        public static int racing_Area_Y_Pos = 0;
        public static int racing_Area_Width = 300;
        public static int racing_Area_Height = gameArea_Height;
        public static Brush racing_Area_bGround_Color = Brushes.Black;
        public static List<C_Item> li_The_Racing_Area = new List<C_Item>();
        /// Racing Area Bkg Lines
        public static int racing_Area_Background_Line_Width = 10;
        public static int racing_Area_Background_Line_Height = 100;
        public static Brush racing_Area_Background_Line_Color = Brushes.White;
        public static int racing_Area_Background_Line_X_Pos = gameArea_Width / 2;
        public static int racing_Area_Dist_Bet_Lines = 100;
        public static int racing_Area_Background_Line_Y_Pos = racing_Area_Dist_Bet_Lines;
        public static int no_Of_Lines_In_racing_Area = 3;
        public static int racing_Area_Bkground_Line_Segment_Height = 1;
        public static int no_Of_Segement_In_Every_Racing_Area_Lines = racing_Area_Background_Line_Height / racing_Area_Bkground_Line_Segment_Height;
        public static int moving_Increment = 50;
        public static List<C_Item> li_Lines_In_Racing_Area_New = new List<C_Item>();
        //------------------------------------
        /// 2 sides of the Racing Area 
        public static int left_Side_Of_The_Racing_Area_Width = 30;
        public static int left_Side_Of_The_Racing_Area_X_Pos = racing_Area_X_Pos - left_Side_Of_The_Racing_Area_Width;
        public static int left_Side_Of_The_Racing_Area_Y_Pos = 0;
        public static int left_Side_Of_The_Racing_Area_Height = gameArea_Height;
        public static Brush left_Side_Of_The_Racing_Area_BKground_Color = Brushes.Orange;
        public static List<C_Item> li_The_Left_Side_Of_The_Racing_Area = new List<C_Item>();
        public static int right_Side_Of_The_Racing_Area_X_Pos = racing_Area_X_Pos + racing_Area_Width;
        public static int right_Side_Of_The_Racing_Area_Y_Pos = 0;
        public static int right_Side_Of_The_Racing_Area_Width = 30;
        public static int right_Side_Of_The_Racing_Area_Height = gameArea_Height;
        public static Brush right_Side_Of_The_Racing_Area_BKground_Color = Brushes.Orange;
        public static List<C_Item> li_The_Right_Side_Of_The_Racing_Area = new List<C_Item>();
        //------------------------------------

        /// Blocks  in sideway of racing area
        // put height that can accept division by 800
        public static int right_Sideway_Blocks_Height = 30;
        public static int right_Sideway_Blocks_Width = right_Side_Of_The_Racing_Area_Width;
        public static int no_Of_The_Right_SideWay_Blocks = 10;
        public static int right_Sideway_Blocks_Y_Pos = 40;
        public static int right_Sideway_Blocks_X_Pos = right_Side_Of_The_Racing_Area_X_Pos;
        public static int right_Sideway_Blocks_Dis_Bet_Blocks = 40;
        public static Brush right_Sideway_Blocks_BKground_Color = Brushes.Black;
        public static int right_Sideway_Blocks_Segment_No = right_Sideway_Blocks_Height;
        public static List<C_Item> li_Of_The_Right_Sideway_Blocks_New = new List<C_Item>();


        public static int left_Sideway_Blocks_Height = 30;
        public static int left_Sideway_Blocks_Width = left_Side_Of_The_Racing_Area_Width;
        public static int no_Of_Left_SideWay_Blocks = 10;
        public static int left_Sideway_Blocks_Y_Pos = 40;
        public static int left_Sideway_Blocks_X_Pos = left_Side_Of_The_Racing_Area_X_Pos;
        public static int left_Sideway_Blocks_Dis_Bet_Blocks = 40;
        public static Brush left_Sideway_Blocks_BKground_Color = Brushes.Black;
        public static int left_Sideway_Blocks_Segment_No = left_Sideway_Blocks_Height;
        public static List<C_Item> li_Of_The_Left_Sideway_Blocks_New = new List<C_Item>();
        //------------------------------------


        /// Start Button 
        public static int btn_Start_Widht = 80;
        public static int btn_Start_Height = 25;
        public static int btn_Start_Left_Pos = 575;
        public static int btn_Start_Top_Pos = 500;
        public static string btn_Start_Text = "Start Game";
        public static Brush btn_Start_Bkground_Color = Brushes.Green;

        /// Stop Button 
        public static int btn_Stop_Widht = 80;
        public static int btn_Stop_Height = 25;
        public static int btn_Stop_Left_Pos = 575;
        public static int btn_Stop_Top_Pos = 575;
        public static string btn_Stop_Text = "Stop Game";
        public static Brush btn_Stop_Bkground_Color = Brushes.Red;
        //-------------------------------------------------
        /// Player Container
        public static int player_One_Block_Width = 15;
        public static int player_One_Block_Height = 10;
        public static int no_Of_Blocks_in_Player_Body = 9;

        public static int player_Container_Width = 3 * player_One_Block_Width;
        public static int player_Container_Height = 5 * player_One_Block_Height;
        public static int player_Container_X_Pos = 328;
        public static int player_Container_Y_Pos = 550;
        public static Brush player_Continer_Color = racing_Area_bGround_Color;
        public static int player_Container_Moving_Speed = player_Move_Speed;
        public static List<C_Item> li_Player_Container = new List<C_Item>();
        //-------------------------------------------

        /// Player 

        public static int player_All_Width = 45;
        public static int player_Width = 35;
        public static int player_Height = 50;
        public static Brush player_Color = Brushes.Green;
        public static List<C_Item> li_player = new List<C_Item>();
        public static int player_Move_Speed = player_All_Width;

        //-------------------------------------------------
        ///Enemies Contaniners
        public static int enemy_One_Block_Width = 15;
        public static int enemy_One_Block_Height = 10;
        public static int no_Of_Blocks_in_enemy_Body = 9;
        //-------------------------------------------------
        ///Enemyies
        public static int number_Of_Enemies = 2;
        public static int vertical_Dis_Bet_Enemies = 250;
        public static List<List<C_Item>> li_Enemy_Cars = new List<List<C_Item>>();

        public static int random_Enemy_X_Pos = 350;
        public static int time_To_Add_Another_Enemy = 600;
        public static int enemy_X_Pos = 328;
        public static int enemy_Y_Pos = 0;
        public static Brush enemy_Color = Brushes.Yellow;
        public static int enemy_Move_Speed = moving_Increment;
        //------------------------------------------------------
        /// Collision
        public static int collision_Num = 0;
        public static bool doesPlayCollision = false;
        public static bool doesLeftMovingEnabled = false;
        public static bool doesRightMovingEnabled = false;
        //------------------------------------------------------
        public static List<Brush> li_Car_Colors = new List<Brush>();
        //-----------------------------------------------------

        /// Player Score
        public static int player_Hi_Score = 0;
        public static int player_Score = 0;
        public static Double player_Fuel = 0;
        //-----------------------------------------------------

        /// Hi Score Text
        public static int hi_Score_TBlock_W = 80;
        public static int hi_Score_TBlock_H = 35;
        public static int hi_Score_TBlock_Left_Pos = 575;
        public static int hi_Score_TBlock_Top_Pos = 50;
        public static string hi_Score_TBlock_Text = "Hi Score";
        public static Brush hi_Score_TBlock_Bkground_Color = gameArea_Bkground_Color;
        /// Hi Score box
        public static int hi_Score_TBox_W = 80;
        public static int hi_Score_TBox_H = 25;
        public static int hi_Score_TBox_Left_Pos = 575;
        public static int hi_Score_TBox_Top_Pos = 80;
        public static Brush hi_Score_TBox_Bkground_Color = gameArea_Bkground_Color;
        //-----------------------------------------------------
        /// Score Text
        public static int progress_TextBlock_Width = 80;
        public static int progress_TextBlock_Height = 35;
        public static int progress_TextBlock_Left_Pos = 575;
        public static int progress_TextBlock_Top_Pos = 130;
        public static string progress_TextBlock_Text = "Score";
        public static Brush progress_TextBlock_Bkground_Color = gameArea_Bkground_Color;
        /// Score box
        public static int progress_TextBox_Width = 80;
        public static int progress_TextBox_Height = 25;
        public static int progress_TextBox_Left_Pos = 575;
        public static int progress_TextBox_Top_Pos = 160;
        public static Brush progress_TextBox_Bkground_Color = gameArea_Bkground_Color;
        //-----------------------------------------------------
        /// Fuel indicator

        public static int fuel_Indic_TBlock_W = 80;
        public static int fuel_Indic_TBlock_H = 35;
        public static int fuel_Indic_TBlock_Left_Pos = 575;
        public static int fuel_Indic_TBlock_Top_Pos = 220;
        public static string fuel_Indic_TBlock_Text = "Fuel";
        public static Brush fuel_Indic_TBlock_Bkground_Color = gameArea_Bkground_Color;

        public static int fuel_Indic_TBox_W = 80;
        public static int fuel_Indic_TBox_H = 25;
        public static int fuel_Indic_TBox_Left_Pos = 575;
        public static int fuel_Indic_TBox_Top_Pos = 250;
        public static Brush fuel_Indic_TBox_Bkground_Color = gameArea_Bkground_Color;

        //--------------------------------------------------------------
        ///Player Food
        public static List<C_Item> li_Player_Food = new List<C_Item>();
        public static int player_Food_X_pos = 300;
        public static int player_Food_Y_Pos = 50;
        public static bool doesFoodEnabled = false;
        public static bool draw_Food = false;
        public static bool food_Collision = false;


        //--------------------------------------------------------------
        /// Levels
        public static I_Level_Runnable current_Level = new C_Level_Runnable();
        public static int level_Score = 10;
        public static int level_Road_Bump = 4;


        public static bool activeOnStart = true;
        public static bool activeOnRun = false;
        public static bool activeOnDestroy = false;



















    }
}
