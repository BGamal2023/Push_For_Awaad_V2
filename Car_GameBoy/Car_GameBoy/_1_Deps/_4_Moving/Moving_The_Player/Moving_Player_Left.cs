using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_The_Player;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Moving_The_Player
{
    internal class Moving_Player_Left
    {
        private C_Moving obj_Moving = new C_Moving();
        private Creating_Player obj_Creating_Player = new Creating_Player();

        //--------------------------------------------------------------------------------------------------------
        public void move_The_Player_Left_Side(Canvas gameArea)
        {
            obj_Moving.clear_Item_From_The_GameArea(Globals.li_player, gameArea);
            obj_Moving.clear_Item_From_The_GameArea(Globals.li_Player_Container, gameArea);
            
            change_Player_Container_Left_Side_V2();
            clear_Player_List();

            create_New_List_Of_Player_According_To_New_Postion_Of_Player_Container();

            obj_Moving.redraw_The_Item(Globals.li_Player_Container, gameArea);
            obj_Moving.redraw_The_Item(Globals.li_player, gameArea,10);

        }
        //--------------------------------------------------------------------------------------------------------
        private void change_Player_Posing_Left_Side_V0()
        {
            int player_Left_limit = Globals.left_Side_Of_The_Racing_Area_X_Pos + Globals.left_Side_Of_The_Racing_Area_Width;


            for (int i = 0; i < Globals.no_Of_Blocks_in_Player_Body; i++)
            {
                int dista_Bet_Player_And_Left_Limit = Globals.li_player[i].left_Pos - player_Left_limit;

                if (Globals.li_player[i].left_Pos > player_Left_limit)
                {

                    if (dista_Bet_Player_And_Left_Limit > Globals.player_Width)
                    {
                        Globals.li_player[i].left_Pos -= Globals.player_Move_Speed;
                    }
                    else
                    {
                        Globals.li_player[i].left_Pos -= dista_Bet_Player_And_Left_Limit;
                    }

                }
            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void change_Player_Posing_Left_Side_V1()
        {
            int player_Left_limit = Globals.racing_Area_X_Pos;


            for (int i = 0; i < Globals.no_Of_Blocks_in_Player_Body; i++)
            {
                int dista_Bet_Player_And_Left_Limit = Globals.li_player[i].left_Pos - player_Left_limit;

                if (Globals.li_player[5].left_Pos > player_Left_limit)
                {

                    if (dista_Bet_Player_And_Left_Limit > Globals.player_All_Width)
                    {
                        Globals.li_player[i].left_Pos -= Globals.player_Move_Speed;
                    }
                    else
                    {
                        Globals.li_player[i].left_Pos -= dista_Bet_Player_And_Left_Limit;
                    }

                }
            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void change_Player_Container_Left_Side_V2()
        {
            int player_Left_limit = Globals.racing_Area_X_Pos;
          
            for (int i = 0; i < Globals.li_Player_Container.Count; i++)
            {
               monitor_Moving_Left_Condition(i,player_Left_limit);
            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void monitor_Moving_Left_Condition(int i,int player_Left_limit)
        {
            bool moving_Left_Condition = Globals.li_Player_Container[i].left_Pos > player_Left_limit;

            if (moving_Left_Condition)
            {
                int dista_Bet_Player_And_Left_Limit = Globals.li_Player_Container[i].left_Pos - player_Left_limit;


                if (dista_Bet_Player_And_Left_Limit > Globals.player_Move_Speed)
                {
                    Globals.li_Player_Container[i].left_Pos -= Globals.player_Move_Speed;
                }
                else
                {
                    Globals.li_Player_Container[i].left_Pos -= dista_Bet_Player_And_Left_Limit;
                }

            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void create_New_List_Of_Player_According_To_New_Postion_Of_Player_Container()
        {
            obj_Creating_Player.create_The_Player();
        }
        //--------------------------------------------------------------------------------------------------------
        private void clear_Player_List()
        {
            Globals.li_player.Clear();

        }
    }
}
