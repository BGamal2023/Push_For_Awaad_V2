using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_The_Player
{
    internal class Creating_Player
    {
        private C_Creating_One_Segement_Items_GC obj_Creating = new C_Creating_One_Segement_Items_GC();
        int[] arr_X_Pos_Of_Player_Body= new int[9];
        int[] arr_Y__Pos_Of_Player_Body=new int[9];
        //-------------------------------------------------------------------------------------------------

        public void create_The_Player()
        {
            /// use creating car not create one segement......

            get_New_X_And_Y_For_The_Player_Parts();

            for (int i = 0; i < Globals.no_Of_Blocks_in_Player_Body; i++)
            {
                obj_Creating.creat_One_Segement_Item(
              Globals.player_One_Block_Width,
              Globals.player_One_Block_Height,
             arr_X_Pos_Of_Player_Body[i],
             arr_Y__Pos_Of_Player_Body[i],
              Globals.player_Color,
              Globals.li_player
              );

            }

        }

        //---------------------------------------------------------------------------------------------------
        private void get_New_X_And_Y_For_The_Player_Parts()
        {
            arr_X_Pos_Of_Player_Body[0] = Globals.li_Player_Container[0].left_Pos + Globals.player_One_Block_Width;
            arr_X_Pos_Of_Player_Body[1] = Globals.li_Player_Container[0].left_Pos + Globals.player_One_Block_Width;
            arr_X_Pos_Of_Player_Body[2] = Globals.li_Player_Container[0].left_Pos + Globals.player_One_Block_Width;
            arr_X_Pos_Of_Player_Body[3] = Globals.li_Player_Container[0].left_Pos + Globals.player_One_Block_Width;
            arr_X_Pos_Of_Player_Body[4] = Globals.li_Player_Container[0].left_Pos + Globals.player_One_Block_Width;
            arr_X_Pos_Of_Player_Body[5] = Globals.li_Player_Container[0].left_Pos;
            arr_X_Pos_Of_Player_Body[6] = Globals.li_Player_Container[0].left_Pos + (2 * Globals.player_One_Block_Width);
            arr_X_Pos_Of_Player_Body[7] = Globals.li_Player_Container[0].left_Pos;
            arr_X_Pos_Of_Player_Body[8] = Globals.li_Player_Container[0].left_Pos + (2 * Globals.player_One_Block_Width);


            arr_Y__Pos_Of_Player_Body[0] = Globals.li_Player_Container[0].top_Pos;
            arr_Y__Pos_Of_Player_Body[1] = Globals.li_Player_Container[0].top_Pos + Globals.player_One_Block_Height;
            arr_Y__Pos_Of_Player_Body[2] = Globals.li_Player_Container[0].top_Pos + (2 * Globals.player_One_Block_Height);
            arr_Y__Pos_Of_Player_Body[3] = Globals.li_Player_Container[0].top_Pos + (3 * Globals.player_One_Block_Height);
            arr_Y__Pos_Of_Player_Body[4] = Globals.li_Player_Container[0].top_Pos + (4 * Globals.player_One_Block_Height);
            arr_Y__Pos_Of_Player_Body[5] = Globals.li_Player_Container[0].top_Pos + Globals.player_One_Block_Height;
            arr_Y__Pos_Of_Player_Body[6] = Globals.li_Player_Container[0].top_Pos + Globals.player_One_Block_Height;
            arr_Y__Pos_Of_Player_Body[7] = Globals.li_Player_Container[0].top_Pos + (4 * Globals.player_One_Block_Height);
            arr_Y__Pos_Of_Player_Body[8] = Globals.li_Player_Container[0].top_Pos + (4 * Globals.player_One_Block_Height);
      

    }


}
}
