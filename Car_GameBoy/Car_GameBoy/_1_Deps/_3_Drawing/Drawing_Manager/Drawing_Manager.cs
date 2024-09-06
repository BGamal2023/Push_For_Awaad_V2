using Car_GameBoy._1_Deps._3_Drawing.Drawing_Enemies;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Fuel_Indicator_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Hi_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Player;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Player_Food;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Racing_Area;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_The_Bkground_Lines_In_The_Racing_Area;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_The_Blocks_In_The_Sideway_Of_Racing_Area;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Two_Sideways_Of_The_Racing_Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager
{
    internal class Drawing_Manager
    {
        private Drawing_The_Sideway_Blocks obj_D_S_W_B = new Drawing_The_Sideway_Blocks();
        private Drawing_Bkground_Lines_In_The_Racing_Area obj_D_Bkg_Lines = new Drawing_Bkground_Lines_In_The_Racing_Area();
        private Drawing_The_Racing_Area obj_Drawing_Racing_Area = new Drawing_The_Racing_Area();
        private Fuel_Level_Drawer obj_Fuel_Level_Drawer=new Fuel_Level_Drawer();
        private Drawing_The_Two_Sideways_Of_The_Racing_Area obj_Drawing_Sideways_Of_The_Racing_Area = new Drawing_The_Two_Sideways_Of_The_Racing_Area();
        private Hi_Score_Box_Drawer obj_Hi_Score_Drawer = new Hi_Score_Box_Drawer();
        private Score_Box_Drawer obj_Score_Drawer = new Score_Box_Drawer();
        private Drawing_The_Player obj_Drawing_Player = new Drawing_The_Player();
        private Drawing_The_Enemies obj_Drawing_Enemyies = new Drawing_The_Enemies();
        private Drawing_Player_Container obj_Drawing_Player_Container = new Drawing_Player_Container();
        //----------------------------------------------------------------------------------
        public void draw(Canvas gameArea)
        {
            obj_Drawing_Racing_Area.draw_The_Racing_Area(gameArea);
            obj_D_Bkg_Lines.draw_The_Bkground_Lines_In_The_Racing_Area(gameArea);
            obj_Drawing_Sideways_Of_The_Racing_Area.draw_The_Left_Sideway(gameArea);
            obj_Drawing_Sideways_Of_The_Racing_Area.draw_The_Right_Sideway(gameArea);
            obj_D_S_W_B.draw_Left_Sideway_Blocks(gameArea);
            obj_D_S_W_B.draw_Right_Sideway_Blocks(gameArea);
            obj_Score_Drawer.draw_The_Score_Box(gameArea);
            obj_Hi_Score_Drawer.draw_The_Hi_Score_Box(gameArea);
            obj_Fuel_Level_Drawer.draw_Fuel_Level_Box(gameArea);
            obj_Drawing_Player_Container.draw_The_Player_Conatiner(gameArea);
            obj_Drawing_Player.draw_The_Player(gameArea);
            obj_Drawing_Enemyies.draw_The_Enemies(gameArea);




        }
    }
}
