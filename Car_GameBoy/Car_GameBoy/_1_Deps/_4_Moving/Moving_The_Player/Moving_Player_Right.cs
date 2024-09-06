using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_The_Player;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Moving_The_Player
{
    internal class Moving_Player_Right
    {
        private C_Moving obj_Moving = new C_Moving();
        private Creating_Player obj_Creating_Player = new Creating_Player();
        //--------------------------------------------------------------------------------------------------------
        public void move_The_Player_Right_Side_V0(Canvas gameArea)
        {
            obj_Moving.clear_Item_From_The_GameArea(Globals.li_player, gameArea);
            change_Player_Position_Right_Side_V0();
            obj_Moving.redraw_The_Item(Globals.li_player, gameArea);
        }
        //--------------------------------------------------------------------------------------------------------
        public void move_The_Player_Right_Side_V1(Canvas gameArea)
        {
            obj_Moving.clear_Item_From_The_GameArea(Globals.li_player, gameArea);
            obj_Moving.clear_Item_From_The_GameArea(Globals.li_Player_Container, gameArea);

            change_Player_Container_Right_Position();
            clear_Player_List();

            create_New_List_Of_Player_According_To_New_Postion_Of_Player_Container();

            obj_Moving.redraw_The_Item(Globals.li_Player_Container, gameArea);
            obj_Moving.redraw_The_Item(Globals.li_player, gameArea,10);
        }
        //--------------------------------------------------------------------------------------------------------
        private void change_Player_Position_Right_Side_V0()
        {
            for (int i = 0; i < Globals.li_player.Count; i++)
            {
                int right_Edge_Of_The_Player = Globals.li_player[i].left_Pos + Globals.player_Width;
                int dista_Bet_Player_And_Right_Limit = Globals.right_Side_Of_The_Racing_Area_X_Pos - (Globals.li_player[i].left_Pos + Globals.player_Width);

                if ( right_Edge_Of_The_Player< Globals.right_Side_Of_The_Racing_Area_X_Pos)
                {

                    if (dista_Bet_Player_And_Right_Limit > Globals.player_Width)
                    {
                        Globals.li_player[i].left_Pos += Globals.player_Move_Speed;
                    }
                    else
                    {
                        Globals.li_player[i].left_Pos += dista_Bet_Player_And_Right_Limit;
                    }
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void change_Player_Container_Right_Position()
        {
            int player_Right_limit = Globals.right_Side_Of_The_Racing_Area_X_Pos;

            for (int i = 0; i < Globals.li_Player_Container.Count; i++)
            {
                monitor_Moving_Right_Condition(i, player_Right_limit);
            }

        }
        //--------------------------------------------------------------------------------------------------------
        private void monitor_Moving_Right_Condition(int i, int player_Right_limit)
        {
            int right_Corner_Of_The_Player_Container = (Globals.li_Player_Container[i].left_Pos + Globals.li_Player_Container[i].width);
            bool moving_Right_Condition = right_Corner_Of_The_Player_Container < player_Right_limit;

            if (moving_Right_Condition)
            {
                int dista_Bet_Right_Corner_Of_The_Player_Container_And_Right_Limit = player_Right_limit-right_Corner_Of_The_Player_Container  ;


                if (dista_Bet_Right_Corner_Of_The_Player_Container_And_Right_Limit > Globals.player_Move_Speed)
                {
                    Globals.li_Player_Container[i].left_Pos += Globals.player_Move_Speed;
                }
                else
                {
                    Globals.li_Player_Container[i].left_Pos += dista_Bet_Right_Corner_Of_The_Player_Container_And_Right_Limit;
                }

            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void clear_Player_List()
        {
            Globals.li_player.Clear();

        }
        //--------------------------------------------------------------------------------------------------------
        private void create_New_List_Of_Player_According_To_New_Postion_Of_Player_Container()
        {
            obj_Creating_Player.create_The_Player();
        }


    }
}
