using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Moving_Player_Food
{
    internal class Player_Food_Mover
    {
        private C_Moving obj_Moving=new C_Moving();
        //-----------------------------------------------------------------------------------------------
        public void move_The_Player_Food(Canvas gameArea)
        {
            if (Globals.doesFoodEnabled){
                obj_Moving.move_Item_Vertical_Down_At_Fixed_Left_Pos_With_Delay_Value(Globals.li_Player_Food
             , gameArea, Globals.moving_Increment, Globals.gameArea_Height,100);

            }
         
        }
       
    }
}
