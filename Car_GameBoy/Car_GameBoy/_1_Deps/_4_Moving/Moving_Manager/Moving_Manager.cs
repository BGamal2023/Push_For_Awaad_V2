using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps._4_Moving.Moving_Player_Food;
using Car_GameBoy._1_Deps._4_Moving.Moving_The_Enemies;
using Car_GameBoy._1_Deps._4_Moving.Moving_The_Lines_In_Racing_Area;
using Car_GameBoy._1_Deps._4_Moving.Moving_The_Player;
using Car_GameBoy._1_Deps._4_Moving.Moving_The_Sideway_Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Moving_Manager
{
    internal class Moving_Manager
    {
        private Moving_The_Racing_Area_Lines obj_Moving_Lines_In_Racing_Area = new Moving_The_Racing_Area_Lines();
        private Moving_The_Right_Sideway_Blocks_Of_the_RA obj_Moving_Right_Sideway_Blocks = new Moving_The_Right_Sideway_Blocks_Of_the_RA();
        private Moving_The_Left_Sideway_Blocks obj_Moving_Left_Sideway_Blocks = new Moving_The_Left_Sideway_Blocks();
        private Moving_Player_Left obj_Moving_Player_Left = new Moving_Player_Left();
        private Moving_Player_Right obj_Moving_Player_Right = new Moving_Player_Right();
        private Moving_Enemies obj_Moving_Enemies = new Moving_Enemies();
        private Player_Food_Mover obj_Player_Food_Mover=new Player_Food_Mover   ();
        //-----------------------------------------------------------------------------------------------------------
        public void move_Items_During_Timer_Tick(Canvas gameArea)
        {
            obj_Moving_Lines_In_Racing_Area.move_The_Racing_Area_Lines(gameArea);
            obj_Moving_Right_Sideway_Blocks.move_The_Right_Blocks_In_Sideway(gameArea);
            obj_Moving_Left_Sideway_Blocks.move_The_Left_Blocks_In_Sideway(gameArea);
            obj_Moving_Enemies.move_Enemies(gameArea);
            obj_Player_Food_Mover.move_The_Player_Food(gameArea);
        }
        //-----------------------------------------------------------------------------------------------------------
        public void move_The_Player_Left(Canvas gameArea)
        {

            obj_Moving_Player_Left.move_The_Player_Left_Side(gameArea);
        }
        //-----------------------------------------------------------------------------------------------------------
        public void move_The_Player_Right(Canvas gameArea)
        {

            obj_Moving_Player_Right.move_The_Player_Right_Side_V1(gameArea);

        }
    }
}
