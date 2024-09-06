using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Player_Food;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Player_Food;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps._4_Moving.Moving_Player_Food;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._7_Controlling.Controlling_Player_Food
{
    internal class Player_Food_Controller
    {
        private Player_Food_Creator obj_Player_Food_Creator=new Player_Food_Creator();
        private Player_Food_Drawer obj_Drawer_Food_Drawer = new Player_Food_Drawer();
        private bool actionExecuted = false;
        private C_Moving obj_Moving = new C_Moving();
        //-----------------------------------------------------------------------------------------------------
        public void control_Player_Food(double player_Fuel, Canvas gameArea)
        {
            change_Color_Of_Player_Food_Parts_Every_Tick();
            draw_Player_Food_In_GameArea(player_Fuel, gameArea);
            remove_Food_From_GameArea(gameArea);

        }
        //-----------------------------------------------------------------------------------------------------
        private void draw_Player_Food_In_GameArea(double player_Fuel, Canvas gameArea)
        {
            double level = player_Fuel;
            if (level%10==0)
            {
                if (!actionExecuted)
                {

                    obj_Player_Food_Creator.create_The_Player_Food();
                    obj_Drawer_Food_Drawer.draw_The_Player_Food(gameArea);
                    actionExecuted = true;
                }

                Globals.doesFoodEnabled = true;


            }
        }
        //-----------------------------------------------------------------------------------------------------
        private void remove_Food_From_GameArea(Canvas gameArea)
        {
           if(Globals.li_Player_Food.Count != 0)
            {

                if (Globals.li_Player_Food[0].top_Pos >= Globals.gameArea_Height || Globals.food_Collision)
                {
                    Globals.food_Collision = false;
                    actionExecuted = false;
                    obj_Moving.clear_Item_From_The_GameArea(Globals.li_Player_Food, gameArea);
                    Globals.li_Player_Food.Clear();
                }


            }
               
            
           
        }
        //-----------------------------------------------------------------------------------------------------
        private void change_Color_Of_Player_Food_Parts_Every_Tick()
        {
            for(int i=0;i<Globals.li_Player_Food.Count;i++)
            {
                Random random_Obj = new Random();
                int number = random_Obj.Next(0, obj_Player_Food_Creator.player_Food_Colors.Length);
                Globals.li_Player_Food[i].rect.Fill= obj_Player_Food_Creator.player_Food_Colors[number];
            }

          
         

        }
        //-----------------------------------------------------------------------------------------------------


    }

}
