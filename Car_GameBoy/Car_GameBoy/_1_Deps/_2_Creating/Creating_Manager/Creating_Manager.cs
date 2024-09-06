using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Blocks_In_Side_Way;
using Car_GameBoy._1_Deps._2_Creating.Creating_Fuel_Indicator;
using Car_GameBoy._1_Deps._2_Creating.Creating_High_Score_Box;
using Car_GameBoy._1_Deps._2_Creating.Creating_Lines_In_Racing_Area;
using Car_GameBoy._1_Deps._2_Creating.Creating_List_Of_Brush_Colors;
using Car_GameBoy._1_Deps._2_Creating.Creating_Player_Food;
using Car_GameBoy._1_Deps._2_Creating.Creating_Racing_Area;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._2_Creating.Creating_SideWay_Of_The_Racing_Area;
using Car_GameBoy._1_Deps._2_Creating.Creating_The_Enemyes;
using Car_GameBoy._1_Deps._2_Creating.Creating_The_Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Manager
{
    internal class Creating_Manager
    {
        private Creating_The_Racing_Area obj_Creating_The_Racing_Area = new Creating_The_Racing_Area();
        private Score_Box_Creator obj_Score_Box_Creator = new Score_Box_Creator();
        private Hight_Score_Box_Creator obj_Hi_Score_Box_Creator = new Hight_Score_Box_Creator();
        private Fuel_Indicator_Creator obj_Fuel_Indic_Creator = new Fuel_Indicator_Creator();
        private Creating_Racing_Area_Bkg_Lines obj_Creating_Line_In_Racing_Area = new Creating_Racing_Area_Bkg_Lines();
        private Creating_The_Two_Sideway_Of_The_Racing_Area obj_Creating_The_Two_Sideways_Of_The_Racing_Area = new Creating_The_Two_Sideway_Of_The_Racing_Area();
        private Creating_Blocks_For_The_Left_Sideway_Of_The_Racing_Area obj_Creating_Left_Sideway_Blocks = new Creating_Blocks_For_The_Left_Sideway_Of_The_Racing_Area();
        private Creating_Blocks_For_The_Right_Sideway_Of_Racing_Area obj_Creating_Right_sideway_Blocks = new Creating_Blocks_For_The_Right_Sideway_Of_Racing_Area();
        private Creating_The_Enemies obj_Creating_Enemyies = new Creating_The_Enemies();
        private Creating_Player_Container obj_Creating_Player_Container = new Creating_Player_Container();
        private Creating_Player obj_Creating_The_Player = new Creating_Player();
        private Player_Food_Creator obj_Player_Food_Creator = new Player_Food_Creator();

        //--------------------------------------------------------------------------------------
        public void creat()
        {
            Creating_The_List_Of_Brush_Colors.GenerateDistinctBrushes(300);
            obj_Score_Box_Creator.create_Score_Box();
            obj_Hi_Score_Box_Creator.create_Hi_Score_Box();
            obj_Fuel_Indic_Creator.create_Fuel_Indicator_Box();
            obj_Creating_The_Racing_Area.creat_The_Racing_Area();
            obj_Creating_Line_In_Racing_Area.create_Lines_Of_Racing_Area();
            obj_Creating_The_Two_Sideways_Of_The_Racing_Area.create_The_Left_Sideway_Of_The_Racing_Area();
            obj_Creating_The_Two_Sideways_Of_The_Racing_Area.create_The_Right_Sideway_Of_The_Racing_Area();
            obj_Creating_Left_Sideway_Blocks.create_Left_Sideway_Blocks();
            obj_Creating_Right_sideway_Blocks.create_Right_Sideway_Blocks();
            obj_Creating_Player_Container.creat_Player_Container();
            obj_Creating_The_Player.create_The_Player();
            obj_Creating_Enemyies.creating_The_Enemies();
            obj_Player_Food_Creator.create_The_Player_Food();   

        }
        
    }
}
